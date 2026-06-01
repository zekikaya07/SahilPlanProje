namespace SahilPlanProje.WebApi.Dtos.TahakkukFeeSubSubjects
{
    public class CreateTahakkukFeeSubSubjectDto
    {
        public int tahakkuk_fee_subject_id { get; set; }

        /// <example>Ücret Alt Konusu</example>
        public string name { get; set; }

        public bool is_central { get; set; }
    }
}
