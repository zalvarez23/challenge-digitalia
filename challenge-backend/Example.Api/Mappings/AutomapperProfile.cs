using AutoMapper;
using Example.Domain.Entities;
using Example.Domain.Service;

namespace Example.Api.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Survey, SurveyDto>().ReverseMap();
            CreateMap<SurveyDto, Survey>()
                     .ForMember(dest => dest.SurveyDate, opt => opt.MapFrom(src => DateTime.Now));
            CreateMap<SurveyDetailDto, SurveyDetail>();

            CreateMap<SurveyDetail, SurveyDetailDto>().ReverseMap();
        }
    }

}
