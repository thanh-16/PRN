public class UserValidator
{
    public bool IsValidEmail(string email)
    {
        if (string.IsNullOrEmpty(email)) return false;
        return email.Contains("@") && email.Contains(".");
    }

    public bool IsValidPhoneNumber(string phoneNumber)
    {
        if (string.IsNullOrEmpty(phoneNumber)) return false; 
        return phoneNumber.Length == 10 && long.TryParse(phoneNumber, out _);
    }
}
