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

namespace IntercityTransportation.Windows.BusStops
{
    /// <summary>
    /// Логика взаимодействия для EditBusStopWindow.xaml
    /// </summary>
    public partial class EditBusStopWindow : Window
    {
        private readonly IntercityTransportationDbContext DbContext;
        public BusStop BusStop { get; set; }
        public List<BusStop>? BusStops { get; set; } = null;
        public bool IsNewBusStop { get; set; }
        public EditBusStopWindow(IntercityTransportationDbContext dbContext, BusStop busStop, bool isNewBusStop)
        {
            InitializeComponent();
            DbContext = dbContext;
            DataContext = this;
            BusStop = busStop;
            IsNewBusStop = isNewBusStop;
        }

        private void SaveBusStopButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(BusStop.Name))
            {
                MessageBox.Show("Укажите название остановки");
                return;
            }
            BusStops = DbContext.BusStops.ToList();
            if (BusStops.Any(x => x.Name == BusStop.Name && x.Id != BusStop.Id))
            {
                MessageBox.Show("Данная остановка уже есть в базе данных");
                return;
            }
            try
            {
                if (IsNewBusStop)
                {
                    DbContext.BusStops.Add(BusStop);
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
