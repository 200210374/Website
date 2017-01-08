using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;




namespace Website
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { }







        protected void Submit_Click(object sender, EventArgs e)
        {
            using (MailMessage mm = new MailMessage(emailTextBox.Text, "brandonroycstn@hotmail.com"))
            {
                mm.Subject = SubjectTextBox.Text;
                mm.Body =   "Name: " + NameTextBox.Text + "email: " + emailTextBox.Text + "Message: " + MessageTextBox.Text;
               
                mm.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp-mail.outlook.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential("brandonroycstn@hotmail.com", "Lovecraft1");
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mm);
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Email sent.');", true);
            }
        }





    }
}