﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rental.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
     
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }
      
        public byte MembershipId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}