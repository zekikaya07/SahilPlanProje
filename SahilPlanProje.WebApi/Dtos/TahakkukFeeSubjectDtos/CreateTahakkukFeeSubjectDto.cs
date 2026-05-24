namespace SahilPlanProje.WebApi.Dtos.TahakkukFeeSubjectDtos
{
    public class CreateTahakkukFeeSubjectDto
    {
        public bool is_active { get; set; }
        /// <example>Ücret Konusu</example>
        public string name { get; set; } = string.Empty;
    }
}
