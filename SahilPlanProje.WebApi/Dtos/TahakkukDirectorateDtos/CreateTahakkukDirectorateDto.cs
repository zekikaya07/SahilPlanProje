
namespace SahilPlanProje.WebApi.Dtos.TahakkukDirectorateDtos
{
    public class CreateTahakkukDirectorateDto
    {
        public bool is_active { get; set; }

        public int tahakkuk_institution_id { get; set; }
        public int? tahakkuk_department_id { get; set; }


        /// <example>Müdürlük</example>
        public string name { get; set; } = string.Empty;

    }
}
