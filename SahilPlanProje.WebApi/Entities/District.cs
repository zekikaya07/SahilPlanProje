using System.ComponentModel.DataAnnotations.Schema;

namespace SahilPlanProje.WebApi.Entities
{
    public class District : BaseEntity
    {

        public int city_id { get; set; }

        // Örn: 07001
        public string code { get; set; } = string.Empty;

        // İl içindeki sıra numarası
        public short district_no { get; set; }

        public string name { get; set; } = string.Empty;

        public bool is_central { get; set; }
        public int district_group_no { get; set; } = 1;

        // Navigation Property
        [ForeignKey(nameof(city_id))]
        public City city { get; set; }
    }
}