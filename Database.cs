using System;
using System.Collections.Generic;

namespace PhoneBookApp
{
    public class Database
    {
        private List<PersonInformation> _phoneList;

        public Database()
        {
            _phoneList = new List<PersonInformation>()
            {
                new PersonInformation("Uğur", "Yağmur", "8934340349304"),
                new PersonInformation("Ahmet", "Kaplan", "2384838483944"),
                new PersonInformation("Ayşe", "Sürer", "9837429348923"),
                new PersonInformation("Volkan", "Tutar", "6473839292929"),
                new PersonInformation("Tuba", "Kapar", "3784239102939")
            };
        }

        public void addContact(PersonInformation person)
        {
            _phoneList.Add(person);
        }

        public bool DeleteContact(string information)
        {
            PersonInformation foundedPerson = null;

            foreach (var item in _phoneList)
            {
                if(information == item.name || information == item.surname)
                {
                    foundedPerson = item;
                    break;
                }
            }
            if(foundedPerson != null)
            {
                _phoneList.Remove(foundedPerson);
                return true;
            }
            return false;
        }
        public bool UpdateContact(PersonInformation person)
        {
            for (int i = 0; i < _phoneList.Count; i++)
            {
                if(person.name == _phoneList[i].name || person.surname == _phoneList[i].surname)
                {
                    _phoneList[i] =  person;
                    return true;
                }
            }
            return false;
        }
        public List<PersonInformation> PhoneList()
        {
            return _phoneList;
        }
        public PersonInformation searchContact(string information)
        {
            foreach (var item in _phoneList)
            {
                if(information == item.name || information == item.surname || information == item.number)
                {
                    return item;
                }
            }
            return null;
        }


    }
}