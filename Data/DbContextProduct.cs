using System;
using System.Data.Entity;
using Domain;

namespace Data;

public class DbContextProduct : DbContext
{
	public DbContextProduct() : base("ProductDb")
	{
		Database.SetInitializer(new CreateDatabaseIfNotExists<DbContextProduct>());
		Database.Initialize(false);
	}

    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Loja> Lojas { get; set; }

}

