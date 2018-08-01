using System;
using System.Collections.Generic;
using System.Linq;
using HappyPets.Data;

namespace HappyPets.Library.Repository.CRUDs
{
    public partial class Repository
    {
        // CRUD operation for Employee
        // Create
        public void CreateEmployee(Employee employee)
        {
            _db.Add(employee);
        }

        public void CreateEmployee(
            string firstname, 
            string lastname, 
            int locationId)
        {
            var employee = new Employee
            {
                FirstName = firstname,
                LastName = lastname,
                LocationId = locationId
            };

            _db.Add(employee);
        }

        // Read Single
        public Employee GetEmployeeByID(int id)
        {
            var employee = _db.Employee.Find(id);
            string errMsg = "Not Employee found with that ID";

            // In case of return no user
            if(employee == null)
            {
                throw new ArgumentException(errMsg, nameof(id));
            }
            return employee;
        }

        // Read All
        public IEnumerable<Employee> GetAllEmployee()
        {
            var employees = _db.Employee.ToList();
            return employees;
        }

        // Update
        public void UpdateEmployee( Employee employee)
        {
            _db.Employee.Update(employee);
        }

        // Delete
        public void DeleteEmployee(int id)
        {
            
            var employee = _db.Employee.Find(id);
            string errMsg = "Not Employee found with that ID";

            if (employee == null)
            {
                throw new ArgumentException(errMsg, nameof(id));
            }

            _db.Remove(employee);
        }
    }
}
