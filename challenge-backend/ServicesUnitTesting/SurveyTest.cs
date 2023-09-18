using AutoMapper;
using Example.Api.Controllers;
using Example.Domain.Service;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace ServicesUnitTesting;

public class SurveyTesting
{
    private readonly SurveyController _permissionController;
    private readonly Mock<ISurveyService> _mockPermissionService;
    private readonly Mock<IMapper> _mockMapper;

    public SurveyTesting()
    {
        _mockMapper = new Mock<IMapper>();
        _mockPermissionService = new Mock<ISurveyService>();
        _permissionController = new SurveyController(
            _mockMapper.Object, _mockPermissionService.Object
        );
    }

    [Fact]
    public async Task TestGet_Ok()
    {
        var expectedResults = new List<SurveyDto>
        {
            new SurveyDto
            {
                Id = 1,
                SurveyTitle = "Encuesta 1",
                SurveyStatus = 1,
                SurveyDate = DateTime.Parse("2023-07-16T21:14:19.385Z")
            }
        };

        var result = await _permissionController.Get() as OkObjectResult;

        Assert.NotNull(result);
        Assert.Equal(200, result.StatusCode);

    }
}