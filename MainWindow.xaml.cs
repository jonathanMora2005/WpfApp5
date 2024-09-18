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

namespace WpfApp3
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
        private void EnviarButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomTextBox.Text))
            {
                MessageBox.Show("El nom no pot estar buit.");
                return;
            }

            if (!int.TryParse(EdatTextBox.Text, out int edat))
            {
                MessageBox.Show("L'edat ha de ser un número.");
                return;
            }

            if (edat < 0 || edat > 120)
            {
                MessageBox.Show("Introdueix una edat vàlida.");
                return;
            }

            MessageBox.Show("Formulari enviat correctament.");
        }

    }
}