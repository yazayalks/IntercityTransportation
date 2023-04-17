using Aspose.Cells;
using ClosedXML.Excel;
using IntercityTransportation.DataBase;
using IntercityTransportation.Models;
using IntercityTransportation.Utilities;
using IntercityTransportation.Windows;
using IntercityTransportation.Windows.AccessRights;
using IntercityTransportation.Windows.Brands;
using IntercityTransportation.Windows.BusStops;
using IntercityTransportation.Windows.Cities;
using IntercityTransportation.Windows.DriverCategories;
using IntercityTransportation.Windows.Drivers;
using IntercityTransportation.Windows.Routes;
using IntercityTransportation.Windows.Vehicles;
using IntercityTransportation.Windows.Voyages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IntercityTransportation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IntercityTransportationDbContext DbContext;
        public string BrandTitle = "Марки автобусов";
        public string DriverCategoryTitle = "Категории водителей";
        public string CityTitle = "Города";
        public string BusStopTitle = "Остановки";
        public string DriverTitle = "Водители";
        public string VehicleTitle = "Автобусы";
        public string RouteTitle = "Маршруты";
        public string VoyageTitle = "Рейсы";
        public string AdminTitle = "Панель администратора";
        public string HelpTitle = "Справка";  
        public string RecoverPasswordTitle = "Изменение пароля пользователя";
        public List<Brand> Brands { get; set; }
        public List<DriverCategory> DriverCategories { get; set; }
        public List<City> Cities { get; set; }
        public List<BusStop> BusStops { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<Route> Routes { get; set; }
        public List<Voyage> Voyages { get; set; }
        public User User { get; set; }
        public MainWindow(User user)
        {
            InitializeComponent();
            DbContext = new IntercityTransportationDbContext();
            this.DataContext = this;
            User = user;

            TabControl.SelectedItem = HelpTabItem;
            TitleTextBox.Text = HelpTitle;

            if (User.UserType != UserType.admin)
            {
                AdminMenuItem.Visibility = Visibility.Hidden;
            }

            var VehicleFormAccessRight = user.AccessRights.Single(x => x.Form == FormType.VehicleForm);
            AccessRightForm(VehicleFormAccessRight, VehicleMenuItem, VehicleGridItem, AddVehicleButton, EditVehicleButton, DeleteVehicleButton);

            var BrandFormAccessRight = user.AccessRights.Single(x => x.Form == FormType.BrandForm);
            AccessRightForm(BrandFormAccessRight, BrandMenuItem, BrandGridItem, AddBrandButton, EditBrandButton, DeleteBrandButton);

            var CityFormAccessRight = user.AccessRights.Single(x => x.Form == FormType.CityForm);
            AccessRightForm(CityFormAccessRight, CityMenuItem, CityGridItem, AddCityButton, EditCityButton, DeleteCityButton);

            var BusStopFormAccessRight = user.AccessRights.Single(x => x.Form == FormType.BusStopForm);
            AccessRightForm(BusStopFormAccessRight, BusStopMenuItem, BusStopGridItem, AddBusStopButton, EditBusStopButton, DeleteBusStopButton);

            var DriverCategoryFormAccessRight = user.AccessRights.Single(x => x.Form == FormType.DriverCategoryForm);
            AccessRightForm(DriverCategoryFormAccessRight, DriverCategoryMenuItem, DriverCategoryGridItem, AddDriverCategoryButton, EditDriverCategoryButton, DeleteDriverCategoryButton);

            var RouteFormAccessRight = user.AccessRights.Single(x => x.Form == FormType.RouteForm);
            AccessRightForm(RouteFormAccessRight, RouteMenuItem, RouteGridItem, AddRouteButton, EditRouteButton, DeleteRouteButton);

            var VoyageFormAccessRight = user.AccessRights.Single(x => x.Form == FormType.VoyageForm);
            AccessRightForm(VoyageFormAccessRight, VoyageMenuItem, VoyageGridItem, AddVoyageButton, EditVoyageButton, DeleteVoyageButton);

            var DriverFormAccessRight = user.AccessRights.Single(x => x.Form == FormType.DriverForm);
            AccessRightForm(DriverFormAccessRight, DriverMenuItem, DriverGridItem, AddDriverButton, EditDriverButton, DeleteDriverButton);
                           
            RefreshBrandGrid();
            RefreshDriverCategoryGrid();
            RefreshCityGrid();
            RefreshBusStopGrid();
            RefreshDriverGrid();
            RefreshVehicleGrid();
            RefreshRouteGrid();
            RefreshVoyageGrid();
            RefreshUserGrid();


            this.Closing += MainWindow_Closing;
        }

        private void AccessRightForm(AccessRight accessRight, MenuItem menuItem, Grid grid, Button addButton, Button editButton, Button deleteButton)
        {
            if (!accessRight.Read)
            {
                menuItem.Visibility = Visibility.Collapsed;
                grid.Visibility = Visibility.Hidden;
            }
            addButton.IsEnabled = accessRight.Write;
            editButton.IsEnabled = accessRight.Edit;
            deleteButton.IsEnabled = accessRight.Delete;
        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var authWindow = new AuthWindow();
            authWindow.Show();
        }

        private void RefreshBrandGrid()
        {
            Brands = DbContext.Brands.ToList();
            BrandGrid.ItemsSource = Brands;
            BrandGrid.Items.Refresh();
        }
        private void RefreshDriverCategoryGrid()
        {
            DriverCategories = DbContext.DriverCategories.ToList();
            DriverCategoryGrid.ItemsSource = DriverCategories;
            DriverCategoryGrid.Items.Refresh();
        }
        private void RefreshCityGrid()
        {
            Cities = DbContext.Cities.ToList();
            CityGrid.ItemsSource = Cities;
            CityGrid.Items.Refresh();
        }
        private void RefreshBusStopGrid()
        {
            BusStops = DbContext.BusStops.ToList();
            BusStopGrid.ItemsSource = BusStops;
            BusStopGrid.Items.Refresh();
        }
        private void RefreshDriverGrid()
        {
            Drivers = DbContext.Drivers
                  .AsSplitQuery()
                  .Include(x => x.DriverCategory)
                  .ToList();
            DriverGrid.ItemsSource = Drivers;
            DriverGrid.Items.Refresh();
        }
        private void RefreshVehicleGrid()
        {
            Vehicles = DbContext.Vehicles
                  .AsSplitQuery()
                  .Include(x => x.Brand)
                  .ToList();
            VehicleGrid.ItemsSource = Vehicles;
            VehicleGrid.Items.Refresh();
        }
        private void RefreshRouteGrid()
        {
            Routes = DbContext.Routes
                  .AsSplitQuery()
                  .Include(x => x.StartingPoint)
                  .Include(x => x.EndingPoint)
                  .Include(x => x.BusStops)
                  .ToList();
            RouteGrid.ItemsSource = Routes;
            RouteGrid.Items.Refresh();
        }
        private void RefreshVoyageGrid()
        {
            var search = SearchVoyageTextBox.Text.ToLower();

            Voyages = DbContext.Voyages
                  .AsSplitQuery()
                  .Include(x => x.Driver)
                  .Include(x => x.Route)
                  .Include(x => x.Vehicle)
                  .ToList();
            VoyageGrid.ItemsSource = Voyages
                  .Where(x => x.Route.StartingPoint.Name.ToString().ToLower().Contains(search)
                || x.Driver.LastName.ToString().ToLower().Contains(search)
                || x.Vehicle.Brand.Name.ToString().ToLower().Contains(search)
                || x.Route.EndingPoint.Name.ToLower().Contains(search)
                || x.Route.DepartureTime.ToString().ToLower().Contains(search)
                )
                .ToList();
            VoyageGrid.Items.Refresh();
        }

        private void RefreshUserGrid()
        {
            var userTypes = Enum.GetValues(typeof(UserType)).Cast<UserType>().ToList();
            UserTypeColumn.ItemsSource = userTypes;
            UserGrid.ItemsSource = DbContext.Users.Include(x => x.AccessRights).ToList();
            UserGrid.Items.Refresh();
        }
        private void OpenBrandButton_Click(object sender, RoutedEventArgs e)
        {
            TabControl.SelectedItem = BrandTabItem;
            TitleTextBox.Text = BrandTitle;
        }
        private void OpenDriverCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            TabControl.SelectedItem = DriverCategoryTabItem;
            TitleTextBox.Text = DriverCategoryTitle;
        }

        private void OpenCityButton_Click(object sender, RoutedEventArgs e)
        {
            TabControl.SelectedItem = CityTabItem;
            TitleTextBox.Text = CityTitle;
        }

        private void OpenBusStopButton_Click(object sender, RoutedEventArgs e)
        {
            TabControl.SelectedItem = BusStopTabItem;
            TitleTextBox.Text = BusStopTitle;
        }
        private void OpenDriverButton_Click(object sender, RoutedEventArgs e)
        {
            TabControl.SelectedItem = DriverTabItem;
            TitleTextBox.Text = DriverTitle;
        }
        private void OpenVehicleButton_Click(object sender, RoutedEventArgs e)
        {
            TabControl.SelectedItem = VehicleTabItem;
            TitleTextBox.Text = VehicleTitle;
        }
        private void OpenRouteButton_Click(object sender, RoutedEventArgs e)
        {
            TabControl.SelectedItem = RouteTabItem;
            TitleTextBox.Text = RouteTitle;

        }
        private void OpenVoyageButton_Click(object sender, RoutedEventArgs e)
        {
            TabControl.SelectedItem = VoyageTabItem;
            TitleTextBox.Text = VoyageTitle;
        }

        private void OpenAdminButton_Click(object sender, RoutedEventArgs e)
        {
            TabControl.SelectedItem = AdminTabItem;
            TitleTextBox.Text = AdminTitle;
        }

        private void OpenHelpButton_Click(object sender, RoutedEventArgs e)
        {
            TabControl.SelectedItem = HelpTabItem;
            TitleTextBox.Text = HelpTitle;
        } 
        private void OpenRecoverPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            TabControl.SelectedItem = RecoverPasswordTabItem;
            TitleTextBox.Text = RecoverPasswordTitle;
        }
        private void DeleteBrandButton_Click(object sender, RoutedEventArgs e)
        {
            if (BrandGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < BrandGrid.SelectedItems.Count; i++)
                {
                    if (BrandGrid.SelectedItems[i] is Brand brand)
                    {
                        DbContext.Brands.Remove(brand);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберете марку для удаления");
                return;
            }

            DbContext.SaveChanges();
            RefreshBrandGrid();
        }

        private void EditBrandButton_Click(object sender, RoutedEventArgs e)
        {
            if (BrandGrid.SelectedItems.Count > 0)
            {
                var editBrandWindow = new EditBrandWindow(DbContext, (Brand)BrandGrid.SelectedItems[0]!, false);
                editBrandWindow.ShowDialog();
                DbContext.Entry((Brand)BrandGrid.SelectedItems[0]!).Reload();
                RefreshBrandGrid();
            }
            else
            {
                MessageBox.Show("Выберете марку для редактирования");
                return;
            }
        }

        private void AddBrandButton_Click(object sender, RoutedEventArgs e)
        {
            Brand newBrand = new Brand();
            var editBrandWindow = new EditBrandWindow(DbContext, newBrand, true);
            editBrandWindow.ShowDialog();
            RefreshBrandGrid();
        }

        private void AddDriverCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            DriverCategory newDriverCategory = new DriverCategory();
            var editDriverCategoryWindow = new EditDriverCategoryWindow(DbContext, newDriverCategory, true);
            editDriverCategoryWindow.ShowDialog();
            RefreshDriverCategoryGrid();
        }

        private void EditDriverCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (DriverCategoryGrid.SelectedItems.Count > 0)
            {
                var editDriverCategoryWindow = new EditDriverCategoryWindow(DbContext, (DriverCategory)DriverCategoryGrid.SelectedItems[0]!, false);
                editDriverCategoryWindow.ShowDialog();
                DbContext.Entry((DriverCategory)DriverCategoryGrid.SelectedItems[0]!).Reload();
                RefreshDriverCategoryGrid();
            }
            else
            {
                MessageBox.Show("Выберете категорию для редактирования");
                return;
            }
        }

        private void DeleteDriverCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (DriverCategoryGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < DriverCategoryGrid.SelectedItems.Count; i++)
                {
                    if (DriverCategoryGrid.SelectedItems[i] is DriverCategory driverCategory)
                    {
                        DbContext.DriverCategories.Remove(driverCategory);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберете категорию для удаления");
                return;
            }

            DbContext.SaveChanges();
            RefreshDriverCategoryGrid();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AddCityButton_Click(object sender, RoutedEventArgs e)
        {
            City newCity = new City();
            var editCityWindow = new EditCityWindow(DbContext, newCity, true);
            editCityWindow.ShowDialog();
            RefreshCityGrid();
        }

        private void EditCityButton_Click(object sender, RoutedEventArgs e)
        {
            if (CityGrid.SelectedItems.Count > 0)
            {
                var editCityWindow = new EditCityWindow(DbContext, (City)CityGrid.SelectedItems[0]!, false);
                editCityWindow.ShowDialog();
                DbContext.Entry((City)CityGrid.SelectedItems[0]!).Reload();
                RefreshCityGrid();
            }
            else
            {
                MessageBox.Show("Выберете город для редактирования");
                return;
            }
        }

        private void DeleteCityButton_Click(object sender, RoutedEventArgs e)
        {
            if (CityGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < CityGrid.SelectedItems.Count; i++)
                {
                    if (CityGrid.SelectedItems[i] is City city)
                    {
                        DbContext.Cities.Remove(city);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберете город для удаления");
                return;
            }

            DbContext.SaveChanges();
            RefreshCityGrid();
        }

        private void AddBusStopButton_Click(object sender, RoutedEventArgs e)
        {
            BusStop newBusStop = new BusStop();
            var editBusStopWindow = new EditBusStopWindow(DbContext, newBusStop, true);
            editBusStopWindow.ShowDialog();
            RefreshBusStopGrid();
        }

        private void EditBusStopButton_Click(object sender, RoutedEventArgs e)
        {
            if (BusStopGrid.SelectedItems.Count > 0)
            {
                var editBusStopWindow = new EditBusStopWindow(DbContext, (BusStop)BusStopGrid.SelectedItems[0]!, false);
                editBusStopWindow.ShowDialog();
                DbContext.Entry((BusStop)BusStopGrid.SelectedItems[0]!).Reload();
                RefreshBusStopGrid();
            }
            else
            {
                MessageBox.Show("Выберете остановку для редактирования");
                return;
            }
        }

        private void DeleteBusStopButton_Click(object sender, RoutedEventArgs e)
        {
            if (BusStopGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < BusStopGrid.SelectedItems.Count; i++)
                {
                    if (BusStopGrid.SelectedItems[i] is BusStop busStop)
                    {
                        DbContext.BusStops.Remove(busStop);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберете остановку для удаления");
                return;
            }

            DbContext.SaveChanges();
            RefreshBusStopGrid();
        }

        private void DeleteDriverButton_Click(object sender, RoutedEventArgs e)
        {
            if (DriverGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < DriverGrid.SelectedItems.Count; i++)
                {
                    if (DriverGrid.SelectedItems[i] is Driver driver)
                    {
                        DbContext.Drivers.Remove(driver);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберете водителя для удаления");
                return;
            }

            DbContext.SaveChanges();
            RefreshDriverGrid();
        }

        private void EditDriverButton_Click(object sender, RoutedEventArgs e)
        {
            if (DriverGrid.SelectedItems.Count > 0)
            {
                var editDriverWindow = new EditDriverWindow(DbContext, (Driver)DriverGrid.SelectedItems[0]!, false);
                editDriverWindow.ShowDialog();
                DbContext.Entry((Driver)DriverGrid.SelectedItems[0]!).Reload();
                RefreshDriverGrid();
            }
            else
            {
                MessageBox.Show("Выберете водителя для редактирования");
                return;
            }
        }

        private void AddDriverButton_Click(object sender, RoutedEventArgs e)
        {
            Driver newDriver = new Driver();
            var editDriverWindow = new EditDriverWindow(DbContext, newDriver, true);
            editDriverWindow.ShowDialog();
            RefreshDriverGrid();
        }

        private void AddVehicleButton_Click(object sender, RoutedEventArgs e)
        {
            Vehicle newVehicle = new Vehicle();
            var editVehicleWindow = new EditVehicleWindow(DbContext, newVehicle, true);
            editVehicleWindow.ShowDialog();
            RefreshVehicleGrid();
        }

        private void EditVehicleButton_Click(object sender, RoutedEventArgs e)
        {
            if (VehicleGrid.SelectedItems.Count > 0)
            {
                var editVehicleWindow = new EditVehicleWindow(DbContext, (Vehicle)VehicleGrid.SelectedItems[0]!, false);
                editVehicleWindow.ShowDialog();
                DbContext.Entry((Vehicle)VehicleGrid.SelectedItems[0]!).Reload();
                RefreshVehicleGrid();
            }
            else
            {
                MessageBox.Show("Выберете автобус для редактирования");
                return;
            }
        }

        private void DeleteVehicleButton_Click(object sender, RoutedEventArgs e)
        {
            if (VehicleGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < VehicleGrid.SelectedItems.Count; i++)
                {
                    if (VehicleGrid.SelectedItems[i] is Vehicle vehicle)
                    {
                        DbContext.Vehicles.Remove(vehicle);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберете автобус для удаления");
                return;
            }

            DbContext.SaveChanges();
            RefreshVehicleGrid();
        }

        private void AddRouteButton_Click(object sender, RoutedEventArgs e)
        {
            Route newRoute = new Route();
            var editRouteWindow = new EditRouteWindow(DbContext, newRoute, true);
            editRouteWindow.ShowDialog();
            RefreshRouteGrid();
        }

        private void EditRouteButton_Click(object sender, RoutedEventArgs e)
        {
            if (RouteGrid.SelectedItems.Count > 0)
            {
                var editRouteWindow = new EditRouteWindow(DbContext, (Route)RouteGrid.SelectedItems[0]!, false);
                editRouteWindow.ShowDialog();
                DbContext.Entry((Route)RouteGrid.SelectedItems[0]!).Reload();
                RefreshRouteGrid();
            }
            else
            {
                MessageBox.Show("Выберете маршрут для редактирования");
                return;
            }
        }

        private void DeleteRouteButton_Click(object sender, RoutedEventArgs e)
        {
            if (RouteGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < RouteGrid.SelectedItems.Count; i++)
                {
                    if (RouteGrid.SelectedItems[i] is Route route)
                    {
                        DbContext.Routes.Remove(route);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберете маршрут для удаления");
                return;
            }

            DbContext.SaveChanges();
            RefreshRouteGrid();
        }

        private void AddVoyageButton_Click(object sender, RoutedEventArgs e)
        {
            Voyage newVoyage = new Voyage();
            var editVoyageWindow = new EditVoyageWindow(DbContext, newVoyage, true);
            editVoyageWindow.ShowDialog();
            RefreshVoyageGrid();
        }

        private void EditVoyageButton_Click(object sender, RoutedEventArgs e)
        {
            if (VoyageGrid.SelectedItems.Count > 0)
            {
                var editVoyageWindow = new EditVoyageWindow(DbContext, (Voyage)VoyageGrid.SelectedItems[0]!, false);
                editVoyageWindow.ShowDialog();
                DbContext.Entry((Voyage)VoyageGrid.SelectedItems[0]!).Reload();
                RefreshVoyageGrid();
            }
            else
            {
                MessageBox.Show("Выберете рейс для редактирования");
                return;
            }
        }

        private void DeleteVoyageButton_Click(object sender, RoutedEventArgs e)
        {
            if (VoyageGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < VoyageGrid.SelectedItems.Count; i++)
                {
                    if (VoyageGrid.SelectedItems[i] is Voyage voyage)
                    {
                        DbContext.Voyages.Remove(voyage);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберете рейс для удаления");
                return;
            }

            DbContext.SaveChanges();
            RefreshVoyageGrid();
        }

        private void SearchVoyageButton_Click(object sender, RoutedEventArgs e)
        {
            RefreshVoyageGrid();
        }

        private void ExportVoyageButton_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            var l = new List<Voyage>((IEnumerable<Voyage>)VoyageGrid.ItemsSource);

            var myExportList = new List<ExportVoyage>();

            foreach (var item in l)
            {
                myExportList.Add(new ExportVoyage()
                {
                    Id = item.Id.ToString(),
                    Driver = item.Driver.LastName,
                    Vehicle = item.Vehicle.Brand.Name,
                    StartingPoint = item.Route.StartingPoint.Name,
                    EndingPoint = item.Route.EndingPoint.Name,
                    VoyageDate = item.VoyageDate.ToString(),
                    TicketCount = item.TicketCount.ToString(),
                    TotalRevenues = item.TotalRevenues.ToString(),
                });
            }

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Common.ToDataTable(myExportList));

                Stream streamF = File.Create("export.xlsx");
                wb.SaveAs(streamF);
                streamF.Close();
            }


            Aspose.Cells.Workbook workbook = new Aspose.Cells.Workbook("export.xlsx");
            workbook.Save("export.docx", SaveFormat.Docx);
            MessageBox.Show("Успешно");
            this.Cursor = Cursors.Arrow;
        }

        private void SaveUserButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DbContext.SaveChanges();
                MessageBox.Show("Изменения сохранены");
            }
            catch (DbUpdateException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void EditAccessRightButton_Click(object sender, RoutedEventArgs e)
        {
            if (UserGrid.SelectedItems.Count > 0)
            {
                var editAccessRightWindow = new EditAccessRightWindow(DbContext, (User)UserGrid.SelectedItems[0]!);
                editAccessRightWindow.ShowDialog();
                DbContext.Entry((User)UserGrid.SelectedItems[0]!).Reload();
                RefreshUserGrid();
            }
            else
            {
                MessageBox.Show("Выберете пользователя для редактирования прав");
                return;
            }
        }

        private void DeleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            if (UserGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < UserGrid.SelectedItems.Count; i++)
                {
                    if (UserGrid.SelectedItems[i] is User user)
                    {
                        if (user.UserType != UserType.admin)
                        {
                            DbContext.Users.Remove(user);
                        }
                        else
                        {
                            MessageBox.Show("Вы не можете удалить администратора");
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберете пользователя для удаления");
                return;
            }

            DbContext.SaveChanges();
            RefreshUserGrid();
        }

        private void RecoverPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            var oldPassword = OldPasswordTexBox.Password;
            var newPassword = NewPasswordTexBox.Password;
            var confirmPassword = ConfirmPasswordTexBox.Password;

            if (oldPassword == String.Empty)
            {
                MessageBox.Show("Старый может быть пустым");
                return;
            }
            if (newPassword == String.Empty)
            {
                MessageBox.Show("Новый пароль не может быть пустым");
                return;
            }
            if (confirmPassword == String.Empty)
            {
                MessageBox.Show("Подтвержение пароля не может быть пустым");
                return;
            }
            if (newPassword.Length < 5)
            {
                MessageBox.Show("Новый пароль не может быть меньше 5 символов");
                return;
            }
            if (confirmPassword.Length < 5)
            {
                MessageBox.Show("Подтвержение пароля не может быть меньше 5 символов");
                return;
            }

            if (User.Password == PasswordEncrypter.GetHash(oldPassword))
            {
                if (newPassword == confirmPassword)
                {
                    var PasswordHash = PasswordEncrypter.GetHash(newPassword);
                    User.Password = PasswordHash;
                    DbContext.SaveChanges();
                    OldPasswordTexBox.Password = string.Empty;
                    NewPasswordTexBox.Password = string.Empty;
                    ConfirmPasswordTexBox.Password = string.Empty;
                    MessageBox.Show("Пароль успешно изменён!");

                }
                else
                {
                    MessageBox.Show("Новые пароли не совпадают");
                }

            }
            else
            {
                MessageBox.Show("Старый пароль неправильный");
            }
        }
    }
}
