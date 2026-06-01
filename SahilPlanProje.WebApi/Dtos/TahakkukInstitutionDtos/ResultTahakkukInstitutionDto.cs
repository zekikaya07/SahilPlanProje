using SahilPlanProje.WebApi.Enums;

namespace SahilPlanProje.WebApi.Dtos.TahakkukInstitutionDtos
{
    public class ResultTahakkukInstitutionDto
    {
        public int id { get; set; }
        public bool is_active { get; set; }
        public string name { get; set; } = string.Empty;
        public InstitutionType institution_type { get; set; } = InstitutionType.DistrictMunicipality;
    }
}
