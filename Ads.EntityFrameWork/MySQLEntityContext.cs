using System;
using System.Linq;
using Ads.DataAcces;
using System.Data.Entity;
using Ads.EntityFrameWork.Mapping;
using System.Configuration;
using MySql.Data.Entity;
using Ads.Model;

namespace Ads.EntityFrameWork
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MySQLEntityContext : DbContext, IContext
    {
        public MySQLEntityContext()
            : base(ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString())
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException("modelBuilder");
            }

            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AdBaseMapping());

        }

        public virtual DbSet<AdBase> AdBases { get; set; }

        public T GetById<T>(int id) where T : class {

            return base.Set<T>().Find(id);
        }

        public void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Query<T>() where T : class
        {
            throw new NotImplementedException();
        }
    }
}
