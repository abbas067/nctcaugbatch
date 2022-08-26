using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nctcaugbatch.Models
{
    public class Employee:IEmployee
    {
        private readonly EmployeeContext context;
        public Employee(EmployeeContext _context)
        {
            context = _context;     
        }
      public List<EmployeeDetail> GetEmployeeList()
        {
            return context.EmployeeDetails.ToList();
        }
    }
}
