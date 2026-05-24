namespace SahilPlanProje.WebApi.Dtos.DistrictDtos
{
    public class UpdateTahakkukDefinitionDto
    {
        public int id { get; set; }
        public bool is_active { get; set; }
        public string description { get; set; } = string.Empty;
        public string description2 { get; set; } = string.Empty;
        // Sayısal ücret
        public decimal price { get; set; }
        public bool has_vat { get; set; }
        public int city_id { get; set; }
        public int district_id { get; set; }
        public int tahakkuk_year_id { get; set; }
        public int tahakkuk_institution_id { get; set; }
        public int tahakkuk_fee_subject_id { get; set; }
        public int tahakkuk_fee_sub_subject_id { get; set; }
        public int? tahakkuk_scale_id { get; set; }
        public int? tahakkuk_department_id { get; set; }
        public int? tahakkuk_directorate_id { get; set; }
    }
}
