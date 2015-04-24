using Ads.DataAcces;
using Ads.EntityFrameWork.Mapping;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Linq;

namespace Ads.EntityFrameWork
{
    public class SQLServerEntityContext : DbContext, IContext
    {

        public SQLServerEntityContext()
            : base(ConfigurationManager.ConnectionStrings["LibraryConnectionString"].ToString())
        {
            //Database.SetInitializer<EntityContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException("modelBuilder");
            }

            base.OnModelCreating(modelBuilder);

           // modelBuilder.Configurations.Add(new BookMapping());

        }

        //public void SaveOrUpdate()
        //{
        //    SaveChanges();
        //}

        //public void Add<T>(T entity) where T : class
        //{
        //    Set<T>().Add(entity);
        //}

        //public void Delete<T>(T entity) where T : class
        //{
        //    Set<T>().Remove(entity);
        //}

        //public IQueryable<T> Query<T>() where T : class
        //{
        //    return Set<T>();
        //}

        //public void GetById<T> (int id)
        //{            
        //}

        T IContext.GetById<T>(int id)
        {
            throw new NotImplementedException();
        }

        void IContext.Add<T>(T entity)
        {
            throw new NotImplementedException();
        }

        void IContext.Delete<T>(T entity)
        {
            throw new NotImplementedException();
        }

        void IContext.SaveOrUpdate()
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IContext.Query<T>()
        {
            throw new NotImplementedException();
        }
    }
}
