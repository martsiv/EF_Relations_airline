﻿// <auto-generated />
using System;
using EF_Relations_airline;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_Relations_airline.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClientFlight", b =>
                {
                    b.Property<int>("ClientsId")
                        .HasColumnType("int");

                    b.Property<int>("FlightsId")
                        .HasColumnType("int");

                    b.HasKey("ClientsId", "FlightsId");

                    b.HasIndex("FlightsId");

                    b.ToTable("ClientFlight");
                });

            modelBuilder.Entity("EF_Relations_airline.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Login = "willsmith",
                            Password = "qwerty1"
                        },
                        new
                        {
                            Id = 2,
                            Login = "abrahamg",
                            Password = "qwerty1"
                        },
                        new
                        {
                            Id = 3,
                            Login = "sarahb",
                            Password = "qwerty1"
                        },
                        new
                        {
                            Id = 4,
                            Login = "annared",
                            Password = "qwerty1"
                        },
                        new
                        {
                            Id = 5,
                            Login = "riardenw",
                            Password = "qwerty1"
                        });
                });

            modelBuilder.Entity("EF_Relations_airline.Airplane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("MaxPassengers")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Airplanes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            MaxPassengers = 300,
                            Model = "AN-15"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 6,
                            MaxPassengers = 8,
                            Model = "Super Jet 03"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 3,
                            MaxPassengers = 220,
                            Model = "Airbus CW-2"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 2,
                            MaxPassengers = 280,
                            Model = "Boeing 747"
                        });
                });

            modelBuilder.Entity("EF_Relations_airline.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.HasIndex("GenderId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountId = 1,
                            Email = "wills@gmail.com",
                            GenderId = 1,
                            Name = "Will",
                            Surname = "Smith"
                        },
                        new
                        {
                            Id = 2,
                            AccountId = 2,
                            Email = "abrahamg@gmail.com",
                            GenderId = 1,
                            Name = "Abraham",
                            Surname = "Green"
                        },
                        new
                        {
                            Id = 3,
                            AccountId = 3,
                            Email = "sarahb@gmail.com",
                            GenderId = 2,
                            Name = "Sarah",
                            Surname = "Black"
                        },
                        new
                        {
                            Id = 4,
                            AccountId = 4,
                            Email = "annared@gmail.com",
                            GenderId = 2,
                            Name = "Anna",
                            Surname = "Red"
                        },
                        new
                        {
                            Id = 5,
                            AccountId = 5,
                            Email = "riardenw@gmail.com",
                            GenderId = 1,
                            Name = "Riarden",
                            Surname = "White"
                        });
                });

            modelBuilder.Entity("EF_Relations_airline.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ukraine"
                        },
                        new
                        {
                            Id = 2,
                            Name = "USA"
                        },
                        new
                        {
                            Id = 3,
                            Name = "United Kingdom"
                        },
                        new
                        {
                            Id = 4,
                            Name = "German"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Italy"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Australia"
                        });
                });

            modelBuilder.Entity("EF_Relations_airline.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AirplaneId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ArrivalPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeparturePlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AirplaneId");

                    b.ToTable("Flights");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AirplaneId = 1,
                            ArrivalDate = new DateTime(2023, 11, 25, 17, 40, 0, 0, DateTimeKind.Unspecified),
                            ArrivalPlace = "Sidney",
                            DepartureDate = new DateTime(2023, 11, 26, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            DeparturePlace = "Dallas",
                            Number = "12N"
                        },
                        new
                        {
                            Id = 2,
                            AirplaneId = 2,
                            ArrivalDate = new DateTime(2023, 10, 14, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            ArrivalPlace = "London",
                            DepartureDate = new DateTime(2023, 10, 14, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            DeparturePlace = "New York",
                            Number = "42D"
                        },
                        new
                        {
                            Id = 3,
                            AirplaneId = 3,
                            ArrivalDate = new DateTime(2023, 12, 16, 17, 40, 0, 0, DateTimeKind.Unspecified),
                            ArrivalPlace = "Paris",
                            DepartureDate = new DateTime(2023, 12, 16, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            DeparturePlace = "Los-Angeles",
                            Number = "24R"
                        },
                        new
                        {
                            Id = 4,
                            AirplaneId = 1,
                            ArrivalDate = new DateTime(2023, 9, 2, 17, 40, 0, 0, DateTimeKind.Unspecified),
                            ArrivalPlace = "Berlin",
                            DepartureDate = new DateTime(2023, 9, 2, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            DeparturePlace = "Mexico City",
                            Number = "25G"
                        },
                        new
                        {
                            Id = 5,
                            AirplaneId = 4,
                            ArrivalDate = new DateTime(2023, 10, 27, 17, 40, 0, 0, DateTimeKind.Unspecified),
                            ArrivalPlace = "Lisboa",
                            DepartureDate = new DateTime(2023, 10, 27, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            DeparturePlace = "New Deli",
                            Number = "63R"
                        });
                });

            modelBuilder.Entity("EF_Relations_airline.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenderName = "Male"
                        },
                        new
                        {
                            Id = 2,
                            GenderName = "Female"
                        });
                });

            modelBuilder.Entity("ClientFlight", b =>
                {
                    b.HasOne("EF_Relations_airline.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Relations_airline.Flight", null)
                        .WithMany()
                        .HasForeignKey("FlightsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF_Relations_airline.Airplane", b =>
                {
                    b.HasOne("EF_Relations_airline.Country", "Country")
                        .WithMany("Airplanes")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("EF_Relations_airline.Client", b =>
                {
                    b.HasOne("EF_Relations_airline.Account", "Account")
                        .WithOne("Client")
                        .HasForeignKey("EF_Relations_airline.Client", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Relations_airline.Gender", "Gender")
                        .WithMany("Clients")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("EF_Relations_airline.Flight", b =>
                {
                    b.HasOne("EF_Relations_airline.Airplane", "Airplane")
                        .WithMany("Flights")
                        .HasForeignKey("AirplaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Airplane");
                });

            modelBuilder.Entity("EF_Relations_airline.Account", b =>
                {
                    b.Navigation("Client");
                });

            modelBuilder.Entity("EF_Relations_airline.Airplane", b =>
                {
                    b.Navigation("Flights");
                });

            modelBuilder.Entity("EF_Relations_airline.Country", b =>
                {
                    b.Navigation("Airplanes");
                });

            modelBuilder.Entity("EF_Relations_airline.Gender", b =>
                {
                    b.Navigation("Clients");
                });
#pragma warning restore 612, 618
        }
    }
}