using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Constructors_Listview.DataAccess;
using Constructors_Listview.Business;

namespace Constructors_Listview.GUI
{
    public partial class FormEmployee2 : Form
    {
        public FormEmployee2()
        {
            InitializeComponent();
        }

        private void btnAddemp_Click(object sender, EventArgs e)
        {
            if(!(System.Text.RegularExpressions.Regex.IsMatch(textBoxEmployeeIDemp.Text, "[0-9]")))
            {
                MessageBox.Show("Employee ID must be only numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmployeeIDemp.Clear();
                textBoxEmployeeIDemp.Focus();
                return;
            }
            else
            {
                Employee emp = new Employee();
                emp.EmployeeID = Convert.ToInt32(textBoxEmployeeIDemp.Text);
                emp.FirstName = textBoxFirstNameemp.Text;
                emp.LastName = textBoxLastNameemp.Text;

                emp.SaveEmployee(emp);

                textBoxEmployeeIDemp.Clear();
                textBoxFirstNameemp.Clear();
                textBoxLastNameemp.Clear();
                textBoxEmployeeIDemp.Focus();
            }            
        }

        private void btnListemp_Click(object sender, EventArgs e)
        {
            if (!(System.Text.RegularExpressions.Regex.IsMatch(textBoxEmployeeIDemp.Text, "[0-9]")))
            {
                MessageBox.Show("Employee ID must be only numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmployeeIDemp.Clear();
                textBoxEmployeeIDemp.Focus();
                return;
            }
            else
            {
                Employee emp = new Employee();

                emp = emp.SearchEmployee(Convert.ToInt32(textBoxEmployeeIDemp.Text));

                if (emp != null)
                {
                    ListViewItem item = new ListViewItem(emp.EmployeeID.ToString());
                    item.SubItems.Add(emp.FirstName);
                    item.SubItems.Add(emp.LastName);

                    listViewemp.Items.Add(item);
                }
                else
                {
                    MessageBox.Show("Employee not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        private void btnListForm_Click(object sender, EventArgs e)
        {
            // Create an object if FormOperation
            FormEmployee oForm = new FormEmployee();

            oForm.ShowDialog();
        }
    }
}
