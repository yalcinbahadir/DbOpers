using Microsoft.EntityFrameworkCore;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> Get()
        {
            return _context.Employees.AsNoTracking();
            //return _context.Employees.ToList();
        }
        public Employee Get(int id)
        {
            return _context.Employees.AsNoTracking().FirstOrDefault(e=>e.Id==id);
            //return _context.Employees.FirstOrDefault(e => e.Id == id);
        }

        public void Update(Employee entity)
        {
            var empToUpdate = Get(entity.Id);
            empToUpdate.FirstName = entity.FirstName;
            _context.Attach(empToUpdate).State = EntityState.Modified;
            _context.SaveChanges();          
        }
    }
}
