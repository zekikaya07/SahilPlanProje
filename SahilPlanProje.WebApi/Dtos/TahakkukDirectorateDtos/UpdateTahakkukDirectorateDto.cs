namespace SahilPlanProje.WebApi.Dtos.TahakkukDirectorateDtos
{
    public class UpdateTahakkukDirectorateDto
    {
        public int id { get; set; }
        public bool is_active { get; set; }

        public int tahakkuk_institution_id { get; set; }
        public int? tahakkuk_department_id { get; set; }


        public string name { get; set; } = string.Empty;
    }
}
