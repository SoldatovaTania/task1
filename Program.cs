//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

using System;

namespace Sem_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string Value_1 = Console.ReadLine();
            int parsedValue1 = int.Parse(Value_1);

            string Value_2 = Console.ReadLine();
            int parsedValue2 = int.Parse(Value_2);

            if (parsedValue1 > parsedValue2)
            {
                Console.WriteLine ("Первое число больше второго");
            }
            else 
            {
                 Console.WriteLine ("Второе число больше первого"); 
            }
           
        }
    }
}
