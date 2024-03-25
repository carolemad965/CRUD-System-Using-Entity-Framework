using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado_wf
{
    public partial class V : Form
    {
        public V()
        {
            InitializeComponent();

            startForm();
            
        }

        public void startForm()
        {
           
            cmbDept.DisplayMember = "Dname";
            cmbDept.ValueMember = "Dnum";
            cmbDept.DataSource = BusinessLogicLayer.GetDepartments();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.CellClick -= dataGridView1_CellClick;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            Employee selectedEmp = (Employee)row.DataBoundItem;
            textBox_F.Text = selectedEmp.Fname.ToString();
            textBox_L.Text = selectedEmp.Lname.ToString();
            textBox_SS.Text = selectedEmp.SSN.ToString();
            textBox_A.Text = selectedEmp.Address.ToString();
            textBox_B.Text = selectedEmp.Bdate.ToString();
            numericUpDown1.Value =(decimal)selectedEmp.Dno;
            textBox_S.Text = selectedEmp.Salary.ToString();


        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                int selectedDeptID = (int)cmbDept.SelectedValue;
                List<Employee> employees = BusinessLogicLayer.GetEmployeesOfDept(selectedDeptID);
                dataGridView1.DataSource = employees;
            
           
        }

        private void btn_I_Click(object sender, EventArgs e)
        {
            string firstName = textBox_F.Text;
            string lastName = textBox_L.Text;
            int ssn = Convert.ToInt32(textBox_SS.Text);
            DateTime birthDate = DateTime.Parse(textBox_B.Text);
            string address = textBox_A.Text;
            int salary = Convert.ToInt32(textBox_S.Text);
            int departmentNumber = Convert.ToInt32(numericUpDown1.Value);
            DataAccessLayer.insertData(firstName, lastName, ssn, birthDate, address, salary, departmentNumber);
                
            
            
        }

        private void btn_U_Click(object sender, EventArgs e)
        {

            string firstName = textBox_F.Text;
            string lastName = textBox_L.Text;
            int ssn = Convert.ToInt32(textBox_SS.Text);
            DateTime birthDate = DateTime.Parse(textBox_B.Text);
            string address = textBox_A.Text;
            int salary = Convert.ToInt32(textBox_S.Text);
            int departmentNumber = Convert.ToInt32(numericUpDown1.Value);
            DataAccessLayer.updateData(firstName, lastName, ssn, birthDate, address, salary, departmentNumber);
      
           


        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            
                DataAccessLayer.DeleteEmployee(Convert.ToInt32(textBox_SS.Text));
               
           

            
        }
    }
}
