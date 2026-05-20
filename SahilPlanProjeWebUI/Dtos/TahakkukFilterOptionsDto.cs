namespace SahilPlanProje.WebUI.Dtos
{
    public class TahakkukFilterOptionsDto
    {
        public List<CityOptionDto> cities { get; set; } = new();
        public List<DistrictOptionDto> districts { get; set; } = new();
        public List<YearOptionDto> years { get; set; } = new();
        public List<InstitutionOptionDto> institutions { get; set; } = new();
        public List<DepartmentOptionDto> departments { get; set; } = new();
        public List<DirectorateOptionDto> directorates { get; set; } = new();
        public List<ScaleOptionDto> scales { get; set; } = new();
        public List<FeeSubjectOptionDto> fee_subjects { get; set; } = new();
        public List<FeeSubSubjectOptionDto> fee_sub_subjects { get; set; } = new();
    }

    public class CityOptionDto
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class DistrictOptionDto
    {
        public int id { get; set; }
        public int city_id { get; set; }
        public string name { get; set; }
    }

    public class YearOptionDto
    {
        public int id { get; set; }
        public int district_id { get; set; }
        public int year { get; set; }
    }

    public class InstitutionOptionDto
    {
        public int id { get; set; }
        public int tahakkuk_year_id { get; set; }
        public string name { get; set; }
    }

    public class DepartmentOptionDto
    {
        public int id { get; set; }
        public int tahakkuk_institution_id { get; set; }
        public string name { get; set; }
    }

    public class DirectorateOptionDto
    {
        public int id { get; set; }
        public int tahakkuk_department_id { get; set; }
        public string name { get; set; }
    }

    public class ScaleOptionDto
    {
        public int id { get; set; }
        public int tahakkuk_directorate_id { get; set; }
        public decimal scale_value { get; set; }
        public string name { get; set; }
    }

    public class FeeSubjectOptionDto
    {
        public int id { get; set; }
        public int tahakkuk_directorate_id { get; set; }
        public int tahakkuk_scale_id { get; set; }
        public string name { get; set; }
    }

    public class FeeSubSubjectOptionDto
    {
        public int id { get; set; }
        public int tahakkuk_fee_subject_id { get; set; }
        public string name { get; set; }
    }
}
