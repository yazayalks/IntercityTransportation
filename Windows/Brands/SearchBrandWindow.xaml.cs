using DocumentFormat.OpenXml.Bibliography;
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

namespace IntercityTransportation.Windows.Brands
{
    /// <summary>
    /// Логика взаимодействия для SearchBrandWindow.xaml
    /// </summary>
    public partial class SearchBrandWindow : Window
    {
        private readonly IntercityTransportationDbContext DbContext;
        public Vehicle Vehicle { get; set; }
        public SearchBrandWindow(IntercityTransportationDbContext dbContext, Vehicle vehicle)
        {
            InitializeComponent();
            DbContext = dbContext;
            DataContext = this;
            Vehicle = vehicle;
            RefreshBrandGrid();
        }

        private void RefreshBrandGrid()
        {
            var search = SearchTextBox.Text.ToLower();
            BrandGrid.ItemsSource = DbContext.Brands
                .Where(x => (x.Name.ToLower().Contains(search)))
                .ToList();
            BrandGrid.Items.Refresh();
        }

        private void ChoiseBrandButton_Click(object sender, RoutedEventArgs e)
        {
            if (BrandGrid.SelectedItems.Count == 1)
            {

                Vehicle.Brand = (Brand)BrandGrid.SelectedItems[0]!;
            }
            Close();
        }

        private void SearchBrandButton_Click(object sender, RoutedEventArgs e)
        {
            RefreshBrandGrid();
        }
    }
}
