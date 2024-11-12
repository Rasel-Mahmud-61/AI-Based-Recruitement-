namespace AlBasedRecruiter.Models
{
    public class Recruiter
    {
        public virtual int RecruiterId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Email { get; set; }
        public virtual string Department { get; set; }
    }
}
