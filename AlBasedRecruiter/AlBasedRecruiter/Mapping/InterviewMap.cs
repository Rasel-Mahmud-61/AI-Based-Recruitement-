using AlBasedRecruiter.Models;
using FluentNHibernate.Mapping;

namespace AlBasedRecruiter.Mapping
{
    public class InterviewMap:ClassMap<Interview>
    {
         public InterviewMap() {

            Table("Interview");
            Id(x => x.InterviewId).Column("Interview_id");
            Map(x => x.InterviewDate).Column("Interview_date");
            Map(x => x.InterviewScore).Column("Interview_Score");


            // map foreign key 
            References(x => x.Applicant).Column("Applicant_id").Not.Nullable(); ;
            References(x => x.JobPosition).Column("Job_id").Not.Nullable();

            References(x => x.Recruiter).Column("Recruiter_id").Not.Nullable();


        
        
        }
    }
}
