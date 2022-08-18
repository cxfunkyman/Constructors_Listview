using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constructors_Listview.DataAccess;

namespace Constructors_Listview.Business
{
    public class Employee
    {
        public int EmployeeID 
        { 
            get; 
            set; 
        }

        public string FirstName 
        { 
            get; 
            set; 
        }

        public string LastName 
        { 
            get; 
            set; 
        }

        public void SaveEmployee(Employee emp)
        {
            EmployeeIO.SaveRecord(emp);
        }
        
        public Employee SearchEmployee(int empId)
        {
            return EmployeeIO.SearchRecord(empId);
        }
        public Employee ShowEmployee(string emp)
        {
            return EmployeeIO.ShowRecord(emp);
        }

    }
    public class ListRecord
    {
        public string[] ShowRecords()
        {
            return EmployeeIO.ListRecords();
        }
    }

 
}
