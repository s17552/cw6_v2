using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace cw6_v2.Models
{
    public class PrescriptionMedicament
    {
        [Key] public int IdPrescription { get; set; }
        public Prescription Prescription { get; set; }
        [Key] public int IdMedicament { get; set; }
        public Medicament Medicament { get; set; }
        
        [MaxLength(100)][Required] public int Dose { get; set; }
        [MaxLength(100)][Required] public string Details { get; set; }
    }
}