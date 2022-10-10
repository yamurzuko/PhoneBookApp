using System;
using System.Collections.Generic;

namespace PhoneBookApp
{
    public class SearchAction : IMenuAction
    {
        private readonly Database database;

        public SearchAction(Database database)
        {
            this.database = database;
        }
        
        public void Run()
        {
            List<PersonInformation> contacts = database.PhoneList();

            Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            int choise = Convert.ToInt32(Console.ReadLine());
                
            if(choise == 1)
            {
                string person = Console.ReadLine();

                foreach (var item in contacts)
                {
                    if(person == item.name || person == item.surname)
                    {
                        Console.WriteLine("Arama Sonucu : ");
                        Console.WriteLine("*******************");
                        Console.WriteLine("İsim : {0}", item.name);
                        Console.WriteLine("Soyisim : {0}", item.surname);
                        Console.WriteLine("Telefon : {0}", item.number);
                        Console.WriteLine("--");
                    }
                }
            }
            else if(choise == 2)
            {
                string person = Console.ReadLine();

                foreach (var item in contacts)
                {
                    if(person == item.number)
                    {
                        Console.WriteLine("Arama Sonucu : ");
                        Console.WriteLine("*******************");
                        Console.WriteLine("İsim : {0}", item.name);
                        Console.WriteLine("Soyisim : {0}", item.surname);
                        Console.WriteLine("Telefon : {0}", item.number);
                        Console.WriteLine("--");
                    }
                }
            }
            else
            {
                Run();
            }
        }
    }
}