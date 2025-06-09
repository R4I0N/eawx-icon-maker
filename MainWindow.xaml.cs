using System.Windows;
using IconMakinator.Exceptions;
using IconMakinator.ViewModel;
using Microsoft.Win32;

namespace IconMakinator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = ViewModel;
        }

        private void SelectBaseImage_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.png)|*.png"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                ViewModel.LoadBaseImage(openFileDialog.FileName);
            }
        }

        private void ApplyOverlay_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = ViewModel.ApplyOverlays();
                if (result == true)
                {
                    MessageBox.Show("Another happy landing", "Success");
                }
                else
                {
                    MessageBox.Show("Perhaps our archives are incomplete (missing a file?)", "Error");
                }
            }
            catch (NoOverlaySelectedException)
            {
                MessageBox.Show("Please select at least 1 type of overlay", "Error");
            }
            catch (NoNameSetException)
            {
                MessageBox.Show("Please set a name for the unit", "Error");
            }
            catch (NoImageSelectedException)
            {
                MessageBox.Show("Please select a file to apply the overlays to", "Error");
            }
        }
    }
}