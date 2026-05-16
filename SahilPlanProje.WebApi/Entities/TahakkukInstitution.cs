using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SahilPlanProje.WebApi.Entities
{
    //Tahakkuk Kurumu Belediye / kurum
    public class TahakkukInstitution : BaseEntity
    {
        [Required]
        public int tahakkuk_year_id { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string name { get; set; }

        [ForeignKey(nameof(tahakkuk_year_id))]
        public TahakkukYear tahakkuk_year { get; set; }
    }
}
