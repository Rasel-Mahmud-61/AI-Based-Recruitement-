namespace AlBasedRecruiter.Models
{
    public class Interview
    {
        public virtual int InterviewId { get; set; }
        public virtual int ApplicantId { get; set; }
        public virtual Applicant Applicant { get; set; }
        public virtual int JobId { get; set; }
        public virtual JobPosition JobPosition { get; set; }
        public virtual int RecruiterId { get; set; }
        public virtual Recruiter Recruiter { get; set; }
        public virtual DateTime InterviewDate { get; set; }
        public virtual decimal InterviewScore { get; set; }
    }
}