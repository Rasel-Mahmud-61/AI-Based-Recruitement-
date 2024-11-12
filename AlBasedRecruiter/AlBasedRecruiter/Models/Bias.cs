namespace AlBasedRecruiter.Models
{
    public class Bias
    {
        public virtual int BiasId { get; set; } 
        public virtual int ApplicantId {  get; set; }
        public virtual int JobId { get; set; }
        public virtual int InterviewId { get; set; }
        public virtual int EvaluationId { get; set; }
        public virtual string InterviewBiasStatus { get; set; } 
        public virtual Applicant Applicant { get; set; }
        public virtual JobPosition JobPosition { get; set; }

        public virtual Interview Interview { get; set; }    
        public virtual AIEvaluation AIEvaluation { get; set; }

    }
}
