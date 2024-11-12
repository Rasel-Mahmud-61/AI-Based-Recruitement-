using AlBasedRecruiter.Models;
using FluentNHibernate.Mapping;

namespace AlBasedRecruiter.Mapping
{
    public class HiringOfferMap:ClassMap<HiringOffer>
    {
        public HiringOfferMap() {

            Table("Hiring_Offer");

            Id(x => x.HiringId).Column("hiring_id");
            Map(x => x.HiringStatus);

            Map(x => x.InterViewBiasStatus);

            References(x => x.Applicant).Column("Applicant_id").Not.Nullable();

            References(x => x.JobPosition).Column("Job_id").Not.Nullable();
            References(x => x.AIEvaluation).Column("Evaluation_id").Not.Nullable();
            References(x => x.Interview).Column("Interview_id").Not.Nullable();



        }
    }
}
