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

namespace IntercityTransportation.Windows.Routes
{
    /// <summary>
    /// Логика взаимодействия для SearchRouteWindow.xaml
    /// </summary>
    public partial class SearchRouteWindow : Window
    {
        private readonly IntercityTransportationDbContext DbContext;
        public Voyage Voyage { get; set; }
        public SearchRouteWindow(IntercityTransportationDbContext dbContext, Voyage voyage)
        {
            InitializeComponent();
            DbContext = dbContext;
            DataContext = this;
            Voyage = voyage;
            RefreshRouteGrid();
        }

        private void RefreshRouteGrid()
        {
            var search = SearchTextBox.Text.ToLower();
            RouteGrid.ItemsSource = DbContext.Routes
                .Where(x => x.DepartureTime.ToString().ToLower().Contains(search) || x.TravelTime.ToString().ToLower().Contains(search) || x.StartingPoint.Name.ToLower().Contains(search) || x.EndingPoint.Name.ToLower().Contains(search))
                .ToList();
            RouteGrid.Items.Refresh();
        }

        private void SearchRouteButton_Click(object sender, RoutedEventArgs e)
        {
            RefreshRouteGrid();
        }

        private void ChoiseRouteButton_Click(object sender, RoutedEventArgs e)
        {
            if (RouteGrid.SelectedItems.Count == 1)
            {

                Voyage.Route = (Route)RouteGrid.SelectedItems[0]!;
            }
            Close();
        }
    }
}
