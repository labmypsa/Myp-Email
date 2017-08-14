using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myp_Email
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();       
        Class.Class_debug her_depurar_ejecutar = new Class.Class_debug();
        Class.Class_email correo = new Class.Class_email();

        //string[] lista_email = {
        //    "mvega@mypsa.com.mx, drodriguez@mypsa.mx, afreyde@mypsa.mx",
        //    "hmofacturacion@mypsa.com.mx, lromero@mypsa.com.mx, svazquez@mypsa.mx, blanca.bernal@mypsa.mx",
        //    "edit.bray@mypsa.com.mx"
        //};
        string horainicial = "07:55:05";
        string[] ArrSucur = { "n", "h", "g" };
        int count_consola = 0;

        public Form1()
        {
            InitializeComponent();
            timer_reloj.Start();
            timer_checador.Interval = (1000 * 60) * 60; // cada  hora
            timer_checador.Start();
            check_n.Checked = true;
            check_h.Checked = true;
            check_g.Checked = false;
            MaximizeBox = false;
        }

        private void _procesos(string proceso = "", string desc = "")
        {
            bool[] Arrcheck = { check_n.Checked, check_h.Checked, check_g.Checked };
            for (int i = 0; i < 3; i++)
            {
                int y = i + 1;
                dt.Clear();
                if (Arrcheck[i] == true)
                {
                    if (proceso == "calib_tec")
                    {
                        _consola("Iniciando envio de correo Proceso : Calibración por técnico, Sucursal: " + ArrSucur[i]);
                        try
                        {
                            DataTable dt_copy = new DataTable();
                            dt = her_depurar_ejecutar._editar(her_depurar_ejecutar._select("calibracion", ArrSucur[i]));                            
                            dt_copy = dt.Copy();
                            her_depurar_ejecutar._tecnico(dt_copy);
                            _consola("Operación terminada exitosamente. Proceso : Calibración por técnico , Sucursal: " + ArrSucur[i]);
                            her_depurar_ejecutar._add("logs", "'calibración Técnico', 'Operación terminada exitosamente. Sucursal: " + ArrSucur[i] + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "'");
                        }
                        catch (Exception)
                        {
                            _consola("Operación  Fallida. Proceso : Calibración por técnico , Sucursal: " + ArrSucur[i]);
                            her_depurar_ejecutar._add("logs", "'calibración Técnico', 'Operación Fallida. Sucursal: " + ArrSucur[i] + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "'");
                        }
                    }
                    else if (proceso == "clientes")
                    {
                        _consola("Iniciando envio de correo Proceso : Recordatorios para Clientes , Sucursal: " + ArrSucur[i]);
                        try
                        {
                            DataTable dt_copy = new DataTable();
                            dt = her_depurar_ejecutar._select(proceso, ArrSucur[i]);
                            dt_copy = dt.Copy();
                            her_depurar_ejecutar._clientes(dt_copy, y);
                            _consola("Operación terminada exitosamente. Proceso : Recordatorios para Clientes, Sucursal: " + ArrSucur[i]);
                            her_depurar_ejecutar._add("logs", "'clientes', 'Operación terminada exitosamente. Sucursal: " + ArrSucur[i] + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "'");
                        }
                        catch (Exception)
                        {
                            _consola("Operación  Fallida. Proceso : Recordatorios para Clientes, Sucursal: " + ArrSucur[i]);
                            her_depurar_ejecutar._add("logs", "'clientes', 'Operación Fallida. Sucursal: " + ArrSucur[i] + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "'");
                        }
                    }
                    else
                    {
                        _consola("iniciando envio de correo Proceso : " + proceso + ", Sucursal: " + ArrSucur[i]);
                        try
                        {
                            DataTable dt_copy = new DataTable();
                            dt = her_depurar_ejecutar._editar(her_depurar_ejecutar._select(proceso, ArrSucur[i]));
                            dt_copy = dt.Copy();
                            DataTable dt_email = new DataTable();
                            dt_email= her_depurar_ejecutar._ejecutar(her_depurar_ejecutar._querys("correo_" + proceso, y.ToString()), "2"); //obtengo el query, deespues el dt
                            string listaemail = her_depurar_ejecutar._listaemails(dt_email); // Obtengo la lista de correos
                            correo._enviar(dt_copy, desc, listaemail); 
                            _consola("Operación terminada exitosamente. Proceso : " + proceso + ", Sucursal: " + ArrSucur[i]);
                            her_depurar_ejecutar._add("logs", "'" + proceso + "', 'Operación terminada exitosamente. Sucursal: " + ArrSucur[i] + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "'");
                        }
                        catch (Exception)
                        {
                            _consola("Operación  Fallida. Proceso : " + proceso + ", Sucursal: " + ArrSucur[i]);
                            her_depurar_ejecutar._add("logs", "'" + proceso + "', 'Operación Fallida. Sucursal: " + ArrSucur[i] + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "'");
                        }

                    }

                }
            }
        }

        private void calibraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _procesos("calibracion", "Calibración");
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _procesos("salida", "Salida");
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _procesos("facturacion", "Facturación");
        }

        private void calibracióntécnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _procesos("calib_tec");
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _procesos("clientes");
        }

        private void timer_reloj_Tick(object sender, EventArgs e)
        {
            int i = 0;
            reloj.Text = DateTime.Now.ToLongTimeString();
            Fecha.Text = DateTime.Now.ToString("dd-MMM-yyyy");

            string contenido = consola.Text.ToString();
            var _length = contenido.Length;
            string seg = DateTime.Now.ToString("ss");
            if ((int.Parse(seg) % 2) == 0)
            {
                string temp = "_";
                if (contenido.Substring((_length - 1), 1) != "_") { consola.Text = contenido + (temp); }
            }
            else
            {
                if (_length > 1 && contenido.Substring((_length - 1), 1) == "_") { consola.Text = contenido.Substring(0, _length - 1); }
                else
                {
                    consola.Text = contenido;
                }
            }

            var Hora = DateTime.Now.ToString("hh:mm:ss");
            if (Hora == horainicial) //Envia recordatorios programado
            {
                DateTime today = DateTime.Today;
                if (today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday)
                {
                    _procesos("calib", "Calibración");
                    Thread.Sleep(1000);
                    _procesos("salida", "Salida");
                    Thread.Sleep(1000);
                    _procesos("factura", "Facturación");
                    Thread.Sleep(1000);
                    _procesos("calib_tec");
                }

            }

        }

        private void timer_checador_Tick(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            DateTime diaultimomes;
            if (hoy.Month + 1 < 13)
            { diaultimomes = new DateTime(hoy.Year, hoy.Month + 1, 1).AddDays(-1); }
            else
            { diaultimomes = new DateTime(hoy.Year + 1, 1, 1).AddDays(-1); }

            if (hoy.ToString("dd-MMM-yyyy") == diaultimomes.ToString("dd-MMM-yyyy"))
            {
                _procesos("clientes");
            }

        }

        private void _consola(string operacion = "")
        {
            var _length = consola.Text.ToString().Length;
            string contenido = consola.Text.ToString();
            if (_length > 1 && contenido.Substring((_length - 1), 1) == "_") { contenido = contenido.Substring(0, _length - 1); }
            consola.Text = contenido;
            count_consola++;
            if (count_consola == 1)
            {
                contenido += " " + operacion + " (" + DateTime.Now.ToString() + ")";
                consola.Text = contenido;
            }
            else if (count_consola < 10)
            {
                contenido += String.Format(Environment.NewLine) + "> " + operacion + " (" + DateTime.Now.ToString() + ")";
                consola.Text = contenido;
            }
            else
            {
                consola.Text = ">";
                contenido = "> " + operacion + " (" + DateTime.Now.ToString() + ")";
                consola.Text = contenido;
                count_consola = 0;
            }
        }

        private void calibracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 View2 = new Form2();
            View2._gridview("correo_calibracion");
            View2.Show();
        }

        private void salidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 View2 = new Form2();
            View2._gridview("correo_salida");
            View2.Show();
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 View2 = new Form2();
            View2._gridview("correo_facturacion");
            View2.Show();
        }

        private void cotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 View2 = new Form2();
            View2._gridview("correo_cotizacion");
            View2.Show();
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 View3 = new Form3();
            View3.Show();
        }
    }
}
