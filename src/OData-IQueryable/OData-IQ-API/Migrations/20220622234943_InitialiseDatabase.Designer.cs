﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OData_IQ_API.DbContexts;

#nullable disable

namespace OData_IQ_API.Migrations
{
    [DbContext(typeof(RecordStoreDbContext))]
    [Migration("20220622234943_InitialiseDatabase")]
    partial class InitialiseDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OData_IQ_API.Entities.MusicRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("RecordStoreId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecordStoreId");

                    b.ToTable("MusicRecords");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Artist = "Artist 1",
                            Title = "Title 1",
                            Year = 2000
                        },
                        new
                        {
                            Id = 2,
                            Artist = "Artist 2",
                            Title = "Title 2",
                            Year = 2001
                        },
                        new
                        {
                            Id = 3,
                            Artist = "Artist 3",
                            Title = "Title 3",
                            Year = 2002
                        },
                        new
                        {
                            Id = 4,
                            Artist = "Artist 1",
                            Title = "Title 4",
                            Year = 2004
                        },
                        new
                        {
                            Id = 5,
                            Artist = "Artist 2",
                            Title = "Title 5",
                            Year = 2005
                        },
                        new
                        {
                            Id = 6,
                            Artist = "Artist 3",
                            Title = "Title 6",
                            Year = 2006
                        });
                });

            modelBuilder.Entity("OData_IQ_API.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset>("DateOfBirth")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "test1@email.com",
                            Name = "name11",
                            Surname = "surname1"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTimeOffset(new DateTime(2000, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "test2@email.com",
                            Name = "name12",
                            Surname = "surname2"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTimeOffset(new DateTime(2000, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "test3@email.com",
                            Name = "name13",
                            Surname = "surname3"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTimeOffset(new DateTime(2000, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "test4@email.com",
                            Name = "name14",
                            Surname = "surname4"
                        });
                });

            modelBuilder.Entity("OData_IQ_API.Entities.PersonMusicRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateBought")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int?>("RecordId")
                        .HasColumnType("int");

                    b.Property<int>("StoreRecordId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("RecordId");

                    b.ToTable("PersonMusicRecord");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateBought = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonId = 1,
                            StoreRecordId = 1
                        },
                        new
                        {
                            Id = 2,
                            DateBought = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonId = 1,
                            StoreRecordId = 2
                        },
                        new
                        {
                            Id = 3,
                            DateBought = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonId = 1,
                            StoreRecordId = 3
                        },
                        new
                        {
                            Id = 4,
                            DateBought = new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonId = 2,
                            StoreRecordId = 2
                        },
                        new
                        {
                            Id = 5,
                            DateBought = new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonId = 2,
                            StoreRecordId = 3
                        },
                        new
                        {
                            Id = 6,
                            DateBought = new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonId = 2,
                            StoreRecordId = 4
                        },
                        new
                        {
                            Id = 7,
                            DateBought = new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonId = 2,
                            StoreRecordId = 5
                        },
                        new
                        {
                            Id = 8,
                            DateBought = new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonId = 3,
                            StoreRecordId = 5
                        },
                        new
                        {
                            Id = 9,
                            DateBought = new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonId = 3,
                            StoreRecordId = 6
                        },
                        new
                        {
                            Id = 10,
                            DateBought = new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonId = 3,
                            StoreRecordId = 7
                        },
                        new
                        {
                            Id = 11,
                            DateBought = new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonId = 3,
                            StoreRecordId = 8
                        });
                });

            modelBuilder.Entity("OData_IQ_API.Entities.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MusicRecordId")
                        .HasColumnType("int");

                    b.Property<int>("RatedByPersonId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RecordStoreId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MusicRecordId");

                    b.HasIndex("RatedByPersonId");

                    b.HasIndex("RecordStoreId");

                    b.ToTable("Rating");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MusicRecordId = 1,
                            RatedByPersonId = 1,
                            RatedDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 4
                        },
                        new
                        {
                            Id = 2,
                            MusicRecordId = 2,
                            RatedByPersonId = 1,
                            RatedDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 5
                        },
                        new
                        {
                            Id = 3,
                            MusicRecordId = 4,
                            RatedByPersonId = 1,
                            RatedDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 3
                        },
                        new
                        {
                            Id = 4,
                            MusicRecordId = 2,
                            RatedByPersonId = 2,
                            RatedDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 4
                        },
                        new
                        {
                            Id = 5,
                            MusicRecordId = 3,
                            RatedByPersonId = 2,
                            RatedDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 4
                        },
                        new
                        {
                            Id = 6,
                            MusicRecordId = 3,
                            RatedByPersonId = 3,
                            RatedDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 5
                        },
                        new
                        {
                            Id = 7,
                            MusicRecordId = 2,
                            RatedByPersonId = 3,
                            RatedDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Value = 5
                        });
                });

            modelBuilder.Entity("OData_IQ_API.Entities.RecordStore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("StoreUri")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RecordStores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Record store 1",
                            StoreUri = "https://recordstore1.azurewebsites.net/",
                            Tags = "[\"classic\",\"jazz\",\"blues\"]"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Record store 2",
                            StoreUri = "https://recordstore1.azurewebsites.net/",
                            Tags = "[\"rock\",\"punk\",\"grunge\",\"metal\"]"
                        });
                });

            modelBuilder.Entity("OData_IQ_API.Entities.StoreMusicRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateFirstArrived")
                        .HasColumnType("datetime2");

                    b.Property<int>("RecordId")
                        .HasColumnType("int");

                    b.Property<int>("RecordStoreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecordId");

                    b.HasIndex("RecordStoreId", "RecordId")
                        .IsUnique();

                    b.ToTable("StoreMusicRecord");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateFirstArrived = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RecordId = 1,
                            RecordStoreId = 1
                        },
                        new
                        {
                            Id = 2,
                            DateFirstArrived = new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RecordId = 2,
                            RecordStoreId = 1
                        },
                        new
                        {
                            Id = 3,
                            DateFirstArrived = new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RecordId = 3,
                            RecordStoreId = 1
                        },
                        new
                        {
                            Id = 4,
                            DateFirstArrived = new DateTime(2020, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RecordId = 4,
                            RecordStoreId = 1
                        },
                        new
                        {
                            Id = 5,
                            DateFirstArrived = new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RecordId = 2,
                            RecordStoreId = 2
                        },
                        new
                        {
                            Id = 6,
                            DateFirstArrived = new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RecordId = 3,
                            RecordStoreId = 2
                        },
                        new
                        {
                            Id = 7,
                            DateFirstArrived = new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RecordId = 4,
                            RecordStoreId = 2
                        },
                        new
                        {
                            Id = 8,
                            DateFirstArrived = new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RecordId = 5,
                            RecordStoreId = 2
                        },
                        new
                        {
                            Id = 9,
                            DateFirstArrived = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RecordId = 6,
                            RecordStoreId = 2
                        });
                });

            modelBuilder.Entity("OData_IQ_API.Entities.MusicRecord", b =>
                {
                    b.HasOne("OData_IQ_API.Entities.RecordStore", null)
                        .WithMany("Records")
                        .HasForeignKey("RecordStoreId");
                });

            modelBuilder.Entity("OData_IQ_API.Entities.PersonMusicRecord", b =>
                {
                    b.HasOne("OData_IQ_API.Entities.Person", null)
                        .WithMany("Records")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OData_IQ_API.Entities.StoreMusicRecord", "Record")
                        .WithMany()
                        .HasForeignKey("RecordId");

                    b.Navigation("Record");
                });

            modelBuilder.Entity("OData_IQ_API.Entities.Rating", b =>
                {
                    b.HasOne("OData_IQ_API.Entities.MusicRecord", "Record")
                        .WithMany("Ratings")
                        .HasForeignKey("MusicRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OData_IQ_API.Entities.Person", "RatedByPerson")
                        .WithMany()
                        .HasForeignKey("RatedByPersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OData_IQ_API.Entities.RecordStore", null)
                        .WithMany("Ratings")
                        .HasForeignKey("RecordStoreId");

                    b.Navigation("RatedByPerson");

                    b.Navigation("Record");
                });

            modelBuilder.Entity("OData_IQ_API.Entities.RecordStore", b =>
                {
                    b.OwnsOne("OData_IQ_API.Entities.Address", "StoreAddress", b1 =>
                        {
                            b1.Property<int>("RecordStoreId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.Property<string>("Country")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.Property<string>("PostalCode")
                                .HasMaxLength(10)
                                .HasColumnType("nvarchar(10)");

                            b1.Property<string>("Street")
                                .HasMaxLength(200)
                                .HasColumnType("nvarchar(200)");

                            b1.HasKey("RecordStoreId");

                            b1.ToTable("RecordStores");

                            b1.WithOwner()
                                .HasForeignKey("RecordStoreId");

                            b1.HasData(
                                new
                                {
                                    RecordStoreId = 1,
                                    City = "City 1",
                                    Country = "Country 1",
                                    PostalCode = "CF101AA",
                                    Street = "Street 1"
                                });
                        });

                    b.Navigation("StoreAddress");
                });

            modelBuilder.Entity("OData_IQ_API.Entities.StoreMusicRecord", b =>
                {
                    b.HasOne("OData_IQ_API.Entities.MusicRecord", "Record")
                        .WithMany()
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OData_IQ_API.Entities.RecordStore", "Store")
                        .WithMany()
                        .HasForeignKey("RecordStoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Record");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("OData_IQ_API.Entities.MusicRecord", b =>
                {
                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("OData_IQ_API.Entities.Person", b =>
                {
                    b.Navigation("Records");
                });

            modelBuilder.Entity("OData_IQ_API.Entities.RecordStore", b =>
                {
                    b.Navigation("Ratings");

                    b.Navigation("Records");
                });
#pragma warning restore 612, 618
        }
    }
}
