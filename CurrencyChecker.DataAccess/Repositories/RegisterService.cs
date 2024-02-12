using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CurrencyChecker.DataAccess.Data;
using CurrencyChecker.Domin.Dto;
using CurrencyChecker.Domin.Model.Authentcation.Register;
using CurrencyChecker.Domin.Service;

namespace CurrencyChecker.DataAccess.Repositories
{
    public class RegisterService : IRegisterService
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;
        public RegisterService(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<RegisterUser> AddUser(RegisterUser dto)
        {
           var user = _mapper.Map<RegisterUser>(dto);
            await _context.AddAsync(dto);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
