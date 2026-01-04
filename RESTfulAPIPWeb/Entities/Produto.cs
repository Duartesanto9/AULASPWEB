using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RESTfulAPIPWeb.Entities;

public class Produto
{
    public int Id { get; set; } // Com "Id" a base de dados sabe que isto é a chave principal

    [StringLength(100)] // Tamanho máximo da variável "Nome"
    [Required] // "Nome" é obrigatório
    public string? Nome { get; set; }

    [StringLength(200)] // Tamanho máximo da variável "Detalhe"
    [Required] // "Detalhe" é obrigatório
    public string? Detalhe { get; set; }

    [StringLength(200)] // Tamanho máximo da variável "UrlImagem"
    public string? UrlImagem { get; set; }
    public byte[]? Imagem { get; set; }

    [Required] // "Preco" é obrigatório
    [Column(TypeName = "decimal(10,2)")] // Define o tipo decimal com precisão 10 e escala de 2
    public decimal Preco { get; set; }
    public bool Promocao { get; set; }
    public bool MaisVendido { get; set; }

    [Column(TypeName = "decimal(10,2)")] // Define o tipo decimal com precisão 10 e escala de 2
    public decimal EmStock { get; set; }
    public bool Disponivel { get; set; }
    public string? Origem { get; set; }
    public int CategoriaId { get; set; } // Chave estrangeira
    public Categoria categoria { get; set; }

    [JsonIgnore] // Variavel não é serializada/deserializada
    public int? ModoEntregaId { get; set; }
    public ModoEntrega modoEntrega { get; set; }

    [NotMapped] // Diz à entityCore para não mapear esta propriedade na base de dados
    public IFormFile? ImageFile { get; set; }
}
