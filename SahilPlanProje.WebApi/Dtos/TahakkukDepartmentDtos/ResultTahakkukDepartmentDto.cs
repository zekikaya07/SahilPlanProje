
using SahilPlanProje.WebApi.Dtos.TahakkukInstitutionDtos;
using SahilPlanProje.WebApi.Entities;

namespace SahilPlanProje.WebApi.Dtos.TahakkukDepartmentDtos
{
    public class ResultTahakkukDepartmentDto
    {
        public bool is_active { get; set; }
        public int id { get; set; }
        public int tahakkuk_institution_id { get; set; }
        public GetByIdTahakkukInstitutionDto tahakkuk_institution { get; set; }


        public string name { get; set; } = string.Empty;
    }
}
