using Education.Data.Persistance.Configurations;
using Education.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Education.Data.Persistance
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<StudentInGroup> StudentInGroups { get; set;}
        public DbSet<Attendance> Attendances { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new LessonEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new GruopEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new StudentInGroupEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new AttandanceEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new StudentTypeConfiguration());

        }

    }
}
