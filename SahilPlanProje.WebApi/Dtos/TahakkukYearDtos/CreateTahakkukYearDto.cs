namespace SahilPlanProje.WebApi.Dtos.TahakkukYearDtos
{
    public class CreateTahakkukYearDto
    {
        public bool is_active { get; set; }

        /// <example>2026</example>
        public int year { get; set; }
    }
}
