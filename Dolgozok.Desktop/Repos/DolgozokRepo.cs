using Dolgozok.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok.Desktop.Repos
{
    public class DolgozokRepo
    {
        private readonly DolgozokContext _context = new DolgozokContext();

        public int GetNumberOfWorkers()
        {
            return _context.Manyworkers.Count();
        }

        public int GetNumberOfWorkersWithSalary()
        {
            return _context.Manyworkers.Where(w => w.Salary > 0).Count();
        }

        public int GetNumberOfWorkersWithoutSalary()
        {
            return _context.Manyworkers.Where(w => w.Salary == 0).Count();
        }

        public double GetAverageSalary()
        {
            return (double) _context.Manyworkers.Average(w => w.Salary);
        }

        public List<Employee> GetAll()
        {
            return _context.Manyworkers.ToList();
        }

        public void DeleteWorker(Employee e)
        {
            _context.Manyworkers.Remove(e);
        }
    }
}
