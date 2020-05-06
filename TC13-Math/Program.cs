using System;

namespace TC13_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            // raiz cuadrada de un numero introducido
            Math.Sqrt(1);
            double res,num=Convert.ToInt32(Console.ReadLine());
            res = Math.Sqrt(num);
            System.Console.WriteLine(res);

            // eleva un numero introducido a otro numero introducido
            Math.Pow(1, 4);
            System.Console.WriteLine("que numero quieres elevar");
            double res2,num2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("cuanto lo quieres elevar");
            res2 = Math.Pow(num2,Convert.ToInt32(Console.ReadLine()));
            System.Console.WriteLine(num2);
            System.Console.WriteLine(res2);

            //obtener el signo de un numero
            System.Console.WriteLine("escrive un numero positivo o negativo");
            int num8 = Convert.ToInt32(Console.ReadLine());
            if (num8 < 0 )
            {
                System.Console.WriteLine("negativo");
            }
            else
            {
                System.Console.WriteLine("positivo");
            }

            //comparacion de numeros
            System.Console.WriteLine("escrive dos numeros a comparar");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            int res3 = Math.Max(num3, num4);
            System.Console.WriteLine(res3);

            //comparacion de dos numeros ignorando el signo
            //  no se que es ni como usarlo: System.CLSCompliant(false);
            System.Console.WriteLine("escrive dos numeros a comparar");
            int num5 = Convert.ToInt32(Console.ReadLine());//solo sirve con positivos
            int num6 = Convert.ToInt32(Console.ReadLine());
            int res4 = Math.Max(num5, num6);
            System.Console.WriteLine(res4);

            //quita los de cimales
            decimal num7 = 3.3M;

            decimal res5 = Math.Truncate(num7);
            System.Console.WriteLine(res5);

            //redondea
            decimal res6 = Math.Round(8.55M);
            System.Console.WriteLine(res6);
        }
    }
}
