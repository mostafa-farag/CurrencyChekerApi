using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CurrencyChecker.Domin.Dto;
using CurrencyChecker.Domin.Model.Authentcation.Register;

namespace CurrencyChecker.Domin.Helper
{
    public class MappingProfiling:Profile
    {
        public MappingProfiling() 
        { 
           CreateMap<RegisterUser,RegisterUserDto>().ReverseMap();
        }
    }
}
