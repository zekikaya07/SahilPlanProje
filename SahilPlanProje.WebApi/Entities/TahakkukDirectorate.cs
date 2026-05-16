using System.ComponentModel.DataAnnotations.Schema;

namespace SahilPlanProje.WebApi.Entities
{
    //Müdürlük Plan Proje Müdürlüğü vb
    public class TahakkukDirectorate : BaseEntity
    {

        public int tahakkuk_department_id { get; set; }

        public string name { get; set; }


        [ForeignKey(nameof(tahakkuk_department_id))]
        public TahakkukDepartment tahakkuk_department { get; set; }
    }
}
