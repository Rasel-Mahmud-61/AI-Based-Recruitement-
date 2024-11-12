using Antlr.Runtime.Tree;

namespace AlBasedRecruiter.Models
{
    public class HiringOffer
    {
        public virtual int HiringId { get; set; }   
        public virtual int ApplicantId {  get; set; }
        public virtual int JobId { get; set; }
        public virtual int EvaluationId { get; set; }
        public virtual int InterviewId { get; set; }
        public virtual string InterViewBiasStatus { get; set; }   
        public virtual Applicant  Applicant { get; set; }
        public virtual  JobPosition JobPosition { get; set; }
        public virtual AIEvaluation  AIEvaluation { get; set; }
        public virtual Interview Interview { get; set; }  

        public virtual string HiringStatus { get; set; }    

    }
}
