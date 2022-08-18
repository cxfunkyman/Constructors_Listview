using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Constructors_Listview.Business;

namespace Constructors_Listview.DataAccess
{
    public static class EmployeeIO
    {
        //Location where the data will be save
        const string dir = @"";

        //The name of the storage file
        const string filePath = dir + "Employee.dat";

        public static void SaveRecord(Employee emp) 
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(emp.EmployeeID + "," + emp.FirstName + "," + emp.LastName);
            
            MessageBox.Show("Save successfully", "Save Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sWriter.Close();
        }

        public static Employee SearchRecord(int id)
        {
            Employee emp = new Employee(); 
            emp.EmployeeID = id;
            if (File.Exists(filePath))
            {
                StreamReader sReader = new StreamReader(filePath);
                string line = sReader.ReadLine();

                bool found = false;

                while(line != null)
                {
                    string[] fields = line.Split(',');

                    if (Convert.ToInt32(fields[0]) == id)
                    {
                        emp.EmployeeID = Convert.ToInt32(fields[0]);
                        emp.FirstName = fields[1];
                        emp.LastName = fields[2];
                        
                        found = true;
                        break;
                    }
                    line = sReader.ReadLine();
                }
                sReader.Close();

                if (!found)
                {
                    emp = null;
                }
            }
            else
            {
                MessageBox.Show("File not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return emp;
        }
        public static Employee SearchRecord(string input)
        {
            Employee emp = new Employee();

            return emp;
        }
        public static string[] ListRecords()
        {
            long length = new System.IO.FileInfo(filePath).Length;
            Employee emp = new Employee();
            string[] infoString = new string[length];

            if (File.Exists(filePath))
            {
                StreamReader sReader = new StreamReader(filePath);
                string line = sReader.ReadLine();

                for(int i = 0; line != null; i++)
                {
                    infoString[i] = line;
                    line = sReader.ReadLine();
                }
                sReader.Close();
            }
            else
            {
                MessageBox.Show("File not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return infoString;
        }
        public static Employee ShowRecord(string inText)
        {
            Employee emp = new Employee();
            string[] fields = inText.Split(',');

            emp.EmployeeID = Convert.ToInt32(fields[0]);
            emp.FirstName = fields[1];
            emp.LastName = fields[2];

            return emp;
        }
    }
}
