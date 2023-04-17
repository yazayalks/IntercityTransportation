using IntercityTransportation.DataBase;
using IntercityTransportation.Models;
using IntercityTransportation.Utilities;
using IntercityTransportation.Windows.DriverCategories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IntercityTransportation.Windows.Drivers
{
    /// <summary>
    /// Логика взаимодействия для EditDriverWindow.xaml
    /// </summary>
    public partial class EditDriverWindow : Window
    {
        private readonly IntercityTransportationDbContext DbContext;
        public Driver Driver { get; set; }
        public List<Driver>? Drivers { get; set; } = null;
        public bool IsNewDriver { get; set; }
        public List<DriverClass> DriverClassColumn { get; set; }
        public BitmapImage? BitmapPhoto { get; set; } = null;
        public EditDriverWindow(IntercityTransportationDbContext dbContext, Driver driver, bool isNewDriver)
        {
            InitializeComponent();
            DriverClassColumn = Enum.GetValues(typeof(DriverClass)).Cast<DriverClass>().ToList();
            DbContext = dbContext;
            DataContext = this;
            Driver = driver;
            IsNewDriver = isNewDriver;
            DriverPhoto.Source = BitmapPhoto;
            Driver.PhotoBase64 = Photo.LoadPhoto(Driver.PhotoBase64 ?? Photo.DefaultImage, DriverPhoto);
        }

        private void SaveDriverButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Driver.FirstName))
            {
                MessageBox.Show("Укажите имя");
                return;
            }
            if (string.IsNullOrEmpty(Driver.LastName))
            {
                MessageBox.Show("Укажите фамилию");
                return;
            }
            if (string.IsNullOrEmpty(Driver.MiddleName))
            {
                MessageBox.Show("Укажите отчество");
                return;
            }
            if (Driver.DriverCategory == null)
            {
                MessageBox.Show("Выберите категорию");
                return;
            }
            try
            {
                if (IsNewDriver)
                {
                    DbContext.Drivers.Add(Driver);
                }
                DbContext.SaveChanges();
                Close();
            }
            catch (DbUpdateException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void AddDriverPhotoButton_Click(object sender, RoutedEventArgs e)
        {
            Driver.PhotoBase64 = Photo.AddPhoto(DriverPhoto);
            Driver.PhotoBase64 = Photo.LoadPhoto(Driver.PhotoBase64 ?? Photo.DefaultImage, DriverPhoto);
        }
        private void SearchDriverCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            var searchDriverCategoryWindow = new SearchDriverCategoryWindow(DbContext, Driver);
            searchDriverCategoryWindow.ShowDialog();
            DriverCategoryTextBox.Text = Driver.DriverCategory.Category;
        }
    }
}
