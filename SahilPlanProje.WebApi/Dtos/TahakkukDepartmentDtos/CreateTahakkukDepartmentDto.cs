
namespace SahilPlanProje.WebApi.Dtos.TahakkukDepartmentDtos
{
    public class CreateTahakkukDepartmentDto
    {
        public bool is_active { get; set; }

        public int tahakkuk_institution_id { get; set; }

        /// <example>Daire Başkanlığı</example>
        public string name { get; set; } = string.Empty;

    }
}
