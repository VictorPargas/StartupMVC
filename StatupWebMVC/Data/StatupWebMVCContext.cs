using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StatupWebMVC.Models;

namespace StatupWebMVC.Data
{
    public class StatupWebMVCContext : DbContext
    {
        public StatupWebMVCContext (DbContextOptions<StatupWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<StatupWebMVC.Models.Departamento> Departamento { get; set; } = default!;
    }
}
