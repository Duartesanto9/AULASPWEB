using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using RESTfulAPIPWeb.Entities;

namespace RESTfulAPIPWeb.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<ModoEntrega> ModosEntrega { get; set; }
    //public DbSet<Favorito> Favoritos { get; set; }
    //public DbSet<ItemCarrinhoCompra> ItensCarrinhoCompra { get; set; }
}
