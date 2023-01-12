using Desafio;
using Desafio.Screens.TagScreens;
using Microsoft.Data.SqlClient;

const string connectionString = "Server=localhost;Database=Blog;Trusted_Connection=True;Encrypt=False";
DataBase.Connection = new SqlConnection(connectionString);
DataBase.Connection.Open();

Load();


Console.ReadKey();
DataBase.Connection.Close();

static void Load()
{
    Console.Clear();
    Console.WriteLine("Meu blog");
    Console.WriteLine("-------------------");
    Console.WriteLine("Oque deseja fazer?");
    Console.WriteLine();
    Console.WriteLine("1 - Gestão de usuários");
    Console.WriteLine("2 - Gestão de perfil");
    Console.WriteLine("3 - Gestão de categoria");
    Console.WriteLine("4 - Gestão de tag");
    Console.WriteLine("5 - Vincular perfil/usuário");
    Console.WriteLine("6 - Vincular post/tag");
    Console.WriteLine("7 - Relatórios");
    Console.WriteLine();
    Console.WriteLine();

    var option = short.Parse(Console.ReadLine());

    switch (option)
    {
        /* case 1:
            ListTagScreen.Load();
            break;
        case 2:
            CreateTagScreen.Load();
            break;
        case 3:
            UpdateTagScreen.Load();
            break; */
        case 4:
            MenuTagScreen.Load();
            break;
        /* case 5:
            ListTagScreen.Load();
            break;
        case 6:
            CreateTagScreen.Load();
            break;
        case 7:
            UpdateTagScreen.Load();
            break; */

        default: Load(); break;
    }
}



