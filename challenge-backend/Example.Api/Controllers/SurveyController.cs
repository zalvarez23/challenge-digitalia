using AutoMapper;
using Example.Domain.Entities;
using Example.Domain.Service;
using Microsoft.AspNetCore.Mvc;
using System.Net;
 
namespace Example.Api.Controllers
{
    [Route("api/survey")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISurveyService _surveyService;

        public SurveyController(IMapper mapper, ISurveyService surveyService)
        {
            _mapper = mapper;
            _surveyService = surveyService;
        }

        [HttpGet(Name = "GetSurvey")]
        public async Task<IActionResult> Get()
        {
           
            var result = await _surveyService.GetAllAsync();
            var response =
            new CustomResponse<IEnumerable<SurveyDto>>("Success", _mapper.Map<IEnumerable<SurveyDto>>(result));
            return Ok(response);
        }

    
        [HttpPost]
        [ProducesResponseType(typeof(CustomResponse<SurveyDto>), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> Create(SurveyDto surveyDto)
        {

            var survey = _mapper.Map<SurveyDto, Survey>(surveyDto);
            await _surveyService.CreateAsync(survey);
        
            return Ok(survey);
        }

        [HttpPut]
        [ProducesResponseType(typeof(CustomResponse<SurveyDto>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Update(SurveyDto surveyDto)
        {
            var survey = _mapper.Map<SurveyDto, Survey>(surveyDto);
            await _surveyService.UpdateAsync(survey);
         
            return Ok(survey);
        }
    }
}