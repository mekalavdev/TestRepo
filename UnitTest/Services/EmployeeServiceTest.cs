using Domain.Interface;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTest.Services
{
    public class EmployeeServiceTest : IEmployeeService
    {
        private readonly List<EmployeeModel> employeeDetails;
        public EmployeeServiceTest()
        {
            employeeDetails = new List<EmployeeModel>()
            {
                new EmployeeModel() { EmpId = 1,Name = "TestEmp1", EmailId="emp1@gmail.com" },
                new EmployeeModel() { EmpId = 2,Name = "TestEmp2", EmailId="emp2@gmail.com" },
                new EmployeeModel() { EmpId = 3,Name = "TestEmp3", EmailId="emp3@gmail.com" }
            };
        }

        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return employeeDetails;
        }

        public EmployeeModel GetEmployeeById(int empId)
        {
            return employeeDetails.Where(x => x.EmpId == empId).FirstOrDefault();
        }

        public void AddEmployee(EmployeeModel employee)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
