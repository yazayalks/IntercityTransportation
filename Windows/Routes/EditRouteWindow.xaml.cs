using DocumentFormat.OpenXml.InkML;
using IntercityTransportation.DataBase;
using IntercityTransportation.Models;
using IntercityTransportation.Windows.BusStops;
using IntercityTransportation.Windows.Cities;
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

namespace IntercityTransportation.Windows.Routes
{
    /// <summary>
    /// Логика взаимодействия для EditRouteWindow.xaml
    /// </summary>
    public partial class EditRouteWindow : Window
    {
        private readonly IntercityTransportationDbContext DbContext;
        public Route Route { get; set; }
        public List<Route>? Routes { get; set; } = null;
        public bool IsNewRoute { get; set; }
        public EditRouteWindow(IntercityTransportationDbContext dbContext, Route route, bool isNewRoute)
        {
            InitializeComponent();
            DbContext = dbContext;
            DataContext = this;
            Route = route;
            IsNewRoute = isNewRoute;
            RefreshBusStopGrid();
            //TravelTimePicker.Text = Route.TravelTime.ToString();
            //DepartureTimePicker.Text = Route.DepartureTime.ToString();

        }

        private void RefreshBusStopGrid()
        {
            BusStopGrid.ItemsSource = Route.BusStops?.ToList();
            BusStopGrid.Items.Refresh();
        }

        private void AddBusStopButton_Click(object sender, RoutedEventArgs e)
        {
            var searchBusStoptWindow = new SearchBusStopWindow(DbContext, Route);
            searchBusStoptWindow.ShowDialog();
            RefreshBusStopGrid();

        }

        private void DeleteBusStopButton_Click(object sender, RoutedEventArgs e)
        {
            if (BusStopGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < BusStopGrid.SelectedItems.Count; i++)
                {
                    if (BusStopGrid.SelectedItems[i] is BusStop busStop)
                    {
                        Route.BusStops.Remove(busStop);
                    }
                }

            }
            RefreshBusStopGrid();
        }  
        private void SaveRouteButton_Click(object sender, RoutedEventArgs e)
        {
          
            if (Route.StartingPoint == null)
            {
                MessageBox.Show("Выберите начальный пункт");
                return;
            }
            if (Route.EndingPoint == null)
            {
                MessageBox.Show("Выберите конечный пункт");
                return;
            }
          
            try
            {
                if (IsNewRoute)
                {
                    DbContext.Routes.Add(Route);
                }
                DbContext.SaveChanges();
                Close();
            }
            catch (DbUpdateException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void SearchStartingPointButton_Click(object sender, RoutedEventArgs e)
        {
            var searchCityWindow = new SearchCityWindow(DbContext, Route, "Starting");
            searchCityWindow.ShowDialog();
            StartingPointTextBox.Text = Route.StartingPoint.Name;
        }

        private void SearchEndingPointButton_Click(object sender, RoutedEventArgs e)
        {
            var searchCityWindow = new SearchCityWindow(DbContext, Route, "Ending");
            searchCityWindow.ShowDialog();
            EndingPointTextBox.Text = Route.EndingPoint.Name;
        }
    }
}
