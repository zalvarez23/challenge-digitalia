using AutoMapper;
using Example.Api.Controllers;
using Example.Domain.Service;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace ServicesUnitTesting;

public class PermissionTesting
{
    private readonly SurveyController _permissionController;
    private readonly Mock<ISurveyService> _mockPermissionService;
    private readonly Mock<IMapper> _mockMapper;

    public PermissionTesting()
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
                Id = 4,
                //EmployeeName = "kevin",
                //LastNameEmployee = "salazar",
                //TypePermit = 1,
                //DatePermission = DateTime.Parse("2023-07-16T21:14:19.385Z")
            }
        };

        var result = await _permissionController.Get() as OkObjectResult;
        
        Assert.NotNull(result);
        Assert.Equal(200, result.StatusCode);
        
    }

    //[Fact]
    //public async Task TestCreate_Success()
    //{
    //    var permissionDto = new PermissionDto()
    //    {
    //        EmployeeName = "kevin",
    //        LastNameEmployee = "salazar",
    //        TypePermit = 1,
    //        DatePermission = DateTime.Parse("2023-07-16T21:14:19.385Z")
    //    };

    //    var permission = _mockMapper.Object.Map<Permission>(permissionDto);
    //    _mockPermissionService.Setup(service => service.CreateAsync(permission)).Returns(Task.CompletedTask);
    //    _mockPermissionService.Setup(service => service.CreateElasticAsync(permission)).Returns(Task.CompletedTask);
        

    //    var result = await _permissionController.Create(permissionDto) as OkObjectResult;
    //    Assert.NotNull(result);
    //    Assert.Equal(200, result.StatusCode);
    //    _mockPermissionService.Verify(service => service.SendMessageTopic(It.IsAny<OperationDto>()), Times.AtLeastOnce);
    //}

    //[Fact]
    //public async Task TestUpdate_Success()
    //{
    //    var permissionDto = new PermissionDto()
    //    {
    //        Id = 1,
    //        EmployeeName = "kevin",
    //        LastNameEmployee = "salazar",
    //        TypePermit = 1,
    //        DatePermission = DateTime.Parse("2023-07-16T21:14:19.385Z")
    //    };

    //    var permission = _mockMapper.Object.Map<Permission>(permissionDto);
    //    _mockPermissionService.Setup(service => service.UpdateAsync(permission)).Returns(Task.CompletedTask);
    //    _mockPermissionService.Setup(service => service.UpdateElasticAsync(permission)).Returns(Task.CompletedTask);

    //    var result = await _permissionController.Update(permissionDto) as OkObjectResult;
    //    Assert.NotNull(result);
    //    Assert.Equal(200, result.StatusCode);
    //    _mockPermissionService.Verify(service => service.SendMessageTopic(It.IsAny<OperationDto>()), Times.AtLeastOnce);
    //}
}