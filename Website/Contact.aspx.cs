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
         

        


                MailMessage email = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                email.From = new MailAddress(emailTextBox.Text);
                email.To.Add("brandonroycstn@hotmail.com");
                email.Subject = "" + SubjectTextBox.Text;
                email.Body = MessageTextBox.Text;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(email);


            MailMessage message = new MailMessage();

            message.From = new MailAddress("sender@foo.bar.com");



            message.To.Add(new MailAddress("recipient1@foo.bar.com"));

            message.To.Add(new MailAddress("recipient2@foo.bar.com"));

            message.To.Add(new MailAddress("recipient3@foo.bar.com"));



            message.CC.Add(new MailAddress("carboncopy@foo.bar.com"));

            message.Subject = "This is my subject";

            message.Body = "This is the content";



            SmtpClient client = new SmtpClient();

            client.Send(message);





        }
}
}