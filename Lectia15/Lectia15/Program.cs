public class UserService
{
    public static string Number = "001";

    private List<string> Users { get; set; }

    public void AddUser()
    {
        // ...
    }
}

class Program
{
    static void Main()
    {

        var userService1 = new UserService();
        userService1.AddUser();

        Console.WriteLine(UserService.Number);

        var userService2 = new UserService();   
    }
}

