namespace SahilPlanProje.WebApi.Entities
{
    public class City : BaseEntity
    {

        // Plaka kodu -> 07
        public string code { get; set; }

        // Sayısal plaka -> 7
        public int plate_code { get; set; }

        public string name { get; set; }

        // TR
        public string country_code { get; set; }

        // Navigation Property
        public ICollection<District> districts { get; set; }
    }
}