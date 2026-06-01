using SahilPlanProje.WebApi.Dtos.CityDtos;
using SahilPlanProje.WebApi.Dtos.TahakkukDepartmentDtos;
using SahilPlanProje.WebApi.Dtos.TahakkukDirectorateDtos;
using SahilPlanProje.WebApi.Dtos.TahakkukFeeSubjectDtos;
using SahilPlanProje.WebApi.Dtos.TahakkukFeeSubSubjects;
using SahilPlanProje.WebApi.Dtos.TahakkukInstitutionDtos;
using SahilPlanProje.WebApi.Dtos.TahakkukScaleDtos;
using SahilPlanProje.WebApi.Dtos.TahakkukYearDtos;
using SahilPlanProje.WebApi.Entities;

namespace SahilPlanProje.WebApi.Dtos.DistrictDtos
{
    public class ResultTahakkukDefinitionDto
    {
        public int id { get; set; }
        public bool is_active { get; set; }
        public string description { get; set; } = string.Empty;
        public string description2 { get; set; } = string.Empty;
        // Sayısal ücret
        public decimal price { get; set; }
        public decimal? price2 { get; set; }
        public decimal? price3 { get; set; }
        public decimal? price4 { get; set; }
        public bool has_vat { get; set; }
        public int city_id { get; set; }
        public GetByIdCityDto city { get; set; }
        public int? district_id { get; set; }
        public GetByIdDistrictDto district { get; set; }
        public int tahakkuk_year_id { get; set; }
        public GetByIdTahakkukYearDto tahakkuk_year { get; set; }
        public int tahakkuk_institution_id { get; set; }
        public GetByIdTahakkukInstitutionDto tahakkuk_institution { get; set; }
        public int tahakkuk_fee_subject_id { get; set; }
        public GetByIdTahakkukFeeSubjectDto tahakkuk_fee_subject { get; set; }
        public int tahakkuk_fee_sub_subject_id { get; set; }
        public GetByIdTahakkukFeeSubSubjectDto tahakkuk_fee_sub_subject { get; set; }

        public int? tahakkuk_scale_id { get; set; }
        public GetByIdTahakkukScaleDto? tahakkuk_scale { get; set; }

        public int? tahakkuk_department_id { get; set; }
        public GetByIdTahakkukDepartmentDto? tahakkuk_department { get; set; }

        public int? tahakkuk_directorate_id { get; set; }
        public GetByIdTahakkukDirectorateDto? tahakkuk_directorate { get; set; }
    }
}
