using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderFinal.Models
{
    public class DrinksDb : DbContext
    {
        public DrinksDb(DbContextOptions<DrinksDb> options) : base(options) {
        }

        public DbSet<Drinks> Drinks { get; set; }
    }
    
}
