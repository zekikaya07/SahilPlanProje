using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SahilPlanProje.WebApi.Entities
{
    //Ölçek 1/1000, 1/5000 vb
    public class TahakkukScale : BaseEntity
    {

        [Required]
        [MaxLength(250)]
        public string name { get; set; } = string.Empty;
    }
}
