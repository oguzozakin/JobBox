using Microsoft.EntityFrameworkCore;

public static class PositionDatabaseBuilder
{

    static void SetDataToDB(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Position>().HasData(
         new Employeer
         { 
             Id = 1,
             Name = "CEO",
         },
         new Employeer
         { 
             Id = 2,
             Name = "CTO",
         }
     );
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
    }
     public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Position>(entity =>
         {
             entity.HasKey(e => e.Id);
             entity.Property(e => e.Name).IsRequired();
             entity.HasMany(e => e.Employeer).WithMany(e => e.Position).UsingEntity(j => j.ToTable("Employeer_Workplace"));

         });

        modelBuilder.Entity<Employeer>(entity =>
       {
           entity.HasKey(e => e.Id);
           entity.Property(e => e.Name).IsRequired();
           entity.Property(e => e.Surname).IsRequired();
       });

        SetDataToDB(modelBuilder);
    }
}