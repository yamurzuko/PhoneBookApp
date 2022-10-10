using System;
using System.Collections.Generic;

namespace PhoneBookApp
{
    public class InsertAction : IMenuAction
    {
        private readonly Database database;

        public InsertAction(Database database)
        {
            this.database = database;
        }

        public void Run()
        {
            Console.WriteLine("Lütfen İsim Giriniz : ");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen Soyisim Giriniz : ");
            string surname = Console.ReadLine();
            Console.WriteLine("Lütfen Numara Giriniz : ");
            string number = Console.ReadLine();

            PersonInformation person = new PersonInformation(name, surname, number);
            database.addContact(person);

            Console.WriteLine("Numara Kaydedilmiştir.");
        }
        
    }
}