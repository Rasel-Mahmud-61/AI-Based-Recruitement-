using AlBasedRecruiter.Models;
using FluentNHibernate.Mapping;

namespace AlBasedRecruiter.Mapping
{
    public class RecruiterMap:ClassMap<Recruiter>
    {
       public RecruiterMap() {

            Table("Recruiter");
            Id(x => x.RecruiterId).Column("Recruiter_id");
            Map(x => x.Name).Not.Nullable();
            Map(x => x.Phone);
            Map(x => x.Email);
            Map(x => x.Department);
        }
    }
}
