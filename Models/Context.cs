using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudProjeto365.Models;

namespace CrudProjeto365.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context>options) : base(options)
        {

        }

        public DbSet<Contato> Contato { get; set; }
        public DbSet<Passagem> Passagem { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Promocao> Promocao { get; set; }
    }
}
