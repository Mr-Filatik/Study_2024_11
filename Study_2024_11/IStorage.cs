namespace Study_2024_11;

public interface IStorage
{
    // удобная замена одной логики на другую
    // для удобства разработки
    public void SetValue(string name, string value);
    public string? GetValue(string name);
}
