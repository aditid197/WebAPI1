using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;

namespace WebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<Employee> GetAllEmployees()
        {
            using(EmployeeEntities entities = new EmployeeEntities())
            {
                return entities.Employees.ToList();
            }
        }

        public Employee GetEmployeeDetails(int id)
        {
            using (EmployeeEntities entities = new EmployeeEntities())
            {
                return entities.Employees.FirstOrDefault(e => e.EmployeeId == id);
            }
        }
    }
}
