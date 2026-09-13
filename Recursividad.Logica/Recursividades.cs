using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Recursividad.Logica
{
    public class Recursividades
    {
        public int CalcularFactorial(int num)
        {
            //Caso base condición de salida

            if (num == 1)
            {
                return 1;
            }

            //Caso general
            return num = num * CalcularFactorial(num - 1);



        }
        public int Vocales(System.String cadena)
        {
            //Caso Base o salida
            if(cadena.Length == 0)
            {
                return 0;
            }
            char letra=char.ToLower(cadena[0]);
            int cont = 0;
            if (letra== 'a' || letra== 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                cont = 1;
            }


            //Caso general
            return cont = cont + Vocales(cadena.Substring(1));

        }

        public int SumaDigitos(int digito)
        {
            //Caso Base o salida
            
            if (digito < 10)
            {
                return digito;
            }
            //Caso general
            return digito = (digito % 10) + SumaDigitos(digito / 10);
        }

        public int SumarNumeros(int numero)
        {
            //Caso Base o salida
            if(numero==1)
            {
                return 1;
            }

            //Caso general
            return numero=numero + SumarNumeros(numero-1);
        }
    }
}
