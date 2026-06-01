using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;using Microsoft.EntityFrameworkCore;
using SahilPlanProje.WebApi.Context;
using SahilPlanProje.WebApi.Dtos.TahakkukDtos;

namespace SahilPlanProje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TahakkukController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;

        public TahakkukController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("filter-options")]
        public async Task<IActionResult> GetFilterOptions()
        {
            var result = new TahakkukFilterOptionsDto
            {
                cities = await _context.Cities
                    .Where(x => x.is_active)
                    .OrderBy(x => x.name)
                    .Select(x => new CityOptionDto
                    {
                        id = x.id,
                        name = x.name
                    })
                    .ToListAsync(),

                districts = await _context.Districts
                    .Where(x => x.is_active)
                    .OrderBy(x => x.name)
                    .Select(x => new DistrictOptionDto
                    {
                        id = x.id,
                        city_id = x.city_id,
                        name = x.name
                    })
                    .ToListAsync(),

                years = await _context.TahakkukYears
                    .Where(x => x.is_active)
                    .OrderByDescending(x => x.year)
                    .Select(x => new YearOptionDto
                    {
                        id = x.id,
                        year = x.year
                    })
                    .ToListAsync(),

                institutions = await _context.TahakkukInstitutions
                    .Where(x => x.is_active)
                    .OrderBy(x => x.name)
                    .Select(x => new InstitutionOptionDto
                    {
                        id = x.id,
                        name = x.name,
                        institution_type = x.institution_type
                    })
                    .ToListAsync(),

                departments = await _context.TahakkukDepartments
                    .Where(x => x.is_active)
                    .OrderBy(x => x.name)
                    .Select(x => new DepartmentOptionDto
                    {
                        id = x.id,
                        tahakkuk_institution_id = x.tahakkuk_institution_id,
                        name = x.name
                    })
                    .ToListAsync(),

                directorates = await _context.TahakkukDirectorates
                    .Where(x => x.is_active)
                    .OrderBy(x => x.name)
                    .Select(x => new DirectorateOptionDto
                    {
                        id = x.id,
                        tahakkuk_institution_id = x.tahakkuk_institution_id,
                        tahakkuk_department_id = x.tahakkuk_department_id,
                        name = x.name
                    })
                    .ToListAsync(),

                scales = await _context.TahakkukScales
                    .Where(x => x.is_active)
                    .OrderBy(x => x.name)
                    .Select(x => new ScaleOptionDto
                    {
                        id = x.id,
                        name = x.name
                    })
                    .ToListAsync(),

                fee_subjects = await _context.TahakkukFeeSubjects
                    .Where(x => x.is_active)
                    .OrderBy(x => x.name)
                    .Select(x => new FeeSubjectOptionDto
                    {
                        id = x.id,
                        name = x.name
                    })
                    .ToListAsync(),

                fee_sub_subjects = await _context.TahakkukFeeSubSubjects
                    .Where(x => x.is_active)
                    .OrderBy(x => x.name)
                    .Select(x => new FeeSubSubjectOptionDto
                    {
                        id = x.id,
                        tahakkuk_fee_subject_id = x.tahakkuk_fee_subject_id,
                        name = x.name
                    })
                    .ToListAsync()
            };

            return Ok(result);
        }

        [HttpGet("definition")]
        public async Task<IActionResult> GetDefinition(
            int cityId,
            int? districtId,
            int? yearId,
            int institutionId,
            int? departmentId,
            int directorateId,
            int scaleId,
            int feeSubjectId,
            int? feeSubSubjectId)
        {
            var query = _context.TahakkukDefinitions
                .Where(x => x.is_active)
                .Where(x => x.city_id == cityId)
                .Where(x => x.tahakkuk_institution_id == institutionId)
                .Where(x => x.tahakkuk_directorate_id == directorateId)
                .Where(x => x.tahakkuk_scale_id == scaleId)
                .Where(x => x.tahakkuk_fee_subject_id == feeSubjectId)
                .AsQueryable();

            var district = await _context.Districts
                .FirstOrDefaultAsync(x => x.id == districtId);
            if (districtId.HasValue)
                query = query.Where(x => x.district_id == districtId);
            //if (district?.district_group_no != null)
            //{
            //    query = query.Where(x =>
            //        x.district_group_no == district.district_group_no);
            //}
            //else
            //{
            //    query = query.Where(x => x.district_id == districtId);
            //}

            if (yearId.HasValue)
                query = query.Where(x => x.tahakkuk_year_id == yearId.Value);

            if (departmentId.HasValue)
                query = query.Where(x => x.tahakkuk_department_id == departmentId.Value);

            if (feeSubSubjectId.HasValue)
                query = query.Where(x => x.tahakkuk_fee_sub_subject_id == feeSubSubjectId.Value);

            var value = await query
                .Select(x => new
                {
                    x.id,
                    fee_text = x.description,
                    fee_amount = x.price,
                    x.has_vat,
                    description1 = x.description,
                    x.description2
                })
                .FirstOrDefaultAsync();

            if (value == null)
                return NotFound("Seçimlere uygun tahakkuk tanımı bulunamadı.");

            return Ok(value);
        }
    }
}