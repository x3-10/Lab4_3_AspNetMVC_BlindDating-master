﻿using System;
using System.Collections.Generic;

namespace Lab4_3_AspNetMVC_BlindDating.Models
{
    public partial class DatingProfile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Bio { get; set; }
        public string UserAccountId { get; set; }
    }
}
