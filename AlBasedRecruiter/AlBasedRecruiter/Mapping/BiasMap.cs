using AlBasedRecruiter.Models;
using FluentNHibernate.Mapping;

namespace AlBasedRecruiter.Mapping
{
    public class BiasMap:ClassMap<Bias>

    {
        public BiasMap() {
            Table("Bias");

            Id(x => x.BiasId).Column("Bias_id").Not.Nullable();
            Map(x => x.InterviewBiasStatus);


            // mapping foreign key 

            References(x => x.Applicant).Column("Applicant_id").Not.Nullable();
            References(x => x.JobPosition).Column("job_id").Not.Nullable();

            References(x=>x.AIEvaluation).Column("Evaluation_id").Nullable();
            References(x => x.Interview).Column("Interview_id").Nullable();


        }
    }
}
