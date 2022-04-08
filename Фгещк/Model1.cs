using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Фгещк
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public object USER { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
