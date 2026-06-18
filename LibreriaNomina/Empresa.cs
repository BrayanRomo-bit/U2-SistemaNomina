using System;
using System.Collections.Generic;

namespace LibreriaNomina
{
    public class Empresa
    {
        private List<Empleado> _listaEmpleados;

        public Empresa()
        {
            _listaEmpleados = new List<Empleado>();
        }
        public void AgregarEmpleado(Empleado nuevoEmpleado)
        {
            _listaEmpleados.Add(nuevoEmpleado);
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return _listaEmpleados;
        }
        public Empleado? ObtenerEmpleadoPorIndice(int indice)
        {
            if (indice >= 0 && indice < _listaEmpleados.Count)
            {
                return _listaEmpleados[indice];
            }
            return null;
        }
        public void EliminarEmpleadoPorIndice(int indice)
        {
            if (indice >= 0 && indice < _listaEmpleados.Count)
            {
                _listaEmpleados.RemoveAt(indice);
            }
        }
    }
}
