using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaApi.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AgendaApi.Contexto
{
    //Classe de context onde será feito o mapamento do banco de dados.
    public class AppDbContext : DbContext
    {
        //Definição do meu contexto
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } //Construtor onde é registrado o contexto.

        //Mepando a entidade Contato com a tabela Contato do DB.
        public DbSet<Contato> Contato { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contato>().Property(p => p.Nome).HasMaxLength(80);
            modelBuilder.Entity<Contato>().Property(p => p.Telefone).HasMaxLength(11);

            //Iseri dados iniciais na criação do banco e da tabela
            modelBuilder.Entity<Contato>().HasData(
                    new Contato { Id = 1, Nome = "Primeiro Sobrenome", Email = "email1@email.com", Telefone = "33911112222"},
                    new Contato { Id = 2, Nome = "Segundo Sobrenome", Email = "email2@email.com", Telefone = "33922223333" },
                    new Contato { Id = 3, Nome = "Terceiro Sobrenome", Email = "email3@email.com", Telefone = "33933334444"}
                );
        }
    }
}
