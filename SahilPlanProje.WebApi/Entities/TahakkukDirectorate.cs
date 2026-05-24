using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SahilPlanProje.WebApi.Entities
{
    public class TahakkukDirectorate : BaseEntity
    {
        [Required]
        [MaxLength(250)]
        public string name { get; set; } = string.Empty;

        [Required]
        public int tahakkuk_institution_id { get; set; }


        [ForeignKey(nameof(tahakkuk_institution_id))]
        public TahakkukInstitution? tahakkuk_institution { get; set; }





        // Opsiyonel (nullable)
        public int? tahakkuk_department_id { get; set; }

        [ForeignKey(nameof(tahakkuk_department_id))]
        public TahakkukDepartment? tahakkuk_department { get; set; }
    }
}
