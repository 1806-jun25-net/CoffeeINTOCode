using System;
using System.Collections.Generic;

namespace HappyPets.Data
{
    public partial class Appointments
    {
        public int AppointmentId { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public bool? AppointmentTime { get; set; }
        public int? OrderId { get; set; }
        public int? UsersId { get; set; }
        public int? EmployeeId { get; set; }

        public Employee Employee { get; set; }
        public Orders Order { get; set; }
        public Users Users { get; set; }
    }
}
