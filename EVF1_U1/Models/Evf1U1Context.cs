using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace EVF1_U1.Models;

public partial class Evf1U1Context : DbContext
{
    public Evf1U1Context()
    {
    }

    public Evf1U1Context(DbContextOptions<Evf1U1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {


        if (!optionsBuilder.IsConfigured) { }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("clientes");

            entity.Property(e => e.Id)
                .HasColumnType("int(100)")
                .HasColumnName("id");
            entity.Property(e => e.Apelido)
                .HasMaxLength(20)
                .HasColumnName("apelido");
            entity.Property(e => e.Email)
                .HasMaxLength(20)
                .HasColumnName("email");
            entity.Property(e => e.FechaHora)
                .HasColumnType("datetime")
                .HasColumnName("fecha_hora");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .HasColumnName("nombre");
            entity.Property(e => e.Rut)
                .HasMaxLength(10)
                .HasColumnName("rut");
            entity.Property(e => e.Telefono)
                .HasMaxLength(10)
                .HasColumnName("telefono");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
