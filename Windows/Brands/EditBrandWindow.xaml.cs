using IntercityTransportation.DataBase;
using IntercityTransportation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для EditBrandWindow.xaml
    /// </summary>
    public partial class EditBrandWindow : Window
    {
        private readonly IntercityTransportationDbContext DbContext;
        public Brand Brand { get; set; }
        public List<Brand>? Brands { get; set; } = null;
        public bool IsNewBrand { get; set; }
        public EditBrandWindow(IntercityTransportationDbContext dbContext, Brand brand, bool isNewBrand)
        {
            InitializeComponent();
            DbContext = dbContext;
            DataContext = this;
            Brand = brand;
            IsNewBrand = isNewBrand;
        }

        private void SaveBrandButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Brand.Name))
            {
                MessageBox.Show("Укажите название марки");
                return;
            }
            Brands = DbContext.Brands.ToList();
            if (Brands.Any(x => x.Name == Brand.Name && x.Id != Brand.Id))
            {
                MessageBox.Show("Данная марка уже есть в базе данных");
                return;
            }

            try
            {
                if (IsNewBrand)
                {
                    DbContext.Brands.Add(Brand);
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
