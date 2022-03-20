using Microsoft.EntityFrameworkCore;

public static class AddressDatabaseBuilder
{


    static void SetDataToDB(ModelBuilder modelBuilder)
    {

    }
    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
          {
              entity.HasKey(e => e.Id);
              entity.Property(e => e.Name).IsRequired();
              entity.Property(e => e.OpenAddress1);
              entity.Property(e => e.OpenAddress2);
              entity.HasOne(e => e.City).WithMany(e => e.Addresses).HasForeignKey(e => e.CityId);
              entity.HasOne(e => e.District).WithMany(e => e.Addresses).HasForeignKey(e => e.DistrictId);
            


          });
    



        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name);
         

        });

        modelBuilder.Entity<District>(entity =>
       {
           entity.HasKey(e => e.Id);

           entity.Property(e => e.Name);
           entity.HasOne(c => c.City).WithMany(c => c.District).HasForeignKey(c => c.CityId);
       });

        modelBuilder.Entity<Address>().HasData(
     new Address
     {
         Id = 1,
         Name = "Mustafa",
         OpenAddress1 = "bagcilar sok mahalllesi",
         OpenAddress2 = "caminin önü",
         CityId = 2,
         DistrictId = 3

     },
     new Address
     {
         Id = 2,
         Name = "Dilek",
         OpenAddress1 = "Pendik sok mahalllesi",
         OpenAddress2 = "caminin karsisi",
         CityId = 6,
         DistrictId = 11

     },
     new Address
     {
         Id = 3,
         Name = "Reyhan",
         OpenAddress1 = "Bahçelievler  mahalllesi",
         OpenAddress2 = "meşhur köftecinin yani",
         CityId = 4,
         DistrictId = 8

     },
     new Address
     {
         Id = 4,
         Name = "İhsan",
         OpenAddress1 = "kadıköy sahil",
         OpenAddress2 = "boğa çaprazı",
         CityId = 5,
         DistrictId = 10

     },
      new Address
      {
          Id = 5,
          Name = "Umut",
          OpenAddress1 = "maltepe  iş sokak mahalllesi",
          OpenAddress2 = "polis karakolu yanı",
          CityId = 1,
          DistrictId = 1

      },
      new Address
      {
          Id = 6,
          Name = "Oğuz",
          OpenAddress1 = "İş adresi sokak mahalle",
          OpenAddress2 = " saha bilgi teknolojileri",
          CityId = 2,
          DistrictId = 4

      }
     );
 
        modelBuilder.Entity<City>().HasData(
            new City
            {
                Id = 1,
                Name = "Ankara",
              



            },
              new City
              {
                  Id = 2,
                  Name = "Istanbul",
                  


              },
            new City
            {
                Id = 3,
                Name = "Bursa",
                

            },
              new City
              {
                  Id = 4,
                  Name = "Izmir",
                  

              },
              new City
              {
                  Id = 5,
                  Name = "Sakarya",
                  
                 

              },
              new City
              {
                  Id = 6,
                  Name = "Manisa",
                  


              }


        );



        modelBuilder.Entity<District>().HasData(
          new District
          {
              Id = 1,
              Name = "Kecioren",
              CityId = 1

          },
          new District
          {
              Id = 2,
              Name = "Mamak",
              CityId = 1

          },
          new District
          {
              Id = 3,
              Name = "Bagcılar",
              CityId = 2

          },
          new District
          {
              Id = 4,
              Name = "Besiktas",
              CityId = 2

          },
          new District
          {
              Id = 5,
              Name = "Manhattan",
              CityId = 3

          },
          new District
          {
              Id = 6,
              Name = "Brooklyn",
              CityId = 3

          },
          new District
          {
              Id = 7,
              Name = "Hollywood",
              CityId = 4

          },
          new District
          {
              Id = 8,
              Name = "Santa Monica",
              CityId = 4

          },
          new District
          {
              Id = 9,
              Name = "Altstadt",
              CityId = 5

          },
          new District
          {
              Id = 10,
              Name = "Neuhausen",
              CityId = 5

          },
          new District
          {
              Id = 11,
              Name = "Greenwich",
              CityId = 6

          },
          new District
          {
              Id = 12,
              Name = "Soho",
              CityId = 6

          }
       );
       SetDataToDB(modelBuilder);
    }
}


