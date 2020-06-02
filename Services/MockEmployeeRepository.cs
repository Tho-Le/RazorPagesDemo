using System.Collections.Generic;
using Models;

namespace Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeesList;

        public MockEmployeeRepository()
        {
            _employeesList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Mary", Department = Department.Hr, Email = "mary@yahoo.com", PhotoPath = "mary.png"},
                new Employee() {Id = 2, Name = "John", Department = Department.It, Email = "john@gmail.com", PhotoPath = "john.png"}
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeesList;
        }
    }
}