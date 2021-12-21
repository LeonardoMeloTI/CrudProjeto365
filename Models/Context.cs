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

        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Passagem> passagem { get; set; }
        public DbSet<CrudProjeto365.Models.Contato> Contato { get; set; }
        public DbSet<CrudProjeto365.Models.Promocao> Promocao { get; set; }
    }
}
