using System;
using System.Collections.Generic;
using System.Linq;
using HappyPets.Data;

namespace HappyPets.Library.Repository.CRUDs
{
    public partial class RepositoryCRUDs
    {
        // CRUD operation for Employee
        // Create
        public void CreateEmployee(Employee employee)
        {
            _db.Add(employee);
            SaveChanges();
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
            SaveChanges();
        }

        // Read Single
        public Employee GetEmployeeByID(int? id)
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
            SaveChanges();
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
            SaveChanges();
        }

        public IEnumerable<Employee> GetEmployeeByName(string name)
        {
            var employee = _db.Employee.Where(n => n.FirstName == name).ToList();
            string errMsg = "Not Employee found with that Name";

            // In case of return no user
            if (employee == null)
            {
                throw new ArgumentException(errMsg, nameof(name));
            }
            return employee;
        }

        public IEnumerable<Employee> GetEmployeeByLastName(string lastname)
        {
            var employee = _db.Employee.Where(n => n.LastName == lastname).ToList();
            string errMsg = "Not Employee found with that Name";

            // In case of return no user
            if (employee == null)
            {
                throw new ArgumentException(errMsg, nameof(lastname));
            }
            return employee;
        }

        public IEnumerable<Employee> GetEmployeeByLocation(int locationId)
        {
            var employee = _db.Employee.Where(n => n.LocationId == locationId).ToList();
            string errMsg = "Not Employee found with that Name";

            // In case of return no user
            if (employee == null)
            {
                throw new ArgumentException(errMsg, nameof(locationId));
            }
            return employee;
        }

        public Employee GetLocationByEmployeeId(int? emId)
        {
            var employee = _db.Employee.First(g => g.EmployeeId == emId);
            return employee;

        }
    }
}
