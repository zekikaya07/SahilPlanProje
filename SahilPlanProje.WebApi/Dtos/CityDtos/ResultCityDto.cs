namespace SahilPlanProje.WebApi.Dtos.CityDtos
{
    public class ResultCityDto
    {
        public int id { get; set; }
        public bool is_active { get; set; }
        public string code { get; set; } = string.Empty;

        // Sayısal plaka -> 7
        public string plate_code { get; set; } = string.Empty;

        public string name { get; set; } = string.Empty;

        // TR
        public string country_code { get; set; } = "TR";
    }
}
