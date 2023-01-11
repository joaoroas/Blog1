using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

const string connectionString = "Server=localhost;Database=Blog;Trusted_Connection=True;Encrypt=False";
var connection = new SqlConnection(connectionString);
connection.Open();

ReadUsers(connection);
ReadRoles(connection);


connection.Close();


static void ReadUsers(SqlConnection connection)
{
    var repository = new UserRepository(connection);
    var users = repository.Get();

    foreach (var user in users)
    {
        Console.WriteLine(user.Name);
    }
}

static void ReadRoles(SqlConnection connection)
{
    var repository = new RoleRepository(connection);
    var roles = repository.Get();

    foreach (var role in roles)
    {
        Console.WriteLine(role.Name);
    }
}

