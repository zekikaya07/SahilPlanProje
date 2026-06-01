using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SahilPlanProje.WebApi.Context;
using SahilPlanProje.WebApi.Dtos.TahakkukDirectorateDtos;
using SahilPlanProje.WebApi.Entities;

namespace SahilPlanProje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TahakkukDirectoratesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiContext _context;

        public TahakkukDirectoratesController(IMapper mapper, ApiContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetDistrictList()
        {
            //var values = await _context.Districts.ToListAsync();
            var values = await _context.TahakkukDirectorates
                        .Include(x => x.tahakkuk_institution)
                        .Include(x => x.tahakkuk_department)
                        .ToListAsync();

            return Ok(_mapper.Map<List<ResultTahakkukDirectorateDto>>(values));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDistrict(int id)
        {

            var district = await _context.TahakkukDirectorates
                .Include(x => x.tahakkuk_institution)
                .Include(x => x.tahakkuk_department)
                .FirstOrDefaultAsync(x => x.id == id);


            if (district == null)
                return NotFound("Kayıt bulunamadı.");

            return Ok(_mapper.Map<GetByIdTahakkukDirectorateDto>(district));
   
        }

        [HttpPost]
        public async Task<IActionResult> CreateDistrict([FromBody] CreateTahakkukDirectorateDto districtDto)
        {
            try
            {
                var value = _mapper.Map<TahakkukDirectorate>(districtDto);

                _context.TahakkukDirectorates.Add(value);
                await _context.SaveChangesAsync();

                return Ok(new
                {
                    success = true,
                    message = "Kayıt başarıyla eklendi.",
                    data = value
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    success = false,
                    message = ex.Message,
                    innerMessage = ex.InnerException?.Message
                });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDistrict(int id, [FromBody] UpdateTahakkukDirectorateDto city)
        {
            if (id != city.id)
                return BadRequest("Id uyuşmuyor.");

            var existingCity = await _context.TahakkukDirectorates.FindAsync(id);

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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDistrict(int id)
        {
            var city = await _context.TahakkukDirectorates.FindAsync(id);

            if (city == null)
                return NotFound("Kayıt bulunamadı.");

            _context.TahakkukDirectorates.Remove(city);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                message = "Kayıt silindi."
            });
        }

        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateDistrict(int id, [FromBody] UpdateDistrictDto districtDto)
        //{
        //    if (id != districtDto.id)
        //        return BadRequest("Id uyuşmuyor.");

        //    var existingDistrict = await _context.Districts.FindAsync(id);

        //    if (existingDistrict == null)
        //        return NotFound("Kayıt bulunamadı.");

        //    existingDistrict.city_id = districtDto.city_id;
        //    existingDistrict.code = districtDto.code;
        //    existingDistrict.district_no = districtDto.district_no;
        //    existingDistrict.name = districtDto.name;
        //    existingDistrict.is_central = districtDto.is_central;
        //    existingDistrict.is_active = districtDto.is_active;

        //    await _context.SaveChangesAsync();

        //    return Ok(new
        //    {
        //        success = true,
        //        message = "İlçe güncellendi."
        //    });
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteDistrict(int id)
        //{
        //    var district = await _context.Districts.FindAsync(id);

        //    if (district == null)
        //        return NotFound("Kayıt bulunamadı.");

        //    _context.Districts.Remove(district);
        //    await _context.SaveChangesAsync();

        //    return Ok(new
        //    {
        //        success = true,
        //        message = "İlçe silindi."
        //    });
        //}

        //[HttpGet("getinfo")]
        //public IActionResult GetInfo()
        //{
        //    return Ok("Sistem API Servisi Çalışıyor");
        //}
    }
}