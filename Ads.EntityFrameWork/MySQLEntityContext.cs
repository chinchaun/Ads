using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Ads.DataAcces;
using System.Data.Entity;
using Ads.EntityFrameWork.Mapping;
using MySql.Data.Entity;

namespace Ads.EntityFrameWork
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MySQLEntityContext : DbContext, IDbContext
    {
        public MySQLEntityContext()
            : base("name=MySQLConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException("modelBuilder");
            }

            base.OnModelCreating(modelBuilder);

            //modelBuilder.Configurations.Add(new AdBaseMapping());
            //modelBuilder.Configurations.Add(new AuthorMapping());
            //modelBuilder.Configurations.Add(new BookStateMapping());
        }
    }
}
