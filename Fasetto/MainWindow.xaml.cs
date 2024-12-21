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

namespace Fasetto
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

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Description text is {this.DescriptionText.Text}");
        }

        private void RasetButton_Click(object sender, RoutedEventArgs e)
        {
            this.WeldCheckbox.IsChecked = this.AssemblyCheckbox.IsChecked = this.PlasmaCheckbox.IsChecked =
                this.LaserCheckbox.IsChecked = this.PurchaseCheckbox.IsChecked = false;
            this.LatheCheckbox.IsChecked = this.DrillCheckbox.IsChecked = this.FoldCheckbox.IsChecked =
                this.RollCheckbox.IsChecked = this.SawCheckbox.IsChecked = false;
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthTextbox.Text += ((CheckBox)sender).Content;
        }

        private void FinishComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteTextbox == null)
                return;
            var comboBox = (ComboBox)sender;
            var value = (ComboBoxItem)comboBox.SelectedValue;
            this.NoteTextbox.Text = (string)value.Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FinishComboBox_SelectionChanged(this.FinishCombobox, null);
        }

        private void SupplierNameTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.MassTextbox.Text += SupplierNameTextbox.Text;
        }
    }
}