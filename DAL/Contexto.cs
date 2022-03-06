using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Blazor.Entidades;

namespace Blazor.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos>? Productos { get; set; }
        public DbSet<ProductosDetalle>? ProductosDetalles { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options){}
    }
}