using System.Windows;
using System.Windows.Controls;
using HrApp.Shared;

namespace HrApp.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnAddEmployee_Clicked(object sender, RoutedEventArgs e)
        {
            //TODO: Refactor code -> create Employee instance and add to listbox

            //string fullName = $"{firstNameTextBox.Text} {lastNameTextBox.Text} ({birthDatePicker.SelectedDate}) - {salaryTextBox.Text:c}";
            //_employees.Add(fullName);

            try
            {
                //Employee employee = new Employee();
                //employee.FirstName = firstNameTextBox.Text;
                //employee.LastName = lastNameTextBox.Text;
                Employee employee = new Employee(firstNameTextBox.Text, lastNameTextBox.Text);
      
                employee.BirthDate = birthDatePicker.SelectedDate.Value;
                employee.Salary = decimal.Parse(salaryTextBox.Text);

                employee.Address.Street = streetTextBox.Text;
                employee.Address.Number = numberTextBox.Text;
                employee.Address.ZipCode = zipcodeTextBox.Text;
                employee.Address.City = cityTextBox.Text;

                employeesListBox.Items.Add(employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void OnSelectedEmployeeChanged(object sender, SelectionChangedEventArgs e)
        {
            //TODO: Show details of selected employee
            Employee employee = employeesListBox.SelectedItem as Employee;

            if(employee is not null)
            {
                firstNameLabel.Content = employee.FirstName;
                lastNameLabel.Content = employee.LastName;
                ageLabel.Content = employee.Age;
                salaryLabel.Content = employee.Salary.ToString("c");
                addressLabel.Content = employee.Address.FullAddress;
            }
        }

        private void OnIncreaseSalary_Clicked(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            Employee employee = employeesListBox.SelectedItem as Employee;

            if (employee is not null)
            {
                if (button.Content.ToString().Contains("2%"))
                {
                    employee.IncreaseSalary(2);
                }
                else if (button.Content.ToString().Contains("3%"))
                {
                    employee.IncreaseSalary(3);
                }

                salaryLabel.Content = employee.Salary.ToString("c");
            }
        }
    }
}