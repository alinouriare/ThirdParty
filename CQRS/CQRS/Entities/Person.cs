﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS.Entities
{
   public class Person
    {

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
