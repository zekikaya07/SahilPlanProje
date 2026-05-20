using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SahilPlanProje.WebUI.Dtos;
using SahilPlanProje.WebUI.Dtos.ContactDtos;

namespace SahilPlanProje.WebUI.ViewComponents
{
    public class _TahakkukDefaultComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _TahakkukDefaultComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("https://api.sahilplanproje.com/api/Tahakkuk/filter-options");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();

                var settings = new JsonSerializerSettings
                {
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    NullValueHandling = NullValueHandling.Ignore
                };

                var values = JsonConvert.DeserializeObject<TahakkukFilterOptionsDto>(jsonData, settings);

                return View(values ?? new TahakkukFilterOptionsDto());
            }

            return View(new TahakkukFilterOptionsDto());
        }
    }
}
