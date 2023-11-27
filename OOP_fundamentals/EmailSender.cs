using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_fundamentals
{
    internal static class EmailSender
    {
        #region Methods
        public static void Send(Email email)
        {
            if (email.Validate())
            {
                email.formatMessage();
                MailMessage mail = new MailMessage(email.From, email.To, email.Subject, email.Message);
                SmtpClient smtp = email.setSmtpCredentials();
                try
                {
                    smtp.Send(mail);
                    Console.WriteLine("Email sent successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error sending the email {ex.Message}");
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    mail.Dispose();
                    smtp.Dispose();
                }
            }else throw new ValidationException("The email is not valid");
        }
        #endregion
    }
}
