namespace SahilPlanProje.WebApi.Dtos.TahakkukDtos
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
}
