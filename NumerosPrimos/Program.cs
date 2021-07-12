using System;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1 variables
             2 arreglo
             3 ciclos (while,for)
             4 condicionales if else if else
             */

            /*
             1 declara variables
             2 hace el procedimiento donde procesa las variables
             3 obtiene un resultado
             */

            /*Signos arimeticos
             * +,-,/*,%,
             * 3 + 2, 3 % 2, 3/2
             * Signos logicos <,>, <=, >=,== (5 < 8) (4 > 2) (2 <= 3) (6 > = 2) (7 == 7)
             */
            //Mostrar los números primos del 1 al 100
            //--Establecer la limitación
            //Hacer una secuencia de numeros 1 al 100 con la condicional que sean numeros primos
            // que si divido el numero entre sus primos anteriores y esto da una division inexacta es primo
            // 2,3,5,7,11
            int limite = 100;
            int[] primosmenores = new int[] { 2, 3, 5, 7, 11 };
            bool IsPrimo = true;
            for (int i = 1; i <= limite; i++)
            {
                IsPrimo = true;
                if (i != 1)
                {
                    for (int j = primosmenores.Length-1; j >= 0; j--)
                    {
                        if(i == primosmenores[j])
                        {
                            IsPrimo = true;
                            break;
                        }
                        if (i % primosmenores[j] == 0)
                        {
                            IsPrimo = false;
                            break;

                        }

                    }
                    if (IsPrimo)
                    {
                        Console.WriteLine(i);
                    }
                }




            }

            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
