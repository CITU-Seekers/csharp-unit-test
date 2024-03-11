using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeChum
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Boolean isRecorded { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
            isRecorded = false;
        }
    }
}
