using System.ComponentModel.DataAnnotations;
namespace GCook.ViewModels;

public class LoginVM
{
    [Display(Name = "Email ou Nome de Usuário", Prompt = "Informe o seu email ou nome de usuário")]
    [Required(ErrorMessage = "O Email ou Nome de Usuário obrigatório")]
    public string Email { get; set; }

    [Display(Name = "Senha de Acesso", Prompt = "*****")]
    [Required(ErrorMessage = "A senha é obrigatória")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    [Display(Name = "Manter Conectado?")]
    public bool Lembrar { get; set; } = false;

    public string UrlRetorno { get; set; }
    
}
