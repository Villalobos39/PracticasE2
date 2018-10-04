using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayor_menor
{
    class clasemaymenor
    {
        public int[] Numeros(int digito)
        {
            int[] sucesion = new int[digito];
            for (int contador = 0; contador < digito; contador++)
            {
                Console.Write("\n\tIGRESE {0} : ", contador + 1);
                sucesion[contador] = Convert.ToInt32(Console.ReadLine());
            }
            return sucesion;
        }

        public int Mayor(int contador, int mayor, int[] sucecion)
        {
            if (contador != sucecion.Length)
            {
                if (sucecion[contador] > mayor)
                {
                    mayor = Mayor(contador + 1, sucecion[contador], sucecion);
                }
                else
                {
                    mayor = Mayor(contador + 1, mayor, sucecion);
                }
            }
            return mayor;
        }

        public int Minimo(int contador, int minimo, int[] sucecion)
        {

            if (contador != sucecion.Length)
            {
                if (sucecion[contador] < minimo)
                {
                    minimo = Minimo(contador + 1, sucecion[contador], sucecion);
                }
                else
                {
                    minimo = Minimo(contador + 1, minimo, sucecion);
                }
            }
            return minimo;
        }
        public void invertir(int digito, params int[] sucecion)
        {
            int numero = 0;
            if (digito > 0)
            {
                numero = sucecion[digito - 1];
                Console.Write(" {0} ||", numero );
                invertir(digito - 1, sucecion);
            }
        }
    }
}
