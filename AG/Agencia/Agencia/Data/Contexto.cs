﻿using Agencia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agencia.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-KOD9I0N;Initial Catalog=Agencia;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(table =>
            {
                table.ToTable("Clientes");
                table.HasKey(prop => prop.Id);

                table.Property(prop => prop.Nome).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.CPF).HasColumnType("char(11)").IsRequired();
                table.Property(prop => prop.Telefone).HasColumnType("char(14)").IsRequired();
                table.Property(prop => prop.Endereco).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.Nascimento).HasColumnType("date");
                table.Property(prop => prop.Situacao).HasConversion<string>().HasMaxLength(9);
            });
        }
    }
}