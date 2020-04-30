using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication7.Models;

namespace WebApplication7.Models
{
    public class WebApplication7Context : DbContext
    {
        public WebApplication7Context (DbContextOptions<WebApplication7Context> options)
            : base(options)
        {
         
        }

        public DbSet<WebApplication7.Models.Pracownik> Pracownik { get; set; }

        public DbSet<WebApplication7.Models.Kupujacy> Kupujacys { get; set; }

        public DbSet<WebApplication7.Models.Polaczenie> Trasa { get; set; }

        public DbSet<WebApplication7.Models.Transakcja> Transakcja { get; set; }

       
    }
}
