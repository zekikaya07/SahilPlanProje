using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SahilPlanProje.WebApi.Context;

namespace SahilPlanProje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureMapperController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiContext _apiContext;

        public FeatureMapperController(IMapper mapper, ApiContext apiContext)
        {
            _mapper = mapper;
            _apiContext = apiContext;
        }

        //[HttpGet]
        //public IActionResult Features()
        //{
        //    var values = _apiContext.Features.ToList();
        //    return Ok(_mapper.Map<List<ResultFeatureDto>>(values));

        //}
        //[HttpPost]
        //public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        //{
        //    var value = _mapper.Map<Feature>(createFeatureDto);
        //    _apiContext.Features.Add(value);
        //    return Ok("Ekleme İşlemi Tamamlandı");

        //}

        //[HttpDelete]
        //public IActionResult DeleteFeature(int id) {
        //    var value = _apiContext.Features.Find(id);
        //    _apiContext.Features.Remove(value);
        //    return Ok("Silme İşlemi Tamamlandı");
        //}

        //[HttpGet("GetFeature")]
        //public IActionResult GetFeature(int id) {
        //    var value = _apiContext.Features.Find(id);
        //    return Ok(_mapper.Map<GetByIdFeatureDto>(value));
        //}

        //[HttpPut]
        //public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        //{
        //    var value = _mapper.Map<Feature>(updateFeatureDto);
        //    _apiContext.Features.Update(value);
        //    return Ok("Güncelleme İşlemi Başarılı");
        //}
    }
}
