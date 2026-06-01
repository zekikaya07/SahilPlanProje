using SahilPlanProje.WebApi.Enums;
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

        [Required]
        public InstitutionType institution_type { get; set; }= InstitutionType.DistrictMunicipality;
    }
}
