using DocumentFormat.OpenXml.Bibliography;
using IntercityTransportation.DataBase;
using IntercityTransportation.Models;
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

namespace IntercityTransportation.Windows.Drivers
{
    /// <summary>
    /// Логика взаимодействия для SearchDriverWindow.xaml
    /// </summary>
    public partial class SearchDriverWindow : Window
    {
        private readonly IntercityTransportationDbContext DbContext;
        public Voyage Voyage { get; set; }
        public SearchDriverWindow(IntercityTransportationDbContext dbContext, Voyage voyage)
        {
            InitializeComponent();
            DbContext = dbContext;
            DataContext = this;
            Voyage = voyage;
            RefreshDriverGrid();
        }

        private void RefreshDriverGrid()
        {
            var search = SearchTextBox.Text.ToLower();
            DriverGrid.ItemsSource = DbContext.Drivers
                .Where(x => x.FirstName.ToLower().Contains(search) || x.LastName.ToLower().Contains(search) || x.MiddleName.ToLower().Contains(search) || x.WorkExperience.ToLower().Contains(search) || x.BirthDate.ToString().Contains(search) || x.DriverCategory.Category.Contains(search))
                .ToList();
            DriverGrid.Items.Refresh();
        }


        private void SearchDriverButton_Click(object sender, RoutedEventArgs e)
        {
            RefreshDriverGrid();
        }

        private void ChoiseDriverButton_Click(object sender, RoutedEventArgs e)
        {
            if (DriverGrid.SelectedItems.Count == 1)
            {

                Voyage.Driver = (Driver)DriverGrid.SelectedItems[0]!;
            }
            Close();
        }
    }
}
