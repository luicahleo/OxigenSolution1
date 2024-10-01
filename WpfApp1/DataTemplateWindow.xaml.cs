using Data;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para DataTemplateWindow.xaml
    /// </summary>
    public partial class DataTemplateWindow : Window
    {
        private OxigenContext _context;

        public DataTemplateWindow()
        {
            InitializeComponent();

            _context = new OxigenContext();
            LoadUsuarios();

        }

        private void LoadUsuarios()
        {
            var usuarios = _context.Usuarios.ToList();
            listViewUsuarios.ItemsSource = usuarios;
        }
    }
}
