using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pr11
{
    struct Employee 
    {
        public string Name;
        public Vacancies Vacancy;
        public int[] Date;
        public int Salary;
    
    }
    public struct Vacancies
    {
        public string Title;
        public string Department;
    }
   
}
