using System;
using Microsoft.AspNetCore.Components;
using System.Net.Mail;

namespace KenneyMusicWeb.Pages
{
    public partial class Contact : ComponentBase
    {
        private Email userEmail = new Email();
        private string confirmationMsg { get; set; }
        private string buttonLabel { get; set; } = "Send";
        private bool buttonDisable { get; set; } = false;

        private void SendMail()
        {
            Console.WriteLine("Inside SendMail");
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(userEmail.email);
                    mail.To.Add("mrphantasticmusic@gmail.com");
                    mail.Subject = userEmail.subjectEmail;
                    mail.Body = userEmail.bodyEmail +
                        "<p><b>Sender's Email: </b>" +
                        userEmail.email +
                        "</p><p><b>Sender's Name: </b>" +
                        userEmail.senderName +
                        "</p>";
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential("mrphantasticmusic@gmail.com", "swjvwxqpnuajbvfd");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                        confirmationMsg =
                            "<h4>Thank you!</h4>" +
                            "<p>I've received your message and will get back to you within 1-2 business days.</p>";
                        buttonLabel = "Submitted";
                        buttonDisable = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
