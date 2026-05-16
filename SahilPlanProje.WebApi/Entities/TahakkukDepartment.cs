using System.ComponentModel.DataAnnotations.Schema;

namespace SahilPlanProje.WebApi.Entities
{
    //Daire Başkanlığı  İmar Dairesi vb
    public class TahakkukDepartment : BaseEntity
    {

        public int tahakkuk_institution_id { get; set; }

        public string name { get; set; }


        [ForeignKey(nameof(tahakkuk_institution_id))]
        public TahakkukInstitution tahakkuk_institution { get; set; }
    }
}
