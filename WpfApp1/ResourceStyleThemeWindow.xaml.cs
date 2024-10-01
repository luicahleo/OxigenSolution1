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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para ResourceStyleThemeWindow.xaml
    /// </summary>
    public partial class ResourceStyleThemeWindow : Window
    {
        public ResourceStyleThemeWindow()
        {
            InitializeComponent();
        }

        private void ApplyLightTheme_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var lightTheme = new ResourceDictionary
                {
                    Source = new Uri("Resources/LightTheme.xaml", UriKind.Relative)
                };
                Application.Current.Resources.MergedDictionaries.Clear();
                Application.Current.Resources.MergedDictionaries.Add(lightTheme);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar el tema: {ex.Message}");
            }
        }

        private void ApplyDarkTheme_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var darkTheme = new ResourceDictionary
                {
                    Source = new System.Uri("Resources/DarkTheme.xaml", System.UriKind.Relative)
                };
                Application.Current.Resources.MergedDictionaries.Clear();
                Application.Current.Resources.MergedDictionaries.Add(darkTheme);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar el tema: {ex.Message}");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
