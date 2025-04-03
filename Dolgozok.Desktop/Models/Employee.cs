using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok.Desktop.Models
{
    public class Employee
    {
        private string _email;
        private int _salary;

        public Employee(string email, string name)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Email and name must be provided");
            }
            if(!email.Contains("@"))
            {
                throw new ArgumentException("Email must contain '@'");
            }
            _email = email;
            Name = name;
            _salary = 0;
        }

        public string Name { get; set; }
        public string Email => _email;
        public int Salary => _salary;

        public override string ToString()
        {
            return $"{Name} ({_email}) - {_salary} Ft";
        }

        public void Pay(int v)
        {
            _salary += v;
        }
    }
}
