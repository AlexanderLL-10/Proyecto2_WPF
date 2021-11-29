using Proyecto2_WPF.datos;
using Proyecto2_WPF.logica;
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

namespace Proyecto2_WPF
{
    /// <summary>
    /// Lógica de interacción para verReservas.xaml
    /// </summary>
    public partial class verReservas : Window
    {
        public ObservableCollection<Reserva> listaReservas2 { get; set; }
        private LogicaNegocio logicaNegocio;
        public verReservas()
        {
            InitializeComponent();
            logicaNegocio = new LogicaNegocio();
            DataGridReservas.DataContext = logicaNegocio;
            
            List<Persona> listaPersonas = new List<Persona>();  //Sobrecarga de metodo
            listaPersonas.Add(new Persona("Andres","Gonzales"));
            listaPersonas.Add(new Persona("Juan", "Cortez"));
            
            foreach (Persona persona in listaPersonas)
            {
                ComboBoxItem cb = new ComboBoxItem();
                cb.Content = persona;
                comboBoxReservas.Items.Add(cb);

                ListBoxItem lb = new ListBoxItem();
                lb.Content = persona;
                listBoxPersonas.Items.Add(lb);
            }
            listaReservas2 = new ObservableCollection<Reserva>();
            this.DataContext = this;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            DialogReserva dialogReserva = new DialogReserva(logicaNegocio);
            dialogReserva.Show();
        }

        private void ButtonModificar_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridReservas.SelectedIndex != -1)
            {
                Reserva reserva = (Reserva)DataGridReservas.SelectedItem;
                DialogReserva dialogReserva = new DialogReserva(logicaNegocio, (Reserva)reserva.Clone(), DataGridReservas.SelectedIndex);
                dialogReserva.Show();
            }
            
        }

        private void comboBoxReservas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cb = (ComboBoxItem)comboBoxReservas.SelectedItem;
            Persona persona = (Persona)cb.Content;
            labelNombre.Content = persona.Nombre;
            labelApellido.Content = persona.Apellido;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem lb = (ListBoxItem)listBoxPersonas.SelectedItem;
            Persona persona = (Persona)lb.Content;
            labelNombre.Content = persona.Nombre;
            labelApellido.Content = persona.Apellido;
        }

        private void BottonActualizar_Click(object sender, RoutedEventArgs e)
        {
            listaReservas2.Add(new Reserva("Alexander","Llundo",DateTime.Now,"1","1"));
        }
    }
}
