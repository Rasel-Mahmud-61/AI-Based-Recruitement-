namespace AlBasedRecruiter.Models
{
    public class JobPosition
    {
        public virtual int JobId { get; set; }
        public virtual string Title { get; set; }
        public virtual decimal Salary { get; set; }
        public virtual string Description { get; set; }
        public virtual string Department { get; set; }
    }
}
