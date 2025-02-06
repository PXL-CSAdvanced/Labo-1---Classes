using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HrApp.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> _employees;

        public MainWindow()
        {
            InitializeComponent();

            _employees = new List<string>();
            employeesListBox.DataContext = _employees;
        }

        private void OnAddEmployee_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                //TODO: Refactor code -> create Employee instance and add to listbox
                string fullName = $"{firstNameTextBox.Text} {lastNameTextBox.Text} ({birthDatePicker.SelectedDate}) - {salaryTextBox.Text:c}";
                _employees.Add(fullName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SortEmployees(string property, bool reversed)
        {
            //TODO: Implement sorting
            throw new NotImplementedException();
        }

        private void OnSelectedEmployeeChanged(object sender, SelectionChangedEventArgs e)
        {
            //TODO: Show details of selected employee
        }

        #region Sort Button Events
        private void OnSortFirstNameDown_Clicked(object sender, RoutedEventArgs e)
        {
            SortEmployees("firstName", false);
        }

        private void OnSortLastNameDown_Clicked(object sender, RoutedEventArgs e)
        {
            SortEmployees("lastName", false);
        }

        private void OnSortAgeDown_Clicked(object sender, RoutedEventArgs e)
        {
            SortEmployees("birthDate", false);
        }

        private void OnSortFirstNameUp_Clicked(object sender, RoutedEventArgs e)
        {
            SortEmployees("firstName", true);
        }

        private void OnSortLastNameUp_Clicked(object sender, RoutedEventArgs e)
        {
            SortEmployees("lastName", true);
        }

        private void OnSortAgeUp_Clicked(object sender, RoutedEventArgs e)
        {
            SortEmployees("birthDate", true);
        }

        #endregion

    }
}