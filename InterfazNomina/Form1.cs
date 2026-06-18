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
                string mensajeLista = String.Format("{0} - P/Hora: ${1} - Horas: {2}h - Extras: {3}h - Total: ${4}",
                                                    empleadoActual.Nombre,
                                                    empleadoActual.PrecioPorHora,
                                                    empleadoActual.HorasTrabajadas,
                                                    empleadoActual.HorasExtras,
                                                    salarioTotal);
                listBoxEmpleados.Items.Add(mensajeLista);
            }
        }

        private void LimpiarCampos()
        {
            textBoxNombre.Clear();
            textBoxPrecioHora.Clear();
            textBoxHorasTrabajadas.Clear();
            textBoxHorasExtras.Clear();
            listBoxEmpleados.SelectedIndex = -1;
            botonAgregar.Enabled = true;
            textBoxNombre.Focus();
        }

        private void BotonAgregar_Click(object remitente, EventArgs argumentos)
        {
            string nombre = textBoxNombre.Text;
            string textoPrecio = textBoxPrecioHora.Text;
            string textoHorasTrabajadas = textBoxHorasTrabajadas.Text;
            string textoHorasExtras = textBoxHorasExtras.Text;

            try
            {
                double precioPorHora = Convert.ToDouble(textoPrecio);
                int horasTrabajadas = Convert.ToInt32(textoHorasTrabajadas);
                int horasExtras = Convert.ToInt32(textoHorasExtras);

                Empleado nuevoEmpleado = new Empleado(nombre, precioPorHora, horasTrabajadas, horasExtras);
                _miEmpresa.AgregarEmpleado(nuevoEmpleado);

                ActualizarListaEmpleados();
                LimpiarCampos();

                MessageBox.Show("Empleado agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Por favor, ingrese números válidos en los campos de precio y horas.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int nuevasHorasTrabajadas = Convert.ToInt32(textBoxHorasTrabajadas.Text);
                int nuevasHorasExtras = Convert.ToInt32(textBoxHorasExtras.Text);

                Empleado empleadoSeleccionado = _miEmpresa.ObtenerEmpleadoPorIndice(indiceSeleccionado);
                if (empleadoSeleccionado != null)
                {
                    empleadoSeleccionado.ActualizarDatos(nuevoPrecio, nuevasHorasTrabajadas, nuevasHorasExtras);
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
                    textBoxHorasTrabajadas.Text = empleadoSeleccionado.HorasTrabajadas.ToString();
                    textBoxHorasExtras.Text = empleadoSeleccionado.HorasExtras.ToString();
                    botonAgregar.Enabled = false;
                }
            }
            else
            {
                botonAgregar.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
