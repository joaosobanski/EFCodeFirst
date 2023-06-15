using System.Reflection.Metadata;
using Data;
using Domain;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Hello, World!");

        using (var db = new DbContextProduct())
        {
            var data = new Loja()
            {
                Descricao = "Test2",
                Nome = "s2",
            };
            db.Lojas.Add(data);


            db.Clientes.Add(new Cliente() { Nome = "teste" });
            db.SaveChanges();
        }
    }
}