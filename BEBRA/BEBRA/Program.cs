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
           
            string anneksname = "Name";
            int id = 5;
            while(id != Crimea.id && id != DNR.id && id != LNR.id && id != Zobl.id && id != Hobl.id)
            {
                Console.WriteLine("Выберите регион, который хотите аннексировать:\n");
                Console.WriteLine("| Крым(0) | ДНР (1) | ЛНР(2) | Запорожье(3) | Херсонесс(4) |\n");
                Console.WriteLine("*Примечание: введите цифру, обозначающую регион\n");
                id = Convert.ToInt32(Console.ReadLine());

                if (id == Crimea.id)
                    anneksname = Crimea.rname;
                else if (id == DNR.id)
                    anneksname = DNR.rname;
                else if (id == LNR.id)
                    anneksname = LNR.rname;
                else if (id == Zobl.id)
                    anneksname = Zobl.rname;
                else if (id == Hobl.id)
                    anneksname = Hobl.rname;
                else
                    Console.WriteLine("Ошибка.Введите корректный номер региона.\n");
            }

            int status = 0;
            Console.WriteLine("Начата аннексия региона {0}", anneksname);
            while (status < 100)
            {
                Console.Write("Аннексия региона завершена на {0}", status);
                Console.WriteLine("процентов.");
                status += 10;
            }
            Console.Write("Аннексия региона {0}", anneksname);
            Console.Write(" завершена успешно.");
            Console.ReadKey();
        }
    }
}
