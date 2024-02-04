using BenchmarkDotNet.Attributes;
using BenchmarkReflection.Attributes;
using BenchmarkReflection.Metadata;
using BenchmarkReflection.Requests;
using System.Reflection;

namespace BenchmarkReflection.Benchmarks;

[MemoryDiagnoser]
public class ReflectionAttributeBenchmark
{
    [Benchmark(Baseline = true)]
    public void GetProperties()
    {
        for (int i = 0; i < 100; i++)
        {
            var obj = CompraRequestFaker.RetornaCompraRequest();

            var properties = obj.GetType().GetProperties()
            .Where(f => f.GetCustomAttribute<SensitiveDataAttribute>() is null)
            .ToArray();

            var infos = properties.Select(p => new { p.Name, Value = p.GetValue(obj) });
        }
    }

    [Benchmark]
    public void GetPropertiesWithCache()
    {
        for (int i = 0; i < 100; i++)
        {
            var obj = CompraRequestFaker.RetornaCompraRequest();

            var properties = PropertyMetadataCache.GetProperties(obj.GetType());

            var infos = properties.Select(p => new {p.Name, Value = p.GetValue(obj) });
        }
    }

    [Benchmark]
    public void GetPropertiesWithoutReflection()
    {
        for (int i = 0; i < 100; i++)
        {
            var compra = CompraRequestFaker.RetornaCompraRequestClass();

            var infos  = new { compra.IdPdvExterno, compra.UrlCallback, compra.IdExterno, compra.TempoExpiracao, compra.ValorTotal };
        }
    }
}
