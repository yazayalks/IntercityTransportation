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

namespace IntercityTransportation.Windows.Vehicles
{
    /// <summary>
    /// Логика взаимодействия для SearchVehicleWindow.xaml
    /// </summary>
    public partial class SearchVehicleWindow : Window
    {
        private readonly IntercityTransportationDbContext DbContext;
        public Voyage Voyage { get; set; }
        public SearchVehicleWindow(IntercityTransportationDbContext dbContext, Voyage voyage)
        {
            InitializeComponent();
            DbContext = dbContext;
            DataContext = this;
            Voyage = voyage;
            RefreshVehicleGrid();
        }
        private void RefreshVehicleGrid()
        {
            var search = SearchTextBox.Text.ToLower();
            VehicleGrid.ItemsSource = DbContext.Vehicles
                .Where(x => x.RepairYear.ToString().ToLower().Contains(search)
                || x.ReleaseYear.ToString().ToLower().Contains(search)
                || x.SeatCount.ToString().ToLower().Contains(search)
                || x.Model.ToLower().Contains(search)
                || x.Brand.Name.Contains(search)
                || x.Mileage.ToString().Contains(search))
                .ToList();
            VehicleGrid.Items.Refresh();
        }

        private void ChoiseVehicleButton_Click(object sender, RoutedEventArgs e)
        {
            if (VehicleGrid.SelectedItems.Count == 1)
            {

                Voyage.Vehicle = (Vehicle)VehicleGrid.SelectedItems[0]!;
            }
            Close();
        }

        private void SearchVehicleButton_Click(object sender, RoutedEventArgs e)
        {
            RefreshVehicleGrid();
        }
    }
}
