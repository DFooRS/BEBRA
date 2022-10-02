using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEBRA
{
    class Program
    {
        class Region
        {
            public string rname;
            public int id;
        }
        static void Main(string[] args)
        {
            Region Crimea;
            Crimea = new Region();
            Crimea.rname = "Крым";
            Crimea.id = 0;

            Region DNR;
            DNR = new Region();
            DNR.rname = "ДНР";
            DNR.id = 1;

            Region LNR;
            LNR = new Region();
            LNR.rname = "ЛНР";
            LNR.id = 2;
            
            Region Zobl;
            Zobl = new Region();
            Zobl.rname = "Запорожская область";
            Zobl.id = 3;

            Region Hobl;
            Hobl = new Region();
            Hobl.rname = "Херсонская область";
            Hobl.id = 4;

            
            Console.WriteLine("Выберите регион, который хотите аннексировать:\n");
            Console.WriteLine("| Крым(0) | ДНР (1) | ЛНР(2) | Запорожье(3) | Херсонесс(4) |\n");
            Console.WriteLine("*Примечание: введите цифру, обозначающую регион\n");
            int id = Convert.ToInt32(Console.ReadLine());


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
