using System.ComponentModel.DataAnnotations.Schema;

namespace SahilPlanProje.WebApi.Entities
{
    //Ücret Alt Konusu    Konunun alt kırılımı
    public class TahakkukFeeSubSubject : BaseEntity
    {

        public int tahakkuk_fee_subject_id { get; set; }

        public string name { get; set; }


        [ForeignKey(nameof(tahakkuk_fee_subject_id))]
        public TahakkukFeeSubject tahakkuk_fee_subject { get; set; }
    }
}
