using AutoMapper;
using CurrencyChecker.DataAccess.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using CurrencyChecker.Domin.Model;
using CurrencyChecker.Domin.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using CurrencyChecker.Domin.Service;
using CurrencyChecker.Domin.Model.Authentcation.Register;

namespace CurrencyChekerApi.Controllers.AuthControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _conf;
        private readonly IRegisterService _iregister;
        public RegisterController(ApplicationDbContext context, IMapper mapper,
            UserManager<IdentityUser>userManager,IConfiguration conf,
            IRegisterService iregister)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _conf = conf;
            _iregister = iregister;
        }
        [HttpPost]
        public async Task<IActionResult> RegisterUserAsync(RegisterUserDto dto)
        {
            var emailUser= await _userManager.FindByEmailAsync(dto.Email);
            if (emailUser != null)
            {
                return StatusCode(400);
                new Respons { Status = "Error", Message = "This Email Is Already" };
            }
            if (dto.Password!=dto.ConfirmPassword)
            {
                return StatusCode(400);
                new Respons { Status = "Error", Message = "Password Not ConfirmPassowrd" };
            }
            var adduser = _mapper.Map<RegisterUser>(dto);
            _iregister.AddUser(adduser);
            return Ok(adduser);
        }
    }
}
