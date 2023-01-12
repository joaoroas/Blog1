using Blog.Models;
using Blog.Repositories;

namespace Desafio.Screens.TagScreens
{
    public class ListTagScreen
    {
        internal static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de tags");
            Console.WriteLine("-----------------");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Tag>(DataBase.Connection);
            var tags = repository.Get();
            foreach (var item in tags)
            {
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
            }
        }
    }
}