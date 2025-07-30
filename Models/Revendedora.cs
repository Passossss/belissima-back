using Microsoft.AspNetCore.Mvc;

namespace belissima_back.Models;

public class Revendedora
{
    public int Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Estado { get; set; } = string.Empty;

    public string Cidade { get; set; } = string.Empty;

    public string Numero { get; set; } = string.Empty;
}