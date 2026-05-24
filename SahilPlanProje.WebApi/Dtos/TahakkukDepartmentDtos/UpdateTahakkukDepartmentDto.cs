namespace SahilPlanProje.WebApi.Dtos.TahakkukDepartmentDtos
{
    public class UpdateTahakkukDepartmentDto
    {
        public int id { get; set; }
        public bool is_active { get; set; }

        public int tahakkuk_institution_id { get; set; }

        public string name { get; set; } = string.Empty;
    }
}
