using AutoMapper;
using DataLayer.Data.Model;
using Domain.Model;

namespace CRUD_Demo.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employee, EmployeeModel>();
        }
    }
}
