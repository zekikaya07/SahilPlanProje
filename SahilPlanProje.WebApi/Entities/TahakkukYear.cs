using System.ComponentModel.DataAnnotations.Schema;

namespace SahilPlanProje.WebApi.Entities
{
    //Tahakkuk Yılı 2025, 2026 gibi
    public class TahakkukYear : BaseEntity
    {
        public int district_id { get; set; }

        public int year { get; set; }


        [ForeignKey(nameof(district_id))]
        public District district { get; set; }
    }
}
