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

namespace IntercityTransportation.Windows.DriverCategories
{
    /// <summary>
    /// Логика взаимодействия для EditDriverCategoryWindow.xaml
    /// </summary>
    public partial class EditDriverCategoryWindow : Window
    {
        private readonly IntercityTransportationDbContext DbContext;
        public DriverCategory DriverCategory { get; set; }
        public List<DriverCategory>? DriverCategories { get; set; } = null;
        public bool IsNewDriverCategory { get; set; }
        public EditDriverCategoryWindow(IntercityTransportationDbContext dbContext, DriverCategory driverCategory, bool isNewDriverCategory)
        {
            InitializeComponent();
            DbContext = dbContext;
            DataContext = this;
            DriverCategory = driverCategory;
            IsNewDriverCategory = isNewDriverCategory;
        }

        private void SaveDriverCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(DriverCategory.Category))
            {
                MessageBox.Show("Укажите название категории");
                return;
            }
            DriverCategories = DbContext.DriverCategories.ToList();
            if (DriverCategories.Any(x => x.Category == DriverCategory.Category && x.Id != DriverCategory.Id))
            {
                MessageBox.Show("Данная категория уже есть в базе данных");
                return;
            }

            try
            {
                if (IsNewDriverCategory)
                {
                    DbContext.DriverCategories.Add(DriverCategory);
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
