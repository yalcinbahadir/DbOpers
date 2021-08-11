using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> Get();
        Employee Get(int id);
        void Update(Employee entity);
    }
}
