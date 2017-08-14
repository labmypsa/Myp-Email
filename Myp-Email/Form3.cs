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
    public partial class Form3 : Form
    {
        Class.Class_ejecutar ejecutar = new Class.Class_ejecutar();

        public Form3()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            _gridview();           
        }

        public void _gridview()
        {         
            DataTable dt = new DataTable();
            DataTable dt_copy = new DataTable(); //Copia el contenido, porque cuando combobox entra a pedir otra vez al metodo se genera otro datatable. y el gridview esta alimentado con el datatable directamente
            dt = ejecutar._ejecutar("select * from logs order by id desc;", "2");
            dt_copy = dt.Copy();
            dataGridView_logs.DataSource = dt_copy;
            dataGridView_logs.Columns[0].Visible = false;
            dataGridView_logs.Columns[1].Width = 80;
            dataGridView_logs.Columns[2].Width = 280;
            dataGridView_logs.Columns[3].Width = 130;
        }
    }
}
