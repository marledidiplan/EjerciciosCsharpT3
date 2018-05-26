using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosCsharpT3.Capitulo9
{
    class Ej1
    {
        public struct PTiendas
        {

            public string Nombre;
            public int Precio;
            public int Cantidad;


            public PTiendas(string tNombre, int tPrecio, int tCantidad)
            {

                Nombre = tNombre;
                Precio = tPrecio;
                Cantidad = tCantidad;


            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre del Producto: {0}, Precio del Producto: {1}, Cantidad del Producto: {2}", Nombre, Precio, Cantidad);
                return (sb.ToString());

            }


        }
        public void Ejerccio1()
        {
            PTiendas t = new PTiendas("Sweater Dress", 1034, 14);
            PTiendas pt1 = new PTiendas("Faux Gemstone Ring Set", 600, 10);
            PTiendas pt2 = new PTiendas("Rhinestone Star Charm Bracelet", 500, 5);


            Console.WriteLine(t.ToString());
            Console.WriteLine(pt1.ToString());
            Console.WriteLine(pt2.ToString());

            Console.ReadKey();
        }

        public struct GuardarInf
        {

        }
        public enum Neumaticos
        {  Neumáticos4x4, NeumáticosRunflat, NeumáticosTubuless };

        public void Ejerccio5()
        {
            Neumaticos neumaticos = (Neumaticos)1;
            Console.WriteLine(neumaticos);
            Neumaticos ne = (Neumaticos)2;
            Console.WriteLine(ne);
            Neumaticos neu = (Neumaticos)3;
            Console.WriteLine(neu);

            Console.ReadKey();

        }
    }
    
 
}
