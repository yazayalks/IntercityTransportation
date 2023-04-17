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

namespace IntercityTransportation.Windows.BusStops
{
    /// <summary>
    /// Логика взаимодействия для SearchBusStopWindow.xaml
    /// </summary>
    public partial class SearchBusStopWindow : Window
    {
        private readonly IntercityTransportationDbContext DbContext;
        public Route Route { get; set; }
        public SearchBusStopWindow(IntercityTransportationDbContext dbContext, Route route)
        {
            InitializeComponent();
            DbContext = dbContext;
            DataContext = this;
            Route = route;
            RefreshBusStopGrid();
        }
        private void RefreshBusStopGrid()
        {
            var search = SearchTextBox.Text.ToLower();
            BusStopGrid.ItemsSource = DbContext.BusStops
                .Where(x => (x.Name.ToLower().Contains(search)))
                .ToList();
            BusStopGrid.Items.Refresh();
        }

        private void SearchBusStopButton_Click(object sender, RoutedEventArgs e)
        {
            RefreshBusStopGrid();
        }

        private void ChoiseBusStopButton_Click(object sender, RoutedEventArgs e)
        {
            if (BusStopGrid.SelectedItems.Count == 1)
            {
                if (Route.BusStops == null)
                {
                    Route.BusStops = new List<BusStop>();
                }
                if (Route.BusStops.Any(x => x.Id == ((BusStop)BusStopGrid.SelectedItems[0]!).Id))
                {
                    MessageBox.Show("Данная остановка уже есть в маршруте");
                    return;
                }
                Route.BusStops.Add((BusStop)BusStopGrid.SelectedItems[0]!);
            }
            Close();
        }
    }
}
