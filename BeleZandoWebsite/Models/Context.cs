using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BeleZando.Models
{
    public class Context: DbContext
    {
        public Context(): base("Server=DESKTOP-1T99VF9;Database=DB_BELEZANDO;User Id=sa;Password=123@qwe;") { }

        public DbSet<Profissional> Profissional { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Atendente> Atendente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Profissional>().ToTable("TBPRFSSBLZ");
            modelBuilder.Entity<Profissional>().Property(p => p.CodigoProfissional).HasColumnName("PFCODBLZ");
            modelBuilder.Entity<Profissional>().Property(p => p.EmailProfissional).HasColumnName("PFEMLBLZ");
            modelBuilder.Entity<Profissional>().Property(p => p.RazaoSocialProfissional).HasColumnName("PFRZSBLZ");
            modelBuilder.Entity<Profissional>().Property(p => p.NomeFantasiaProfissional).HasColumnName("PFNMFTBLZ");
            modelBuilder.Entity<Profissional>().Property(p => p.CpfProfissional).HasColumnName("PFCPFBLZ");
            modelBuilder.Entity<Profissional>().Property(p => p.CnpjProfissional).HasColumnName("PFCNPJBLZ");
            modelBuilder.Entity<Profissional>().Property(p => p.TelefoneProfissional).HasColumnName("PFTLFBLZ");
            modelBuilder.Entity<Profissional>().Property(p => p.NumeroEnderecoProfissional).HasColumnName("PFNUMBLZ");
            modelBuilder.Entity<Profissional>().Property(p => p.EnderecoProfissional).HasColumnName("PFENDBLZ");
            modelBuilder.Entity<Profissional>().Property(p => p.BairroProfissional).HasColumnName("PFBAIBLZ");
            modelBuilder.Entity<Profissional>().Property(p => p.CidadeProfissional).HasColumnName("PFCIDBLZ");
            modelBuilder.Entity<Profissional>().Property(p => p.EstadoProfissional).HasColumnName("PFUFBLZ");
            modelBuilder.Entity<Profissional>().Property(p => p.CepProfissional).HasColumnName("PFCEPBLZ");
            modelBuilder.Entity<Profissional>().Property(p => p.SenhaProfissional).HasColumnName("PFSNHBLZ");
            modelBuilder.Entity<Profissional>().Property(p => p.SituacaoProfissional).HasColumnName("PFSITBLZ");
            modelBuilder.Entity<Profissional>().Property(p => p.UltimaAtualizacaoProfissional).HasColumnName("PFULTABLZ");

            modelBuilder.Entity<Cliente>().ToTable("TBCLTBLZ");
            modelBuilder.Entity<Cliente>().Property(p => p.CodigoCliente).HasColumnName("CLCODBLZ");
            modelBuilder.Entity<Cliente>().Property(p => p.NomeCliente).HasColumnName("CLNMBLZ");
            modelBuilder.Entity<Cliente>().Property(p => p.EmailCliente).HasColumnName("CLEMLBLZ");
            modelBuilder.Entity<Cliente>().Property(p => p.CpfCliente).HasColumnName("CLCPFBLZ");
            modelBuilder.Entity<Cliente>().Property(p => p.DataNascimentoCliente).HasColumnName("CLDTNSCBLZ");
            modelBuilder.Entity<Cliente>().Property(p => p.TelefoneCliente).HasColumnName("CLTLFBLZ");
            modelBuilder.Entity<Cliente>().Property(p => p.SenhaCliente).HasColumnName("CLSNHBLZ");
            modelBuilder.Entity<Cliente>().Property(p => p.SituacaoCliente).HasColumnName("CLSITBLZ");
            modelBuilder.Entity<Cliente>().Property(p => p.UltimaAtualizacaoCliente).HasColumnName("CLULTABLZ");

            modelBuilder.Entity<Atendente>().ToTable("TBATNDBLZ");
            modelBuilder.Entity<Atendente>().Property(p => p.CodigoAtendente).HasColumnName("ATCODBLZ");
            modelBuilder.Entity<Atendente>().Property(p => p.NomeAtendente).HasColumnName("ATNMBLZ");
            modelBuilder.Entity<Atendente>().Property(p => p.EmailAtendente).HasColumnName("ATEMLBLZ");     
            modelBuilder.Entity<Atendente>().Property(p => p.TelefoneAtendente).HasColumnName("ATTLFBLZ");
            modelBuilder.Entity<Atendente>().Property(p => p.SenhaAtendente).HasColumnName("ATSNHBLZ");
            modelBuilder.Entity<Atendente>().Property(p => p.SituacaoAtendente).HasColumnName("ATSITBLZ");
            modelBuilder.Entity<Atendente>().Property(p => p.UltimaAtualizacaoAtendente).HasColumnName("ATULTABLZ");
        }        
    }
}