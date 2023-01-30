using Education.Domain.Entities;


namespace Education.Domain.Entities
{
    public class Group
    {
        public Group()
        {
            Lessons= new HashSet<Lesson>();
            StudentInGroups = new HashSet<StudentInGroup>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndDate { get; set; } 
        public int TeacherId { get; set; }
        public User Teacher { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
        public ICollection<StudentInGroup> StudentInGroups { get; set;}
    }
}
