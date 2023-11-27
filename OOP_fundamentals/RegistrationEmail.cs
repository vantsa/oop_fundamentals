using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace OOP_fundamentals
{
    internal class RegistrationEmail : Email
    {
        public string? CustomerName {  get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? WebsiteName { get; set; }
        public string? WebsiteUrl { get; set; }
        public override SmtpClient setSmtpCredentials()
        {     
            return new SmtpClient("smtp-pulse.com", 2525)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("tankoi@enetix.ro", "9SqCLkdP87DE"),
                EnableSsl = false,
            };
        }

        public override void formatMessage()
        {
            base.Message = $"Dear {this.CustomerName},\n\n" +
                $"Thank you for registering on {this.WebsiteName} website.\n" +
                "Your user information is the following\n\n" +
                $"User name: {this.UserName}\n" +
                $"Password: {this.Password}\n\n" +
                $"Please visit our website in the following URL : {this.WebsiteUrl}\\n\n" +
                "Sincerrely,\n" +
                $"The {this.WebsiteName} team.";
        }
    }
}
