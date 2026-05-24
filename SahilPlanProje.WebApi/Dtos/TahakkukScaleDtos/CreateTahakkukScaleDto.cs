namespace SahilPlanProje.WebApi.Dtos.TahakkukScaleDtos
{
    public class CreateTahakkukScaleDto
    {
        public bool is_active { get; set; }
        /// <example>1/1000</example>
        public string name { get; set; } = string.Empty;
    }
}
