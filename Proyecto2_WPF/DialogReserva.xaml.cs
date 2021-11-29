using Proyecto2_WPF.datos;
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
    /// Lógica de interacción para DialogReserva.xaml
    /// </summary>
    public partial class DialogReserva : Window
    {
        private LogicaNegocio logicaNegocio;
        public Reserva reserva;
        private int posicion;
        private Boolean modificar;
        private int errores;
        public DialogReserva(LogicaNegocio logicaNegocio)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            reserva = new Reserva();
            this.DataContext = reserva;
            modificar = false;
        }


        public DialogReserva(LogicaNegocio logicaNegocio, Reserva reservaModificar, int posicion)
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio;
            this.reserva = reservaModificar;
            this.posicion = posicion;
            this.DataContext = reserva;
            modificar = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (modificar)
                logicaNegocio.modificarReserva(reserva, posicion);
            else
            logicaNegocio.añadirReserva(reserva);
            //reserva = new Reserva();
            //this.DataContext = reserva;
            this.Close();
            MessageBox.Show("RESERVA CREADA");

        }

        private void Validation_Error(object sender, ValidationErrorEventArgs e) {
            if (e.Action == ValidationErrorEventAction.Added)
                errores++;
            else
                errores--;
            if (errores == 0)
                ButtonAceptar.IsEnabled = true;
            else
                ButtonAceptar.IsEnabled = false;
                
        }

        
    }
}
