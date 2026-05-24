using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SahilPlanProje.WebApi.Context;
using SahilPlanProje.WebApi.Dtos.MessageDtos;
using SahilPlanProje.WebApi.Entities;

namespace SahilPlanProje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiContext _apiContext;

        public MessageController(IMapper mapper, ApiContext apiContext)
        {
            _mapper = mapper;
            _apiContext = apiContext;
        }

        //[HttpGet]
        //public IActionResult Messages()
        //{
        //    var values = _apiContext.Messages.ToList();
        //    return Ok(_mapper.Map<List<ResultMessageDto>>(values));

        //}
        //[HttpPost]
        //public IActionResult CreateFeature(CreateMessageDto createFeatureDto)
        //{
        //    var value = _mapper.Map<Message>(createFeatureDto);
        //    _apiContext.Messages.Add(value);
        //    return Ok("Ekleme İşlemi Tamamlandı");

        //}

        //[HttpDelete]
        //public IActionResult DeleteFeature(int id) {
        //    var value = _apiContext.Messages.Find(id);
        //    _apiContext.Messages.Remove(value);
        //    return Ok("Silme İşlemi Tamamlandı");
        //}

        //[HttpGet("GetFeature")]
        //public IActionResult GetFeature(int id) {
        //    var value = _apiContext.Messages.Find(id);
        //    return Ok(_mapper.Map<GetByIdMessageDto>(value));
        //}

        //[HttpPut]
        //public IActionResult UpdateFeature(UpdateMessageDto updateFeatureDto)
        //{
        //    var value = _mapper.Map<Message>(updateFeatureDto);
        //    _apiContext.Messages.Update(value);
        //    return Ok("Güncelleme İşlemi Başarılı");
        //}
    }
}
