using Dolgozok.Console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok.Console.Repos
{
    public class EmployeeRepo
    {
        private readonly DolgozokContext _context = new DolgozokContext();

        public int GetNumberOfWorkers()
        {
            return _context.Workers.Count();
        }

        public int GetNumberOfWorkersWithSalary()
        {
            return _context.Workers.Where(w => w.Salary > 0).Count();
        }

        public int GetNumberOfWorkersWithoutSalary()
        {
            return _context.Workers.Where(w => w.Salary == 0).Count();
        }

        public double GetAverageSalary()
        {
            return (double)_context.Workers.Average(w => w.Salary);
        }

        public List<Employee> GetAll()
        {
            return _context.Workers.ToList();
        }
    }
}
