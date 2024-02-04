using BenchmarkReflection.Attributes;
using System.Text.Json.Serialization;

namespace BenchmarkReflection.Requests;

public class CompraRequest
{ 
    [JsonPropertyName("id-externo")]
    public string IdExterno { get; set; }

    [JsonPropertyName("valor-total")]
    public decimal ValorTotal { get; set; }

    [JsonPropertyName("id-pdv-externo")]
    public string IdPdvExterno { get; set; }

    [JsonPropertyName("callback-url")]
    public string UrlCallback { get; set; }

    [JsonPropertyName("tempo-expiracao")]
    public double? TempoExpiracao { get; set; }

    public CompraClienteRequest Cliente { get; set; }
}
