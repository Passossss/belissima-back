using System.ComponentModel.DataAnnotations;

namespace belissima_back.Models;

public class Revendedora
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório.")]
    public string Nome { get; set; } = string.Empty;

    [EmailAddress(ErrorMessage = "O e-mail informado é inválido.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "O estado é obrigatório.")]
    [StringLength(2, ErrorMessage = "A sigla deve conter exatamente 2 caracteres.")]
    public string Estado { get; set; } = string.Empty;

    [Required(ErrorMessage = "A cidade é obrigatória.")]
    public string Cidade { get; set; } = string.Empty;

    [Required(ErrorMessage = "O número é obrigatório.")]
    [RegularExpression(@"^\(?\d{2}\)?\s?\d{4,5}-?\d{4}$", ErrorMessage = "Número de telefone inválido.")]
    public string Numero { get; set; } = string.Empty;
}