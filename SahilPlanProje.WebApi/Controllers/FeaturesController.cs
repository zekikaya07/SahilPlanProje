 using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SahilPlanProje.WebApi.Context;
using SahilPlanProje.WebApi.Entities;

namespace SahilPlanProje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly ApiContext _context;
        public FeaturesController(ApiContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateFeature(Feature feature)
        {
            _context.Features.Add(feature);
            _context.SaveChanges();
            return Ok("Özellik EKleme İşlemi başarılı");
        }

        [HttpGet]
        public IActionResult GetFeatureList()
        {
            var values = _context.Features.ToList();
            return Ok(values);
        }

        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {
            var feature = _context.Features.Find(id);
            _context.Features.Remove(feature);
            _context.SaveChanges();
            return Ok("Silme İşlemi Başarılı");
        }

        [HttpGet("GetFeature")]
        public IActionResult GetFeature(int id)
        {
            var feature = _context.Features.Find(id);
            return Ok(feature);
        }

        [HttpPut]
        public IActionResult UpdateFeature(Feature feature)
        {
            _context.Features.Update(feature);
            _context.SaveChanges();
            return Ok("Özellik GÜncelleme başarılı");
        }

        [HttpGet("getinfo")]
        public IActionResult getInfo()
        {
            return Ok("Sistem APi Servis Çalışıyor");
        }

    }
}
