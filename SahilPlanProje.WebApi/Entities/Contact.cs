using System.Security.Principal;

namespace SahilPlanProje.WebApi.Entities
{
    public class Contact
    {
        public int id { get; set; }
        public string map_location { get; set; }
        public string adress { get; set; }
        public string phone {  get; set; }
        public string email { get; set; }
        public string open_hours { get; set; }
    }
}
