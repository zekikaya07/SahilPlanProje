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
    public class TahakkukDefinitionsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiContext _context;

        public TahakkukDefinitionsController(IMapper mapper, ApiContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetTahakkukDefinitionList()
        {
            try
            {
                var values = await _context.TahakkukDefinitions
                .Include(x => x.city)
                .Include(x => x.district)
                .Include(x => x.tahakkuk_year)
                .Include(x => x.tahakkuk_institution)
                .Include(x => x.tahakkuk_fee_subject)
                .Include(x => x.tahakkuk_fee_sub_subject)
                .Include(x => x.tahakkuk_scale)
                .Include(x => x.tahakkuk_department)
                .Include(x => x.tahakkuk_directorate)
                .ToListAsync();
                return Ok(_mapper.Map<List<ResultTahakkukDefinitionDto>>(values));

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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTahakkukDefinition(int id)
        {
            var value = await _context.TahakkukDefinitions
                .Include(x => x.city)
                .Include(x => x.district)
                .Include(x => x.tahakkuk_year)
                .Include(x => x.tahakkuk_institution)
                .Include(x => x.tahakkuk_fee_subject)
                .Include(x => x.tahakkuk_fee_sub_subject)
                .Include(x => x.tahakkuk_scale)
                .Include(x => x.tahakkuk_department)
                .Include(x => x.tahakkuk_directorate)
                .FirstOrDefaultAsync(x => x.id == id);

            if (value == null)
                return NotFound("Kayıt bulunamadı.");

            return Ok(_mapper.Map<GetByIdTahakkukDefinitionDto>(value));
        }

        [HttpPost]
        public async Task<IActionResult> CreateTahakkukDefinition([FromBody] CreateTahakkukDefinitionDto dto)
        {
            try
            {
                var value = _mapper.Map<TahakkukDefinition>(dto);

                _context.TahakkukDefinitions.Add(value);
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
        public async Task<IActionResult> UpdateTahakkukDefinition(int id, [FromBody] UpdateTahakkukDefinitionDto dto)
        {
            if (id != dto.id)
                return BadRequest("Id uyuşmuyor.");

            var existingValue = await _context.TahakkukDefinitions.FindAsync(id);

            if (existingValue == null)
                return NotFound("Kayıt bulunamadı.");

            _mapper.Map(dto, existingValue);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                message = "Kayıt güncellendi."
            });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTahakkukDefinition(int id)
        {
            var value = await _context.TahakkukDefinitions.FindAsync(id);

            if (value == null)
                return NotFound("Kayıt bulunamadı.");

            _context.TahakkukDefinitions.Remove(value);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                message = "Kayıt silindi."
            });
        }



    }
}