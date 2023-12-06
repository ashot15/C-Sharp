using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            bool is64 = Environment.Is64BitOperatingSystem;
            int time_windows = Environment.TickCount ;
            var os = Environment.OSVersion;
            Console.WriteLine($"Текущая дата {DateTime.Now}");
            Console.WriteLine($"Операционная система: {os}");
            Console.WriteLine($"Количество потоков у процессора: {Environment.ProcessorCount}");
            Console.WriteLine($"Имя машины: {Environment.MachineName}");
            Console.WriteLine($"Версия: {Environment.Version}");
            Console.WriteLine($"Как давно работает Windows в днях : {time_windows / 86400}");

            
            {
                if (is64 == true)
                
                    Console.WriteLine($"64 Битная версия Windows : Да");






                 else if (is64 == false) {
                        Console.WriteLine($"64 Битная версия Windows : Нет");

                    }
                


            }







        }
    }
}
