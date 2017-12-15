using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myp_Email
{
    public partial class Form2 : Form
    {
        Class.Class_ejecutar ejecutar = new Class.Class_ejecutar();

        int id_contacto = 0;
        public Form2(string tipo = "")
        {
            InitializeComponent();
            MaximizeBox = false;
            _combobox();
            this.button_editar.Enabled = false;
            this.button_delete.Enabled = false;
            this.button_add.Enabled = true;
        }

        public void _gridview(string tipo = "")
        {
            this.Text = tipo;

            DataTable dt = new DataTable();
            DataTable dt_copy = new DataTable(); //Copia el contenido, porque cuando combobox entra a pedir otra vez al metodo se genera otro datatable. y el gridview esta alimentado con el datatable directamente
            dt = ejecutar._ejecutar("select id,nombre as Nombre,email,sucursal as Planta,id_sucursal from view_" + this.Text + ";", "2");
            dt_copy = dt.Copy();
            tabla.DataSource = dt_copy;
            tabla.Columns[0].Visible = false;
            tabla.Columns[1].Width = 110;
            tabla.Columns[2].Width = 150;
            tabla.Columns[3].Width = 80;
            tabla.Columns[4].Visible = false;
        }

        public void _combobox()
        {
            DataTable dt = new DataTable();
            DataTable dt_copy = new DataTable();
            dt = ejecutar._ejecutar("select id,nombre from sucursal;", "2");
            dt_copy = dt.Copy();
            comboBox_sucursal.DataSource = dt_copy;
            comboBox_sucursal.DisplayMember = "nombre";
            comboBox_sucursal.ValueMember = "id";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string tipo = this.Text;
            if (_validar() == true)
            {
                string values = String.Format("'{0}','{1}','{2}'", this.text_name.Text, this.text_correo.Text, this.comboBox_sucursal.SelectedValue);
                try
                {

                    if (duplicado("select count(correo) as count from " + this.Text + " where correo='" + this.text_correo.Text + "';") == 0)
                    {
                        ejecutar._add(tipo, values);
                        MessageBox.Show("Se agrego Exitosamente!");
                        _gridview(tipo);
                        this.text_name.Text = "";
                        this.text_correo.Text = "";
                        this.button_editar.Enabled = false;
                        this.button_delete.Enabled = false;
                    }
                    else
                    {
                        this.text_correo.Focus();
                        MessageBox.Show("Correo duplicado!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error de operación!");
                }
            }
            else
            {
                MessageBox.Show("Campos vacios!");
            }

        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            string tipo = this.Text;
            if (_validar() == true)
            {
                string values = String.Format(" nombre='{0}', correo='{1}', id_sucursal='{2}' where id='{3}'", this.text_name.Text, this.text_correo.Text, this.comboBox_sucursal.SelectedValue, id_contacto);
                try
                {
                    if (duplicado("select count(correo) as count from " + this.Text + " where correo='" + this.text_correo.Text + "' and id !="+id_contacto+";") == 0)
                    {
                        ejecutar._update(tipo, values);
                        MessageBox.Show("Se edito Exitosamente!");
                        _gridview(tipo);
                        this.text_name.Text = "";
                        this.text_correo.Text = "";
                        this.button_editar.Enabled = false;
                        this.button_delete.Enabled = false;
                    }
                    else
                    {
                        this.text_correo.Focus();
                        MessageBox.Show("Correo duplicado!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error de operación!");
                }
            }
            else
            {
                MessageBox.Show("Campos vacios!");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string tipo = this.Text;
            string values = String.Format("id='{0}'", id_contacto);
            try
            {
                ejecutar._delete(tipo, values);
                MessageBox.Show("Se elimino Exitosamente!");
                _gridview(tipo);               
                this.text_name.Text = "";
                this.text_correo.Text = "";
                this.button_editar.Enabled = false;
                this.button_delete.Enabled = false;
                this.button_add.Enabled = true;
                this.text_name.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Error de operación!");
            }
        }

        private void tabla_DoubleClick(object sender, EventArgs e)
        {
            if (tabla.CurrentRow.Index != -1)
            {
                id_contacto = int.Parse(tabla.CurrentRow.Cells[0].Value.ToString());
                this.text_name.Text = tabla.CurrentRow.Cells[1].Value.ToString();
                this.text_correo.Text = tabla.CurrentRow.Cells[2].Value.ToString();
                this.comboBox_sucursal.SelectedIndex = int.Parse(tabla.CurrentRow.Cells[4].Value.ToString()) - 1;

                this.button_editar.Enabled = true;
                this.button_delete.Enabled = true;
            }
        }

        private Boolean _validar()
        {
            var result = true;
            if (String.IsNullOrEmpty(this.text_name.Text) == true && String.IsNullOrEmpty(this.text_correo.Text) == true)
            {
                result = false;
                this.text_name.Focus();
            }
            return result;
        }

        private int duplicado(string query = "")
        {
            DataTable dt = new DataTable();
            dt = ejecutar._ejecutar(query, "2");
            int count = int.Parse(dt.Rows[0]["count"].ToString());
            return count;

        }
    }
}
