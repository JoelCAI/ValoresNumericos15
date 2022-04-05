using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresNumericos15
{
    public class Validador
    {
        public static void CompararStringConNumero(string str1)
        {
            int nuevoUno;

            
            if (int.TryParse(str1, out nuevoUno))
            {
                Console.WriteLine("\n La cadena" + " *" + str1 + "*" + " SI es un número y es: " + "*" + nuevoUno + "*");
            }
            else
            {

                Console.WriteLine("\n La cadena" + " *" + str1 + "*" + " NO es un número ");
                Console.WriteLine(" La función TryParse no convierte un caracter ");
            }
        }

        public static void MostrarString(string cadena)
        {

            Console.WriteLine("\n Usted escribio " + "*" + cadena + "*");

        }


        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }

        public static void Bienvenida()
        {
            Console.WriteLine("\n Bienvenido al Programa");
        }

        public static string ValidarString(string mensaje)
        {

            string opcion;
            do
            {

                Console.WriteLine(mensaje);
                opcion = Console.ReadLine();
                if (string.IsNullOrEmpty(opcion))
                {
                    Console.Clear();
                    Console.WriteLine(" \nEl valor ingresado no puede ser vacio.");
                    Console.WriteLine(" Por favor ingrese un valor.");
                }
            } while (string.IsNullOrEmpty(opcion));
            return opcion;

        }
    }
}
