using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ado_wf
{
    internal class DataAccessLayer
    {
      public static Company_SDEntities context=new Company_SDEntities();
        public static List<Department> GetDepartments()
        {
            
            var departments = context.Departments.ToList();

            return departments;
        }
        public static List<Employee> GetDepartmentEmplyees(int departmentID)
        {
            List<Employee> employees= context.Employees.Where(e => e.Dno == departmentID).ToList(); 
            
            return employees;

        }
        public static void insertData(string firstName, string lastName, int ssn, DateTime birthDate, string address, int salary, int departmentNumber)
        {
            try
            {
                Employee employee = new Employee();
                employee.Fname = firstName;
                employee.Lname = lastName;
                employee.SSN = ssn;
                employee.Bdate = birthDate;
                employee.Address = address;
                employee.Salary = salary;
                employee.Dno = departmentNumber;
                context.Employees.Add(employee);
                context.SaveChanges();
                MessageBox.Show("Data is inserted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in inserting data: " + ex.Message);
            }
           

            
        }

        public static void updateData(string firstName, string lastName, int ssn, DateTime birthDate, string address, int salary, int departmentNumber)
        {
            try
            {
                Employee employee = context.Employees.FirstOrDefault(e => e.SSN == ssn);

                if (employee != null)
                {

                    employee.Fname = firstName;
                    employee.Lname = lastName;
                    employee.Bdate = birthDate;
                    employee.Address = address;
                    employee.Salary = salary;
                    employee.Dno = departmentNumber;
                    context.SaveChanges();
                    MessageBox.Show("Data is updated successfully");
                }
                else
                {

                    MessageBox.Show("Employee with SSN " + ssn + " not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in update data: " + ex.Message);
            }
           

        }
        public static void DeleteEmployee(int employeeId)
        {

            try {
                Employee employee = context.Employees.FirstOrDefault(e => e.SSN == employeeId);
                if (employee != null)
                {
                    context.Employees.Remove(employee);
                    context.SaveChanges();
                    MessageBox.Show("Data is deleted successfully");

                }
                else
                {
                    MessageBox.Show("Unable To delete this Employee");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Delete data: " + ex.Message);
            }

            
        }

    }
}
