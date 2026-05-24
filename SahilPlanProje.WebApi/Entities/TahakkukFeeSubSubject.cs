using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SahilPlanProje.WebApi.Entities
{
    //Ücret Alt Konusu    Konunun alt kırılımı
    public class TahakkukFeeSubSubject : BaseEntity
    {
        
        [Required]
        public int tahakkuk_fee_subject_id { get; set; }

        [Required]
        [MaxLength(250)]
        public string name { get; set; } = string.Empty;


        [ForeignKey(nameof(tahakkuk_fee_subject_id))]
        public TahakkukFeeSubject? tahakkuk_fee_subject { get; set; }
    }
}
