using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SahilPlanProje.WebApi.Entities
{
    //Daire Başkanlığı  İmar Dairesi vb
    public class TahakkukDepartment : BaseEntity
    {

        [Required]
        public int tahakkuk_institution_id { get; set; }

        [Required]
        [MaxLength(250)]
        public string name { get; set; } = string.Empty;


        [ForeignKey(nameof(tahakkuk_institution_id))]
        public TahakkukInstitution? tahakkuk_institution { get; set; }

        //public ICollection<TahakkukDirectorate>? directorates { get; set; }
    }
}
