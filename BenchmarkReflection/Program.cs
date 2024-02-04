// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using BenchmarkReflection.Benchmarks;
using BenchmarkReflection.Metadata;
using BenchmarkReflection.Requests;

BenchmarkRunner.Run<ReflectionAttributeBenchmark>();

//var verdadeiro = ComparaCompraRequest();

//bool ComparaCompraRequest()
//{
//    var obj = CompraRequestFaker.RetornaCompraRequest();

//    var comprarequest = obj as CompraRequest;
    
//    var properties = PropertyMetadataCache.GetProperties(obj.GetType());

//    var infos = properties.Select(p => new {p.Name, Value = p.GetValue(obj) });

//    var obj2 = CompraRequestFaker.RetornaCompraRequest("Marcelo", "novoemail@email.com", "87669");

//    var comprarequest2 = obj2 as CompraRequest;

//    var properties2 = PropertyMetadataCache.GetProperties(obj2.GetType());

//    var infos2 = properties2.Select(p => new {p.Name, Value = p.GetValue(obj2) });

//    return true;
//}
