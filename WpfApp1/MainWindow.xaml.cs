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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void comboBoxOpciones_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string selectedOption = (comboBoxOpciones.SelectedItem as ComboBoxItem)?.Content.ToString();
            switch (selectedOption)
            {
                case "Static resource - Dynamic Resource":
                    var staticDynamicWindow = new StaticDynamicWindow();
                    staticDynamicWindow.Show();
                    break;
                case "ResourceStyleTheme":
                    var resourceStyleThemeWindow = new ResourceStyleThemeWindow();
                    resourceStyleThemeWindow.Show();
                    break;
                case "ImplicitExplicitStyle":
                    var implicitExplicitStyleWindow = new ImplicitExplicitStyleWindow();
                    implicitExplicitStyleWindow.Show();
                    break;
                case "Trigger":
                    var triggerExampleWindow = new TriggerExampleWindow();
                    triggerExampleWindow.Show();
                    break;
                case "Freezable":
                    var freezableExampleWindow = new FreezableExampleWindow();
                    freezableExampleWindow.Show();
                    break;
                case "DataTemplate":
                    var dataTemplateWindow = new DataTemplateWindow();
                    dataTemplateWindow.Show();
                    break;

                case "UserInput":
                    var userInputWindow = new UserInputWindow();
                    userInputWindow.Show();
                    break;
                case "StackPanel":
                    var stackPanel = new StackPanel();
                    stackPanel.Show();
                    break;
                default:
                    // Lógica para opción no reconocida
                    break;
            }
        }
    }
}
