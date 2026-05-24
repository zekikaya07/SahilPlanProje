using System.ComponentModel.DataAnnotations.Schema;

namespace SahilPlanProje.WebApi.Entities
{
    //Tahakkuk Yılı 2025, 2026 gibi
    public class TahakkukYear : BaseEntity
    {
        public int year { get; set; }

    }
}
