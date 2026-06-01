using SahilPlanProje.WebApi.Dtos.CityDtos;

namespace SahilPlanProje.WebApi.Dtos.DistrictDtos
{
    public class GetByIdDistrictDto
    {
        public bool is_active { get; set; }
        public int id { get; set; }
        public int city_id { get; set; }
        public GetByIdCityDto city { get; set; }

        // Örn: 07001
        public string code { get; set; }

        // İl içindeki sıra numarası
        public short district_no { get; set; }
        public int district_group_no { get; set; } = 1;

        public string name { get; set; }

        public bool is_central { get; set; }
    }
}
