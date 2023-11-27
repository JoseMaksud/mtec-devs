using System.ComponentModel.DataAnnotations;

namespace MtecDevs.ViewModels;

public class RegisterVM
{
    [Display(Name = "Nome de Usuário", Prompt = "Informe seu  Nome de Usuário")]
    [Required(ErrorMessage = "Por favor, informe seu  nome de usuário")]
    public string Nome { get; set; }

    [Display(Name = "Email", Prompt = "Informe seu Email")]
    [Required(ErrorMessage = "Por favor, informe seu email")]
    public string Email { get; set; }

    [Display(Name = "Data de Nascimento", Prompt = "Informe sua Data de Nascimento")]
    [Required(ErrorMessage = "Por favor, informe sua Data de Nascimento")]
    public DateTime DataNascimento { get; set; }

    [Display(Name = "Senha de Acesso", Prompt = "Informe sua Senha de Acesso")]
    [Required(ErrorMessage = "Por favor, informe sua senha de acesso")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    [Display(Name = "TipoDev", Prompt = "Informe seu tipo de dev")]
    [Required(ErrorMessage = "Por favor, informe seu tipo de dev")]

    public byte TipoDevId { get; set; }

    [Display(Name = "Foto", Prompt = "Informe sua Foto")]
    [Required(ErrorMessage = "Por favor, informe sua Foto")]
    public string Foto { get; set; }
}