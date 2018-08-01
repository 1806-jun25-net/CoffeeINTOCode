using HappyPets.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyPets.Library.Repository.CRUDs
{
    public partial class Repository
    {


        /////////////////////// Get Appointments ////////////////////////////////////
        public IEnumerable<Appointments> GetAppointments()
        {
            var appointments = _db.Appointments.ToList();
            return appointments;
        }

        /////////////////////// Add an Appointment ////////////////////////////////////
        public void AddAppointment( bool? ApTime, int? orderID, int? userID, int? employeeID)
        {
            DateTime Date = DateTime.Now;

            var appointment = new Appointments
            {
                AppointmentDate = Date,
                AppointmentTime = ApTime,
                OrderId = orderID,
                UsersId = userID,
                EmployeeId = employeeID

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
    }
}
