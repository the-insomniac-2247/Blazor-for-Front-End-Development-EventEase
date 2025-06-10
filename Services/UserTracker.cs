namespace EventEase.Services;

public class UserTracker
{
    public string? Name { get; set; }
    public string? Email { get; set; }

    public void RegisterUser(string ipName, string ipEmail)
    {
        Name = ipName;
        Email = ipEmail;
    }

    public void Logout()
    {
        Name = null;
        Email = null;
    }
}