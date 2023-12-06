using System;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;

namespace consoleApp2
{
    class Program
    {
       public static void Main()
        {
            double a;
            double b;

            Console.Write("Введите число:\t");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите знак для осуществления операции: ");
            String oper = Console.ReadLine();
            if (oper == "degree" || oper == "power" || oper == "возвести в степень" || oper == "возвести" || oper == "**")
            {
                Console.WriteLine($"Ответ :\t {a * a}"); Environment.Exit(0);
            }
            
            Console.Write("Введи второе число: ");
            b = Convert.ToDouble(Console.ReadLine());

            if (oper == "+" || oper == "plus" || oper == "плюс" || oper == "плюсик")
            {
                Console.WriteLine($"Ответ :\t {a + b}");
            }

            else if (oper == "-" || oper == "minus" || oper == "минус")
            {
                Console.WriteLine($"Ответ :\t {a - b}");

            }

            else if (oper == "*" || oper == "умножить" || oper == "умножить на" || oper == "multiply")
            {
                Console.WriteLine($"Ответ :\t {a * b}");

            }

            else if (oper == "/" || oper == "делить" || oper == "делить на" || oper == "division")
            {
                Console.WriteLine($"Ответ :\t {a / b}");

            }

        }





        }
    }












        


    


  














