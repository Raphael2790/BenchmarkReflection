namespace BenchmarkReflection.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class SensitiveDataAttribute : Attribute
{
    public SensitiveDataAttribute()
    {

    }

    public SensitiveDataAttribute(string mask)
    {
        Mask = mask;
    }

    public string Mask { get; internal set; }
}
