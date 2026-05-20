 using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SahilPlanProje.WebApi.Context;
using SahilPlanProje.WebApi.Entities;

namespace SahilPlanProje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ApiContext _context;
        public CitiesController(ApiContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateFeature(City feature)
        {
            _context.Cities.Add(feature);
            _context.SaveChanges();
            return Ok("Özellik EKleme İşlemi başarılı");
        }

        [HttpGet]
        public IActionResult GetFeatureList()
        {
            var values = _context.Cities.ToList();
            return Ok(values);
        }

        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {
            var feature = _context.Cities.Find(id);
            _context.Cities.Remove(feature);
            _context.SaveChanges();
            return Ok("Silme İşlemi Başarılı");
        }

        [HttpGet("GetFeature")]
        public IActionResult GetFeature(int id)
        {
            var feature = _context.Cities.Find(id);
            return Ok(feature);
        }

        [HttpPut]
        public IActionResult UpdateFeature(City feature)
        {
            _context.Cities.Update(feature);
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
