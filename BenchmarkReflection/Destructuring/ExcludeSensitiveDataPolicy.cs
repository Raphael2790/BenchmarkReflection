using BenchmarkReflection.Metadata;
using Serilog.Core;
using Serilog.Events;

namespace BenchmarkReflection.Destructuring;

public class ExcludeSensitiveDataPolicy : IDestructuringPolicy
{
    public bool TryDestructure(object value, ILogEventPropertyValueFactory propertyValueFactory, out LogEventPropertyValue result)
    {
        var type = value.GetType();
        var properties = PropertyMetadataCache.GetProperties(type);

        var fieldsWithValues = properties
            .Select(propertyInfo => new LogEventProperty(propertyInfo.Name,
                propertyValueFactory.CreatePropertyValue(propertyInfo.GetValue(value))));

        result = new StructureValue(fieldsWithValues);
        return true;
    }
}
