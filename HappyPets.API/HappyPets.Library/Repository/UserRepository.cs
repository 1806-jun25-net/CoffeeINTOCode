using HappyPets.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyPets.Library.Repository
{

    public partial class Repository
    {
        // Users
        public Users GetUser(int id)
        {
            var user = _repo.GetUsersByID(id);
            return user;
        }

        public IEnumerable<Users> GetUsers(string value, int option = 0)
        {
            IEnumerable<Users> user;

            switch(option)
            {
                case 1:
                    user = _repo.GetUserByLastName(value);
                    break;
                case 2:
                    user = _repo.GetUserByEmail(value);
                    break;
                default:
                    user = _repo.GetUserByName(value);
                    break;
            }

            return user;

        }

        public IEnumerable<Products> GetAllProducts()
        {
            var p = _repo.GetProducts();
            return p;
        }

        public IEnumerable<Employee>  GetAvailableEmployees(DateTime date, bool time, int location)
        {
            var allEmployees = _repo.GetAllEmployee();
            var allLocationEmployee = _repo.GetAllLocationEmployee(location);

            return allLocationEmployee;
        }
        public Users GetUserByUserName(string username)
        {
            var user = _db.Users.First(n => n.UserName == username);
            return user;
        }

        public IEnumerable<Location> GetLocations()
        {
            var locations = _repo.GetAllLocation();
            return locations;
        }

        public IEnumerable<Users> GetUsers(int locationId)
        {
            var user = _repo.GetUserByLocation(locationId);
            return user;
        }

        public IEnumerable<Users> GetAllUsers()
        {
            var user = _repo.GetAllUser();
            return user;
        }

        public void EditUser(Users users)
        {
            _repo.UpdateUser(users);
        }

        public void CreateNewUser(Users user)
        {
            _repo.CreateUser(user);
        }

        public void CreateNewUser(
            string firstName,
            string lastName,
            string email,
            string password,
            string streetAddress,
            int locationId,
            int userType,
            int? employeeId)
        {
            _repo.CreateUser(
                firstName,
                lastName,
                email,
                password,
                streetAddress,
                locationId,
                userType,
                employeeId
            );
        }

        public Employee GetUserFavoriteEmployee(int userId)
        {
            var user = _repo.GetUsersByID(userId);
            var employeeId = (int) user.EmployeeId;
            var employee = _repo.GetEmployeeByID(employeeId);
            return employee;
        }


        public int? GetEmployeeRatingByEmployeeId(int? id)
        {
            var employeeRating = _repo.GetEmployeeRatingByEmployeeId(id);
            int? rating = int.Parse(employeeRating.Rating.ToString());
            return rating;
        }

      


        // Employee
        public Employee GetEmployee(int? id)
        {
            return _repo.GetEmployeeByID(id);
        }

        public IEnumerable<Employee> GetEmployees(string value, int option = 0)
        {
            IEnumerable<Employee> employees;

            switch (option)
            {
                case 1:
                    employees = _repo.GetEmployeeByLastName(value);
                    break;

                default:
                    employees = _repo.GetEmployeeByName(value);
                    break;
            }

            return employees;
        }

        public IEnumerable<Employee> GetEmployees(int locationId)
        {
            var employees = _repo.GetEmployeeByLocation(locationId);
            return employees;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            var employees = _repo.GetAllEmployee();
            return employees;
        }

        public void EditEmployee(Employee employee)
        {
            _repo.UpdateEmployee(employee);
        }

        public void CreateNewEmployee(Employee employee)
        {
            _repo.CreateEmployee(employee);
        }

        public void CreateNewEmployee(
            string firstName,
            string lastName,
            int locationId)
        {
            _repo.CreateEmployee(
                firstName,
                lastName,
                locationId
            );
        }

        public int GetLocationOfEmployee(int? employeeid)
        {
            var  employee = _repo.GetLocationByEmployeeId(employeeid);
            var locationid = employee.LocationId;
            var locationId = int.Parse(locationid.ToString());
            return locationId;

        }

        public void CreateOrder(DateTime OrderTime, decimal? TotalCost, int location, int? employee, int orderid )
        {
            
            _repo.AddOrders(OrderTime, TotalCost,  location, employee, orderid);
            _repo.EditCart(orderid);

        }

        public int? GetEmployeeOfOrder(int?  orderid)
        {
            var Order = _db.Orders.First(g => g.OrderId == orderid);

            return Order.EmployeeId;

        }

        public List<int?> GetuserOrders(int userid)
        {
            List<int?> ordersid = new List<int?>();
            var carts = _db.Cart.Where(g=> g.UsersId == userid);

            foreach (var item in carts)
            {
                ordersid.Add( item.OrderId);
            }



         


            return ordersid;
           
        }

        public DateTime GetOrderDate(int? orderid)
        {
            var date = _repo.GetOrderTime(orderid);
            return date;

           

        }
    }
}

 
