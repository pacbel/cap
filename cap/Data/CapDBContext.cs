using cap.Business.Entities;
using cap.Data.Mappings;

using cap.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cap.Data
{
    public class CapDBContext : DbContext
    {
        public CapDBContext(DbContextOptions<CapDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            modelBuilder.ApplyConfiguration(new PessoaFisicaMapping());
            modelBuilder.ApplyConfiguration(new PessoaJuridicaMapping());
            base.OnModelCreating(modelBuilder);
        }
        /// <summary>
        /// 
        /// </summary>
        /// 
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<ContaPagar> ContaPagar { get; set; }

    }
}
