using BankApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.UI.Authentication
{
    public interface IAuthenticationService
    {
        public User MyProperty { get; set; }
    }
}
