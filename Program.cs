using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

const string connectionString = "Server=localhost;Database=Blog;Trusted_Connection=True;Encrypt=False";
var connection = new SqlConnection(connectionString);
connection.Open();

//CreateRole(connection);
ReadUsersWithRoles(connection);
//ReadRoles(connection);
//ReadTags(connection);
//CreateUser(connection);

connection.Close();


static void ReadUsersWithRoles(SqlConnection connection)
{
    var repository = new UserRepository(connection);
    var items = repository.GetWithRoles();

    foreach (var item in items)
    {
        Console.WriteLine(item.Name);
        foreach ( var role in item.Roles)
        {
            Console.WriteLine($" - {role.Name}");
        }
    }
}
static void CreateUser(SqlConnection connection)
{
    var user = new User()
    {
        Email = "gabriela@roas.com",
        Bio = "Minha esposa",
        Image = "Imagem",
        Name = "Gabriela Robonato",
        PasswordHash = "Password",
        Slug = "esposa"
    };
    var repository = new Repository<User>(connection);
    repository.Create(user);
    
}

static void CreateRole(SqlConnection connection)
{
    var role = new Role()
    {
        Name = "Suporte",
        Slug = "Support"
    };
    var repository = new Repository<Role>(connection);
    repository.Create(role);
}

static void ReadRoles(SqlConnection connection)
{
    var repository = new Repository<Role>(connection);
    var items = repository.Get();

    foreach (var item in items)
    {
        Console.WriteLine(item.Name);
    }
}

static void ReadTags(SqlConnection connection)
{
    var repository = new Repository<Tag>(connection);
    var items = repository.Get();

    foreach (var item in items)
    {
        Console.WriteLine(item.Name);
    }
}

