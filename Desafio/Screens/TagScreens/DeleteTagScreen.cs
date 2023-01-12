using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Desafio.Screens.TagScreens
{
    public class DeleteTagScreen
    {
         public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir uma tag");
            Console.WriteLine("-----------------");
            Console.WriteLine("Qual Id da tag que deseja excluir: ");
            var id = int.Parse(Console.ReadLine());

            Delete(id);
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(DataBase.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag deletada com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível deletar a tag");
                Console.WriteLine(ex.Message);
            }

        }
    }
}