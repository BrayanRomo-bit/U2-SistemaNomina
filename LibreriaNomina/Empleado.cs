using System;

namespace LibreriaNomina
{
    public class Empleado
    {
        // Atributos privados
        private string _nombre;
        private double _precioPorHora;
        private int _horasTrabajadas;
        private int _horasExtras;

        // Propiedades publicas para acceder a los atributos
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

        // Constructor
        public Empleado(string nombre, double precioPorHora, int horasTrabajadas, int horasExtras)
        {
            _nombre = nombre;
            _precioPorHora = precioPorHora;
            _horasTrabajadas = horasTrabajadas;
            _horasExtras = horasExtras;
        }

        // Método para actualizar datos
        public void ActualizarDatos(double nuevoPrecioPorHora, int nuevasHorasTrabajadas, int nuevasHorasExtras)
        {
            _precioPorHora = nuevoPrecioPorHora;
            _horasTrabajadas = nuevasHorasTrabajadas;
            _horasExtras = nuevasHorasExtras;
        }

        // Método para calcular salario total
        public double CalcularSalarioTotal()
        {
            // Ámbito local: estas variables solo viven dentro de este método
            double multiplicadorHoraExtra = 2.0;

            double pagoHorasNormales = _horasTrabajadas * _precioPorHora;
            double pagoPorHoraExtra = _precioPorHora * multiplicadorHoraExtra;
            
            return pagoHorasNormales + (_horasExtras * pagoPorHoraExtra);
        }
    }
}
