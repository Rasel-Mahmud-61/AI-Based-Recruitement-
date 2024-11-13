using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate;
using AlBasedRecruiter.Models;

namespace AlBasedRecruiter
{
    public class NhibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    string connectionString = "Data Source=LAPTOP-SP1NASH4\\SQLEXPRESS;Initial Catalog = AIRecruitement;TrustServerCertificate=True; Trusted_Connection=True;";
                    _sessionFactory = Fluently.Configure()
                        .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString)
                                                              .CommandTimeout(60)
                                                              .ShowSql())

                       .Mappings(m => m.FluentMappings
                            .AddFromAssemblyOf<JobPosition>()   // Adds JobPosition mappings
                            .AddFromAssemblyOf<Applicant>()     // Adds Applicant mappings
                            .AddFromAssemblyOf<Recruiter>()  
                            .AddFromAssemblyOf<Interview>()
                             .AddFromAssemblyOf<AIEvaluation>() 
                             .AddFromAssemblyOf<Bias>()
                      
                        )

                        .BuildSessionFactory();
                }

                return _sessionFactory;
            }
        }

        public static NHibernate.ISession GetSession()
        {
            return SessionFactory.OpenSession();
        }

        
    }
}
