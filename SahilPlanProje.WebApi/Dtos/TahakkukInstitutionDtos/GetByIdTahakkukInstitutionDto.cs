namespace SahilPlanProje.WebApi.Dtos.TahakkukInstitutionDtos
{
    public class GetByIdTahakkukInstitutionDto
    {
        public int id { get; set; }
        // Plaka kodu -> 07
        public bool is_active { get; set; }
        public string name { get; set; } = string.Empty;
    }
}
