using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrimerEjercicio();
            //SegundoEjercicio();
            //TercerEjercicio();
            //CuartoEjercicio();
            //QuintoEjercicio();
            //SextoEjercicio();
            SeptimoEjercicio();
        }



        public static void PrimerEjercicio()
        {
            int numero;
            try
            {
                Console.Write("Bienvenido, Ingrese un número entero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEl doble de " + numero + " es: " + numero * 2);
            }
            catch
            {
                Console.WriteLine("\nLo que ingresaste no es un número entero..");
            }
            Console.ReadKey();
        }

        public static void SegundoEjercicio()
        {
            const int FUTURO = 23;
            try
            {
                Console.Write("Bienvenido!. Ingrese su edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nSu edad, dentro de 23 años será: " + (edad + FUTURO));
            }
            catch
            {
                Console.WriteLine("\nUsted no ingresó una edad.");
            }
            Console.ReadKey();
        }

        public static void TercerEjercicio()
        {
            const double IVA = 0.21;
            try
            {
                Console.WriteLine("Calculador de IVA.");
                Console.Write("\nIngrese el precio: $");
                double precio = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nEl precio + IVA es de: $" + (precio + (precio * IVA)));
            }
            catch
            {
                Console.WriteLine("\nUsted no ingresó un valor válido");
            }
            Console.ReadKey();
        }

        public static void CuartoEjercicio()
        {
            const double DESCUENTO = 0.09;
            try
            {
                Console.Write("\nIngrese un precio: $");
                double preciodto = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Aplicando descuento del 9% ... ");
                Console.WriteLine("\nEl precio, con el descuento del 9% es de: $" + (preciodto - (preciodto * DESCUENTO)));
            }
            catch
            {
                Console.WriteLine("\nUsted no ingresó un valor válido");
            }
            Console.ReadKey();
        }

        public static void QuintoEjercicio()
        {
            try
            {
                Console.Write("Ingrese cantidad de fruta que tiene actualmente: ");
                int frutas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nSi tiene que repartirla entre 3 chicos, a cada uno le tocan: " + (frutas / 3.0) + " frutas.");

            }
            catch
            {
                Console.WriteLine("\nUsted no ingresó un valor válido");
            }
            Console.ReadKey();
        }

        public static void SextoEjercicio()
        {
            try
            {
                Console.Write("POSITIVO O NEGATIVO? Introduzca un número: ");
                int posneg = Convert.ToInt32(Console.ReadLine());

                if (posneg < 0)
                {
                    Console.WriteLine("\n El numero " + posneg + " es: NEGATIVO");
                }
                else
                {
                    Console.WriteLine("\n El numero " + posneg + " es: POSITIVO");
                }
            }
            catch
            {
                Console.WriteLine("\nLo que usted ingresó, no es un valor válido.");
            }
            Console.ReadKey();

        }

        public static void SeptimoEjercicio()
        {
            try
            {
                Console.Write("PAR O IMPAR. Ingrese un número: ");
                int parimp = Convert.ToInt32(Console.ReadLine());

                if (parimp % 2 == 0)
                {
                    Console.WriteLine("\nEl número: " + parimp + " es: PAR");
                }
                else
                {
                    Console.WriteLine("\nEl número " + parimp + " es: IMPAR");
                }
            }
            catch
            {
                Console.WriteLine("\nLo que usted ingresó, no es un valor válido.");
            }
            Console.ReadKey();
        }

        public static void OctavoEjercicio()
        {

        }

    }
}