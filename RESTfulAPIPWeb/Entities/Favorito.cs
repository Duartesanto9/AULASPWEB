namespace RESTfulAPIPWeb.Entities;

public class Favorito
{
    public int Id { get; set; }
    public bool EFavorito { get; set; }
    public int ProdutoId { get; set; }
    public Produto produto { get; set; }
    public int ClienteId { get; set; }
}
