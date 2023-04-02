using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Exe_WebApi.Models
{
    public class SemanaContext : DbContext
    {
        public SemanaContext(DbContextOptions<SemanaContext> options) : base(options)
        {
            
        }
    public DbSet<SemanaModel> Semana { get; set; }
    }
}