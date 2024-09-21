namespace getting_started.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CousreId { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
