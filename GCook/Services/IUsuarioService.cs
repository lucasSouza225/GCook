using Microsoft.AspNetCore.Identity;
using GCook.ViewModels;

namespace GCook.Services;

public interface IUsuarioService
{
    Task<SignInResult> LoginUsuario(LoginVM login);
    Task LogoutUsuario();
}
