namespace SahilPlanProje.WebApi.Dtos.TahakkukScaleDtos
{
    public class GetByIdTahakkukScaleDto
    {
        public int id { get; set; }
        // Plaka kodu -> 07
        public bool is_active { get; set; }
        public string name { get; set; } = string.Empty;
    }
}
