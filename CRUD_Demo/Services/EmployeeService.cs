using AutoMapper;
using DataLayer.UnitOfWork;
using Domain.Interface;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;

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
        /// <summary>
        /// To get all employee details.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// To get employee by id
        /// </summary>
        /// <param name="empId">Employee Id.</param>
        /// <returns>Returns employee details.</returns>
        public EmployeeModel GetEmployeeById(int empId)
        {
            try
            {
                var getEmployee = unitOfWork.EmployeeRepository.Get(x => x.EmpId == empId)?.FirstOrDefault();
                EmployeeModel result = new EmployeeModel();
                MapModels(getEmployee, out result);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddEmployee(EmployeeModel employee)
        {
            try
            {
                //To be implemented
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Genrics Implementation - Returns R type
        /// </summary>
        /// <typeparam name="T">Source Model Type.</typeparam>
        /// <typeparam name="R">Destination Model Type.</typeparam>
        /// <param name="source">Source Value.</param>
        /// <param name="output">Destination Value.</param>
        private void MapModels<T, R>(T source, out R output)
        {
            output = mapper.Map<R>(source);
        }

    }
}
