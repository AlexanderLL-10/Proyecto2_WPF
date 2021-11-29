using Proyecto2_WPF.logica;
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

namespace Proyecto2_WPF
{
    /// <summary>
    /// Lógica de interacción para RegistroSesion.xaml
    /// </summary>
    public partial class RegistroSesion : Window
    {
        
        public RegistroSesion()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            verReservas verReservas = new verReservas();
            verReservas.Show();
            this.Close();
        }
    }
}
