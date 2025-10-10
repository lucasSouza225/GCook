using System.ComponentModel.DataAnnotations;

namespace GCook.Models;
public class Ingrediente
{
    [Key]
    public int Id { get; set; }
    
    [StringLength(50)]
    [Required(ErrorMessage = "O Nome é obrigatório")]
    public string Nome { get; set; }
    
}