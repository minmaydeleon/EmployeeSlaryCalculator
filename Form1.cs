using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EmployeeApplication_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class PartTimeEmployee : Form
        {
            public string FirstName
            {
                get; set;
            }
            public string LastName
            {
                get; set;
            }
            public string DepartmentName
            {
                get; set;
            }
            public string JobTitle
            {
                get; set;
            }
            public string BasicSalaryName
            {
                get; set;
            }

            public double BasicSalary { get; set; }

            public PartTimeEmployee(string fName, string IName, string department, string jobTitle)
            {
                FirstName = fName;
                LastName = IName;
                DepartmentName = department;
                JobTitle = jobTitle;
                BasicSalary = 0.0;

                
            }
            public void ComputeSalary(int hoursworked, double rateperhour)
            {
                BasicSalary = hoursworked * rateperhour;
            }

        }
           
            private void Form1_Load(object sender, EventArgs e)
            {

            }
            private void ComputeSalary_Click(object sender, EventArgs e)
            {
                string firstname = txtFname.Text;
                string secondname = txtLname.Text;
                string department = txtDept.Text;
                string title = txtJtitle.Text;
                double rateperhouse = Double.Parse(txtRPH.Text);
                int hoursworked = int.Parse(txtTHW.Text);

            PartTimeEmployee employee = new PartTimeEmployee(firstname, secondname, department, title);

            employee.ComputeSalary(hoursworked, rateperhouse);

            lbl_fname.Text = firstname;
            lbl_lname.Text = secondname; 
            lbl_basicsal.Text = employee.BasicSalary.ToString();




            }
        }
    }

