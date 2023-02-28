using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using technicalChallenge.Models;

namespace technicalChallenge
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           

            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Persona> Persona { get; set; }
    }
}
