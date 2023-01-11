using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

const string connectionString = "Server=localhost;Database=Blog;Trusted_Connection=True;Encrypt=False";
var connection = new SqlConnection(connectionString);
connection.Open();

ReadUsers(connection);
ReadRoles(connection);
ReadTags(connection);


connection.Close();


static void ReadUsers(SqlConnection connection)
{
    var repository = new Repository<User>(connection);
    var items = repository.Get();

    foreach (var item in items)
    {
        Console.WriteLine(item.Name);
    }
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

