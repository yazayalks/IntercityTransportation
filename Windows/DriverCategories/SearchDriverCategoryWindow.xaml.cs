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

namespace IntercityTransportation.Windows.DriverCategories
{
    /// <summary>
    /// Логика взаимодействия для SearchDriverCategoryWindow.xaml
    /// </summary>
    public partial class SearchDriverCategoryWindow : Window
    {
        private readonly IntercityTransportationDbContext DbContext;
        public Driver Driver { get; set; }
        public SearchDriverCategoryWindow(IntercityTransportationDbContext dbContext, Driver driver)
        {
            InitializeComponent();
            DbContext = dbContext;
            DataContext = this;
            Driver = driver;
            RefreshDriverCategoryGrid();
        }

        private void RefreshDriverCategoryGrid()
        {
            var search = SearchTextBox.Text.ToLower();
            DriverCategoryGrid.ItemsSource = DbContext.DriverCategories
                .Where(x => (x.Category.ToLower().Contains(search)))
                .ToList();
            DriverCategoryGrid.Items.Refresh();
        }


        private void ChoiseDriverCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (DriverCategoryGrid.SelectedItems.Count == 1)
            {

                Driver.DriverCategory = (DriverCategory)DriverCategoryGrid.SelectedItems[0]!;
            }
            Close();
        }

        private void SearchDriverCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            RefreshDriverCategoryGrid();
        }
    }
}
