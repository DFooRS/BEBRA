using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEBRA
{
    class Program
    {
        static void Main(string[] args)
        {
            int status = 0;
            Console.WriteLine("Начата аннексия выбранного региона");
            while (status < 100)
            {
                Console.Write("Аннексия региона завершена на {0}", status);
                Console.WriteLine("процентов.");
                status += 10;
            }
            Console.ReadKey();
        }
    }
}
