using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2_WPF.datos
{
    public class Reserva : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));
            }
        }

        private String apellido;
        public String Apellido
        {
            get { return apellido; }
            set
            {
                apellido = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Apellido"));
            }
        }

        private DateTime fechaRegistro;
        public DateTime FechaRegistro
        {
            get
            {
                return fechaRegistro;
            }
            set
            {
                fechaRegistro = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("FechaRegistro"));
            }
        }
        public Reserva()
        {
            this.fechaRegistro = DateTime.Now;
        }
      

        private String oficina;
        public String Oficina
        {
            get { return oficina; }
            set
            {
                oficina = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Oficina"));
            }
        }
        private String mesa;
        public String Mesa
        {
            get { return mesa; }
            set
            {
                mesa = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Mesa"));

            }
        }

       
        public Reserva(String nombre, String apellido, DateTime fechaRegistro, String oficina, String mesa)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaRegistro = fechaRegistro;
            this.oficina = oficina;
            this.mesa = mesa;
        }

        


        public event PropertyChangedEventHandler PropertyChanged;

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string Error
        {
            get { return ""; }
        }
        public string this[string columnName]
        {
            get
            {
                string result = "";
                if (columnName == "Nombre")
                {
                    if (string.IsNullOrEmpty(nombre))
                        result = "Introduzca el nombre";
                }
                if (columnName == "Apellido")
                {
                    if (string.IsNullOrEmpty(apellido))
                        result = "Introduzca el apellido";
                }
                if (columnName == "Oficina")
                {
                    if (string.IsNullOrEmpty(oficina))
                        result = "Introduzca el oficina";
                }
                if (columnName == "Mesa")
                {
                    if (string.IsNullOrEmpty(mesa))
                        result = "Introduzca el mesa";
                }
                return result;
            }
        }

        public override string ToString()
        {
            return nombre + " " + apellido;
        }
    }
}
