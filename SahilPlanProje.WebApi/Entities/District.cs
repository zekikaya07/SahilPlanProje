using System.ComponentModel.DataAnnotations.Schema;

namespace SahilPlanProje.WebApi.Entities
{
    public class District : BaseEntity
    {

        public int city_id { get; set; }

        // Örn: 07001
        public string code { get; set; }

        // İl içindeki sıra numarası
        public short district_no { get; set; }

        public string name { get; set; }

        public bool is_central { get; set; }


        // Navigation Property
        [ForeignKey(nameof(city_id))]
        public City city { get; set; }
    }
}