namespace AlBasedRecruiter.Models
{
    public class Applicant
    {
        public virtual int ApplicantId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string Resume { get; set; }
        public virtual DateTime ApplicationDate { get; set; }
        public virtual char Gender { get; set; }
        public virtual int Age { get; set; }

        // Foreign Key References
        public virtual int RecruiterId { get; set; }
        public virtual Recruiter Recruiter { get; set; }
        public virtual int JobId { get; set; }
        public virtual JobPosition JobPosition { get; set; }
    }
}
