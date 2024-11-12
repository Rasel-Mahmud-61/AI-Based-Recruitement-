using AlBasedRecruiter.Models;
using FluentNHibernate.Mapping;

namespace AlBasedRecruiter.Mapping
{
    public class JobPositionMap : ClassMap<JobPosition>
    {
        public JobPositionMap()
        {
            Table("Job_Position");
            Id(x => x.JobId).Column("Job_id");
            Map(x => x.Title).Not.Nullable();
            Map(x => x.Salary);
            Map(x => x.Description);
            Map(x => x.Department);
        }
    }
}
