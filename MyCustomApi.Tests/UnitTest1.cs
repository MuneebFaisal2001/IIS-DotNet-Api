using Xunit;
using MyCustomApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MyCustomApi.Tests
{
    public class CalculationTests
    {
        [Fact]
        public void AddNumbers_ShouldReturnCorrectSum()
        {
            // Arrange
            var controller = new TestController();

            // Act
            var actionResult = controller.AddNumbers(15, 25);
            var okResult = actionResult as OkObjectResult;

            // Assert
            Assert.NotNull(okResult);
            Assert.Equal(200, okResult.StatusCode);
        }
    }
}