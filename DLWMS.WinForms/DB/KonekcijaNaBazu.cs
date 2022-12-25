
using System.Data.Entity;

namespace DLWMS.WinForms.DB
{

    //DLWMSContext
    public class KonekcijaNaBazu : DbContext
    {
        public KonekcijaNaBazu() : base("DLWMSPutanja")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Spol>().ToTable("Spolovi");
            modelBuilder.Entity<Student>().ToTable("Studenti");
            modelBuilder.Entity<Predmet>().ToTable("Predmeti");
            modelBuilder.Entity<StudentPredmet>().ToTable("StudentiPredmeti");
            modelBuilder.Entity<StudentiKonsultacije>().ToTable("StudentiKonsultacije");
        }       

        // DbSet se mora postaviti za svaku klasu da bi se poslije mogla koristiti kroz Entity Framework
        public DbSet<Spol> Spolovi { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<StudentPredmet> StudentiPredmeti { get; set; }
        public DbSet<StudentiKonsultacije> StudentiKonsultacije { get; set; }

    }
}