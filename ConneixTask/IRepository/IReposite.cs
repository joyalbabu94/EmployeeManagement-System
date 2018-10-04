using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConneixTask.Models;

namespace ConneixTask.IRepository
{
    public interface IReposite
    {
        void AddEmployee(Employee emp);
        void UpdateEmployee(Employee emp);
        void DeleteEmployee(Employee emp);
        List<Employee> GetAllEmployees();
    }
}
