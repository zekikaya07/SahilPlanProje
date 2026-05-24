namespace SahilPlanProje.WebApi.Dtos.TahakkukInstitutionDtos
{
    public class CreateTahakkukInstitutionDto
    {
        public bool is_active { get; set; }
        /// <example>Tahakkuk Kurumu</example>
        public string name { get; set; } = string.Empty;
    }
}
