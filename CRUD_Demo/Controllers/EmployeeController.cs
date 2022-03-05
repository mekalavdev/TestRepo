using DataLayer.Data.Model;
using DataLayer.UnitOfWork;
using Domain.Interface;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using VMD.RESTApiResponseWrapper.Core.Wrappers;

namespace CRUD_Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        [Route("GetAllEmployees")]
        public ApiResponse GetAllEmployees()
        {
            int statusCode = (int)HttpStatusCode.NoContent;
            string responseMessage = string.Empty;
            try
            {
                var userInfo = this.employeeService.GetEmployees();
                statusCode = (int)System.Net.HttpStatusCode.OK;
                return new ApiResponse(responseMessage, userInfo, statusCode);
            }
            catch (Exception ex)
            {
                return new ApiResponse("Internal Server Error");
            }
        }
    }
}
