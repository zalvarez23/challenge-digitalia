using AutoMapper;
using Example.Domain.Service;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Example.Api.Controllers
{
    [Route("api/surveyDetail")]
    [ApiController]
    public class SurveyDetailController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISurveyDetailService _surveyDetailService;

        public SurveyDetailController(IMapper mapper, ISurveyDetailService surveyDetailService)
        {
            _mapper = mapper;
            _surveyDetailService = surveyDetailService; 
        }

        [HttpGet("{id}", Name = "GetSurveyDetail")]
        [ProducesResponseType(typeof(CustomResponse<IEnumerable<SurveyDetailDto>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _surveyDetailService.GetAllByIdAsync(id);
            var response =
             new CustomResponse<IEnumerable<SurveyDetailDto>>("Success", _mapper.Map<IEnumerable<SurveyDetailDto>>(result));
            return Ok(response);
        }
    }
}