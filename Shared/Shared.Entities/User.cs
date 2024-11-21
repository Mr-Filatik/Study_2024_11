namespace Study_2024_11.Shared.Entities;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public int Age { get; set; }
    public bool? Gender { get; set; }
}
