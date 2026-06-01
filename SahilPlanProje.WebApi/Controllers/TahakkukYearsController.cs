using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SahilPlanProje.WebApi.Context;
using SahilPlanProje.WebApi.Dtos.TahakkukYearDtos;
using SahilPlanProje.WebApi.Entities;

namespace SahilPlanProje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TahakkukYearsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;

        public TahakkukYearsController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult GeTahakkukList()
        {
            var values = _context.TahakkukYears.ToList();
            return Ok(_mapper.Map<List<ResultTahakkukYearDto>>(values));
        }

        [HttpGet("{id}")]
        public IActionResult GetTahakkuk(int id)
        {
            var value = _context.TahakkukYears.Find(id);
            return Ok(_mapper.Map<GetByIdTahakkukYearDto>(value));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCity([FromBody] CreateTahakkukYearDto city)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var value = _mapper.Map<TahakkukYear>(city);

            await _context.TahakkukYears.AddAsync(value);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                message = "İl başarıyla eklendi.",
                data = _mapper.Map<ResultTahakkukYearDto>(value)
            });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCity(int id, [FromBody] UpdateTahakkukYearDto city)
        {
            if (id != city.id)
                return BadRequest("Id uyuşmuyor.");

            var existingCity = await _context.TahakkukYears.FindAsync(id);

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
            var city = await _context.TahakkukYears.FindAsync(id);

            if (city == null)
                return NotFound("Kayıt bulunamadı.");

            _context.TahakkukYears.Remove(city);

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

        //// LIST
        //[HttpGet]
        //public async Task<IActionResult> GetTahakkukYearList()
        //{
        //    var values = await _context.TahakkukYears.ToListAsync();

        //    return Ok(values);
        //}

        //// DETAIL
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetTahakkukYear(int id)
        //{
        //    var city = await _context.TahakkukYears.FindAsync(id);

        //    if (city == null)
        //        return NotFound("Kayıt bulunamadı.");

        //    return Ok(city);
        //}

        //// CREATE
        //[HttpPost]
        //public async Task<IActionResult> CreateTahakkukYear([FromBody] TahakkukYear city)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    _context.TahakkukYears.Add(city);

        //    await _context.SaveChangesAsync();

        //    return Ok(new
        //    {
        //        success = true,
        //        message = "İl başarıyla eklendi.",
        //        data = city
        //    });
        //}

        //// UPDATE
        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateTahakkukYear(int id, [FromBody] TahakkukYear city)
        //{
        //    if (id != city.id)
        //        return BadRequest("Id uyuşmuyor.");

        //    var existingCity = await _context.TahakkukYears.FindAsync(id);

        //    if (existingCity == null)
        //        return NotFound("Kayıt bulunamadı.");

        //    existingCity.year = city.year;
        //    existingCity.is_active = city.is_active;

        //    await _context.SaveChangesAsync();

        //    return Ok(new
        //    {
        //        success = true,
        //        message = "Kayıt güncellendi."
        //    });
        //}

        //// DELETE
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteTahakkukYear(int id)
        //{
        //    var city = await _context.TahakkukYears.FindAsync(id);

        //    if (city == null)
        //        return NotFound("Kayıt bulunamadı.");

        //    _context.TahakkukYears.Remove(city);

        //    await _context.SaveChangesAsync();

        //    return Ok(new
        //    {
        //        success = true,
        //        message = "Kayıt silindi."
        //    });
        //}

        //[HttpGet("getinfo")]
        //public IActionResult GetInfo()
        //{
        //    return Ok("Sistem API Servisi Çalışıyor");
        //}
    }
}