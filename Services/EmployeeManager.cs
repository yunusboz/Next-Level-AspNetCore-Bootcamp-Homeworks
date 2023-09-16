using Domain.Entities;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IRepositoryManager _manager;

        public EmployeeManager(IRepositoryManager manager)
        {
            _manager = manager;
        }
        public IEnumerable<Employee> GetAllEmployees(bool trackChanges)
        {
            return _manager.Employee.GetAllEmployees(trackChanges);
        }

        public Employee? GetOneEmployee(int id, bool trackChanges)
        {
            Employee? employee = _manager.Employee.GetOneEmployee(id, trackChanges);
            if(employee is null)
            {
                throw new Exception($"Employee with {id} not found!");
            }
            return employee;
        }

        public void CreateEmployee(Employee employee)
        {
            _manager.Employee.CreateEmployee(employee);
            _manager.Save();
        }
    }
}
