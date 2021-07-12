using System;

namespace MultiplosDe3
{  //En contrar los numeros multiplo de 3 que esten entre 1 al N
    class Program
    {
        static void Main(string[] args)
        {
            //Declara variables
            int limite = 100;
            //Que me permite hacer una actividad N veces?R Ciclo for

            for (int i=1;i<=limite;i++)
            {
                //Como hago para saber si un numero es multiplo de 3? 

                if(i % 3 == 0)
                {
                    //Como hago para imprimir el numero en pantalla?
                    //R://
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
