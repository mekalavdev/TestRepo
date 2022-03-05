using Domain.Model;
using System.Collections.Generic;

namespace Domain.Interface
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeModel> GetEmployees();
    }
}
