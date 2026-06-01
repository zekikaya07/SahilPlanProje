using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SahilPlanProje.WebApi.Context;
using SahilPlanProje.WebApi.Dtos.TahakkukDepartmentDtos;
using SahilPlanProje.WebApi.Entities;

namespace SahilPlanProje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TahakkukDepartmentsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiContext _context;

        public TahakkukDepartmentsController(IMapper mapper, ApiContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetTahakkukDepartmentList()
        {
            //var values = await _context.Districts.ToListAsync();
            var values = await _context.TahakkukDepartments
                        .Include(x => x.tahakkuk_institution)
                        .ToListAsync();

            return Ok(_mapper.Map<List<ResultTahakkukDepartmentDto>>(values));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTahakkukDepartment(int id)
        {

            var district = await _context.TahakkukDepartments
                .Include(x => x.tahakkuk_institution)
                        .Include(x => x.tahakkuk_institution)
                .FirstOrDefaultAsync(x => x.id == id);


            if (district == null)
                return NotFound("Kayıt bulunamadı.");

            return Ok(_mapper.Map<GetByIdTahakkukDepartmentDto>(district));
   
        }

        [HttpPost]
        public async Task<IActionResult> CreateTahakkukDepartment([FromBody] CreateTahakkukDepartmentDto districtDto)
        {
            try
            {
                var value = _mapper.Map<TahakkukDepartment>(districtDto);

                _context.TahakkukDepartments.Add(value);
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
        public async Task<IActionResult> UpdateTahakkukDepartment(int id, [FromBody] UpdateTahakkukDepartmentDto city)
        {
            if (id != city.id)
                return BadRequest("Id uyuşmuyor.");

            var existingCity = await _context.TahakkukDepartments.FindAsync(id);

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
        public async Task<IActionResult> DeleteTahakkukDepartment(int id)
        {
            var city = await _context.TahakkukDepartments.FindAsync(id);

            if (city == null)
                return NotFound("Kayıt bulunamadı.");


            var hasSubSubject = await _context.TahakkukDirectorates
                                .AnyAsync(x => x.tahakkuk_department_id == id);

            if (hasSubSubject)
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Bu Daire Başkanlığı işlem görmüş / bağlantılı kayıt içerdiği için silinemez."
                });
            }



            _context.TahakkukDepartments.Remove(city);

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