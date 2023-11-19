using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr11
{
    class pr
    {
        static void Main()
        {
            Employee employee;

            
            employee.Name = "ADIL ULDANA";
            employee.Vacancy.Title = "Software";
            employee.Vacancy.Department = "IT";
            employee.Date = new int[] { 2023, 11, 10 }; 
            employee.Salary = 250000;

            
            Console.WriteLine($"Имя: {employee.Name}");
            Console.WriteLine($"Вакансия: {employee.Vacancy.Title} в отделе {employee.Vacancy.Department}");
            Console.WriteLine($"Дата приема на работу: {employee.Date[0]}.{employee.Date[1]}.{employee.Date[2]}");
            Console.WriteLine($"Зарплата: {employee.Salary}");
        }
    }
}
