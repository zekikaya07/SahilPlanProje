namespace SahilPlanProje.WebApi.Dtos.TahakkukDtos
{
    public class DirectorateOptionDto
    {
        public int id { get; set; }

        public int tahakkuk_institution_id { get; set; }

        public int? tahakkuk_department_id { get; set; }

        public string name { get; set; } = string.Empty;
    }
}
