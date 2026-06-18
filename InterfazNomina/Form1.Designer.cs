namespace InterfazNomina
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelNombre = new Label();
            textBoxNombre = new TextBox();
            labelPrecioHora = new Label();
            textBoxPrecioHora = new TextBox();
            labelHorasTrabajadas = new Label();
            textBoxHorasTrabajadas = new TextBox();
            labelHorasExtras = new Label();
            textBoxHorasExtras = new TextBox();
            botonAgregar = new Button();
            botonModificar = new Button();
            botonEliminar = new Button();
            listBoxEmpleados = new ListBox();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(34, 31);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(67, 20);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(160, 27);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(159, 27);
            textBoxNombre.TabIndex = 1;
            // 
            // labelPrecioHora
            // 
            labelPrecioHora.AutoSize = true;
            labelPrecioHora.Location = new Point(34, 84);
            labelPrecioHora.Name = "labelPrecioHora";
            labelPrecioHora.Size = new Size(117, 20);
            labelPrecioHora.TabIndex = 2;
            labelPrecioHora.Text = "Precio por Hora:";
            // 
            // textBoxPrecioHora
            // 
            textBoxPrecioHora.Location = new Point(160, 80);
            textBoxPrecioHora.Margin = new Padding(3, 4, 3, 4);
            textBoxPrecioHora.Name = "textBoxPrecioHora";
            textBoxPrecioHora.Size = new Size(159, 27);
            textBoxPrecioHora.TabIndex = 3;
            // 
            // labelHorasTrabajadas
            // 
            labelHorasTrabajadas.AutoSize = true;
            labelHorasTrabajadas.Location = new Point(34, 137);
            labelHorasTrabajadas.Name = "labelHorasTrabajadas";
            labelHorasTrabajadas.Size = new Size(119, 20);
            labelHorasTrabajadas.TabIndex = 4;
            labelHorasTrabajadas.Text = "Horas Normales:";
            // 
            // textBoxHorasTrabajadas
            // 
            textBoxHorasTrabajadas.Location = new Point(160, 133);
            textBoxHorasTrabajadas.Margin = new Padding(3, 4, 3, 4);
            textBoxHorasTrabajadas.Name = "textBoxHorasTrabajadas";
            textBoxHorasTrabajadas.Size = new Size(159, 27);
            textBoxHorasTrabajadas.TabIndex = 5;
            // 
            // labelHorasExtras
            // 
            labelHorasExtras.AutoSize = true;
            labelHorasExtras.Location = new Point(34, 191);
            labelHorasExtras.Name = "labelHorasExtras";
            labelHorasExtras.Size = new Size(94, 20);
            labelHorasExtras.TabIndex = 6;
            labelHorasExtras.Text = "Horas Extras:";
            labelHorasExtras.Click += labelHorasExtras_Click;
            // 
            // textBoxHorasExtras
            // 
            textBoxHorasExtras.Location = new Point(160, 187);
            textBoxHorasExtras.Margin = new Padding(3, 4, 3, 4);
            textBoxHorasExtras.Name = "textBoxHorasExtras";
            textBoxHorasExtras.Size = new Size(159, 27);
            textBoxHorasExtras.TabIndex = 7;
            // 
            // botonAgregar
            // 
            botonAgregar.Location = new Point(34, 253);
            botonAgregar.Margin = new Padding(3, 4, 3, 4);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(137, 40);
            botonAgregar.TabIndex = 8;
            botonAgregar.Text = "Agregar";
            botonAgregar.UseVisualStyleBackColor = true;
            botonAgregar.Click += BotonAgregar_Click;
            // 
            // botonModificar
            // 
            botonModificar.Location = new Point(183, 253);
            botonModificar.Margin = new Padding(3, 4, 3, 4);
            botonModificar.Name = "botonModificar";
            botonModificar.Size = new Size(137, 40);
            botonModificar.TabIndex = 9;
            botonModificar.Text = "Modificar";
            botonModificar.UseVisualStyleBackColor = true;
            botonModificar.Click += BotonModificar_Click;
            // 
            // botonEliminar
            // 
            botonEliminar.Location = new Point(343, 253);
            botonEliminar.Margin = new Padding(3, 4, 3, 4);
            botonEliminar.Name = "botonEliminar";
            botonEliminar.Size = new Size(400, 40);
            botonEliminar.TabIndex = 10;
            botonEliminar.Text = "Eliminar Seleccionado";
            botonEliminar.UseVisualStyleBackColor = true;
            botonEliminar.Click += BotonEliminar_Click;
            // 
            // listBoxEmpleados
            // 
            listBoxEmpleados.FormattingEnabled = true;
            listBoxEmpleados.Location = new Point(343, 27);
            listBoxEmpleados.Margin = new Padding(3, 4, 3, 4);
            listBoxEmpleados.Name = "listBoxEmpleados";
            listBoxEmpleados.Size = new Size(534, 204);
            listBoxEmpleados.TabIndex = 11;
            listBoxEmpleados.SelectedIndexChanged += ListBoxEmpleados_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 333);
            Controls.Add(listBoxEmpleados);
            Controls.Add(botonEliminar);
            Controls.Add(botonModificar);
            Controls.Add(botonAgregar);
            Controls.Add(textBoxHorasExtras);
            Controls.Add(labelHorasExtras);
            Controls.Add(textBoxHorasTrabajadas);
            Controls.Add(labelHorasTrabajadas);
            Controls.Add(textBoxPrecioHora);
            Controls.Add(labelPrecioHora);
            Controls.Add(textBoxNombre);
            Controls.Add(labelNombre);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Sistema de Nómina";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelPrecioHora;
        private System.Windows.Forms.TextBox textBoxPrecioHora;
        private System.Windows.Forms.Label labelHorasTrabajadas;
        private System.Windows.Forms.TextBox textBoxHorasTrabajadas;
        private System.Windows.Forms.Label labelHorasExtras;
        private System.Windows.Forms.TextBox textBoxHorasExtras;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.ListBox listBoxEmpleados;
    }
}
