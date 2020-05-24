using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace cw6_v2.Models
{
    public class Medicament
    {
        [Key] public int IdMedicament { get; set; }
        [MaxLength(100)][Required] public string Name { get; set; }
        [MaxLength(100)][Required] public string Description { get; set; }
        [MaxLength(100)][Required] public string Type { get; set; }
        
        public List<PrescriptionMedicament> Prescriptions { get; set; }

    }
}