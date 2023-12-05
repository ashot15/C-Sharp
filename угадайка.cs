using System;
using System.Globalization;
using System.Linq;

namespace consoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введи свое имя:\t");
            string name = Console.ReadLine();
            link1:
            Console.Write("Попробуй угадать число:\t");
            string input = Console.ReadLine();
            if (input == "1")
                Console.WriteLine($"Молодец {name}");
            else
                Console.WriteLine("Ты не угадал, попробуй снова");
            if (input !="1") goto link1;












        }
        


    }


  



}










