using CurrencyChecker.Domin.Model.Authentcation.Register;
using CurrencyChecker.Domin.Dto;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyChecker.Domin.Service
{
    public interface IRegisterService
    {
        Task<RegisterUser> AddUser(RegisterUser register);
    }
}
