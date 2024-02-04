using BenchmarkReflection.Attributes;
using System.Collections.Concurrent;
using System.Reflection;

namespace BenchmarkReflection.Metadata;

public static class PropertyMetadataCache
{
    private static readonly ConcurrentDictionary<Type, PropertyInfo[]> propertyCache = new();

    public static PropertyInfo[] GetProperties(Type type)
    {
        return propertyCache.GetOrAdd(type, t =>
        {
            return t.GetProperties()
                    .Where(f => f.GetCustomAttribute<SensitiveDataAttribute>() is null)
                    .ToArray();
        });
    }
}
