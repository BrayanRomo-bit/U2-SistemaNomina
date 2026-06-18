using System;
using System.Windows.Forms;
using LibreriaNomina;

namespace InterfazNomina
{
    public partial class Form1 : Form
    {
        private Empresa _miEmpresa;

        public Form1()
        {
            InitializeComponent();
            _miEmpresa = new Empresa();
        }

        private void ActualizarListaEmpleados()
        {
            listBoxEmpleados.Items.Clear();
            foreach (Empleado empleadoActual in _miEmpresa.ObtenerEmpleados())
            {
                double salarioTotal = empleadoActual.CalcularSalarioTotal();
                string mensajeLista = String.Format("{0} - Pago x Hora: ${1} - Extras: {2}h - Total: ${3}",
                                                    empleadoActual.Nombre,
                                                    empleadoActual.PrecioPorHora,
                                                    empleadoActual.HorasExtras,
                                                    salarioTotal);
                listBoxEmpleados.Items.Add(mensajeLista);
            }
        }

        private void LimpiarCampos()
        {
            textBoxNombre.Clear();
            textBoxPrecioHora.Clear();
            textBoxHoras.Clear();
            textBoxNombre.Focus();
        }

        private void BotonAgregar_Click(object remitente, EventArgs argumentos)
        {
            string nombre = textBoxNombre.Text;
            string textoPrecio = textBoxPrecioHora.Text;
            string textoHoras = textBoxHoras.Text;

            try
            {
                double precioPorHora = Convert.ToDouble(textoPrecio);
                int horasExtras = Convert.ToInt32(textoHoras);

                Empleado nuevoEmpleado = new Empleado(nombre, precioPorHora, horasExtras);
                _miEmpresa.AgregarEmpleado(nuevoEmpleado);

                ActualizarListaEmpleados();
                LimpiarCampos();

                MessageBox.Show("Empleado agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Por favor, ingrese números válidos para el precio por hora y las horas extras.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception excepcionGeneral)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + excepcionGeneral.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonModificar_Click(object remitente, EventArgs argumentos)
        {
            int indiceSeleccionado = listBoxEmpleados.SelectedIndex;
            if (indiceSeleccionado == -1)
            {
                MessageBox.Show("Por favor seleccione un empleado de la lista para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                double nuevoPrecio = Convert.ToDouble(textBoxPrecioHora.Text);
                int nuevasHoras = Convert.ToInt32(textBoxHoras.Text);

                Empleado empleadoSeleccionado = _miEmpresa.ObtenerEmpleadoPorIndice(indiceSeleccionado);
                if (empleadoSeleccionado != null)
                {
                    empleadoSeleccionado.ActualizarDatos(nuevoPrecio, nuevasHoras);
                    empleadoSeleccionado.Nombre = textBoxNombre.Text;

                    ActualizarListaEmpleados();
                    LimpiarCampos();
                    MessageBox.Show("Empleado modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Por favor, ingrese números válidos al modificar.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception excepcionGeneral)
            {
                MessageBox.Show("Ocurrió un error al modificar: " + excepcionGeneral.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonEliminar_Click(object remitente, EventArgs argumentos)
        {
            int indiceSeleccionado = listBoxEmpleados.SelectedIndex;
            if (indiceSeleccionado == -1)
            {
                MessageBox.Show("Por favor seleccione un empleado de la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _miEmpresa.EliminarEmpleadoPorIndice(indiceSeleccionado);
            ActualizarListaEmpleados();
            LimpiarCampos();
            MessageBox.Show("Empleado eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ListBoxEmpleados_SelectedIndexChanged(object remitente, EventArgs argumentos)
        {
            int indiceSeleccionado = listBoxEmpleados.SelectedIndex;
            if (indiceSeleccionado != -1)
            {
                Empleado empleadoSeleccionado = _miEmpresa.ObtenerEmpleadoPorIndice(indiceSeleccionado);
                if (empleadoSeleccionado != null)
                {
                    textBoxNombre.Text = empleadoSeleccionado.Nombre;
                    textBoxPrecioHora.Text = empleadoSeleccionado.PrecioPorHora.ToString();
                    textBoxHoras.Text = empleadoSeleccionado.HorasExtras.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
