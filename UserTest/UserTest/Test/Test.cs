using Xunit;
using System;

public class UserValidatorTests
{
    private readonly UserValidator _validator = new UserValidator();

    private void PrintResult(string testName, bool result, bool expected)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        if (result == expected)
        {
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine($"✅ {testName}: Kết quả = {result}, Kỳ vọng = {expected}");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine($"❌ {testName}: Kết quả = {result}, Kỳ vọng = {expected}");
        }
        Console.ResetColor(); 
    }

    [Theory]
    [InlineData("user@example.com", true)]
    [InlineData("invalid-email", false)]
    [InlineData("", false)]
    [InlineData("user@domain", false)]
    public void IsValidEmail_ShouldReturnExpectedResult(string email, bool expected)
    {
        bool result = _validator.IsValidEmail(email);
        PrintResult($"Kiểm tra email '{email}'", result, expected);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("0123456789", true)]
    [InlineData("12345", false)]
    [InlineData("", false)]
    [InlineData("abcdefghij", false)]
    public void IsValidPhoneNumber_ShouldReturnExpectedResult(string phoneNumber, bool expected)
    {
        bool result = _validator.IsValidPhoneNumber(phoneNumber);
        PrintResult($"Kiểm tra số điện thoại '{phoneNumber}'", result, expected);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void IsValidEmail_ShouldFail_WhenEmailIsNull()
    {
        bool result = _validator.IsValidEmail(null);
        PrintResult("Kiểm tra email null", result, false);
        Assert.False(result, "Email null phải bị từ chối.");
    }

    [Fact]
    public void IsValidPhoneNumber_ShouldFail_WhenPhoneIsNull()
    {
        bool result = _validator.IsValidPhoneNumber(null);
        PrintResult("Kiểm tra số điện thoại null", result, false);
        Assert.False(result, "Số điện thoại null phải bị từ chối.");
    }

    [Fact]
    public void IsValidEmail_ShouldFail_WhenExpectingWrongResult()
    {
        bool result = _validator.IsValidEmail("user@example.com");
        PrintResult("Bài kiểm thử cố tình sai (Email hợp lệ bị từ chối)", result, false);
        Assert.False(result, "Bài kiểm thử này phải thất bại.");
    }

    [Fact]
    public void IsValidPhoneNumber_ShouldFail_WhenExpectingWrongResult()
    {
        bool result = _validator.IsValidPhoneNumber("0123456789");
        PrintResult("Bài kiểm thử cố tình sai (Số điện thoại hợp lệ bị từ chối)", result, false);
        Assert.False(result, "Bài kiểm thử này phải thất bại.");
    }
}
