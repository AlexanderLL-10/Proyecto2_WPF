
using Proyecto2_WPF.datos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2_WPF.logica
{
    public class LogicaNegocio
    {
        
        public ObservableCollection<Reserva> listaReservas { get; set; }
        public LogicaNegocio()
        {
            
            listaReservas = new ObservableCollection<Reserva>();
            
        }

        

        public void añadirReserva(Reserva reserva)
        {
            listaReservas.Add(reserva);
            
            
            
        }

        public void modificarReserva(Reserva reserva, int posicion) {
            listaReservas[posicion] = reserva;
        }
    }
}
