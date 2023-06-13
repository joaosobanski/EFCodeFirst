using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain;

[Table("Loja")]
public class Loja
{
    public Loja()
    {
        Produtos = new List<Produto>();
    }

    [Key]
    public int Id { get; set; }
    [MaxLength(200)]
    [Required]
    public string Nome { get; set; }
    [MaxLength(2000)]
    [Required]
    public string Descricao { get; set; }

    public virtual List<Produto> Produtos { get; set; }

}

