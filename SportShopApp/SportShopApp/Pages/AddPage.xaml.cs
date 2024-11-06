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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SportShopApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
            RoleComboBox.ItemsSource = Data.EmployeeBDEntities.GetContext().UserRole.ToList();
            GenderComboBox.ItemsSource = Data.EmployeeBDEntities.GetContext().UserGender.ToList();

        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            Classes.Manager.MainFrame.Navigate(new Pages.ListPage());
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StringBuilder errors = new StringBuilder();
                if (string.IsNullOrEmpty(FirstNameTextBox.Text))
                {
                    errors.AppendLine("Заполните фамилию");
                }
                if (string.IsNullOrEmpty(NameTextBox.Text))
                {
                    errors.AppendLine("Заполните имя");
                }
                if (string.IsNullOrEmpty(PatronymicTextBox.Text))
                {
                    errors.AppendLine("Заполните отчество");
                }
                if (string.IsNullOrEmpty(RoleComboBox.Text))
                {
                    errors.AppendLine("Выберите роль");
                }
                if (string.IsNullOrEmpty(DateOfBirthTextBox.Text))
                {
                    errors.AppendLine("Заполните дату рождения");
                }
                if (string.IsNullOrEmpty(PhoneNumberTextBox.Text))
                {
                    errors.AppendLine("Заполните номер телефона");
                }
                if (string.IsNullOrEmpty(GenderComboBox.Text))
                {
                    errors.AppendLine("Выберите пол");
                }
                if (string.IsNullOrEmpty(EmailTextBox.Text))
                {
                    errors.AppendLine("Заполните email");
                }
                if (string.IsNullOrEmpty(LoginTextBox.Text))
                {
                    errors.AppendLine("Заполните логин");
                }
                if (string.IsNullOrEmpty(PasswordTextBox.Text))
                {
                    errors.AppendLine("Заполните пароль");
                }
                if (string.IsNullOrEmpty(AcceptPasswordTextBox.Text))
                {
                    errors.AppendLine("Подтвердите пароль");
                }

                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString(), "Ошбка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            catch
            {

               

            }
            

        }
    }
}
