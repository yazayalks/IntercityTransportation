using DocumentFormat.OpenXml.InkML;
using IntercityTransportation.DataBase;
using IntercityTransportation.Models;
using IntercityTransportation.Windows.Drivers;
using IntercityTransportation.Windows.Routes;
using IntercityTransportation.Windows.Vehicles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

namespace IntercityTransportation.Windows.Voyages
{
    /// <summary>
    /// Логика взаимодействия для EditVoyageWindow.xaml
    /// </summary>
    public partial class EditVoyageWindow : Window
    {
        private readonly IntercityTransportationDbContext DbContext;
        public Voyage Voyage { get; set; }
        public List<Voyage>? Voyages { get; set; } = null;
        public bool IsNewVoyage { get; set; }
        public EditVoyageWindow(IntercityTransportationDbContext dbContext, Voyage voyage, bool isNewVoyage)
        {
            InitializeComponent();
            DbContext = dbContext;
            DataContext = this;
            Voyage = voyage;
            IsNewVoyage = isNewVoyage;
            RefreshDriverGrid();
            RefreshVehicleGrid();
            RefreshRouteGrid();
        }
        private void RefreshDriverGrid()
        {
            List<Driver> newDriver = new List<Driver>();
            if (Voyage.Driver != null)
            {
                newDriver.Add(Voyage.Driver);
            }
            DriverGrid.ItemsSource = newDriver.ToList();
            DriverGrid.Items.Refresh();
        }
        private void RefreshVehicleGrid()
        {
            List<Vehicle> newVehicle = new List<Vehicle>();
            if (Voyage.Vehicle != null)
            {
                newVehicle.Add(Voyage.Vehicle);
            }
            VehicleGrid.ItemsSource = newVehicle.ToList();
            VehicleGrid.Items.Refresh();
        }
        private void RefreshRouteGrid()
        {
            List<Route> newRoute = new List<Route>();
            if (Voyage.Route != null)
            {
                newRoute.Add(Voyage.Route);
            }
            RouteGrid.ItemsSource = newRoute.ToList();
            RouteGrid.Items.Refresh();
        }

        private void SearchDriverButton_Click(object sender, RoutedEventArgs e)
        {
            var searchDriverWindow = new SearchDriverWindow(DbContext, Voyage);
            searchDriverWindow.ShowDialog();
            RefreshDriverGrid();
        }

        private void SearchVehicleButton_Click(object sender, RoutedEventArgs e)
        {
            var searchVehicleWindow = new SearchVehicleWindow(DbContext, Voyage);
            searchVehicleWindow.ShowDialog();
            RefreshVehicleGrid();
        }

        private void SearchRouteButton_Click(object sender, RoutedEventArgs e)
        {
            var searchRouteWindow = new SearchRouteWindow(DbContext, Voyage);
            searchRouteWindow.ShowDialog();
            RefreshRouteGrid();
        }

        private void SaveVoyageButton_Click(object sender, RoutedEventArgs e)
        {
            if (Voyage.Driver == null)
            {
                MessageBox.Show("Выберите водителя");
                return;
            }
            if (Voyage.Vehicle == null)
            {
                MessageBox.Show("Выберите автобус");
                return;
            }
            if (Voyage.Route == null)
            {
                MessageBox.Show("Выберите маршрут");
                return;
            }
            try
            {
                if (IsNewVoyage)
                {
                    DbContext.Voyages.Add(Voyage);
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
