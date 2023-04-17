using IntercityTransportation.DataBase;
using IntercityTransportation.Models;
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
    /// Логика взаимодействия для SearchCityWindow.xaml
    /// </summary>
    public partial class SearchCityWindow : Window
    {
        private readonly IntercityTransportationDbContext DbContext;
        public Route Route { get; set; }
        public string PointType { get; set; }
        public SearchCityWindow(IntercityTransportationDbContext dbContext, Route route, string pointType)
        {
            InitializeComponent();
            DbContext = dbContext;
            DataContext = this;
            Route = route;
            PointType = pointType;
            RefreshCityGrid();
        }
        private void RefreshCityGrid()
        {
            var search = SearchTextBox.Text.ToLower();
            CityGrid.ItemsSource = DbContext.Cities
                .Where(x => (x.Name.ToLower().Contains(search)))
                .ToList();
            CityGrid.Items.Refresh();
        }

        private void ChoiseCityButton_Click(object sender, RoutedEventArgs e)
        {
            if (CityGrid.SelectedItems.Count == 1)
            {
                if (Route.BusStops == null)
                {
                    Route.BusStops = new List<BusStop>();
                }
                if (Route.BusStops.Any(x => x.Id == ((City)CityGrid.SelectedItems[0]!).Id))
                {
                    MessageBox.Show("Данная остановка уже есть в маршруте");
                    return;
                }

                if (PointType == "Starting")
                {   
                    var startingPoint = (City)CityGrid.SelectedItems[0]!;
                    if (startingPoint == Route.EndingPoint)
                    {
                        MessageBox.Show("Данный город уже есть в маршруте");
                        return;
                    }
                    Route.StartingPoint = startingPoint;
                }
                if (PointType == "Ending")
                {
                    var edingPoint = (City)CityGrid.SelectedItems[0]!;
                    if (edingPoint == Route.StartingPoint)
                    {
                        MessageBox.Show("Данный город уже есть в маршруте");
                        return;
                    }
                    Route.EndingPoint = edingPoint;

                }
            }
            Close();
        }

        private void SearchCityButton_Click(object sender, RoutedEventArgs e)
        {
            RefreshCityGrid();
        }
    }
}
