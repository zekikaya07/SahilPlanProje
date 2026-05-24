using SahilPlanProje.WebApi.Dtos.CityDtos;
using SahilPlanProje.WebApi.Dtos.TahakkukFeeSubjectDtos;

namespace SahilPlanProje.WebApi.Dtos.DistrictDtos
{
    public class GetByIdTahakkukFeeSubSubjectDto
    {
        public bool is_active { get; set; }
        public int id { get; set; }
        public int tahakkuk_fee_subject_id { get; set; }
        public GetByIdTahakkukFeeSubjectDto tahakkuk_fee_subject { get; set; }

        // Örn: 07001
        public string code { get; set; }

        // İl içindeki sıra numarası
        public short district_no { get; set; }

        public string name { get; set; }

        public bool is_central { get; set; }
    }
}
