using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;




namespace Website
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { }



              protected void Submit_Click(object sender, EventArgs e)
        {




            string EmailAddress = emailTextBox.Text;
            MailMessage mailMessage = new MailMessage(EmailAddress, EmailAddress);
            mailMessage.To.Add(emailTextBox.Text);

            mailMessage.Subject = NameTextBox.Text + SubjectTextBox.Text;
            mailMessage.Body = MessageTextBox.Text;

            SmtpClient smtpClient = new SmtpClient("smtp.live.com");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            smtpClient.Host = "smtp.live.com";
            smtpClient.Port = 587;

            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "brandonroycstn@hotmail.com",
                Password = "Silverlight1"
            };
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Send(mailMessage);

            Response.Write("E-mail sent!");


            smtpClient.UseDefaultCredentials = false;

           











        }
}
}