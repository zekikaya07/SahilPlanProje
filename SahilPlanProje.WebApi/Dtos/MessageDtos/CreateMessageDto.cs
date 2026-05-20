namespace SahilPlanProje.WebApi.Dtos.MessageDtos
{
    public class CreateMessageDto
    {
        public string name_surname { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public string messahe_detail { get; set; }
        public DateTime send_date { get; set; }
        public bool is_read { get; set; }
    }
}
