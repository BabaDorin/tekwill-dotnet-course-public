// Interfața serviciului de e-mail
public interface IEmailService
{
    void SendEmail(string to, string subject, string body);
}

public class User
{
    public string Email { get; set; }

    public string Name { get; set; }
}

// Clasa de utilizator
public class UserService
{
    private IEmailService _emailService;

    public UserService(IEmailService emailService)
    {
        _emailService = emailService;
    }

    public void NotifyUser(User user)
    {
        string message = $"Hello, {user.Name}! You have a new notification.";
        _emailService.SendEmail(user.Email, "Notification", message);
    }
}

public class Program
{
    static void Main()
    {

    }
}