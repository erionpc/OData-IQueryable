using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using OData_IQ_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OData_IQ_API.DbContexts
{
    public class RecordStoreDbContext : DbContext
    {
        public DbSet<Person>? People { get; set; }
        public DbSet<MusicRecord>? MusicRecords { get; set; }
        public DbSet<RecordStore>? RecordStores { get; set; }
        public DbSet<PersonMusicRecord>? PersonMusicRecords { get; set; }
        public DbSet<StoreMusicRecord>? StoreMusicRecords { get; set; }
        public DbSet<Rating>? Ratings { get; set; }

        public RecordStoreDbContext(DbContextOptions<RecordStoreDbContext> options)
           : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Person data
            modelBuilder.Entity<Person>().HasData(
                new Person()
                {
                    Id = 1,
                    Email = "test1@email.com",
                    Name = "name11",
                    Surname = "surname1",
                    DateOfBirth = new DateTimeOffset(new DateTime(2000, 1, 1))
                },
                new Person()
                {
                    Id = 2,
                    Email = "test2@email.com",
                    Name = "name12",
                    Surname = "surname2",
                    DateOfBirth = new DateTimeOffset(new DateTime(2000, 1, 2))
                },
                new Person()
                {
                    Id = 3,
                    Email = "test3@email.com",
                    Name = "name13",
                    Surname = "surname3",
                    DateOfBirth = new DateTimeOffset(new DateTime(2000, 1, 3))
                },
                new Person()
                {
                    Id = 4,
                    Email = "test4@email.com",
                    Name = "name14",
                    Surname = "surname4",
                    DateOfBirth = new DateTimeOffset(new DateTime(2000, 1, 4))
                });
            #endregion

            #region RecordStore data
            modelBuilder.Entity<RecordStore>(r =>
            {
                r.HasData(
                    new RecordStore()
                    {
                        Id = 1,
                        Name = "Record store 1",
                        StoreUri = new Uri("https://recordstore1.azurewebsites.net"),
                        Tags = new() { "classic", "jazz", "blues" }
                    },
                    new RecordStore()
                    {
                        Id = 2,
                        Name = "Record store 2",
                        StoreUri = new Uri("https://recordstore1.azurewebsites.net"),
                        Tags = new() { "rock", "punk", "grunge", "metal" }
                    });

                r.OwnsOne(r => r.StoreAddress).HasData(
                  new Address()
                  {
                      City = "City 1",
                      Country = "Country 1",
                      PostalCode = "CF101AA",
                      RecordStoreId = 1,
                      Street = "Street 1"
                  });
            });
            #endregion

            #region MusicRecord data
            modelBuilder.Entity<MusicRecord>().HasData(
                new MusicRecord()
                {
                    Id = 1,
                    Artist = "Artist 1",
                    Title = "Title 1",
                    Year = 2000
                },
                new MusicRecord()
                {
                    Id = 2,
                    Artist = "Artist 2",
                    Title = "Title 2",
                    Year = 2001
                },
                new MusicRecord()
                {
                    Id = 3,
                    Artist = "Artist 3",
                    Title = "Title 3",
                    Year = 2002
                },
                new MusicRecord()
                {
                    Id = 4,
                    Artist = "Artist 1",
                    Title = "Title 4",
                    Year = 2004
                },
                new MusicRecord()
                {
                    Id = 5,
                    Artist = "Artist 2",
                    Title = "Title 5",
                    Year = 2005
                },
                new MusicRecord()
                {
                    Id = 6,
                    Artist = "Artist 3",
                    Title = "Title 6",
                    Year = 2006
                });
            #endregion

            #region StoreMusicRecord data
            modelBuilder.Entity<StoreMusicRecord>().HasData(
                new StoreMusicRecord()
                {
                    Id = 1,
                    DateFirstArrived = new DateTime(2020, 1, 1),
                    RecordId = 1,
                    RecordStoreId = 1
                },
                new StoreMusicRecord()
                {
                    Id = 2,
                    DateFirstArrived = new DateTime(2020, 1, 2),
                    RecordId = 2,
                    RecordStoreId = 1
                },
                new StoreMusicRecord()
                {
                    Id = 3,
                    DateFirstArrived = new DateTime(2020, 1, 3),
                    RecordId = 3,
                    RecordStoreId = 1
                },
                new StoreMusicRecord()
                {
                    Id = 4,
                    DateFirstArrived = new DateTime(2020, 1, 4),
                    RecordId = 4,
                    RecordStoreId = 1
                },
                new StoreMusicRecord()
                {
                    Id = 5,
                    DateFirstArrived = new DateTime(2020, 1, 5),
                    RecordId = 2,
                    RecordStoreId = 2
                },
                new StoreMusicRecord()
                {
                    Id = 6,
                    DateFirstArrived = new DateTime(2020, 1, 6),
                    RecordId = 3,
                    RecordStoreId = 2
                },
                new StoreMusicRecord()
                {
                    Id = 7,
                    DateFirstArrived = new DateTime(2020, 1, 7),
                    RecordId = 4,
                    RecordStoreId = 2
                },
                new StoreMusicRecord()
                {
                    Id = 8,
                    DateFirstArrived = new DateTime(2020, 1, 8),
                    RecordId = 5,
                    RecordStoreId = 2
                },
                new StoreMusicRecord()
                {
                    Id = 9,
                    DateFirstArrived = new DateTime(2020, 1, 9),
                    RecordId = 6,
                    RecordStoreId = 2
                });
            #endregion

            #region PersonMusicRecord data
            modelBuilder.Entity<PersonMusicRecord>().HasData(
                new PersonMusicRecord()
                {
                    Id = 1,
                    PersonId = 1,
                    StoreRecordId = 1,
                    DateBought = new DateTime(2022, 1, 1)
                },
                new PersonMusicRecord()
                {
                    Id = 2,
                    PersonId = 1,
                    StoreRecordId = 2,
                    DateBought = new DateTime(2022, 1, 1)
                },
                new PersonMusicRecord()
                {
                    Id = 3,
                    PersonId = 1,
                    StoreRecordId = 3,
                    DateBought = new DateTime(2022, 1, 1)
                },
                new PersonMusicRecord()
                {
                    Id = 4,
                    PersonId = 2,
                    StoreRecordId = 2,
                    DateBought = new DateTime(2022, 1, 2)
                },
                new PersonMusicRecord()
                {
                    Id = 5,
                    PersonId = 2,
                    StoreRecordId = 3,
                    DateBought = new DateTime(2022, 1, 2)
                },
                new PersonMusicRecord()
                {
                    Id = 6,
                    PersonId = 2,
                    StoreRecordId = 4,
                    DateBought = new DateTime(2022, 1, 2)
                },
                new PersonMusicRecord()
                {
                    Id = 7,
                    PersonId = 2,
                    StoreRecordId = 5,
                    DateBought = new DateTime(2022, 1, 2)
                },
                new PersonMusicRecord()
                {
                    Id = 8,
                    PersonId = 3,
                    StoreRecordId = 5,
                    DateBought = new DateTime(2022, 1, 3)
                },
                new PersonMusicRecord()
                {
                    Id = 9,
                    PersonId = 3,
                    StoreRecordId = 6,
                    DateBought = new DateTime(2022, 1, 3)
                },
                new PersonMusicRecord()
                {
                    Id = 10,
                    PersonId = 3,
                    StoreRecordId = 7,
                    DateBought = new DateTime(2022, 1, 3)
                },
                new PersonMusicRecord()
                {
                    Id = 11,
                    PersonId = 3,
                    StoreRecordId = 8,
                    DateBought = new DateTime(2022, 1, 3)
                });
            #endregion

            #region Rating data
            modelBuilder.Entity<Rating>().HasData(
                new Rating()
                {
                    Id = 1,
                    MusicRecordId = 1,
                    RatedByPersonId = 1,
                    Value = 4,
                    RatedDate = new DateTime(2022, 1, 1)
                },
                new Rating()
                {
                    Id = 2,
                    MusicRecordId = 2,
                    RatedByPersonId = 1,
                    Value = 5,
                    RatedDate = new DateTime(2022, 1, 1)
                },
                new Rating()
                {
                    Id = 3,
                    MusicRecordId = 4,
                    RatedByPersonId = 1,
                    Value = 3,
                    RatedDate = new DateTime(2022, 1, 1)
                },
                new Rating()
                {
                    Id = 4,
                    MusicRecordId = 2,
                    RatedByPersonId = 2,
                    Value = 4,
                    RatedDate = new DateTime(2022, 1, 1)
                },
                new Rating()
                {
                    Id = 5,
                    MusicRecordId = 3,
                    RatedByPersonId = 2,
                    Value = 4,
                    RatedDate = new DateTime(2022, 1, 1)
                },
                new Rating()
                {
                    Id = 6,
                    MusicRecordId = 3,
                    RatedByPersonId = 3,
                    Value = 5,
                    RatedDate = new DateTime(2022, 1, 1)
                },
                new Rating()
                {
                    Id = 7,
                    MusicRecordId = 2,
                    RatedByPersonId = 3,
                    Value = 5,
                    RatedDate = new DateTime(2022, 1, 1)
                },
                new Rating()
                {
                    Id = 8,
                    RecordStoreId = 1,
                    RatedByPersonId = 1,
                    Value = 5,
                    RatedDate = new DateTime(2022, 1, 1)
                },
                new Rating()
                {
                    Id = 9,
                    RecordStoreId = 1,
                    RatedByPersonId = 2,
                    Value = 5,
                    RatedDate = new DateTime(2022, 1, 1)
                },
                new Rating()
                {
                    Id = 10,
                    RecordStoreId = 1,
                    RatedByPersonId = 3,
                    Value = 4,
                    RatedDate = new DateTime(2022, 1, 1)
                },
                new Rating()
                {
                    Id = 11,
                    RecordStoreId = 2,
                    RatedByPersonId = 1,
                    Value = 4,
                    RatedDate = new DateTime(2022, 1, 1)
                },
                new Rating()
                {
                    Id = 12,
                    RecordStoreId = 2,
                    RatedByPersonId = 2,
                    Value = 5,
                    RatedDate = new DateTime(2022, 1, 1)
                });
            #endregion

            // comparer & converter for storing a list of strings
            var stringListValueComparer = new ValueComparer<List<string>>(
                  (v1, v2) => v1!.SequenceEqual(v2!),
                  v => v.Aggregate(0, (a, f) => HashCode.Combine(a, f.GetHashCode())),
                  v => v.ToList());

            modelBuilder.Entity<RecordStore>()
                .Property(r => r.Tags)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions?)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions?)null)!);

            modelBuilder.Entity<RecordStore>()
               .Property(r => r.Tags)
               .Metadata
               .SetValueComparer(stringListValueComparer);

            modelBuilder.Entity<RecordStore>().OwnsOne(p => p.StoreAddress);

            modelBuilder.Entity<Person>().HasIndex(p => p.Email).IsUnique();

            modelBuilder.Entity<StoreMusicRecord>().HasIndex(p => new { p.RecordStoreId, p.RecordId }).IsUnique();
        }
    }
}
