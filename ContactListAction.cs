using System;
using System.Collections.Generic;

namespace PhoneBookApp
{
    public class ContactListAction : IMenuAction
    {
        private readonly Database database;

        public ContactListAction(Database database)
        {
            this.database = database;
        }
        
        public void Run()
        {
            List<PersonInformation> contacts = database.PhoneList();

            Console.WriteLine(" Telefon Rehberi ");
            Console.WriteLine("**********************************************");
        
            foreach (var item in contacts)
            {
                Console.WriteLine("İsim : {0}", item.name);
                Console.WriteLine("Soyisim : {0}", item.surname);
                Console.WriteLine("Telefon : {0}", item.number);
                Console.WriteLine("--");
            }
        }
    }
}