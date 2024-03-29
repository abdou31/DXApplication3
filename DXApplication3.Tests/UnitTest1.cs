using DXApplication3.Models;
using DXApplication3.Services;
using Moq;
using System;
using System.Linq;
using Xunit;
using Xunit.Extensions;

namespace DXApplication3.Tests
{
    public class UserServiceTest
    {
        private readonly UserService _userService;

        // setup
        public UserServiceTest()
        {
            _userService = new UserService();
        }

        // teardown
        public void Dispose()
        {
            GC.Collect();
        }
        [Fact]
        public void CalculateAge_ReturnsCorrectAge()
        {
            // Arrange
            Mock<IUserService> userServiceMock = new Mock<IUserService>();

            User user = new User("Ali", new DateTime(1993, 10, 20));
        
            // Set up mock to return expected age when CalculateAge method is called with the specified user
            userServiceMock.Setup(u => u.CalculateAge(user)).Returns(30);
            
            // Set up real UserService for comparison
            IUserService userServiceReal = new UserService();

            // Act
            int ageMock = userServiceMock.Object.CalculateAge(user);
            int ageReal = userServiceReal.CalculateAge(user);

            // Assert
            Assert.Equal(ageReal, ageMock); // Verify that both results are equal

            // Additional assertion to verify that the mock method was called
            userServiceMock.Verify(u => u.CalculateAge(user), Times.Once);
        }
    }
}
