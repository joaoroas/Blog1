using Blog.Models;
using Blog.Repositories;

namespace Desafio.Screens.TagScreens
{
    public class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar tag");
            Console.WriteLine("-----------------");
            Console.WriteLine("Id: ");
            var id = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Update(id, name, slug);
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Update(int id, string name, string slug)
        {
            try
            {
                var repository = new Repository<Tag>(DataBase.Connection);
                var tag = repository.Get(id);
                tag.Name = name;
                tag.Slug = slug;
                repository.Update(tag);
                Console.WriteLine("Tag atualizada com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a tag");
                Console.WriteLine(ex.Message);
            }

        }
    }
}