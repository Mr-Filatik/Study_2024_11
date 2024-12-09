namespace Study_2024_11;

public class MemoryStorage : IStorage
{
    private Dictionary<string, string> _memory = new Dictionary<string, string>();

    public void SetValue(string name, string value)
    {
        if (_memory.ContainsKey(name))
        {
            _memory[name] = value;
        }
        _memory.Add(name, value);
    }

    public string? GetValue(string name)
    {
        if (_memory.ContainsKey(name))
        {
            return _memory[name];
        }
        return null;
    }

    public string SetString()
    {
        return string.Empty;
    }
}
