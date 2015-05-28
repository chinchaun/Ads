using System;
using System.Linq;
using System.Data.Entity;
using Ads.EntityFrameWork.Mapping;
using System.Configuration;
using MySql.Data.Entity;
using Ads.Model;
using Ads.DataAcces;

namespace Ads.EntityFrameWork
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public partial class OLDModelMySQLEntityContext : DbContext, IContext
    {
        public OLDModelMySQLEntityContext()
            : base(ConfigurationManager.ConnectionStrings[2].ToString())
        {
        }

        //public ModelMySQLEntityContext() : base("name=DialisisEntities")
        //{
        //}


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException("modelBuilder");
            }

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<estudio> estudio { get; set; }
        public DbSet<localizacionanastomosi> localizacionanastomosi { get; set; }
        public DbSet<motivobaja> motivobaja { get; set; }
        public DbSet<observacione> observacione { get; set; }
        public DbSet<paciente_ioma> paciente_ioma { get; set; }
        public DbSet<paciente_pami> paciente_pami { get; set; }
        public DbSet<paciente> pacientes { get; set; }
        public DbSet<pacientes_estudios> pacientes_estudios { get; set; }
        public DbSet<tipoanastomosi> tipoanastomosi { get; set; }
        public DbSet<accesovascular> accesovascular { get; set; }
        public DbSet<obrasocial> obrasocial { get; set; }
        public DbSet<vacuna_paciente> vacuna_paciente { get; set; }
        public DbSet<vacuna> vacuna { get; set; }


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
            return Set<T>();
        }

    }
}
