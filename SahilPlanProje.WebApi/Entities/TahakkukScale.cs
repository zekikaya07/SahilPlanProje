using System.ComponentModel.DataAnnotations.Schema;

namespace SahilPlanProje.WebApi.Entities
{
    //Ölçek 1/1000, 1/5000 vb
    public class TahakkukScale : BaseEntity
    {

        public int tahakkuk_directorate_id { get; set; }

        public int? scale_value { get; set; }

        public string name { get; set; }


        [ForeignKey(nameof(tahakkuk_directorate_id))]
        public TahakkukDirectorate tahakkuk_directorate { get; set; }
    }
}
