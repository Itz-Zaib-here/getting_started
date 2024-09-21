using System;
using System.Collections;
using System.Collections.Generic;

namespace getting_started.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime enrolled { get; set; }
        public ICollection<StudentCourse> Enrollment{ get; set; }
    }
}
