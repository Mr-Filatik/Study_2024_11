
namespace Study_2024_11;

public class DatabaseStorage : IStorage
{
    private Dictionary<string, string> _memory = new Dictionary<string, string>();

    public void SetValue(string name, string value)
    {
        // database
        if (_memory.ContainsKey(name))
        {
            _memory[name] = value;
        }
        _memory.Add(name, value);
    }

    public string? GetValue(string name)
    {
        // database
        if (_memory.ContainsKey(name))
        {
            return _memory[name];
        }
        return null;
    }
}
