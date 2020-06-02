using System;
using System.Collections;
using System.Collections.Generic;
using Models;

namespace Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
    }
}
