using System;
using System.Collections.Generic;

namespace PhoneBookApp
{
    public class DeleteAction : IMenuAction
    {
        private readonly Database database;

        public DeleteAction(Database database)
        {
            this.database = database;
        }

        public void Run()
        {
            Console.WriteLine("Silmek İstediğiniz Kişinin Adını ya da Soyadını Giriniz : ");
            string str = Console.ReadLine();
            bool value = database.DeleteContact(str);

            if(!value)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi Sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");

                int choise = Convert.ToInt32(Console.ReadLine());
                if(choise == 2)
                {
                    Run();
                }
            }
            Console.WriteLine("Kişi silindi.");
        }
    }
}