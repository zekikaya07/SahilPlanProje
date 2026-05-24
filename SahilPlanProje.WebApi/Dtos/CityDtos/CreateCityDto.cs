namespace SahilPlanProje.WebApi.Dtos.CityDtos
{
    public class CreateCityDto
    {
        public bool is_active { get; set; } = true;


        /// <example>07ANT</example>
        public string code { get; set; } = string.Empty;

        // Sayısal plaka -> 7

        /// <example>07</example>
        public string plate_code { get; set; } = string.Empty;

        /// <example>ANTALYA</example>
        public string name { get; set; } = string.Empty;

        // TR
        /// <example>TR</example>
        public string country_code { get; set; } = string.Empty;
    }
}
