using System;
using System.Collections.Generic; // 2.7 Clases predefinidas: List<>

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
    }
}
