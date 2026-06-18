using System;
using System.Windows.Forms;
using LibreriaNomina;

namespace InterfazNomina
{
    public partial class Form1 : Form
    {
        // 2.6 Creación de objetos: Usar la palabra 'new'
        private Empresa _miEmpresa;

        public Form1()
        {
            InitializeComponent();
            _miEmpresa = new Empresa();
        }

        // Delegado tradicional, sin usar expresiones lambda
        private void BotonAgregar_Click(object remitente, EventArgs argumentos)
        {
            string nombre = textBoxNombre.Text;
            string textoSalario = textBoxSalario.Text;
            string textoHoras = textBoxHoras.Text;

            // 2.9 Manejo de excepciones
            try
            {
                // Intentamos convertir el texto a número
                double salarioBase = Convert.ToDouble(textoSalario);
                int horasExtras = Convert.ToInt32(textoHoras);

                // 2.6 Creación de objetos
                Empleado nuevoEmpleado = new Empleado(nombre, salarioBase, horasExtras);
                _miEmpresa.AgregarEmpleado(nuevoEmpleado);

                // Calculamos el salario total usando el método de la clase
                double salarioTotal = nuevoEmpleado.CalcularSalarioTotal();

                // 2.7 Clases predefinidas: uso de String y MessageBox
                string mensajeLista = String.Format("{0} - Salario Base: ${1} - Total con Extras: ${2}", 
                                                    nuevoEmpleado.Nombre, 
                                                    nuevoEmpleado.SalarioBase, 
                                                    salarioTotal);

                listBoxEmpleados.Items.Add(mensajeLista);

                // Limpiar campos
                textBoxNombre.Clear();
                textBoxSalario.Clear();
                textBoxHoras.Clear();
                
                MessageBox.Show("Empleado agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                // Si el usuario ingresa letras en los campos numéricos, cae aquí
                MessageBox.Show("Error: Por favor, ingrese números válidos para el salario y las horas extras.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception excepcionGeneral)
            {
                // Capturador general de errores
                MessageBox.Show("Ocurrió un error inesperado: " + excepcionGeneral.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
