public class StringValidator
{
    public bool IsValidEmail(string email)
    {
        return email.Contains("@") && email.Contains(".");
    }

    public bool IsPhoneNumber(string phoneNumber)
    {
        return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
    }
}
