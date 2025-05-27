using System.Text;
using OOP2;
Console.OutputEncoding = System.Text.Encoding.UTF8;


/* 
 * Sử dụng generic List để quản lý nhân sự
 * thực hiện đầy đủ các chức năng:
 * CRUD (Create, Read, Update, Delete)
 */

// Câu 1 - C (Create) - Thêm mới nhân sự
// Dung list để tạo 5 Employee, trong đó 4 empployee là nhân viên chính thức 1 vn thời vụe
List<Employee> employees = new List<Employee>();
Fulltime fulltime = new Fulltime();
fulltime.Id = 1;
fulltime.IdCard = "FT001";
fulltime.Name = "Nguyễn Văn A";
fulltime.Age = 28;
fulltime.Brithday = new DateTime(1995, 1, 15);
employees.Add(fulltime);

Fulltime fulltime2 = new Fulltime();
fulltime2.Id = 2;
fulltime2.IdCard = "FT002";
fulltime2.Name = "Trần Thị B";
fulltime2.Age = 30;
fulltime2.Brithday = new DateTime(1993, 6, 20);
employees.Add(fulltime2);

Parttime parttime = new Parttime();
parttime.Id = 3;
parttime.IdCard = "PT001";
parttime.Name = "Lê Văn C";
parttime.Age = 24;
parttime.Brithday = new DateTime(1999, 3, 10);
parttime.WorkHours = 120;
employees.Add(parttime);

Parttime parttime2 = new Parttime();
parttime2.Id = 4;
parttime2.IdCard = "PT002";
parttime2.Name = "Phạm Thị D";
parttime2.Age = 22;
parttime2.Brithday = new DateTime(2001, 8, 5);
parttime2.WorkHours = 100;
employees.Add(parttime2);
// Câu 2 - R (Read) - Hiển thị danh sách nhân sự
//Console.WriteLine("Danh sách nhân sự 1 ");
//employees.ForEach(emp => Console.WriteLine(emp));   
//Console.WriteLine("======Nhân sự 2=======");
//for (int i = 0; i < employees.Count; i++)
//{
//    Console.WriteLine($"Nhân viên {i + 1}: {employees[i]}");
//}



// Câu 3 - R lọc ra nhân viên Fulltime và tính tổng lương 
//cách 1 Dung extention hệ thống

List<Fulltime> fullList = employees.OfType<Fulltime>().ToList();
Console.WriteLine("Danh sách nhân viên Fulltime:");
fullList.ForEach(emp => Console.WriteLine(emp));


////Cách 2 dung vòng lặp thông thường
//List<Fulltime> fullList2 = new List<Fulltime>();
//foreach (var emp in employees)
//{
//    if (emp is Fulltime fullEmp)
//    {
//        fullList2.Add(fullEmp);
//    }
//}
//Console.WriteLine("Danh sách nhân viên Fulltime (cách 2):");
//fullList2.ForEach(emp => Console.WriteLine(emp));

// Tính tổng lương của nhân viên Fulltime
double sumSalary = fullList.Sum(emp => emp.Salary());
Console.WriteLine($"Tổng lương của nhân viên Fulltime: {sumSalary}");

// Câu 4 - R Sắp xếp danh sách nhân sự theo ngày tháng năm sinh

for(int i = 0; i<employees.Count; i++)
{
    for(int j = i +1; j < employees.Count; j++)
    {
        Employee ei = employees[i];
        Employee ej = employees[j];
        if (ei.Brithday > ej.Brithday)
        {
            // Hoán đổi
            employees[i] = ej;
            employees[j] = ei;
        }


    }
}

Console.WriteLine("Danh sách nhân sự sau khi sắp xếp theo ngày tháng năm sinh:");
employees.ForEach(emp => Console.WriteLine(emp));