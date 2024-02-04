using BenchmarkReflection.Attributes;
using System.Text.Json.Serialization;

namespace BenchmarkReflection.Requests;

public class CompraClienteRequest
{

    public string Nome { get; set; }

    public string Sobrenome { get; set; }
    [SensitiveData]
    public string Email { get; set; }
    [JsonPropertyName("telefone-celular")]
    [SensitiveData]
    public string NumeroTelefone { get; set; }
    [SensitiveData]
    public string Cpf { get; set; }
}
