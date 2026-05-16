using System.ComponentModel.DataAnnotations.Schema;

namespace SahilPlanProje.WebApi.Entities
{
    //Ücret Konusu İmar Durumu, Ruhsat vb
    public class TahakkukFeeSubject : BaseEntity
    {

        public int tahakkuk_directorate_id { get; set; }

        public int? tahakkuk_scale_id { get; set; }

        public string name { get; set; }


        [ForeignKey(nameof(tahakkuk_directorate_id))]
        public TahakkukDirectorate tahakkuk_directorate { get; set; }

        [ForeignKey(nameof(tahakkuk_scale_id))]
        public TahakkukScale tahakkuk_scale { get; set; }
    }
}
