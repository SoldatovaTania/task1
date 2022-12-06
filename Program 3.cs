//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

using System;
using System.Globalization;
 
namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
             
                int Value = Convert.ToInt32(Console.Read());
                if (Value % 2 == 0) Console.WriteLine("Четное");
                else Console.WriteLine("Нечетное");

        }
    }
}