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
    /// Lógica de interacción para FreezableExampleWindow.xaml
    /// </summary>
    public partial class FreezableExampleWindow : Window
    {
        public FreezableExampleWindow()
        {
            InitializeComponent();
        }
        //AQUI CREAMOS UN OBJETO RECTANGULO CON UN PINCEL QUE ESTA CONGELADO
        private void CreateRectanglesWithFrozenBrush_Click(object sender, RoutedEventArgs e)
        {
            wrapPanel.Children.Clear();
            SolidColorBrush frozenBrush = new SolidColorBrush(Colors.Blue);
            if (frozenBrush.CanFreeze)
            {
                frozenBrush.Freeze();
            }

            for (int i = 0; i < 10; i++)
            {
                Rectangle rect = new Rectangle
                {
                    Width = 20,
                    Height = 20,
                    Fill = frozenBrush,
                    Margin = new Thickness(2)
                };
                wrapPanel.Children.Add(rect);
            }
        }

        //AQUI CREAMOS UN BJETO RECTANGULO CON UN PINCEL QUE NO ESTA CONGELADO ESTO ES MENOS EFICINETE EN MEMORIA
        private void CreateRectanglesWithUnfrozenBrush_Click(object sender, RoutedEventArgs e)
        {
            wrapPanel.Children.Clear();
            for (int i = 0; i < 10; i++)
            {
                SolidColorBrush unfrozenBrush = new SolidColorBrush(Colors.Blue);
                Rectangle rect = new Rectangle
                {
                    Width = 20,
                    Height = 20,
                    Fill = unfrozenBrush,
                    Margin = new Thickness(2)
                };
                wrapPanel.Children.Add(rect);
            }
        }
    }
}
