namespace SahilPlanProje.WebApi.Dtos.TahakkukFeeSubjectDtos
{
    public class GetByIdTahakkukFeeSubjectDto
    {
        public int id { get; set; }
        // Plaka kodu -> 07
        public bool is_active { get; set; }
        public string name { get; set; } = string.Empty;
    }
}
