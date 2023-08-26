using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Relations_airline
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; } = null!;
        public DbSet<Airplane> Airplanes { get; set; } = null!;
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Flight> Flights { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<Gender> Genders { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                        : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder
            //    .Entity<Account>()
            //    .HasOne(a => a.Client)
            //    .WithOne(c => c.Account)
            //    .HasForeignKey<Client>(c => c.AccountId);
            //modelBuilder.Entity<Country>().HasData(new Country[]
            //{
            //    new Country() { Id = 1, Name="Ukraine"},
            //    new Country() { Id = 2, Name="USA"},
            //    new Country() { Id = 3, Name="United Kingdom"},
            //    new Country() { Id = 4, Name="German"},
            //    new Country() { Id = 5, Name="Italy"},
            //    new Country() { Id = 6, Name="Australia"},
            //});
            //modelBuilder.Entity<Gender>().HasData(new Gender[]
            //{
            //    new Gender() { Id = 1, GenderName="Male"},
            //    new Gender() { Id = 2, GenderName="Female"},
            //});
            //modelBuilder.Entity<Airplane>().HasData(new Airplane[]
            //{
            //    new Airplane() { Id = 1, Model="AN-15", CountryId=1, MaxPassengers=300},
            //    new Airplane() { Id = 2, Model="Super Jet 03", CountryId=6, MaxPassengers=8},
            //    new Airplane() { Id = 3, Model="Airbus CW-2", CountryId=3, MaxPassengers=220},
            //    new Airplane() { Id = 4, Model="Boeing 747", CountryId=2, MaxPassengers=280},
            //});
            //modelBuilder.Entity<Account>().HasData(new Account[]
            //{
            //    new Account() { Id = 1, Login="willsmith", Password="qwerty1"},
            //    new Account() { Id = 2, Login="abrahamg", Password="qwerty1"},
            //    new Account() { Id = 3, Login="sarahb", Password="qwerty1"},
            //    new Account() { Id = 4, Login="annared", Password="qwerty1"},
            //    new Account() { Id = 5, Login="riardenw", Password="qwerty1"},
            //});
            //modelBuilder.Entity<Client>().HasData(new Client[]
            //{
            //    new Client() { Id = 1, Name="Will", Surname="Smith", Email="wills@gmail.com", GenderId=1, AccountId=1},
            //    new Client() { Id = 2, Name="Abraham", Surname="Green", Email="abrahamg@gmail.com", GenderId=1, AccountId=2},
            //    new Client() { Id = 3, Name="Sarah", Surname="Black", Email="sarahb@gmail.com", GenderId=2, AccountId=3},
            //    new Client() { Id = 4, Name="Anna", Surname="Red", Email="annared@gmail.com", GenderId=2, AccountId=4},
            //    new Client() { Id = 5, Name="Riarden", Surname="White", Email="riardenw@gmail.com", GenderId=1, AccountId=5},
            //});
            //modelBuilder.Entity<Flight>().HasData(new Flight[]
            //{
            //    new Flight() { Id = 1, Number="12N", AirplaneId=1, ArrivalDate= DateTime.Parse("25.11.2023 17:40:00"), DepartureDate=DateTime.Parse("26.11.2023 1:00:00"), ArrivalPlace="Sidney", DeparturePlace="Dallas"},
            //    new Flight() { Id = 2, Number="42D", AirplaneId=2, ArrivalDate= DateTime.Parse("14.10.2023 12:30:00"), DepartureDate=DateTime.Parse("14.10.2023 15:00:00"), ArrivalPlace="London", DeparturePlace="New York"},
            //    new Flight() { Id = 3, Number="24R", AirplaneId=3, ArrivalDate= DateTime.Parse("16.12.2023 17:40:00"), DepartureDate=DateTime.Parse("16.12.2023 1:00:00"), ArrivalPlace="Paris", DeparturePlace="Los-Angeles"},
            //    new Flight() { Id = 4, Number="25G", AirplaneId=1, ArrivalDate= DateTime.Parse("02.09.2023 17:40:00"), DepartureDate=DateTime.Parse("02.09.2023 1:00:00"), ArrivalPlace="Berlin", DeparturePlace="Mexico City"},
            //    new Flight() { Id = 5, Number="63R", AirplaneId=4, ArrivalDate= DateTime.Parse("27.10.2023 17:40:00"), DepartureDate=DateTime.Parse("27.10.2023 1:00:00"), ArrivalPlace="Lisboa", DeparturePlace="New Deli"},
            //});

        }
    }
}
