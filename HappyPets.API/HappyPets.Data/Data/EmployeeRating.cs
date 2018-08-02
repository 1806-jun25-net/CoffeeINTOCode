using System;
using System.Collections.Generic;

namespace HappyPets.Data
{
    public partial class EmployeeRating
    {
        public int RatingId { get; set; }
        public int? EmployeeId { get; set; }
        public int? Rating { get; set; }

        public Employee Employee { get; set; }
    }
}
