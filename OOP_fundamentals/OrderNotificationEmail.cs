using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OOP_fundamentals
{
    internal class OrderNotificationEmail : RegistrationEmail
    {
        #region Properties
        public string? CustomerName { get; set; }
        public string? WebsiteName { get; set; }
        public int? OrderNumber { get; set; }
        public string? OrderUrl { get; set; }
        #endregion

        #region Methods
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
            base.Message = $"Dear {base.CustomerName},\n\n" +
                $"Thank you for order {this.OrderNumber}.\n\n" +
                $"To track your order, click on the following URL: {this.OrderUrl}.\n\n" +
                "Sincerelly,\n" +
                $"The: {base.WebsiteName} team.";
        }
        #endregion
    }
}
