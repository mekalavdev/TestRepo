using Common.Constants;
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
            string responseMessage = string.Empty;
            try
            {
                var userInfo = this.employeeService.GetEmployees();
                return new ApiResponse(responseMessage, userInfo, (int)HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return new ApiResponse(LabelConstants.InternalServerErrorMsg);
            }
        }

        [HttpGet]
        [Route("GetEmployeeById")]
        public ApiResponse GetEmployeeById(int empId)
        {
            string responseMessage = string.Empty;
            try
            {
                var empInfo = this.employeeService.GetEmployeeById(empId);
                if (empInfo != null)
                {
                    return new ApiResponse(responseMessage, empInfo, (int)HttpStatusCode.OK);
                }
                responseMessage = LabelConstants.EmpNotFountMsg;
                return new ApiResponse(responseMessage, empInfo, (int)HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return new ApiResponse(LabelConstants.InternalServerErrorMsg);
            }
        }

        [HttpPost]
        [Route("AddEmployee")]
        public ApiResponse AddEmployee(EmployeeModel employee)
        {
            string responseMessage = string.Empty;
            try
            {
                this.employeeService.AddEmployee(employee);
                return new ApiResponse(responseMessage, (int)HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return new ApiResponse(LabelConstants.InternalServerErrorMsg);
            }
        }
    }
}
