using Xunit;
using devops_service.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Tests
{
    public class UnitTests
    {
        [Fact]
        public void TestGetEndpointStatus()
        {
            //Arrange
            var Controller = new myobController();
            //Act
            var Result = Controller.Get("unittest");
            //Assert
            Assert.IsType<OkObjectResult>(Result.Result);
     
        }

        [Fact]
        public void TestHealthEndpointStatus()
        {
            //Arrange
            var Controller = new healthzController();
            //Act
            var Result = Controller.Get();
            //Assert
            Assert.IsType<OkObjectResult>(Result.Result);
     
        }

        // [Fact]
        // public void TestMetainfoEndpointStatus()
        // {
        //     //Arrange
        //     var Controller = new metainfoController();
        //     //Act
        //     var Result = Controller.Get();
        //     //Assert
        //     Assert.IsType<OkObjectResult>(Result.Result);
     
        // }
    }
}