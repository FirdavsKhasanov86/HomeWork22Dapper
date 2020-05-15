using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork22_Dapper
{
    class Program
    {
        static void Main(string[] args)

        {
            //Insert
            POOP.Add(new AlifShop { Company = "HP", Model = "HP22" });

            //Select
            List<AlifShop> list = POOP.Read<AlifShop>();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Id},{item.Company},{item.Model}");
            }

            //Update
            POOP.Update(new AlifShop { Company = "HP", Model = "HP25", Id = 13 });

            //Delete
            POOP.Delete(new AlifShop { Id = 13 });

            Console.ReadKey();
        }
    }
}
