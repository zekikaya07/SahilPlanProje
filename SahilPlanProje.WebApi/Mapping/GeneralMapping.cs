using AutoMapper;
using SahilPlanProje.WebApi.Dtos.CityDtos;
using SahilPlanProje.WebApi.Dtos.DistrictDtos;
using SahilPlanProje.WebApi.Dtos.FeatureDtos;
using SahilPlanProje.WebApi.Dtos.MessageDtos;
using SahilPlanProje.WebApi.Dtos.TahakkukDepartmentDtos;
using SahilPlanProje.WebApi.Dtos.TahakkukDirectorateDtos;
using SahilPlanProje.WebApi.Dtos.TahakkukFeeSubjectDtos;
using SahilPlanProje.WebApi.Dtos.TahakkukFeeSubSubjects;
using SahilPlanProje.WebApi.Dtos.TahakkukInstitutionDtos;
using SahilPlanProje.WebApi.Dtos.TahakkukScaleDtos;
using SahilPlanProje.WebApi.Dtos.TahakkukYearDtos;
using SahilPlanProje.WebApi.Entities;

namespace SahilPlanProje.WebApi.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<City, ResultCityDto>().ReverseMap();
            CreateMap<City, CreateCityDto>().ReverseMap();
            CreateMap<City, UpdateCityDto>().ReverseMap();
            CreateMap<City, GetByIdCityDto>().ReverseMap();
            
            CreateMap<District, ResultDistrictDto>().ReverseMap();
            CreateMap<District, CreateDistrictDto>().ReverseMap();
            CreateMap<District, UpdateDistrictDto>().ReverseMap();
            CreateMap<District, GetByIdDistrictDto>().ReverseMap();

            CreateMap<TahakkukYear, ResultTahakkukYearDto>().ReverseMap();
            CreateMap<TahakkukYear, CreateTahakkukYearDto>().ReverseMap();
            CreateMap<TahakkukYear, UpdateTahakkukYearDto>().ReverseMap();
            CreateMap<TahakkukYear, GetByIdTahakkukYearDto>().ReverseMap();
            
            CreateMap<TahakkukInstitution, ResultTahakkukInstitutionDto>().ReverseMap();
            CreateMap<TahakkukInstitution, CreateTahakkukInstitutionDto>().ReverseMap();
            CreateMap<TahakkukInstitution, UpdateTahakkukInstitutionDto>().ReverseMap();
            CreateMap<TahakkukInstitution, GetByIdTahakkukInstitutionDto>().ReverseMap();

            CreateMap<TahakkukScale, ResultTahakkukScaleDto>().ReverseMap();
            CreateMap<TahakkukScale, CreateTahakkukScaleDto>().ReverseMap();
            CreateMap<TahakkukScale, UpdateTahakkukScaleDto>().ReverseMap();
            CreateMap<TahakkukScale, GetByIdTahakkukScaleDto>().ReverseMap();
            
            CreateMap<TahakkukFeeSubject, ResultTahakkukFeeSubjectDto>().ReverseMap();
            CreateMap<TahakkukFeeSubject, CreateTahakkukFeeSubjectDto>().ReverseMap();
            CreateMap<TahakkukFeeSubject, UpdateTahakkukFeeSubjectDto>().ReverseMap();
            CreateMap<TahakkukFeeSubject, GetByIdTahakkukFeeSubjectDto>().ReverseMap();

            CreateMap<TahakkukFeeSubSubject, ResultTahakkukFeeSubSubjectDto>().ReverseMap();
            CreateMap<TahakkukFeeSubSubject, CreateTahakkukFeeSubSubjectDto>().ReverseMap();
            CreateMap<TahakkukFeeSubSubject, UpdateTahakkukFeeSubSubjectDto>().ReverseMap();
            CreateMap<TahakkukFeeSubSubject, GetByIdTahakkukFeeSubSubjectDto>().ReverseMap();


            CreateMap<TahakkukDepartment, ResultTahakkukDepartmentDto>().ReverseMap();
            CreateMap<TahakkukDepartment, CreateTahakkukDepartmentDto>().ReverseMap();
            CreateMap<TahakkukDepartment, UpdateTahakkukDepartmentDto>().ReverseMap();
            CreateMap<TahakkukDepartment, GetByIdTahakkukDepartmentDto>().ReverseMap();


            CreateMap<TahakkukDirectorate, ResultTahakkukDirectorateDto>().ReverseMap();
            CreateMap<TahakkukDirectorate, CreateTahakkukDirectorateDto>().ReverseMap();
            CreateMap<TahakkukDirectorate, UpdateTahakkukDirectorateDto>().ReverseMap();
            CreateMap<TahakkukDirectorate, GetByIdTahakkukDirectorateDto>().ReverseMap();

            CreateMap<TahakkukDefinition, ResultTahakkukDefinitionDto>().ReverseMap();
            CreateMap<TahakkukDefinition, CreateTahakkukDefinitionDto>().ReverseMap();
            CreateMap<TahakkukDefinition, UpdateTahakkukDefinitionDto>().ReverseMap();
            CreateMap<TahakkukDefinition, GetByIdTahakkukDefinitionDto>().ReverseMap();

            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetByIdFeatureDto>().ReverseMap();

            CreateMap<Message, ResultMessageDto>().ReverseMap();
            CreateMap<Message, CreateMessageDto>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();
            CreateMap<Message, GetByIdMessageDto>().ReverseMap();
        }

    }
}
