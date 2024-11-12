using AlBasedRecruiter.Models;
using FluentNHibernate.Mapping;
using System.Security.Cryptography.Xml;

namespace AlBasedRecruiter.Mapping
{
    public class AIEvaluationMap : ClassMap<AIEvaluation>
    {
        public AIEvaluationMap() {

            Table("AI_Evaluation");

            Id(x => x.EvaluationId).Column("Evaluation_id");
            Map(x => x.EvaluationDate);
            Map(x => x.EvaluationScore);

            //mapping foreign key

            References(x => x.Applicant).Column("Applicant_id").Not.Nullable();

            References(x => x.JobPosition).Column("Job_id").Not.Nullable();


        
        
        }    
    }
}
