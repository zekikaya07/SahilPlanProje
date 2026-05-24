using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SahilPlanProje.WebApi.Entities
{
    //Tahakkuk Kurumu Belediye / kurum
    public class TahakkukInstitution : BaseEntity
    {        
        [Required]
        [MaxLength(250)]
        public string name { get; set; } = string.Empty;

        //[MaxLength(50)]
        //public string code { get; set; } = string.Empty;

        //public string description { get; set; } = string.Empty ;

        //public ICollection<TahakkukDepartment>? departments { get; set; }

        //public ICollection<TahakkukDirectorate>? directorates { get; set; }
    }
}
