﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rental.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }

        public Movie Movie { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime?  DateReturned { get; set; }
    }
}