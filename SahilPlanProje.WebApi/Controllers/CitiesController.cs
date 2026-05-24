using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SahilPlanProje.WebApi.Context;
using SahilPlanProje.WebApi.Dtos.CityDtos;
using SahilPlanProje.WebApi.Entities;

namespace SahilPlanProje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;

        public CitiesController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetCityList()
        {
            var values = _context.Cities.ToList();
            return Ok(_mapper.Map<List<ResultCityDto>>(values));
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var value = _context.Cities.Find(id);
            return Ok(_mapper.Map<GetByIdCityDto>(value));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCity([FromBody] CreateCityDto city)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var value = _mapper.Map<City>(city);

            await _context.Cities.AddAsync(value);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                message = "İl başarıyla eklendi.",
                data = _mapper.Map<ResultCityDto>(value)
            });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCity(int id, [FromBody] UpdateCityDto city)
        {
            if (id != city.id)
                return BadRequest("Id uyuşmuyor.");

            var existingCity = await _context.Cities.FindAsync(id);

            if (existingCity == null)
                return NotFound("Kayıt bulunamadı.");

            _mapper.Map(city, existingCity);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                message = "Kayıt güncellendi."
            });
        }


        // DELETE

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCity(int id)
        {
            var city = await _context.Cities.FindAsync(id);

            if (city == null)
                return NotFound("Kayıt bulunamadı.");

            _context.Cities.Remove(city);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                message = "Kayıt silindi."
            });
        }

        [HttpGet("getinfo")]
        public IActionResult GetInfo()
        {
            return Ok("Sistem API Servisi Çalışıyor");
        }
    }
}