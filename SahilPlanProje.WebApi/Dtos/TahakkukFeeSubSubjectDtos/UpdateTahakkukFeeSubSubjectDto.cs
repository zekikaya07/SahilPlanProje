namespace SahilPlanProje.WebApi.Dtos.DistrictDtos
{
    public class UpdateTahakkukFeeSubSubjectDto
    {
        public bool is_active {  get; set; }
        public int id { get; set; }
        public int tahakkuk_fee_subject_id { get; set; }
        public string name { get; set; }

        public bool is_central { get; set; }
    }
}
