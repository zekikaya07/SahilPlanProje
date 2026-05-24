using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SahilPlanProje.WebApi.Context;
using SahilPlanProje.WebApi.Dtos.TahakkukFeeSubjectDtos;
using SahilPlanProje.WebApi.Entities;

namespace SahilPlanProje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TahakkukFeeSubjectsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;

        public TahakkukFeeSubjectsController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GeTahakkukList()
        {
            var values = _context.TahakkukFeeSubjects.ToList();
            return Ok(_mapper.Map<List<ResultTahakkukFeeSubjectDto>>(values));
        }

        [HttpGet("{id}")]
        public IActionResult GetTahakkuk(int id)
        {
            var value = _context.TahakkukFeeSubjects.Find(id);
            return Ok(_mapper.Map<ResultTahakkukFeeSubjectDto>(value));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCity([FromBody] CreateTahakkukFeeSubjectDto city)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var value = _mapper.Map<TahakkukFeeSubject>(city);

            await _context.TahakkukFeeSubjects.AddAsync(value);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                message = "İl başarıyla eklendi.",
                data = _mapper.Map<ResultTahakkukFeeSubjectDto>(value)
            });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCity(int id, [FromBody] UpdateTahakkukFeeSubjectDto city)
        {
            if (id != city.id)
                return BadRequest("Id uyuşmuyor.");

            var existingCity = await _context.TahakkukFeeSubjects.FindAsync(id);

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
            var city = await _context.TahakkukFeeSubjects.FindAsync(id);

            if (city == null)
                return NotFound("Kayıt bulunamadı.");

            _context.TahakkukFeeSubjects.Remove(city);

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


        //[HttpGet("getinfo")]
        //public IActionResult GetInfo()
        //{
        //    return Ok("Tahakkuk API Servis Çalışıyor");
        //}

        ///// <summary>
        ///// İlçeye ait tahakkuk yıllarını getirir
        ///// </summary>
        ///// <remarks>
        ///// Bu servis, seçilen ilçeye ait aktif tahakkuk yıllarını listeler.
        ///// 
        ///// Örnek kullanım:
        ///// GET /api/Tahakkuk/years?districtId=1
        ///// </remarks>
        ///// <param name="districtId">İlçe Id bilgisi</param>
        //[HttpGet("years")]
        //public IActionResult GetYears(int districtId)
        //{
        //    var values = _context.TahakkukInstitutions
        //        .Where(x => x.district_id == districtId && x.is_active)
        //        .Select(x => new
        //        {
        //            x.id,
        //            x.year
        //        })
        //        .OrderByDescending(x => x.year)
        //        .ToList();

        //    return Ok(values);
        //}

        //[HttpGet("institutions")]
        //public IActionResult GetInstitutions(int tahakkukYearId)
        //{
        //    var values = _context.TahakkukInstitutions
        //        .Where(x => x.tahakkuk_year_id == tahakkukYearId && x.is_active)
        //        .Select(x => new
        //        {
        //            x.id,
        //            x.name
        //        })
        //        .OrderBy(x => x.name)
        //        .ToList();

        //    return Ok(values);
        //}

        //[HttpGet("departments")]
        //public IActionResult GetDepartments(int institutionId)
        //{
        //    var values = _context.TahakkukDepartments
        //        .Where(x => x.tahakkuk_institution_id == institutionId && x.is_active)
        //        .Select(x => new
        //        {
        //            x.id,
        //            x.name
        //        })
        //        .OrderBy(x => x.name)
        //        .ToList();

        //    return Ok(values);
        //}

        //[HttpGet("directorates")]
        //public IActionResult GetDirectorates(int departmentId)
        //{
        //    var values = _context.TahakkukDirectorates
        //        .Where(x => x.tahakkuk_department_id == departmentId && x.is_active)
        //        .Select(x => new
        //        {
        //            x.id,
        //            x.name
        //        })
        //        .OrderBy(x => x.name)
        //        .ToList();

        //    return Ok(values);
        //}

        //[HttpGet("scales")]
        //public IActionResult GetScales(int directorateId)
        //{
        //    var values = _context.TahakkukScales
        //        .Where(x => x.tahakkuk_directorate_id == directorateId && x.is_active)
        //        .Select(x => new
        //        {
        //            x.id,
        //            x.scale_value,
        //            x.name
        //        })
        //        .OrderBy(x => x.scale_value)
        //        .ToList();

        //    return Ok(values);
        //}

        //[HttpGet("fee-subjects")]
        //public IActionResult GetFeeSubjects(int directorateId, int? scaleId)
        //{
        //    var query = _context.TahakkukFeeSubjects
        //        .Where(x => x.tahakkuk_directorate_id == directorateId && x.is_active);

        //    if (scaleId.HasValue)
        //    {
        //        query = query.Where(x => x.tahakkuk_scale_id == scaleId.Value);
        //    }
        //    else
        //    {
        //        query = query.Where(x => x.tahakkuk_scale_id == null);
        //    }

        //    var values = query
        //        .Select(x => new
        //        {
        //            x.id,
        //            x.name
        //        })
        //        .OrderBy(x => x.name)
        //        .ToList();

        //    return Ok(values);
        //}

        //[HttpGet("fee-sub-subjects")]
        //public IActionResult GetFeeSubSubjects(int feeSubjectId)
        //{
        //    var values = _context.TahakkukFeeSubSubjects
        //        .Where(x => x.tahakkuk_fee_subject_id == feeSubjectId && x.is_active)
        //        .Select(x => new
        //        {
        //            x.id,
        //            x.name
        //        })
        //        .OrderBy(x => x.name)
        //        .ToList();

        //    return Ok(values);
        //}

        //[HttpGet("definition")]
        //public IActionResult GetDefinition(int feeSubjectId, int? feeSubSubjectId)
        //{
        //    var query = _context.TahakkukDefinitions
        //        .Where(x => x.tahakkuk_fee_subject_id == feeSubjectId && x.is_active);

        //    if (feeSubSubjectId.HasValue)
        //    {
        //        query = query.Where(x => x.tahakkuk_fee_sub_subject_id == feeSubSubjectId.Value);
        //    }
        //    else
        //    {
        //        query = query.Where(x => x.tahakkuk_fee_sub_subject_id == null);
        //    }

        //    var value = query
        //        .Select(x => new
        //        {
        //            x.id,
        //            x.fee_text,
        //            x.fee_amount,
        //            x.has_vat,
        //            x.description1,
        //            x.description2
        //        })
        //        .FirstOrDefault();

        //    return Ok(value);
        //}

        //[HttpGet("filter-options")]
        //public IActionResult GetFilterOptions()
        //{
        //    var scales = _context.TahakkukScales
        //        .Where(x => x.is_active)
        //        .Select(x => new
        //        {
        //            x.id,
        //            x.tahakkuk_directorate_id,
        //            x.scale_value,
        //            x.name
        //        })
        //        .OrderBy(x => x.scale_value)
        //        .ToList();

        //    var directorateIds = scales
        //        .Select(x => x.tahakkuk_directorate_id)
        //        .Distinct()
        //        .ToList();

        //    var directorates = _context.TahakkukDirectorates
        //        .Where(x => x.is_active &&
        //                    directorateIds.Contains(x.id))
        //        .Select(x => new
        //        {
        //            x.id,
        //            x.tahakkuk_department_id,
        //            x.name
        //        })
        //        .OrderBy(x => x.name)
        //        .ToList();

        //    var departmentIds = directorates
        //        .Select(x => x.tahakkuk_department_id)
        //        .Distinct()
        //        .ToList();

        //    var departments = _context.TahakkukDepartments
        //        .Where(x => x.is_active &&
        //                    departmentIds.Contains(x.id))
        //        .Select(x => new
        //        {
        //            x.id,
        //            x.tahakkuk_institution_id,
        //            x.name
        //        })
        //        .OrderBy(x => x.name)
        //        .ToList();

        //    var institutionIds = departments
        //        .Select(x => x.tahakkuk_institution_id)
        //        .Distinct()
        //        .ToList();

        //    var institutions = _context.TahakkukInstitutions
        //        .Where(x => x.is_active &&
        //                    institutionIds.Contains(x.id))
        //        .Select(x => new
        //        {
        //            x.id,
        //            x.tahakkuk_year_id,
        //            x.name
        //        })
        //        .OrderBy(x => x.name)
        //        .ToList();

        //    var yearIds = institutions
        //        .Select(x => x.tahakkuk_year_id)
        //        .Distinct()
        //        .ToList();

        //    var years = _context.TahakkukInstitutions
        //        .Where(x => x.is_active &&
        //                    yearIds.Contains(x.id))
        //        .Select(x => new
        //        {
        //            x.id,
        //            x.district_id,
        //            x.year
        //        })
        //        .OrderByDescending(x => x.year)
        //        .ToList();

        //    var districtIds = years
        //        .Select(x => x.district_id)
        //        .Distinct()
        //        .ToList();

        //    var districts = _context.Districts
        //        .Where(x => x.is_active &&
        //                    districtIds.Contains(x.id))
        //        .Select(x => new
        //        {
        //            x.id,
        //            x.city_id,
        //            x.name
        //        })
        //        .OrderBy(x => x.name)
        //        .ToList();

        //    var cityIds = districts
        //        .Select(x => x.city_id)
        //        .Distinct()
        //        .ToList();

        //    var cities = _context.Cities
        //        .Where(x => x.is_active &&
        //                    cityIds.Contains(x.id))
        //        .Select(x => new
        //        {
        //            x.id,
        //            x.name
        //        })
        //        .OrderBy(x => x.name)
        //        .ToList();

        //    var values = new
        //    {
        //        cities,
        //        districts,
        //        years,
        //        institutions,
        //        departments,
        //        directorates,
        //        scales
        //    };

        //    return Ok(values);
        //}

        //[HttpGet("filter-optionsv2")]
        //public IActionResult GetFilterOptionsv2()
        //{
        //    var values = new
        //    {
        //        cities = _context.Cities
        //            .Where(x => x.is_active)
        //            .Select(x => new
        //            {
        //                x.id,
        //                x.name
        //            })
        //            .OrderBy(x => x.name)
        //            .ToList(),

        //        districts = _context.Districts
        //            .Where(x => x.is_active)
        //            .Select(x => new
        //            {
        //                x.id,
        //                x.city_id,
        //                x.name
        //            })
        //            .OrderBy(x => x.name)
        //            .ToList(),

        //        years = _context.TahakkukInstitutions
        //            .Where(x => x.is_active)
        //            .Select(x => new
        //            {
        //                x.id,
        //                x.district_id,
        //                x.year
        //            })
        //            .OrderByDescending(x => x.year)
        //            .ToList(),

        //        institutions = _context.TahakkukInstitutions
        //            .Where(x => x.is_active)
        //            .Select(x => new
        //            {
        //                x.id,
        //                x.tahakkuk_year_id,
        //                x.name
        //            })
        //            .OrderBy(x => x.name)
        //            .ToList(),

        //        departments = _context.TahakkukDepartments
        //            .Where(x => x.is_active)
        //            .Select(x => new
        //            {
        //                x.id,
        //                x.tahakkuk_institution_id,
        //                x.name
        //            })
        //            .OrderBy(x => x.name)
        //            .ToList(),

        //        directorates = _context.TahakkukDirectorates
        //            .Where(x => x.is_active)
        //            .Select(x => new
        //            {
        //                x.id,
        //                x.tahakkuk_department_id,
        //                x.name
        //            })
        //            .OrderBy(x => x.name)
        //            .ToList(),


        //        scales = _context.TahakkukScales
        //            .Where(x => x.is_active)
        //            .Select(x => new
        //            {
        //                x.id,
        //                x.tahakkuk_directorate_id,
        //                x.scale_value,
        //                x.name
        //            })
        //            .OrderBy(x => x.scale_value)
        //            .ToList(),

        //        fee_subjects = _context.TahakkukFeeSubjects
        //            .Where(x => x.is_active)
        //            .Select(x => new
        //            {
        //                x.id,
        //                x.tahakkuk_directorate_id,
        //                x.tahakkuk_scale_id,
        //                x.name
        //            })
        //            .OrderBy(x => x.name)
        //            .ToList(),

        //        fee_sub_subjects = _context.TahakkukFeeSubSubjects
        //            .Where(x => x.is_active)
        //            .Select(x => new
        //            {
        //                x.id,
        //                x.tahakkuk_fee_subject_id,
        //                x.name
        //            })
        //            .OrderBy(x => x.name)
        //            .ToList()
        //    };

        //    return Ok(values);
        //}

        //[HttpPost("calculate")]
        //public IActionResult Calculate([FromBody] TahakkukCalculateRequest request)
        //{
        //    var query =
        //        from definition in _context.TahakkukDefinitions
        //        join subject in _context.TahakkukFeeSubjects
        //            on definition.tahakkuk_fee_subject_id equals subject.id
        //        join directorate in _context.TahakkukDirectorates
        //            on subject.tahakkuk_directorate_id equals directorate.id
        //        join department in _context.TahakkukDepartments
        //            on directorate.tahakkuk_department_id equals department.id
        //        join institution in _context.TahakkukInstitutions
        //            on department.tahakkuk_institution_id equals institution.id
        //        join year in _context.TahakkukInstitutions
        //            on institution.tahakkuk_year_id equals year.id
        //        join district in _context.Districts
        //            on year.district_id equals district.id
        //        join city in _context.Cities
        //            on district.city_id equals city.id
        //        join subSubject in _context.TahakkukFeeSubSubjects
        //            on definition.tahakkuk_fee_sub_subject_id equals subSubject.id into subSubjectJoin
        //        from subSubject in subSubjectJoin.DefaultIfEmpty()
        //        join scale in _context.TahakkukScales
        //            on subject.tahakkuk_scale_id equals scale.id into scaleJoin
        //        from scale in scaleJoin.DefaultIfEmpty()
        //        where
        //            definition.is_active &&
        //            subject.is_active &&
        //            directorate.is_active &&
        //            department.is_active &&
        //            institution.is_active &&
        //            year.is_active &&
        //            district.is_active &&
        //            city.is_active
        //        select new
        //        {
        //            definition,
        //            subject,
        //            subSubject,
        //            scale,
        //            directorate,
        //            department,
        //            institution,
        //            year,
        //            district,
        //            city
        //        };

        //    if (request.city_id.HasValue)
        //        query = query.Where(x => x.city.id == request.city_id.Value);

        //    if (request.district_id.HasValue)
        //        query = query.Where(x => x.district.id == request.district_id.Value);

        //    if (request.year_id.HasValue)
        //        query = query.Where(x => x.year.id == request.year_id.Value);

        //    if (request.institution_id.HasValue)
        //        query = query.Where(x => x.institution.id == request.institution_id.Value);

        //    if (request.department_id.HasValue)
        //        query = query.Where(x => x.department.id == request.department_id.Value);

        //    if (request.directorate_id.HasValue)
        //        query = query.Where(x => x.directorate.id == request.directorate_id.Value);

        //    if (request.scale_id.HasValue)
        //        query = query.Where(x => x.scale != null && x.scale.id == request.scale_id.Value);

        //    if (request.fee_subject_id.HasValue)
        //        query = query.Where(x => x.subject.id == request.fee_subject_id.Value);

        //    if (request.fee_sub_subject_id.HasValue)
        //        query = query.Where(x => x.subSubject != null && x.subSubject.id == request.fee_sub_subject_id.Value);

        //    var values = query
        //        .Select(x => new
        //        {
        //            city_id = x.city.id,
        //            city_name = x.city.name,

        //            district_id = x.district.id,
        //            district_name = x.district.name,

        //            tahakkuk_year_id = x.year.id,
        //            year = x.year.year,

        //            institution_id = x.institution.id,
        //            tahakkuk_kurum = x.institution.name,

        //            department_id = x.department.id,
        //            daire_baskanligi = x.department.name,

        //            directorate_id = x.directorate.id,
        //            mudurluk = x.directorate.name,

        //            scale_id = x.scale != null ? x.scale.id : (int?)null,
        //            olcek = x.scale != null ? x.scale.name : null,

        //            fee_subject_id = x.subject.id,
        //            ucret_konusu = x.subject.name,

        //            fee_sub_subject_id = x.subSubject != null ? x.subSubject.id : (int?)null,
        //            ucret_alt_konusu = x.subSubject != null ? x.subSubject.name : null,

        //            definition_id = x.definition.id,
        //            ucret_yazisi = x.definition.fee_text,
        //            ucret = x.definition.fee_amount,
        //            kdv_var_mi = x.definition.has_vat,
        //            aciklama1 = x.definition.description1,
        //            aciklama2 = x.definition.description2
        //        })
        //        .ToList();

        //    return Ok(values);
        //}
    }
}