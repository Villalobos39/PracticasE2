using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayor_menor
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                Console.Write("\n\t>>> PRATICA EVALUATIVA <<<");
                // 1. EL NUMERO MAXIMO DE LA SUCESION 
                // 2. EL VALOR MINIMO DE LA SUCESIO 
                // 3. INVERTIR LA SUCESION
                try
                {
                    clasemaymenor CLASE = new clasemaymenor();

                    Console.Write("\n\tINGRESE LA CATIDAD DE NUMERO DE LA SUCESION: ");
                    int numero = int.Parse(Console.ReadLine());
                    int[] sucecion = new int[numero];
                    sucecion = CLASE.Numeros(numero);

                    Console.Write("\n\tEL MINIMO: " + CLASE.Minimo(0, sucecion[0], sucecion));
                    Console.Write("\n\tEL MAXIMO: " + CLASE.Mayor(0, sucecion[0], sucecion));
                    Console.Write("\n\tSUCESION INVERTIDA : ");
                    CLASE.invertir(numero, sucecion);

                    Console.ReadKey();
                }
                catch (Exception) { Console.Write("\n\t\aERROR DE COMPILACION"); }
                Console.Write("\n\t\a>>> REINICIAR<<<"); opcion = Console.ReadLine();
            }
            while (opcion == "si" || opcion == "SI");
            Console.ReadKey();
          }
        }
    }




