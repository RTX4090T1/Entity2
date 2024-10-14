// See https://aka.ms/new-console-template for more information
using Entity2;
using Entity2.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using static Entity2.EBJCONTEXT1;
Productt studentinfo = new()
{
    NameSurname = "St1",
    Faculty = "FMDT",
    Course = 1,
    Gender = "Male",
    SalaryEnable = "True",
    Raiting = 100,
};
 void GetInfo()
{
using (var context = new EbjContext())
{
    context.Students.Add(studentinfo);
    context.SaveChanges();
    var stList = context.Students.ToList();
        ShowInfo(stList);
    }
}
    void GetinfoByInput(string input)
    {
    using(var fstList = new EbjContext())
    {
        var filtererdStudentList = fstList.Students.Where(st=>st.NameSurname == input).ToList();
        ShowInfo(filtererdStudentList);
    }
    }
    void GetExelentResult()
{
    using (var fstList = new EbjContext())
    {
        var filtererdStudentList = fstList.Students.Where(st => st.Raiting < 90).ToList();
        ShowInfo(filtererdStudentList);
    }
}
void ShowInfo(List<Productt> students)
{
    foreach (var st in students)
    {
        Console.WriteLine(st.NameSurname);
        Console.WriteLine(st.Faculty);
        Console.WriteLine(st.Gender);
        Console.WriteLine(st.SalaryEnable);
        Console.WriteLine(st.Course);
        Console.WriteLine(st.Raiting);
    }
}
Console.WriteLine("Enter 1 to get students from db, 2 to get students that is excelent, 3 to get student info by name:");
int inp = Convert.ToInt32(Console.ReadLine());
switch (inp)
{
    case 1:
        {
            GetInfo(); break;
        }
        case 2:
        {
            Console.WriteLine("Enter student name:");
            string input = Console.ReadLine();
            GetinfoByInput(input);
            break;
        }
        case 3:
        {
            GetExelentResult(); break;
        }
    default:
        {
            Console.WriteLine("Incorrect operation!");
            break;
        }
}
