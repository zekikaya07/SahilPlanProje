using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SahilPlanProje.WebApi.Entities
{
    //Ücret Konusu İmar Durumu, Ruhsat vb
    public class TahakkukFeeSubject : BaseEntity
    {

        [Required]
        [MaxLength(250)]
        public string name { get; set; } = string.Empty;


    }
}
