using System;

namespace LibreriaNomina
{
    public class Empleado
    {
        private string _nombre;
        private double _salarioBase;
        private int _horasExtras;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public double SalarioBase
        {
            get { return _salarioBase; }
            set { _salarioBase = value; }
        }

        public int HorasExtras
        {
            get { return _horasExtras; }
            set { _horasExtras = value; }
        }

        public Empleado(string nombre, double salarioBase, int horasExtras)
        {
            _nombre = nombre;
            _salarioBase = salarioBase;
            _horasExtras = horasExtras;
        }

        public double CalcularSalarioTotal()
        {
            double pagoPorHoraExtra = _salarioBase * 0.01;
            
            return _salarioBase + (_horasExtras * pagoPorHoraExtra);
        }
    }
}
