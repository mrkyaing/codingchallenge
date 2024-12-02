using AWebsite.API.Controllers;
using AWebsite.API.Models;
using AWebsite.API.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SkillPracticeBackendDev.UnitTests.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SkillPracticeBackendDev.UnitTests.Systems.ApiControllers;
public class FansControllerUnitTest
{
    [Fact]
    public async Task Get_onSuccess_ReturnStatusCode200()
    {
        //Arrange
        var mockFanService=new Mock<IFanService>();
        mockFanService.Setup(s => s.GetAllFansAsync())
                                                            .ReturnsAsync(new List<Fan>());
        var fansController=new FansController(mockFanService.Object);
        //Act
        var result=(OkObjectResult)await fansController.SayHi();
        //Assert
        result.StatusCode.Should().Be(200);
    }

    [Fact]
    public async Task Get_onSuccess_InvokeService()
    {
        //Arrange
        var mockFanService = new Mock<IFanService>();
        mockFanService.Setup(s => s.GetAllFansAsync())
                                                            .ReturnsAsync(FansFixture.GetFans());
        var fansController = new FansController(mockFanService.Object);
        //Act
        var result = (OkObjectResult)await fansController.GetFans();
        //Assert
       mockFanService.Verify(service=>service.GetAllFansAsync(), Times.Once());
    }
    [Fact]
    public async Task Get_onSuccess_ReturnListOfFans()
    {
        //Arrange
        var mockFanService = new Mock<IFanService>();
        mockFanService.Setup(s => s.GetAllFansAsync())
                                                    .ReturnsAsync(FansFixture.GetFans());
        var fansController = new FansController(mockFanService.Object);
        //Act
        var result = (OkObjectResult)await fansController.GetFans();
        //Assert
      result.Should().BeOfType<OkObjectResult>();
      result.Value.Should().BeOfType<List<Fan>>();
    }
}
