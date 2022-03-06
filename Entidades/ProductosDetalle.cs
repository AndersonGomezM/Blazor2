using System;
using System.Collections;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Blazor.Entidades
{
    public class ProductosDetalle
    {
        [Key]

        public int DetallesId { get; set; }

        public int ProductosId { get; set; }

        public string? DescripcionDetalle { get; set; }

        public string? Presentacion { get; set; }

        public double Cantidad { get; set; }

        public double Precio { get; set; }

        public int Empaque { get; set; }

        public ProductosDetalle(string? descripcionDetalle, string? presentacion, double cantidad, double precio, int empaque)
        {
            this.DescripcionDetalle = descripcionDetalle;
            this.Presentacion = presentacion;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Empaque = empaque;
        }
    }
}