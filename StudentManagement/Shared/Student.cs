using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Shared
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime AdmissionDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; }

        public string? ImageUrl { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
