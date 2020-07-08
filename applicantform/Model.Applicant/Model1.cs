namespace Model.Applicant
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<TB_Applicant> TB_Applicant { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TB_Applicant>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Applicant>()
                .Property(e => e.Contact_Number)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Applicant>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Applicant>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Applicant>()
                .Property(e => e.Question)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Applicant>()
                .Property(e => e.Created_By)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Applicant>()
                .Property(e => e.Modified_By)
                .IsUnicode(false);
        }
    }
}
