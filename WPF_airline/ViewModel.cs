using EF_Relations_airline;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static System.Reflection.Metadata.BlobBuilder;

namespace WPF_airline
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ApplicationContext db = null;
        private DbContextOptions<ApplicationContext> options = null;
        public ViewModel()
        {
            searchAirline = new((o) => Search(), (с) =>IsButtonEnabled == true);
            SelectedDate = default;
            EnteredText = "";
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("MyDbConnection");

            var optionBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            options = optionBuilder.UseSqlServer(connectionString).Options;
            
        }
        private DateTime selectedDate;
        public DateTime SelectedDate
        {
            get { return selectedDate; }
            set
            {
                selectedDate = value;
                OnPropertyChanged(nameof(SelectedDate));
                UpdateButtonState();
            }
        }

        private string enteredText;
        public string EnteredText
        {
            get { return enteredText; }
            set
            {
                enteredText = value;
                OnPropertyChanged(nameof(EnteredText));
                UpdateButtonState();
            }
        }

        public bool IsButtonEnabled { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void UpdateButtonState()
        {
            IsButtonEnabled = !string.IsNullOrEmpty(EnteredText) && SelectedDate != default;
            OnPropertyChanged(nameof(IsButtonEnabled));
        }

        private readonly RelayCommand searchAirline;
        public ICommand SearchAirline => searchAirline;
        public void Search()
        {
            using (db = new ApplicationContext(options))
            {
                var aviaraces = db.Flights.Where(x => x.ArrivalDate.Day == selectedDate.Day && x.ArrivalDate.Month == selectedDate.Month && x.ArrivalDate.Year == selectedDate.Year && x.ArrivalPlace == enteredText).Select(p => new
                {
                    p.Id,
                    p.Number,
                    p.DepartureDate,
                    p.ArrivalDate,
                    p.DeparturePlace,
                    p.ArrivalPlace,
                    p.Airplane.Model,
                }).ToList();

                AirlineListWindow resultWindow = new AirlineListWindow();
                resultWindow.dataGrid.ItemsSource = aviaraces;
                resultWindow.ShowDialog();
            }
        }
    }
}
