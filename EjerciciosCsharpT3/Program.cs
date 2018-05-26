using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosCsharpT3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Digite la opcion del capitulo que desea");
            opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {
                int op;
                Console.WriteLine("Cual ejerccio desea");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        Capitulo9.Ej1 ej1 = new Capitulo9.Ej1();
                        ej1.Ejerccio1();
                        break;
                    case 2:
                        Capitulo9.Ej1 ej = new Capitulo9.Ej1();
                        ej.Ejerccio5();

                        break;



                }
            }
            
        }
    }
}