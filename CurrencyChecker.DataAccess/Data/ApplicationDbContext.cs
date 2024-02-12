using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyChecker.Domin.Model.Authentcation.Register;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CurrencyChecker.DataAccess.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options){}
        public DbSet<RegisterUser> RegisterUsers { get; set; }
    }
}
