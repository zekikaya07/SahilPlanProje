using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SahilPlanProje.WebApi.Entities
{
    // Tanımlar gibi,Ücret Tarifesi / Tahakkuk Ücreti Son ücret bilgisi
    public class TahakkukDefinition : BaseEntity
    {
        // Görünen ücret metni
        // Örn: 1540 TL + KDV
        [Required]

        public string description { get; set; } = string.Empty;
        public string description2 { get; set; } = string.Empty;
        // Sayısal ücret
        public decimal price { get; set; }

        // KDV dahil mi
        public bool has_vat { get; set; }

        public int city_id { get; set; }
        // Navigation Property
        [ForeignKey(nameof(city_id))]
        public City city { get; set; }

        public int district_id { get; set; }
        // Navigation Property
        [ForeignKey(nameof(district_id))]
        public District district { get; set; }

        public int tahakkuk_year_id { get; set; }
        // Navigation Property
        [ForeignKey(nameof(tahakkuk_year_id))]
        public TahakkukYear tahakkuk_year { get; set; }

        public int tahakkuk_institution_id { get; set; }
        // Navigation Property
        [ForeignKey(nameof(tahakkuk_institution_id))]
        public TahakkukInstitution tahakkuk_institution { get; set; }
        
        public int tahakkuk_fee_subject_id { get; set; }
        // Navigation Property
        [ForeignKey(nameof(tahakkuk_fee_subject_id))]
        public TahakkukFeeSubject tahakkuk_fee_subject { get; set; }

        public int tahakkuk_fee_sub_subject_id { get; set; }
        // Navigation Property
        [ForeignKey(nameof(tahakkuk_fee_sub_subject_id))]
        public TahakkukFeeSubSubject tahakkuk_fee_sub_subject { get; set; }


        // Opsiyonel (nullable)
        public int? tahakkuk_scale_id { get; set; }
        [ForeignKey(nameof(tahakkuk_scale_id))]
        public TahakkukScale? tahakkuk_scale { get; set; }


        // Opsiyonel (nullable)
        public int? tahakkuk_department_id { get; set; }

        [ForeignKey(nameof(tahakkuk_department_id))]
        public TahakkukDepartment? tahakkuk_department { get; set; }
        
        // Opsiyonel (nullable)
        public int? tahakkuk_directorate_id { get; set; }

        [ForeignKey(nameof(tahakkuk_directorate_id))]
        public TahakkukDirectorate? tahakkuk_directorate { get; set; }

    }
}
