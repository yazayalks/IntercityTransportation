using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Spreadsheet;
using IntercityTransportation.DataBase;
using IntercityTransportation.Models;
using IntercityTransportation.Utilities;
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

namespace IntercityTransportation.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        private readonly IntercityTransportationDbContext DbContext;
        public List<UserType> UserTypes { get; set; }
        public AccessRight AccessRight { get; set; }
        public List<AccessRight> AccessRights { get; set; } = new List<AccessRight>();
        public AuthWindow()
        {
            InitializeComponent();
            DbContext = new IntercityTransportationDbContext();
            this.DataContext = this;
        }

        private AccessRight AddAccessRight(bool v1, bool v2, bool v3, bool v4, FormType formType)
        {
            AccessRight = new AccessRight();
            AccessRight.Read = v1;
            AccessRight.Write = v2;
            AccessRight.Edit = v3;
            AccessRight.Delete = v4;

            AccessRight.Form = formType;
            return AccessRight;
        }

        private void RegistrButton_Click(object sender, RoutedEventArgs e)
        {
        
            try
            {
                this.Cursor = Cursors.Wait;
                var Email = RegisterEmailTextBox.Text;
                if (String.IsNullOrEmpty(RegisterEmailTextBox.Text))
                {
                    MessageBox.Show("Емаил не может быть пустым");
                    return;
                }
                if (String.IsNullOrEmpty(RegisterPasswordTextBox.Password))
                {
                    MessageBox.Show("Пароль не может быть пустым");
                    return;
                }
                if (String.IsNullOrEmpty(RegisterPasswordConfirmTextBox.Password))
                {
                    MessageBox.Show("Подтвержение пароля не может быть пустым");
                    return;
                }
                if (RegisterEmailTextBox.Text.Length < 5)
                {
                    MessageBox.Show("Емаил не может быть меньше 5 символов");
                    return;
                }
                if (RegisterPasswordTextBox.Password.Length < 5)
                {
                    MessageBox.Show("Пароль не может быть меньше 5 символов");
                    return;
                }
                if (RegisterPasswordConfirmTextBox.Password.Length < 5)
                {
                    MessageBox.Show("Подтвержение пароля не может быть меньше 5 символов");
                    return;
                }

                if (!DbContext.Users.Any(x => x.Email == Email))
                {
                    if (RegisterPasswordConfirmTextBox.Password == RegisterPasswordTextBox.Password)
                    {
                        var PasswordHash = PasswordEncrypter.GetHash(RegisterPasswordTextBox.Password);
                        User user = new User();
                        user.Email = Email;
                        user.Password = PasswordHash;
                        user.UserType = UserType.user;


                        foreach (var form in Enum.GetValues(typeof(FormType)).Cast<FormType>())
                        {
                            AccessRights.Add(AddAccessRight(false, false, false, false, form));
                        }


                        user.AccessRights = AccessRights;
                        DbContext.Add(user);
                        try
                        {
                            DbContext.SaveChanges();
                        }
                        catch (DbUpdateException exception)
                        {
                            MessageBox.Show(exception.Message);
                        }

                        var mainWindow = new MainWindow(user);
                        mainWindow.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают");
                    }
                }
                else
                {
                    MessageBox.Show("Такой емаил уже есть");
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }

        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
         
            try
            {
                this.Cursor = Cursors.Wait;

                if (String.IsNullOrEmpty(LoginEmailTextBox.Text))
                {
                    MessageBox.Show("Емаил не может быть пустым");
                    return;
                }
                if (String.IsNullOrEmpty(LoginPasswordTextBox.Password))
                {
                    MessageBox.Show("Пароль не может быть пустым");
                    return;
                }

                var Email = LoginEmailTextBox.Text;
                var PasswordHash = PasswordEncrypter.GetHash(LoginPasswordTextBox.Password);
                User? user = DbContext.Users
                    .Include(x => x.AccessRights)
                    .FirstOrDefault(u => u.Email == Email && u.Password == PasswordHash);
                if (user != null)
                {

                    var mainWindow = new MainWindow(user);
                    mainWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }
    }
}
