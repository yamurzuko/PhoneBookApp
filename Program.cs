using System;

namespace PhoneBookApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            Dictionary<int, IMenuAction> menuActions = new Dictionary<int, IMenuAction>();
            menuActions.Add(1, new InsertAction(database));
            menuActions.Add(2, new DeleteAction(database));
            menuActions.Add(3, new UpdateAction(database));
            menuActions.Add(4, new ContactListAction(database));
            menuActions.Add(5, new SearchAction(database));

            while (true)
            {
                Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçin.");
                Console.WriteLine("***************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncellemek");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                int choise;

                if(int.TryParse(Console.ReadLine(), out choise))
                {
                    if(menuActions.ContainsKey(choise))
                    {
                        menuActions[choise].Run();
                    }
                }
            }
        }
    }
}