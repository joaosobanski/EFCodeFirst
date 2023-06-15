using System;
using System.Data.Entity;
using System.Reflection.Emit;
using Domain;

namespace Data;

public class DbContextProduct : DbContext
{
    public DbContextProduct() : base("Data Source=localhost,1433;Initial Catalog=ProductDB;User ID=sa;Password=P@ssw0rd;")
    {

    }

    // DbSet properties and other configuration...
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        // Model configuration...
        ConfiguraCliente(modelBuilder);
    }


    private void ConfiguraCliente(DbModelBuilder construtorDeModelos)
    {
        var cliente = construtorDeModelos.Entity<Cliente>();
        cliente.ToTable("Cliente");
        cliente.HasKey(c => c.Id);
        cliente.Property(c => c.Id).HasColumnName("id").IsRequired();
        cliente.Property(c => c.Nome).HasColumnName("nome").IsRequired().HasMaxLength(200);

    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Loja> Lojas { get; set; }

}


