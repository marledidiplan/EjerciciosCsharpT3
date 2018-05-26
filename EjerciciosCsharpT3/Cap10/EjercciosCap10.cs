using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosCsharpT3.Cap10
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Costo { get; set; }
        public double Precio { get; set; }
        public double Cantidad { get; set;}

        public Articulo()
        {
            Id = 0;
            Costo = 0;
            Precio = 0;
            Cantidad = 0;


        }
        public Articulo(int Id, string Nombre, double Costo, double Precio, double Cantidad)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Costo = Costo;
            this.Precio = Precio;
            this.Cantidad = Cantidad;
        }

        
    }

    public class Estudiante
    {
        public int id { get; set; }
        public string Nombres { get; set; }
        public string  Apellidos { get; set; }
        public string Matricula { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Carrerra { get; set; }
        public string Telefono { get; set; }

        public Estudiante()
        {
            id = 0;
        }
        public Estudiante(int id, string Nombres, string Apellidos, string Matricula, string Cedula, string Direccion, string Carrera, string Telefono)
        {
            this.id = id;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Matricula = Matricula;
            this.Cedula = Cedula;
            this.Direccion = Direccion;
            this.Carrerra = Carrerra;
            this.Telefono = Telefono;


        }
        
    }


}
