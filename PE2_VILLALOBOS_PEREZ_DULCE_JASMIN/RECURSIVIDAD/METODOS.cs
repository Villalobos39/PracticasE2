using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECURSIVIDAD
{
    class METODOS
    {
        public int[] Numeros(int digito)
        {
            int[] sucesion = new int[digito]; // EL ARREGLO ALMACENA LA CAPTURA DE DATOS INGRESADA POR EL USUARIO
            for (int contador = 0; contador < digito; contador++)
            {
                Console.Write("\n\tIGRESE {0} : ", contador + 1);
                sucesion[contador] = Convert.ToInt32(Console.ReadLine());
            }
            return sucesion; // REGRESA LA CAPTURA DE MEMORIA 
        }

        public int Mayor(int contador, int mayor, int[] sucecion)
        {
            if (contador != sucecion.Length) // EL CONTADOR SE INICIA EN CERO
            { // SI EL NUMERO DE ELEMENTOS DEL ARREGLO ES DIFERENTE A CERO (IF)
                if (sucecion[contador] > mayor) //SI UN ELEMENTO DEL ARREGLO ES MAYOR (IF)
                { 
                    mayor = Mayor(contador + 1, sucecion[contador], sucecion); // RECURSIVIDAD 
                }
                else // SI NO EL MAYOR ES IGUAL AL PRIMER ELEMENTO ENCONTRADO
                {
                    mayor = Mayor(contador + 1, mayor, sucecion); //RECURSIVIDAD 
                }
            }
            return mayor; // REGRESA EN MAYOR DEPUES DE EVALUARLOS 
        }

        public int Minimo(int contador, int minimo, int[] sucecion)
        {
            if (contador != sucecion.Length) //LOS ELEMENTOS DEL ARREGLO DEBEN SER DIFERENTES A CERO
            {
                if (sucecion[contador] < minimo) //EL ARREGLO SE EVALUARIA DIGITO POR DIJITO 
                {
                    minimo = Minimo(contador + 1, sucecion[contador], sucecion); //RECURSIVIDAD
                }
                else // EN CASO DE QUE NO CUMPLA LA CONDICION SE REFGRESARA EL ULTIMO VALRO QUE SE IDENTIFICO COMO MENOR
                {
                    minimo = Minimo(contador + 1, minimo, sucecion); //RECURSIVIDAD
                }
            }
            return minimo; // REGRESA EN MENOR DEPUES DE EVALUARLOS 
        }
        public void invertir(int digito, params int[] sucecion)
        {
            int numero = 0; // REPRESENTA TODOS LOS DIGITOS ACTUALES DE LA SUCESION 
            if (digito > 0) // SI EL DIGITO ES MAYOR A CERO
            {
                numero = sucecion[digito - 1]; // CAMPO DE POSICION EN RETROCESO  
                Console.Write(" {0} ||", numero );
                invertir(digito - 1, sucecion); // CON AYUDA DE LA PALABRA CLAVE ( params (Referencia C#))
            }
        }
    }
}