using OOP1;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//Category category1 = new Category();
//category1.ID = 1;
//category1.Name = "Nước Mắm";
//category1.PrintInfor();

// khởi tạo nhân viên 
Employee emp = new Employee();
emp.ID = 1;
emp.IDCard = "9999";
emp.Name = "Nguyễn Văn A";
emp.Phone = "0123456789";
emp.Email = "nqthan1602@gmail.com";
emp.PrintInfor();
Console.WriteLine("=====================================");
Console.WriteLine("ID của e1 = " + emp.ID);
Console.WriteLine($"IDCard của e1 = { emp.Name}");

Employee emp2 = new Employee()
{
    ID = 2,
    Name = "Nguyễn Văn B",
    IDCard = "8888",
    Phone = "0123456789",
    Email = "nqthanh102@gmail.com"

};
Console.WriteLine("=====================================");
emp2.PrintInfor();
Console.WriteLine("=====================================");

Employee emp3 = new Employee(3,"3993","THANH","DFNDG","FSDIFN");
emp3.PrintInfor();
Console.WriteLine(emp3);