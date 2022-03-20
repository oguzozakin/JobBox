using Microsoft.EntityFrameworkCore;

public static class EmployeerDatabaseBuilder
{

    static void SetDataToDB(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employeer>().HasData(
         new Employeer
         { 
             Id = 1,
             Name = "Oğuz",
             Surname = "Özakın",
         },
         new Employeer
         { 
             Id = 2,
             Name = "İhsan",
             Surname = "Özakın",
         }
     );
        modelBuilder.Entity<WorkPlace>().HasData(
          new WorkPlace
          {
              Id = 1,
              Name = "Saha Bt",
              PhoneNumber="55645664",

          },
          new WorkPlace
          {
              Id = 2,
              Name = "Turkcell",
              PhoneNumber ="646465231",

          }
      );
      modelBuilder.Entity<Position>().HasData(
          new Position
          {
              Id = 1,
              Name = "CEO",
              
          },
          new Position
          {
              Id = 2,
              Name = "CTO",
             
          },
          new Position
          {
              Id = 3,
              Name = "Human Resources Specialist",
             
          }
      );
    }

        public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employeer>(entity =>
         {
             entity.HasKey(e => e.Id);
             entity.Property(e => e.Name).IsRequired();
             entity.Property(e => e.Surname).IsRequired();
             entity.HasMany(e => e.WorkPlace).WithMany(e => e.Employeer).UsingEntity(j => j.ToTable("Employeer_Workplace"));

         });

        modelBuilder.Entity<WorkPlace>(entity =>
       {
           entity.HasKey(e => e.Id);
           entity.Property(e => e.Name).IsRequired();
           entity.Property(e => e.PhoneNumber).IsRequired();
       });

        SetDataToDB(modelBuilder);
    }
}