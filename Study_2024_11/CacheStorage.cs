namespace Study_2024_11;

public class CacheStorage : IStorage
{
    public string? GetValue(string name)
    {
        return name;
    }

    public void SetValue(string name, string value)
    {
        name = value;
    }
}
