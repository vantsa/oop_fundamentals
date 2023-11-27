using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace OOP_fundamentals
{
    internal abstract class Email
    {
        #region Properties
        public string? From { get; set; }
        public string? To { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        #endregion

        #region Methods
        public abstract SmtpClient setSmtpCredentials();
        public bool Validate()
        {
            if (string.IsNullOrEmpty(this.From) == false && string.IsNullOrEmpty(this.To) == false && string.IsNullOrEmpty(this.Subject) == false) 
            {
                return true;
            } else return false;
        }
        public virtual void formatMessage()
        {
            this.Message = string.Empty;
        }
        #endregion
    }
}
