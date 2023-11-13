using MtecDevs.ViewModels;

namespace MtecDevs.Services;

public interface IUsuarioService
{
    Task<UsuarioVM> GetUsuarioLogado();
}
