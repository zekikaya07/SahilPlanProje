namespace SahilPlanProje.WebApi.Dtos.DistrictDtos
{
    public class CreateTahakkukDefinitionDto
    {
        public bool is_active { get; set; }
        /// <example>Açıklama 1</example>
        public string description { get; set; } = string.Empty;
        /// <example>Açıklama 2</example>
        public string description2 { get; set; } = string.Empty;
        
        // Sayısal ücret
        /// <example>1500</example>
        public decimal price { get; set; }
        public decimal? price2 { get; set; }
        public decimal? price3 { get; set; }
        public decimal? price4 { get; set; }
        public bool has_vat { get; set; }
        public int city_id { get; set; }
        public int? district_id { get; set; }
        public int tahakkuk_year_id { get; set; }
        public int tahakkuk_institution_id { get; set; }
        public int tahakkuk_fee_subject_id { get; set; }
        public int tahakkuk_fee_sub_subject_id { get; set; }
        public int? tahakkuk_scale_id { get; set; }
        public int? tahakkuk_department_id { get; set; }
        public int? tahakkuk_directorate_id { get; set; }

    }
}
