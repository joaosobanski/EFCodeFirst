using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain;

[Table("Produto")]
public class Produto
{
    [Key]
    public int Id { get; set; }
    [MaxLength(200)]
    [Required]
    public string Nome { get; set; }
    [MaxLength(2000)]
    [Required]
    public string Descricao { get; set; }
    public decimal Valor { get; set; }

    [ForeignKey("Loja")]
    public int LojaId { get; set; }

    public virtual Loja Loja { get; set; }
}

