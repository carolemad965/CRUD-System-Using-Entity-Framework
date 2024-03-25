using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ado_wf
{
    internal class BusinessLogicLayer
    {
        public static List<Department> GetDepartments()
        {
            List<Department> departments = DataAccessLayer.GetDepartments();

            return departments;
        }
        
        public static Department GetDepartment(int ID)
        {

            List<Department> departments = DataAccessLayer.GetDepartments();
            foreach (Department department1 in departments)
            {
                if (department1.Dnum == ID)
                {
                    return department1;
                }
            }
            return null;
        }
        public static List<Employee> GetEmployeesOfDept(int deptID)
        {
           
            List<Employee> employees = DataAccessLayer.GetDepartmentEmplyees(deptID);
            List<Employee> Newemployees = new List<Employee>();
            foreach (Employee emp in employees)
            {
                Newemployees.Add(new Employee
                {
                    Fname = emp.Fname,
                    Lname = emp.Lname,
                    Dno = emp.Dno,
                    Bdate = emp.Bdate,
                    Address = emp.Address,
                    Salary = emp.Salary,
                    SSN = emp.SSN,
                    
                });
            }
            return Newemployees;
        }
        

    }
}
