using System;
using System.Collections.Generic;

namespace PhoneBookApp
{
    public class UpdateAction : IMenuAction
    {
        private readonly Database database;

        public UpdateAction(Database database)
        {
            this.database = database;
        }

        public void Run()
        {
            Console.WriteLine("Güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            
            string value = Console.ReadLine();
            PersonInformation person = database.searchContact(value);
            
            if(person != null)
            {
                Console.WriteLine("İsim girin");
                string name = Console.ReadLine();
                Console.WriteLine("Soyisim girin");
                string surname = Console.ReadLine();
                Console.WriteLine("Numara girin");
                string number = Console.ReadLine();

                person = new PersonInformation(name, surname, number);
                database.UpdateContact(person);
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. ");
                Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
                Console.WriteLine("* Yeniden denemek için              : (2)");
                int choise = Convert.ToInt32(Console.ReadLine());
                
                if(choise == 2);
                {
                    Run();
                }
            }
        }
    }
}