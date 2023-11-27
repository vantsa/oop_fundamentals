using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_fundamentals
{
    internal class Customer : Person
    {
        #region Propterties
        public string Email { get; set; }
        #endregion

        #region Controllers
        public Customer(string Name, Genders Gender, DateTime DateOfBirth, string email) : base(Name, Gender, DateOfBirth)
        {
            this.Email = email;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return base.ToString() + $"Email: {this.Email}";
        }
        #endregion
    }
}
