﻿// <auto-generated />
using System;
using Blazor.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blazor.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220306003353_Producto")]
    partial class Producto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("Blazor.Entidades.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Costo")
                        .HasColumnType("REAL");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Existencia")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ganancia")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Precio")
                        .HasColumnType("REAL");

                    b.Property<string>("Presentacion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("ValorInventario")
                        .HasColumnType("REAL");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Blazor.Entidades.ProductosDetalle", b =>
                {
                    b.Property<int>("DetallesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Cantidad")
                        .HasColumnType("REAL");

                    b.Property<string>("DescripcionDetalle")
                        .HasColumnType("TEXT");

                    b.Property<double>("Precio")
                        .HasColumnType("REAL");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductosId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetallesId");

                    b.HasIndex("ProductoId");

                    b.ToTable("ProductosDetalle");
                });

            modelBuilder.Entity("Blazor.Entidades.ProductosDetalle", b =>
                {
                    b.HasOne("Blazor.Entidades.Productos", null)
                        .WithMany("ProductosDetalle")
                        .HasForeignKey("ProductoId");
                });

            modelBuilder.Entity("Blazor.Entidades.Productos", b =>
                {
                    b.Navigation("ProductosDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
