using AlBasedRecruiter.Models;
using FluentNHibernate.Mapping;
using System.Security.Cryptography.Xml;

namespace AlBasedRecruiter.Mapping
{
    public class ApplicantMap:ClassMap<Applicant>
    {
        public ApplicantMap() {

            Table("Applicant");
            Id(x=>x.ApplicantId).Column("Applicant_id");
            Map(x => x.Name).Not.Nullable();
            Map(x => x.Email);
            Map(x => x.Resume);
            Map(x => x.ApplicationDate).Column("Application_date");
            Map(x => x.Gender);
            Map(x=>x.Age);

            // mapping foreign key 
            References(x => x.Recruiter).Column("Recruiter_id").Nullable();
            References(x => x.JobPosition).Column("Job_id").Nullable();

        }
    }
}
