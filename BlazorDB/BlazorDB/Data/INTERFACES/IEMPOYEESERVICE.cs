using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDB.Data.INTERFACES
{
    interface IEMPOYEESERVICE
    {
        Task<IEnumerable<EmployeeModel>> GetEmployees();
        Task<bool> CreateEmployee(Employee employee);
        Task<bool> EditEmployee(int id, EmployeeModel employee);
        Task<bool> DeleteEmployee(int id);
    }
}
