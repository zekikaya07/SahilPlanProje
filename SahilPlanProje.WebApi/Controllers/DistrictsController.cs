using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SahilPlanProje.WebApi.Context;
using SahilPlanProje.WebApi.Dtos.DistrictDtos;
using SahilPlanProje.WebApi.Entities;

namespace SahilPlanProje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiContext _context;

        public DistrictsController(IMapper mapper, ApiContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetDistrictList()
        {
            //var values = await _context.Districts.ToListAsync();
            var values = await _context.Districts
                        .Include(x => x.city)
                        .ToListAsync();

            return Ok(_mapper.Map<List<ResultDistrictDto>>(values));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDistrict(int id)
        {

            var district = await _context.Districts
                .Include(x => x.city)
                .FirstOrDefaultAsync(x => x.id == id);


            if (district == null)
                return NotFound("Kayıt bulunamadı.");

            return Ok(_mapper.Map<GetByIdDistrictDto>(district));
   
        }

        [HttpPost]
        public async Task<IActionResult> CreateDistrict([FromBody] CreateDistrictDto districtDto)
        {
            var value = _mapper.Map<District>(districtDto);

            _context.Districts.Add(value);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                message = "Kayıt başarıyla eklendi.",
                data = value
            });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDistrict(int id, [FromBody] UpdateDistrictDto city)
        {
            if (id != city.id)
                return BadRequest("Id uyuşmuyor.");

            var existingCity = await _context.Districts.FindAsync(id);

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
            var city = await _context.Districts.FindAsync(id);

            if (city == null)
                return NotFound("Kayıt bulunamadı.");

            var hasSubSubject = await _context.TahakkukDefinitions
                    .AnyAsync(x => x.district_id == id);

            if (hasSubSubject)
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Bu ilçe tahakkuk tanımlarında işlem görmüş / bağlantılı kayıt içerdiği için silinemez."
                });
            }

            _context.Districts.Remove(city);

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