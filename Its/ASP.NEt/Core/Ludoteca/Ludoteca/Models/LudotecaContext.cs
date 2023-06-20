using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ludoteca.Models
{
    public partial class LudotecaContext : DbContext
    {
        public LudotecaContext()
        {
        }

        public LudotecaContext(DbContextOptions<LudotecaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Gioco> Giochi { get; set; } = null!;
        public virtual DbSet<Prestito> Prestiti { get; set; } = null!;
        public virtual DbSet<Utente> Utenti { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\MSSQLSERVER01;Database=Ludoteca;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gioco>(entity =>
            {
                entity.HasKey(e => e.IdGioco)
                    .HasName("PK_Giochi");

                entity.ToTable("Gioco");

                entity.Property(e => e.IdGioco)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Gioco");

                entity.Property(e => e.Denominazione)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("denominazione");

                entity.Property(e => e.Descrizione)
                    .HasColumnType("text")
                    .HasColumnName("descrizione");

                entity.Property(e => e.DurataPartita)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("durata_partita");

                entity.Property(e => e.EtaDeiGiocatori)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eta_dei_giocatori");

                entity.Property(e => e.NumeroDiGiocatori)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numero_di_giocatori");

                entity.Property(e => e.NumeroDiPezzi).HasColumnName("numero_di_pezzi");

                entity.Property(e => e.Tipologia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipologia");

                entity.Property(e => e.url_img)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("url_img");
            });

            modelBuilder.Entity<Prestito>(entity =>
            {
                entity.HasKey(e => e.IdPrestito);

                entity.ToTable("Prestito");

                entity.Property(e => e.IdPrestito)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Prestito");

                entity.Property(e => e.CfUtente)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CF_Utente");

                entity.Property(e => e.DataPrestito)
                    .HasColumnType("date")
                    .HasColumnName("data_prestito");

                entity.Property(e => e.DataRestituzione)
                    .HasColumnType("date")
                    .HasColumnName("data_restituzione");

                entity.Property(e => e.IdGioco).HasColumnName("ID_Gioco");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasColumnName("note");

                entity.HasOne(d => d.CfUtenteNavigation)
                    .WithMany(p => p.Prestiti)
                    .HasForeignKey(d => d.CfUtente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prestito_Utente");

                entity.HasOne(d => d.IdGiocoNavigation)
                    .WithMany(p => p.Prestiti)
                    .HasForeignKey(d => d.IdGioco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prestito_Giochi");
            });

            modelBuilder.Entity<Utente>(entity =>
            {
                entity.HasKey(e => e.Codicefiscale);

                entity.ToTable("Utente");

                entity.Property(e => e.Codicefiscale)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Cap)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Citta)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cognome)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DataNascita)
                    .HasColumnType("date")
                    .HasColumnName("Data_Nascita");

                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Indirizzo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LuogoNascita)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Luogo_Nascita");

                entity.Property(e => e.Nome)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Provincia)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
