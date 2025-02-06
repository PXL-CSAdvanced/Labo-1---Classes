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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnAddEmployee_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                //TODO: Refactor code -> create Employee instance and add to listbox
                string fullName = $"{firstNameTextBox.Text} {lastNameTextBox.Text} ({birthDatePicker.SelectedDate}) - {salaryTextBox.Text:c}";
                employeesListBox.Items.Add(fullName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void OnSelectedEmployeeChanged(object sender, SelectionChangedEventArgs e)
        {
            //TODO: Show details of selected employee
        }


    }
}