using Microsoft.EntityFrameworkCore;

public static class JobSeekerDatabaseBuilder
{

    static void SetDataToDB(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<JobSeeker>().HasData(
         new JobSeeker
         { 
             Id = 1,
             Name = "Hakan",
             Surname = "Sarı",
             CoverLetter = "Merhaba ben Hakan Sarı..........",
             LevelOfEducation = "Bachelor's Degree"
         },
         new JobSeeker
         { 
             Id = 2,
             Name = "Emre",
             Surname = "Demir",
             CoverLetter = "Merhaba ben Emre Demir..........",
             LevelOfEducation = "Master of Engineering"
         }
     );
        
    }
}