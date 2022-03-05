using Common.Constants;
using CRUD_Demo.Controllers;
using Domain.Interface;
using Domain.Model;
using System.Collections.Generic;
using System.Linq;
using UnitTest.Services;
using VMD.RESTApiResponseWrapper.Core.Wrappers;
using Xunit;

namespace UnitTest.Controller
{
    public class EmployeeControllerTest
    {
        private readonly EmployeeController _controller;
        private readonly IEmployeeService _service;

        public EmployeeControllerTest()
        {
            _service = new EmployeeServiceTest();
            _controller = new EmployeeController(_service);
        }

        #region GetAllEmployees Test Case
        [Fact]
        public void Get_WhenCalled_ReturnsApiResponse()
        {
            // Act
            var result = _controller.GetAllEmployees();

            // Assert
            Assert.IsType<ApiResponse>(result);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllEmployees()
        {
            // Act
            var result = _controller.GetAllEmployees() as ApiResponse;

            // Assert
            var items = Assert.IsAssignableFrom<IEnumerable<EmployeeModel>>(result.Result);
            Assert.Equal(3, items.Count());
        }
        #endregion

        #region GetEmployeeById Test Case
        [Fact]
        public void GetEmployeeById_UnknownIdPassed_ReturnsNotFoundMsg()
        {
            // Act
            var notFoundResult = _controller.GetEmployeeById(5);

            // Assert
            var msg = Assert.IsType<string>(notFoundResult.Message);
            Assert.Equal(LabelConstants.EmpNotFountMsg, msg);
        }

        [Fact]
        public void GetEmployeeById_ExistingIdPassed_ReturnsApiResponse()
        {
            // Arrange
            var testId = 1;

            // Act
            var okResult = _controller.GetEmployeeById(testId);

            // Assert
            Assert.IsType<ApiResponse>(okResult as ApiResponse);
        }

        [Fact]
        public void GetEmployeeById_ExistingidPassed_ReturnsRightItem()
        {
            // Arrange
            var testGuid = 1;

            // Act
            var result = _controller.GetEmployeeById(testGuid) as ApiResponse;

            // Assert
            Assert.IsType<EmployeeModel>(result.Result);
            Assert.Equal(testGuid, (result.Result as EmployeeModel).EmpId);
        }
        #endregion
    }
}
