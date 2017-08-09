using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Drawing;
using System.Net.Mime;
using System.IO;
using System.Drawing.Imaging;
using System.Data;

namespace Myp_Email.Class
{
    public class Class_email
    {
        public Class_email()
        {

        }

        private string _mes(DateTime hoy)
        {
            string[] meses_array = new string[] { "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" };
            var mes = "";
            if (hoy.Month + 1 < 13) // un año nuevo           
            {
                mes = meses_array[hoy.Month];
            }
            else
            {
                mes = meses_array[0].ToString();
            }

            return mes;
        }

        private string _encabezado()
        {
            string contenido = "";
            contenido = "<table style=\"width:100% \"> " +
              "<tr>" +
                "<td> <img src='cid:imagen'/> </td>" +
                "<td align=\"right\">" +
                    "<p> RFC: MPR990906AF4" +
                        "<br> Privada Tecnológico No. 25" +
                        "<br> Col. Granja Nogales Sonora, C.P. 84065" +
                        "<br> Tel: 631-314-6263, 631-314-6193" +
                    "</p>" +
               "</td>" +
              "</tr>" +
            "</table> <br>";

            return contenido;
        }

        private string _procesos(DataTable dtequipo, string tipo = "")
        {
            string contenido = "";
            if (tipo != "cliente") { contenido += "<h1> " + tipo + "</h1> "; }

            contenido += "<table style=\"width:100%;\"><tr>" +
            "<th style=\"width:5%;\">No.</th>";

            if (tipo != "cliente") { contenido += "<th >Id</th>"; }

            contenido += "<th style=\"width:18%;\">Id equipo</th>" +
            "<th >Equipo</th>" +
            "<th >Marca</th>" +
            "<th >Modelo</th>" +
            "<th >Serie</th>";
            if (tipo != "cliente")
            {
                contenido += "<th >Cliente</th>" +
                "<th >Dirección</th>" +
                "<th >Fecha de entrada</th>" +
                "<th style='width:10px;'>Estancia</th>";
            }

            contenido += "</tr>";
            for (int i = 0; i < dtequipo.Rows.Count; i++)
            {
                if ((i % 2) == 0)
                {
                    contenido += "<tr style='background-color: #efefef;' class=\"cuadro2\">";
                }
                else
                {
                    contenido += "<tr style='background-color: #393939; color: white;' class=\"cuadro2\">";
                }
                var count = i + 1;
                contenido += "" +
                     "<td>" + count + "</td>";
                if (tipo != "cliente") { contenido += "<td>" + dtequipo.Rows[i]["id"] + "</td>"; }

                contenido += "<td >" + dtequipo.Rows[i]["id_equipo"] + "</td>" +
                 "<td >" + dtequipo.Rows[i]["descripcion"] + "</td>" +
                 "<td >" + dtequipo.Rows[i]["marca"] + "</td>" +
                 "<td >" + dtequipo.Rows[i]["modelo"] + "</td>" +
                 "<td >" + dtequipo.Rows[i]["serie"] + "</td>";

                if (tipo != "cliente")
                {
                    contenido += "<td >" + dtequipo.Rows[i]["cliente"] + "</td>" +
                     "<td >" + dtequipo.Rows[i]["direccion"] + "</td>" +
                     "<td >" + Convert.ToDateTime(dtequipo.Rows[i]["fecha_inicio"]).ToString("dd/MM/yyyy") + "</td>" +
                     "<td >" + dtequipo.Rows[i]["dias"] + "</td>";
                }
                contenido += "</tr>";
            }
            contenido += "</table>";

            return contenido;
        }

        public string _infocliente(string cliente = "", string dir = "", string rfc = "", string correo = "",string suc="")
        {          

            string contenido = "";
            contenido = "<hr> <table>" +
                    "<tr>" +
                        "<th class='cuadro'> Información del cliente</ th>" +
                        "<th class=\"cuadro\"></th>" +
                    "</tr>" +
                    "<tr>" +
                    "<td class=\"cuadro\">" +
                        "<p> <strong> Cliente:</strong> " + cliente + "</ p>" +
                        "<p> <strong> Dirección:</strong> " + dir + "</p>" +
                        "<p> <strong> RFC:</strong> " + rfc + "</p>" +
                        "<p> <strong> Contacto(s):</strong> " + correo + "</p>" +
                    "</td>" +
                        "<td class=\"cuadro\"><p> <strong>Contacto:</strong> </p>" +
                        "<p> <strong>Fecha:</strong> " + DateTime.Now + "</p>" +
                        "<p> <strong>Asunto:</strong> Recordatorio " + _mes(DateTime.Now) + " </p>" +
                        "<p> <strong>Nota:</strong> Este correo se envía de manera automática, favor de responder a la dirección de correo siguiente: <br> <a>  </a> </p>" +
                    "</td>" +
                   "</tr>" +
                   "</table> <br>";
            return contenido;
        }

        public string _enviar(DataTable dtequipo, string tipo = "", string correo = "", string info_cliente = "")
        {
            //Creamos un nuevo Objeto de Mensaje
            MailMessage oMsg = new MailMessage();
            var email = "laboratoriomypsa@gmail.com";
            //Desde (correo electronico del que enviamos)
            oMsg.From = new MailAddress(email, "Mypsa.com.mx");
            oMsg.To.Add(correo);              
            oMsg.Bcc.Add(new MailAddress("test@mypsa.com.mx", "Copia " + tipo));

            var subject = "Recordatorio de calibración";
            oMsg.Subject = subject;
            // Add HTML and text body
            oMsg.IsBodyHtml = true;
            string html = "";
            html += "<html>" +
                "<head><style>" +
                "table { width: 100 %;}" +
                ".cuadro {border: 1px solid black; border-collapse: collapse; border-radius: 7px; padding: 5px; padding-left: 20px; font-family:verdana;}";
            if (tipo == "cliente") { html += ".cuadro2 {border: 1px solid black; border-collapse: collapse;  padding: 1px; padding-left: 10px; font-family:verdana; text-align:center; font-size:90%;}"; }
            else { html += ".cuadro2 {border: 1px solid black; border-collapse: collapse; border-radius: 3px; padding: 1px; padding-left: 10px; font-family:verdana; font-size:10px;}"; }
            html += "th {width:50%;}" +
            "p {font-family:verdana; font-size:100%;}" +
            "</style></head>" +
            "<body>";
            html += _encabezado();

            if (tipo != "cliente")
            {
                html += _procesos(dtequipo, tipo);
            }
            else
            {
                html += info_cliente;
                html += _procesos(dtequipo, tipo);
            }

            html += "</body></html>";

            // Para concatenar el contenido del body con la imagen que viene pidiendo el encabezado cid:imagen
            AlternateView plainView = AlternateView.CreateAlternateViewFromString("", Encoding.UTF8, MediaTypeNames.Text.Plain);
            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(html, Encoding.UTF8, MediaTypeNames.Text.Html);
            Bitmap bitmap = new Bitmap(Img.logo);
            MemoryStream logo = new MemoryStream();
            bitmap.Save(logo, ImageFormat.Jpeg);
            logo.Position = 0;
            LinkedResource img = new LinkedResource(logo, "image/jpeg");
            img.ContentId = "imagen";
            // Lo egregamos en la vista HTML...
            htmlView.LinkedResources.Add(img);
            // Por último, vinculamos ambas vistas al mensaje...
            oMsg.AlternateViews.Add(plainView);
            oMsg.AlternateViews.Add(htmlView);

            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com"))
            {
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("laboratoriomypsa@gmail.com", "*Z*R311H7e*");
                smtp.Send(oMsg);
            }
            return "Message sent successfully.";
        }
    }
}
