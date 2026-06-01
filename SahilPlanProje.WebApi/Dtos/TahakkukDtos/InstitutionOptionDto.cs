using SahilPlanProje.WebApi.Enums;

namespace SahilPlanProje.WebApi.Dtos.TahakkukDtos
{
    public class InstitutionOptionDto
    {
        public int id { get; set; }

        public string name { get; set; } = string.Empty; 
        public InstitutionType institution_type { get; set; }
    }
}
