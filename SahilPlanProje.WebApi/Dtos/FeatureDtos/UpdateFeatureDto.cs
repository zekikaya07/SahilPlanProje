namespace SahilPlanProje.WebApi.Dtos.FeatureDtos
{
    public class UpdateFeatureDto
    {
        public int id { get; set; }
        public string title { get; set; }
        public string sub_title { get; set; }
        public string description { get; set; }
        public string video_url { get; set; }
        public string image_url { get; set; }
    }
}
