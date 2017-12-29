using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
    public partial class Form1 : MetroForm
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        Class.Class_debug her_depurar_ejecutar = new Class.Class_debug();
        Class.Class_email correo = new Class.Class_email();
        bool filecsv = false;

        string horainicial = "08:15:00";
        string[] ArrSucur = { "n", "h", "g" };
        string[] ArrNomSucur = { "Nogales", "Hermosillo", "Guaymas" };
        int count_consola = 0;
        string horainicial2 = "07:35";       

        public Form1()
        {
            InitializeComponent();
            this.StyleManager = this.metroStyleManager1;
            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;
            timer_reloj.Start();
            timer_checador.Interval = (1000 * 60); // cada  minuto
            timer_checador.Start();
            check_n1.Checked = true;
            check_h1.Checked = true;
            check_g1.Checked = false;
            metroCheckBox5.Checked = true;
            MaximizeBox = false;
            metroTextBox_correos.Enabled = false;
            metroButtonFileCsv.Enabled = false;


        }

        private void _procesos(string proceso = "", string desc = "", string correotep = "")
        {
            bool[] Arrcheck = { check_n1.Checked, check_h1.Checked, check_g1.Checked };
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
                            her_depurar_ejecutar._tecnico(dt_copy, ArrNomSucur[i]);
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
                            DataTable dt_tempreport = new DataTable();
                            DataTable dt_copy = new DataTable();
                            dt = her_depurar_ejecutar._select(proceso, ArrSucur[i]);
                            dt_copy = dt.Copy();
                            dt_tempreport = her_depurar_ejecutar._clientes(dt_copy, y);
                            // Enviar reporte, REvisar                            
                            DataTable dt_email = new DataTable();
                            dt_email = her_depurar_ejecutar._ejecutar(her_depurar_ejecutar._querys("correo_reporte", y.ToString()), "2"); //obtengo el query, deespues el dt
                            string listaemail = her_depurar_ejecutar._listaemails(dt_email); // Obtengo la lista de correos
                            correo._enviar(dt_tempreport, "reporte", listaemail, "", ArrNomSucur[i]);
                            // Fin
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
                            //Opcion para enviar correo de manera particular
                            string listaemail = "";
                            if (String.IsNullOrEmpty(correotep))
                            {
                                DataTable dt_email = new DataTable();
                                dt_email = her_depurar_ejecutar._ejecutar(her_depurar_ejecutar._querys("correo_" + proceso, y.ToString()), "2"); //obtengo el query, deespues el dt
                                listaemail = her_depurar_ejecutar._listaemails(dt_email); // Obtengo la lista de correos
                            }
                            else
                            {
                                listaemail = correotep;
                            }

                            correo._enviar(dt_copy, desc, listaemail, "", ArrNomSucur[i]);
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
            metrotimer.Text = DateTime.Now.ToLongTimeString();
            Fecha.Text = DateTime.Now.ToString("dd-MMM-yyyy");

            string contenido = metroconsola.Text.ToString();
            var _length = contenido.Length;
            string seg = DateTime.Now.ToString("ss");
            if ((int.Parse(seg) % 2) == 0)
            {
                string temp = "_";
                if (contenido.Substring((_length - 1), 1) != "_") { metroconsola.Text = contenido + (temp); }
            }
            else
            {
                if (_length > 1 && contenido.Substring((_length - 1), 1) == "_") { metroconsola.Text = contenido.Substring(0, _length - 1); }
                else
                {
                    metroconsola.Text = contenido;
                }
            }

            var Hora = DateTime.Now.ToString("HH:mm:ss");
            if (Hora == horainicial) //Envia recordatorios programado
            {
                DateTime today = DateTime.Today;
                if (today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday)
                {
                    _procesos("calibracion", "Calibración");
                    Thread.Sleep(10000);
                    _procesos("salida", "Salida");
                    Thread.Sleep(10000);
                    _procesos("facturacion", "Facturación");
                    Thread.Sleep(10000);
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
            var Hora = DateTime.Now.ToString("HH:mm");
            if ((hoy.ToString("dd-MMM-yyyy") == diaultimomes.ToString("dd-MMM-yyyy")) && (Hora == horainicial2))
            {
                _procesos("clientes");
            }

        }

        private void _consola(string operacion = "")
        {
            var _length = metroconsola.Text.ToString().Length;
            string contenido = metroconsola.Text.ToString();
            if (_length > 1 && contenido.Substring((_length - 1), 1) == "_") { contenido = contenido.Substring(0, _length - 1); }
            metroconsola.Text = contenido;
            count_consola++;
            if (count_consola == 1)
            {
                contenido += " " + operacion + " (" + DateTime.Now.ToString() + ")";
                metroconsola.Text = contenido;
            }
            else if (count_consola < 10)
            {
                contenido += String.Format(Environment.NewLine) + "> " + operacion + " (" + DateTime.Now.ToString() + ")";
                metroconsola.Text = contenido;
            }
            else
            {
                metroconsola.Text = ">";
                contenido = "> " + operacion + " (" + DateTime.Now.ToString() + ")";
                metroconsola.Text = contenido;
                count_consola = 0;
            }
        }

        private void calibracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 View2 = new Form2("Correos calibracion");
            View2._gridview("correo_calibracion");
            View2.Show();
        }

        private void salidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 View2 = new Form2("Correos salida");
            View2._gridview("correo_salida");
            View2.Show();
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 View2 = new Form2("Correos facturación");
            View2._gridview("correo_facturacion");
            View2.Show();
        }

        private void cotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 View2 = new Form2("Correos cotización");
            View2._gridview("correo_cotizacion");
            View2.Show();
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 View3 = new Form3();
            View3.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 View2 = new Form2("Correos reportes");
            View2._gridview("correo_reporte");
            View2.Show();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            var m = new Random();
            int next = m.Next(0, 13);
            metroStyleManager1.Style = (MetroColorStyle)next;
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Theme = metroStyleManager1.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
        }

        private void metroButtonenviar_Click(object sender, EventArgs e)
        {

            try
            {
                _procesos(metroComboproceso.Text, metroComboproceso.Text, metroTextBoxcorreo.Text);
                metroTextBoxcorreo.Text = "";
                MetroMessageBox.Show(this, "Se envio Exitosamente!", "Mensaje de notificación", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Error al enviar el correo, verificar datos. Si persite el error reportarlo al administrador!", "Mensaje de notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            // Array [cliente,nogales,hermosillo,nogales,htmlbody]
            bool[] Arrcheck = { metroCheckBox1.Checked, metroCheckBox2.Checked, metroCheckBox3.Checked, metroCheckBox4.Checked,metroCheckBox6.Checked, metroCheckBox5.Checked };
            String[] Arrayquery =
            {
                "SELECT email FROM mypsa_bitacoramyp.view_usuarios where roles_id=10005 and activo='si';",
                "SELECT email FROM mypsa_bitacoramyp.view_usuarios where plantas_id=758  and activo='si';",
                "SELECT email FROM mypsa_bitacoramyp.view_usuarios where plantas_id=757  and activo='si';",
                "SELECT email FROM mypsa_bitacoramyp.view_usuarios where plantas_id=2341  and activo='si';",
                "",
                "",
            };
                        string asunto = metroTextBox_asunto.Text;           
            string body = metroTextBox_body.Text;

            for (int i = 0; i < Arrcheck.Length -1; i++)
            {
                if (Arrcheck[i] == true)
                {
                    string contactos = "";
                    if (i == 4) // Opcion de otros
                    {
                        /*  Opcion  */
                        string correos = metroTextBox_correos.Text;
                        if (filecsv==true)
                        {
                            contactos = her_depurar_ejecutar._listaemails(dt2);
                        }
                        if (!String.IsNullOrEmpty(correos))
                        {
                            contactos += "," +correos;
                        }                          
                    }
                    else {
                        DataTable dt_email = new DataTable();
                        dt_email = her_depurar_ejecutar._ejecutar(Arrayquery[i]);
                        contactos = her_depurar_ejecutar._listaemails(dt_email);                       
                    }

                    try
                    {
                        if (!String.IsNullOrEmpty(contactos)){string retorno = correo._enviartemp(asunto, contactos, body, Arrcheck[5]);}
                        else { MetroMessageBox.Show(this, "Se ha detecto que no existen contactos, favor de verificar!", "Mensaje de notificación", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                        MetroMessageBox.Show(this, "Operacion exitosa!", "Mensaje de notificación", MessageBoxButtons.OK, MessageBoxIcon.Question);                        
                    }
                    catch (Exception)
                    {
                        MetroMessageBox.Show(this, "Se ha detecto un error al enviar mensaje, Contactarse con el Administrador!", "Mensaje de notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                    
                }
            }
            
            

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            dt2.Clear();
            filecsv = false;
            metroLabelFile.Text = "Archivo limpio";
            metroTextBox_body.Text = "";
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames=true,Multiselect=false }) {
                    if (ofd.ShowDialog()== DialogResult.OK)
                    {
                        dt2 = readCsv(ofd.FileName);
                        if (dt2.Rows.Count > 0)
                        {                                                      
                            metroLabelFile.Text = "Archivo listo, Contactos: # "+ dt2.Rows.Count;
                            filecsv = true;
                        }                                                                   
                    }
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Error de operación!", "Mensaje de notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
        }

        public DataTable readCsv(string filename) {
            DataTable dt = new DataTable("Data");
            using (OleDbConnection cn= new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\""+
                    Path.GetDirectoryName(filename)+ "\";Extended Properties='text; HDR=yes;FMT=Delimited(,)';"))
            {
                using (OleDbCommand cmd=new OleDbCommand(String.Format("select * from [{0}]",new FileInfo(filename).Name),cn))
                {
                    cn.Open();
                    using (OleDbDataAdapter adapter= new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        private void metroCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox6.Checked == true)
            {
                metroTextBox_correos.Enabled = true;
                metroButtonFileCsv.Enabled = true;
            }
            else {
                metroTextBox_correos.Enabled = false;
                metroButtonFileCsv.Enabled = false;
            }
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "HTML|*.html", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string bodyhtml = File.ReadAllText(ofd.FileName);
                        if (bodyhtml.Length > 0)
                        {
                            metroTextBox_body.Text = bodyhtml;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Error de operación!", "Mensaje de notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
