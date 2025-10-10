using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.SignalR.Protocol;

namespace GCook.Models;

public class Receita
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Categoria")]
    [Required(ErrorMessage = "A categoria é obrigatória")]
    public int CategoriaId { get; set; }
    [ForeignKey("CategoriaId")]
    [Display(Name = "Categoria")]
    public Categoria Categoria { get; set; }

    [StringLength(100)]
    [Required(ErrorMessage = "O Nome é obrigatório")]
    public string Nome { get; set; }

    [StringLength(1000)]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; }

    [StringLength(30)]
    [Display(Name = "Tempo de Preparo")]
    public string TempoPreparo { get; set; }
    
    public int Rendimento { get; set; }

    public Dificuldade Dificuldade { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }

    [StringLength(8000)]
    [Display(Name = "Preparo")]
    [Required(ErrorMessage = "O Modo de Preparo é obrigatório")]
    public string Preparo { get; set;}
};
