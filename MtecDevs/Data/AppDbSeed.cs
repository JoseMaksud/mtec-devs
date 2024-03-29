using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MtecDevs.Models;


namespace MtecDevs.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder) 
    {
        #region Popular os dados de TipoDev
        List<TipoDev> tipoDevs = new() {
            new TipoDev() {
                Id = 1,
                Nome = "FullStack"
            },
            new TipoDev() {
                Id = 2,
                Nome = "FrontEnd"
            },
            new TipoDev() {
                Id = 3,
                Nome = "BackEnd"
            },
            new TipoDev() {
                Id = 4,
                Nome = "Design"
            },
            new TipoDev() {
                Id = 5,
                Nome = "Jogos"
            }
        };
        builder.Entity<TipoDev>().HasData(tipoDevs);
        #endregion

        #region Popular dos dados Perfis de Usuário
        List<IdentityRole> roles = new() {
            new IdentityRole() {
                Id = Guid.NewGuid().ToString(),
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole() {
                Id = Guid.NewGuid().ToString(),
                Name = "Moderador",
                NormalizedName = "MODERADOR"
            },
            new IdentityRole() {
                Id = Guid.NewGuid().ToString(),
                Name = "Usuário",
                NormalizedName = "USUÁRIO"
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Popular os dados do Usuários
        // Cria a lista de contas
        List<IdentityUser> users = new() {
            new IdentityUser() {
                Id = Guid.NewGuid().ToString(),
                Email = "jose.santos1242@etec.sp.gov.br",
                NormalizedEmail = "JOSE.SANTOS1242@ETEC.SP.GOV.BR",
                UserName = "JoseMaksud",
                NormalizedUserName = "JOSEMAKSUD",
                LockoutEnabled = false,
                PhoneNumber = "14912345678",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true
            }
        };
        // Criptografar as senhas
        foreach (var user in users) {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "@Etec123");
        }
        // Adicina a conta no banco
        builder.Entity<IdentityUser>().HasData(users);

        // Cria a conta pessoal do usuário
        List<Usuario> usuarios = new() {
            new Usuario() {
                UserId = users[0].Id,
                Nome = "José Francisco Dos Santos Neto",
                DataNascimento = DateTime.Parse("30/12/2006"),
                TipoDevId = 1,
                Foto = "/img/usuarios/avatar.png"
            }
        };
        builder.Entity<Usuario>().HasData(usuarios);

        // Associar o usuário ao tipo de perfil
        List<IdentityUserRole<string>> userRoles = new() {
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[0].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
}
