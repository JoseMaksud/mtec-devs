using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MtecDevs.Data;
using MtecDevs.ViewModels;

namespace MtecDevs.Services;

public class UsuarioService : IUsuarioService
{
    private readonly AppDbContext _contexto;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly HttpContextAccessor _httpContextAccessor;

    public UsuarioService(
        AppDbContext contexto, 
        SignInManager<IdentityUser> signInManager,
        UserManager<IdentityUser> userManager,
        HttpContextAccessor httpContextAccessor
    )
    {
        _contexto = contexto;
        _signInManager = signInManager;
        _userManager = userManager;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<UsuarioVM> GetUsuarioLogado()
    {
        if (_signInManager.IsSignedIn(_httpContextAccessor.HttpContext.User))
        {
            string userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userAccount = await _userManager.FindByIdAsync(userId);
            var usuario =  await _contexto.Usuarios.FindAsync(userId);
            var tipodev = await _contexto.TipoDevs.Where(t => t.Id == usuario.TipoDevId).SingleOrDefaultAsync();
            var perfis = string.Join(", ", await _userManager.GetRolesAsync(userAccount));
            UsuarioVM usuarioVM = new()
            {
                Id = userId,
                UserName = userAccount.UserName,
                Nome = usuario.Nome,
                Email = userAccount.Email,
                DataNascimento = usuario.DataNascimento,
                Foto = usuario.Foto,
                Perfil = perfis,
                TipoDev = tipodev.Nome
            };
            return usuarioVM;
        }
        return null;
    }
}
