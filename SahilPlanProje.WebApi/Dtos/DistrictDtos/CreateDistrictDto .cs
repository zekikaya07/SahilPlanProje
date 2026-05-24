namespace SahilPlanProje.WebApi.Dtos.DistrictDtos
{
    public class CreateDistrictDto
    {
        public int city_id { get; set; }

        // Örn: 07001
        /// <example>0701</example>
        public string code { get; set; }

        // İl içindeki sıra numarası
        /// <example>1</example>
        public short district_no { get; set; }

        /// <example>Alanya</example>
        public string name { get; set; }

        public bool is_central { get; set; }
    }
}
