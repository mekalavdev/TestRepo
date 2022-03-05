using Domain.Model;
using System.Collections.Generic;

namespace Domain.Interface
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeModel> GetEmployees();
        EmployeeModel GetEmployeeById(int empId);

        void AddEmployee(EmployeeModel employee);
    }
}
