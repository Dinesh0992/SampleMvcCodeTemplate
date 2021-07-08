using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using SampleMvcCodeTemplate.Controllers;
using System;
using Xunit;

namespace SampleMvcCodeTemplate.Test
{
    public class HomeTest
    {
        private readonly HomeController _controller;
        private readonly Mock<ILogger<HomeController>> _mockRepo;

        public HomeTest()
        {
            _mockRepo = new Mock<ILogger<HomeController>>();
            _controller = new HomeController(_mockRepo.Object);
        }

        [Fact]
        public void Index_ActionExecutes_ReturnsViewForIndex()
        {
            var result = _controller.Index();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_ActionExecutes_CheckforNotTypeObjectResultForIndex()
        {
            var result = _controller.Index();
         //   Assert.IsType<OkObjectResult>(result); //failed test case check
            Assert.IsNotType<OkObjectResult>(result);
        }

    }
}
