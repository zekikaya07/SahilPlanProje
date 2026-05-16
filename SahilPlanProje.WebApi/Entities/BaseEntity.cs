namespace SahilPlanProje.WebApi.Entities
{
    public class BaseEntity
    {
        public int id { get; set; }

        public bool is_active { get; set; } = true;

        public DateTime create_date { get; set; } = DateTime.Now;
    }
}
