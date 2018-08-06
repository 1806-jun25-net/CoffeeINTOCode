using HappyPets.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyPets.Library.Repository.CRUDs
{
    public partial class RepositoryCRUDs
    {


        /////////////////////// Get Appointments ////////////////////////////////////
        public IEnumerable<Appointments> GetAppointments()
        {
            var appointments = _db.Appointments.ToList();
            return appointments;
        }

        /////////////////////// Add an Appointment ////////////////////////////////////
        public void AddAppointment( bool? ApTime, int? orderId, int? userId, int? employeeId, DateTime Date)
        {
            

            var appointment = new Appointments
            {
                AppointmentDate = Date,
                AppointmentTime = ApTime,
                OrderId = orderId,
                UsersId = userId,
                EmployeeId = employeeId

            };
            _db.Add(appointment);
            SaveChanges();
        }



        /////////////////////// Edit Appointment ////////////////////////////////////
        public void Edit(Appointments appointment)
        {
            //updates the current appointment
            _db.Update(appointment);
            SaveChanges();
        }

        public IEnumerable<Appointments> GetAppointmentsByEmployeeID(int id)
        {
            var appointment = _db.Appointments.Where(
                a =>
                a.EmployeeId == id
            ).ToList();

            return appointment;

        }
        public Appointments GetAppointmentsByOrderId(int? orderid)
        {
            var appointment = _db.Appointments.First(
                a =>
                a.OrderId == orderid
            );

            return appointment;

        }
    }
}
