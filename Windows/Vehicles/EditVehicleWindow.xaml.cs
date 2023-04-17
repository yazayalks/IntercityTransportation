using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.InkML;
using IntercityTransportation.DataBase;
using IntercityTransportation.Models;
using IntercityTransportation.Utilities;
using IntercityTransportation.Windows.Brands;
using IntercityTransportation.Windows.DriverCategories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;

namespace IntercityTransportation.Windows.Vehicles
{
    /// <summary>
    /// Логика взаимодействия для EditVehicleWindow.xaml
    /// </summary>
    public partial class EditVehicleWindow : Window
    {
        private readonly IntercityTransportationDbContext DbContext;
        public Vehicle Vehicle { get; set; }
        public List<Vehicle>? Vehicles { get; set; } = null;
        public List<string>? GovernmentNumbers { get; set; } = null;
        public bool IsNewVehicle { get; set; }
        public BitmapImage? BitmapPhoto { get; set; } = null;
        public EditVehicleWindow(IntercityTransportationDbContext dbContext, Vehicle vehicle, bool isNewVehicle)
        {
            InitializeComponent();
            DbContext = dbContext;
            DataContext = this;
            Vehicle = vehicle;
            IsNewVehicle = isNewVehicle;
            VehiclePhoto.Source = BitmapPhoto;
            Vehicle.PhotoBase64 = Photo.LoadPhoto(Vehicle.PhotoBase64 ?? Photo.DefaultImage, VehiclePhoto);
        }
        private void AddVehiclePhotoButton_Click(object sender, RoutedEventArgs e)
        {
            Vehicle.PhotoBase64 = Photo.AddPhoto(VehiclePhoto);
            Vehicle.PhotoBase64 = Photo.LoadPhoto(Vehicle.PhotoBase64 ?? Photo.DefaultImage, VehiclePhoto);
        }
        private void SearchBrandButton_Click(object sender, RoutedEventArgs e)
        {
            var searchBrandWindow = new SearchBrandWindow(DbContext, Vehicle);
            searchBrandWindow.ShowDialog();
            BrandTextBox.Text = Vehicle.Brand.Name;
        }

        private void SaveDriverButton_Click(object sender, RoutedEventArgs e)
        {
            Regex regexGovernmentNumber = new Regex(@"^(?![WRYUISDFGJLZVN])[A-Z]{2}\d{3,4}$");
            if (!regexGovernmentNumber.IsMatch(Vehicle.GovernmentNumber))
            {
                MessageBox.Show("Укажите государственный номер транспорта в формате:\nAB1234\nOM123");
                return;
            }

            Vehicles = DbContext.Vehicles.ToList();
            if (Vehicles.Any(x => x.GovernmentNumber == Vehicle.GovernmentNumber && x.Id != Vehicle.Id))
            {
                MessageBox.Show("Данный государственный номер уже привязан к другому транспортному средству");
                return;
            }
            if (Vehicle.Brand == null)
            {
                MessageBox.Show("Выберите марку");
                return;
            }
            if (string.IsNullOrEmpty(Vehicle.Model))
            {
                MessageBox.Show("Укажите название модели");
                return;
            }
            var seatCount = Vehicle.SeatCount.ToString();
            if (seatCount == null || seatCount == "0")
            {
                MessageBox.Show("Укажите вместимость");
                return;
            }
            var releaseYear = Vehicle.ReleaseYear.ToString();
            if (releaseYear == null || releaseYear == "0")
            {
                MessageBox.Show("Укажите год выпуска");
                return;
            }
            if (releaseYear.Length != 4)
            {
                MessageBox.Show("Год выпуска должен состоять из 4-ёх чисел");
                return;
            }
            var repairYear = Vehicle.RepairYear.ToString();
            if (repairYear == null || repairYear == "0")
            {
                MessageBox.Show("Укажите год ремонта");
                return;
            }
            if (repairYear.Length != 4)
            {
                MessageBox.Show("Год ремонта должен состоять из 4-ёх чисел");
                return;
            }
            try
            {
                if (IsNewVehicle)
                {
                    DbContext.Vehicles.Add(Vehicle);
                }
                DbContext.SaveChanges();
                Close();
            }
            catch (DbUpdateException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
