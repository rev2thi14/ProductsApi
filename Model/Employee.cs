﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
       
        public string Name { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
    }
}
