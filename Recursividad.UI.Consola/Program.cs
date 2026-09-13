using Recursividad.Logica;

Console.WriteLine("Ejemplos de recursividad");
//Console.WriteLine("\n\nFactorial");

Recursividades oRecursividades = new Recursividades();

//int resultadoFactorial = oRecursividades.CalcularFactorial(5);
//Console.WriteLine("El resultado de 5! es: " + resultadoFactorial);

Console.WriteLine("\n\nVocales");
int resultadoVocales = oRecursividades.Vocales("Wakanda por siempre");
Console.WriteLine("El numero de vocales en Wakanda por siempre es de: " + resultadoVocales);

Console.WriteLine("\n\nSuma de digitos");
int[] numeros = {123, 456, 209, 789, 9999 };
int mayorNum = 0;
int mayorSuma = -1;
for (int i = 0; i < numeros.Length; i++)
{
    int numero = numeros[i];
    int suma = oRecursividades.SumaDigitos(numero);
    if (suma > mayorSuma)
    {
        mayorSuma = suma;
        mayorNum = numero;
    }
}
Console.WriteLine("El numero con la suma mayor es: "+ mayorNum);
Console.WriteLine("La suma de los digitos es de: " + mayorSuma);


Console.WriteLine("\n\nSuma de Positivos");
int resultadoSuma = oRecursividades.SumarNumeros(6);
Console.WriteLine("El resultado de la suma de los primeros 6 numeros positivos es de: " + resultadoSuma);