using System.ComponentModel.DataAnnotations.Schema;

namespace SahilPlanProje.WebApi.Entities
{
    // Tanımlar gibi,Ücret Tarifesi / Tahakkuk Ücreti Son ücret bilgisi
    public class TahakkukDefinition : BaseEntity
    {

        public int tahakkuk_fee_subject_id { get; set; }

        public int? tahakkuk_fee_sub_subject_id { get; set; }

        public string fee_text { get; set; }

        public decimal? fee_amount { get; set; }

        public bool has_vat { get; set; }

        public string description1 { get; set; }

        public string description2 { get; set; }


        [ForeignKey(nameof(tahakkuk_fee_subject_id))]
        public TahakkukFeeSubject tahakkuk_fee_subject { get; set; }

        [ForeignKey(nameof(tahakkuk_fee_sub_subject_id))]
        public TahakkukFeeSubSubject tahakkuk_fee_sub_subject { get; set; }
    }
}
