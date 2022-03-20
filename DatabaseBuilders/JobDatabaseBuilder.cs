using Microsoft.EntityFrameworkCore;

public static class JobDatabaseBuilder
{

    static void SetDataToDB(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Job>().HasData(
         new Job
         { 
             Id = 1,
             Name = "Software Engineer",
             Salary = 10000,
             JobType = "Remote"
         },
         new Job
         { 
             Id = 2,
             Name = "Data Specialist",
             Salary = 15000,
             JobType = "Part Time"
         },
         new Job
         { 
             Id = 3,
             Name = "Full Stack Software Developer",
             Salary = 25000,
             JobType = "Contractual"
         }
        );
    }
        public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Job>(entity =>
         {
             entity.HasKey(e => e.Id);
             entity.Property(e => e.Name).IsRequired();
             entity.Property(e => e.Salary).IsRequired();
             entity.Property(e => e.JobType).IsRequired();

         });

        SetDataToDB(modelBuilder);
    }
}