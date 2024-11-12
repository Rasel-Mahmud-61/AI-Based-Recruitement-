namespace AlBasedRecruiter.Models
{
    public class AIEvaluation
    {
        public virtual int EvaluationId { get; set; }

        public virtual int ApplicantId { get; set; }
        public virtual int JobId { get; set; }
        public virtual int RecruiterId { get; set; }

        public virtual DateTime EvaluationDate { get; set; }
        public virtual decimal EvaluationScore { get; set; }

        public virtual Recruiter Recruiter { get; set; }
        public virtual JobPosition JobPosition { get; set; }
        public virtual Applicant Applicant { get; set; }
    

    }
}
