﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace cw6_v2.Models
{
    public class Doctor
    {
        [Key] public int IdDoctor { get; set; }

        [Required] [MaxLength(100)] public string FirstName { get; set; }

        [Required] [MaxLength(100)] public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        public List<Prescription> Prescriptions { get; set; }
    }
}