using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace cw6_v2.Models
{
    public class Prescription
    {
        [Key]
        public int IdPrescription { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
        
        [Required]
        public DateTime DueDate { get; set; }
        
        public int IdDoctor { get; set; }
        public Doctor Doctor { get; set; }
        
        public int IdPatient { get; set; }
        public Doctor Patient { get; set; }
        
        public List<PrescriptionMedicament> PrescriptionMedicaments { get; set; }



    }
}