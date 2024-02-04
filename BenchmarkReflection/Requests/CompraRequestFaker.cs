namespace BenchmarkReflection.Requests;

public static class CompraRequestFaker
{
    public static object RetornaCompraRequest(string? nome = null, string? email = null, string? idExterno = null)
    {
        var compraRequest = new CompraRequest
        {
            IdExterno = idExterno ?? "123",
            ValorTotal = 100,
            IdPdvExterno = "123",
            UrlCallback = "http://localhost:5000",
            TempoExpiracao = 100,
            Cliente = new CompraClienteRequest
            {
                Nome = nome ?? "João",
                Sobrenome = "Silva",
                Email = email ?? "email@email.com",
                NumeroTelefone = "123456789",
                Cpf = "123456789"
            }
        };

        return compraRequest;
    }

    public static CompraRequest RetornaCompraRequestClass(string? nome = null, string? email = null, string? idExterno = null)
    {
        var compraRequest = new CompraRequest
        {
            IdExterno = idExterno ?? "123",
            ValorTotal = 100,
            IdPdvExterno = "123",
            UrlCallback = "http://localhost:5000",
            TempoExpiracao = 100,
            Cliente = new CompraClienteRequest
            {
                Nome = nome ?? "João",
                Sobrenome = "Silva",
                Email = email ?? "email@email.com",
                NumeroTelefone = "123456789",
                Cpf = "123456789"
            }
        };

        return compraRequest;
    }
}
