using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Constructors_Listview.Business;

namespace Constructors_Listview.GUI
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(System.Text.RegularExpressions.Regex.IsMatch(textBoxEmployeeID.Text, "[0-9]")))
            {
                MessageBox.Show("Employee ID must be only numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmployeeID.Clear();
                textBoxEmployeeID.Focus();
                return;
            }
            else
            {
                Employee emp = new Employee();
                emp.EmployeeID = Convert.ToInt32(textBoxEmployeeID.Text);
                emp.FirstName = textBoxFirstName.Text;
                emp.LastName = textBoxLastName.Text;

                emp.SaveEmployee(emp);

                textBoxEmployeeID.Clear();
                textBoxFirstName.Clear();
                textBoxLastName.Clear();
                textBoxEmployeeID.Focus();
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ListRecord listRecord = new ListRecord();
            string[] array = listRecord.ShowRecords();
            Employee emp = new Employee();

            listView1.Items.Clear();

            if (array != null)
            {                
                for (int i = 0; i < array.Length; i++)
                {
                    if(array[i] == null)
                    {
                        break;
                    }
                    else
                    {
                        string textSplit = array[i];
                        emp = emp.ShowEmployee(textSplit);
                        if (emp != null)
                        {
                            ListViewItem item = new ListViewItem(emp.EmployeeID.ToString());
                            item.SubItems.Add(emp.FirstName);
                            item.SubItems.Add(emp.LastName);

                            listView1.Items.Add(item);
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("There's nothing to show", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
