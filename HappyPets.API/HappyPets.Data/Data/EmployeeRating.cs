﻿using System;
using System.Collections.Generic;

namespace HappyPets.Data
{
    public partial class EmployeeRating
    {
        public int RatingId { get; set; }
        public int? EmployeeId { get; set; }
        public int? Rating { get; set; }
        public int? RatingCount { get; set; }
        public int? RatingPoint { get; set; }

        public Employee Employee { get; set; }
    }
}
