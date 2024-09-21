using System.Collections.Generic;

namespace getting_started.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public ICollection<StudentCourse> Enrollment { get; set; }
    }
}
