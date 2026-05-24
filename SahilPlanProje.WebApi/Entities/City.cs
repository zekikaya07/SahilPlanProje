
using System.ComponentModel.DataAnnotations;

namespace SahilPlanProje.WebApi.Entities
{
    public class City : BaseEntity
    {

        // Plaka kodu -> 07
        [MaxLength(10)]
        public string code { get; set; } = string.Empty;

        // Sayısal plaka -> 7
        [MaxLength(10)]
        public string plate_code { get; set; } = string.Empty;

        [MaxLength(100)]
        public string name { get; set; } = string.Empty;

        // TR
        [MaxLength(5)]
        public string country_code { get; set; } = "TR";

        // Navigation Property
        public ICollection<District> districts { get; set; }
    }
}