﻿namespace PasosIniciales.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Foto { get; set;}
        public double Precio { get; set;}
        public int Cantidad { get; set; }
    }
}