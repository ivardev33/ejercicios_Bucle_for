using System;



/*
class Program
{
    static void Main()
    {
        
        //Imprimir números del 1 al 10

        for (int i = 1; i<=10; i++) 
        {
            Console.WriteLine(i);
        
        }

    }
}
*/


class Program
{
    static void Main()
    {
        int suma=0;

        for (int i = 0; i < 10; i++)
        {
            suma += i;

            Console.WriteLine($"La suma de los numeros es : {suma}");
        }
    }
}
