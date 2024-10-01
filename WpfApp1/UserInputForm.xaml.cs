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
    /// Lógica de interacción para UserInputForm.xaml
    /// </summary>
    public partial class UserInputForm : UserControl
    {
        public UserInputForm()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtNombre.Text;
            int edad;
            if (int.TryParse(txtEdad.Text, out edad))
            {
                MessageBox.Show($"Nombre: {nombre}, Edad: {edad}");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una edad válida.");
            }
        }
    }
}
