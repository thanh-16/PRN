using System.Linq.Expressions;
using System.Text;
using OOP2;
Console.OutputEncoding = Encoding.UTF8;

Fulltime f1 = new Fulltime()
{
    Id = 1,
    IdCard = "00123",
    Name = "Tèo",
    Age = 30,
    Brithday = new DateTime(1993, 5, 20),
};
Console.WriteLine("---Thông tin nhân viên f1:---");
Console.WriteLine($"Id: {f1.Id}");
Console.WriteLine($"IdCard: {f1.IdCard}");
Console.WriteLine($"Name: {f1.Name}");
Console.WriteLine($"Age: {f1.Age}");
Console.WriteLine($"Brithday: {f1.Brithday.ToShortDateString()}");
Console.WriteLine($"Salary: {f1.Salary()}");

Parttime p1 = new Parttime()
{
    Id = 2,
    IdCard = "00234",
    Name = "Tý",
    Age = 25,
    Brithday = new DateTime(1998, 3, 15),
    WorkHours = 160,
};
Console.WriteLine("---Thông tin nhân viên p1:---");
Console.WriteLine($"Id: {p1.Id}");
Console.WriteLine($"IdCard: {p1.IdCard}");
Console.WriteLine($"Name: {p1.Name}");
Console.WriteLine($"Age: {p1.Age}");
Console.WriteLine($"Brithday: {p1.Brithday.ToShortDateString()}");
Console.WriteLine($"WorkHours: {p1.WorkHours}");
Console.WriteLine($"Salary: {p1.Salary()}");

Console.WriteLine("---Dùng toString:---");
Console.WriteLine(f1);
Console.WriteLine(p1);