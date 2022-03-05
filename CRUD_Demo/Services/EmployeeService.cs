using AutoMapper;
using DataLayer.UnitOfWork;
using Domain.Interface;
using Domain.Model;
using System;
using System.Collections.Generic;

namespace CRUD_Demo.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly UnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public EmployeeService(IMapper mapper)
        {
            unitOfWork = new UnitOfWork();
            this.mapper = mapper;
        }

        public IEnumerable<EmployeeModel> GetEmployees()
        {
            try
            {
                var getEmployees = unitOfWork.EmployeeRepository.Get();
                return mapper.Map<IEnumerable<EmployeeModel>>(getEmployees);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
