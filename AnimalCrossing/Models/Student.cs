using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalCrossing.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string nomhabitant { get; set; }
        public string espece { get; set; }
        public string personnalite { get; set; }
        public string genre { get; set; }


        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}