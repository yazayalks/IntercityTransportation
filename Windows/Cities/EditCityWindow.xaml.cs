using IntercityTransportation.DataBase;
using IntercityTransportation.Models;
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

namespace IntercityTransportation.Windows.Cities
{
    /// <summary>
    /// Логика взаимодействия для EditCityWindow.xaml
    /// </summary>
    public partial class EditCityWindow : Window
    {
        private readonly IntercityTransportationDbContext DbContext;
        public City City { get; set; }
        public List<City>? Cities { get; set; } = null;
        public bool IsNewCity { get; set; }
        public EditCityWindow(IntercityTransportationDbContext dbContext, City city, bool isNewCity)
        {
            InitializeComponent();
            DbContext = dbContext;
            DataContext = this;
            City = city;
            IsNewCity = isNewCity;
        }

        private void SaveCityButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(City.Name))
            {
                MessageBox.Show("Укажите название города");
                return;
            }
            Cities = DbContext.Cities.ToList();
            if (Cities.Any(x => x.Name == City.Name && x.Id != City.Id))
            {
                MessageBox.Show("Данный город уже есть в базе данных");
                return;
            }
            try
            {
                if (IsNewCity)
                {
                    DbContext.Cities.Add(City);
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
