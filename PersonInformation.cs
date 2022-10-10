using System;
using System.Collections.Generic;

namespace PhoneBookApp
{
    public class PersonInformation
    {
        public string name;
        public string surname;
        public string number;

        public PersonInformation(string name, string surname, string number)
        {
            this.name = name;
            this.surname = surname;
            this.number = number;
        }
    }
}