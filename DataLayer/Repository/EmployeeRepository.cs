using DataLayer.Data;
using DataLayer.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository
{
   public class DepartmentRepository : BaseRepository<Department>
    {
        public DepartmentRepository(EmployeeContext _db) : base(_db)
        {

        }
    }

    public class DesignationRepository : BaseRepository<Designation>
    {
        public DesignationRepository(EmployeeContext _db) : base(_db)
        {

        }
    }

    public class EmployeeRepository : BaseRepository<Employee>
    {
        public EmployeeRepository(EmployeeContext _db) : base(_db)
        {

        }
    }
}
