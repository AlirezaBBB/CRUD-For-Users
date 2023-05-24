﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_For_Users.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime UserCreationDate { get; set; }
    }
}
