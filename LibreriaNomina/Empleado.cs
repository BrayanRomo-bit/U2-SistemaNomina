using System;

namespace LibreriaNomina
{
    public class Empleado
    {
        private string _nombre;
        private double _precioPorHora;
        private int _horasTrabajadas;
        private int _horasExtras;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public double PrecioPorHora
        {
            get { return _precioPorHora; }
            set { _precioPorHora = value; }
        }

        public int HorasTrabajadas
        {
            get { return _horasTrabajadas; }
            set { _horasTrabajadas = value; }
        }

        public int HorasExtras
        {
            get { return _horasExtras; }
            set { _horasExtras = value; }
        }

        
        public Empleado(string nombre, double precioPorHora, int horasTrabajadas, int horasExtras)
        {
            _nombre = nombre;
            _precioPorHora = precioPorHora;
            _horasTrabajadas = horasTrabajadas;
            _horasExtras = horasExtras;
        }

        public void ActualizarDatos(double nuevoPrecioPorHora, int nuevasHorasTrabajadas, int nuevasHorasExtras)
        {
            _precioPorHora = nuevoPrecioPorHora;
            _horasTrabajadas = nuevasHorasTrabajadas;
            _horasExtras = nuevasHorasExtras;
        }

        public double CalcularSalarioTotal()
        {
            double multiplicadorHoraExtra = 2.0;

            double pagoHorasNormales = _horasTrabajadas * _precioPorHora;
            double pagoPorHoraExtra = _precioPorHora * multiplicadorHoraExtra;
            
            return pagoHorasNormales + (_horasExtras * pagoPorHoraExtra);
        }
    }
}
