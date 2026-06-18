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
            labelHoras = new Label();
            textBoxHoras = new TextBox();
            botonAgregar = new Button();
            botonModificar = new Button();
            botonEliminar = new Button();
            listBoxEmpleados = new ListBox();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(34, 40);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(67, 20);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(149, 36);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(171, 27);
            textBoxNombre.TabIndex = 1;
            // 
            // labelPrecioHora
            // 
            labelPrecioHora.AutoSize = true;
            labelPrecioHora.Location = new Point(34, 93);
            labelPrecioHora.Name = "labelPrecioHora";
            labelPrecioHora.Size = new Size(117, 20);
            labelPrecioHora.TabIndex = 2;
            labelPrecioHora.Text = "Precio por Hora:";
            // 
            // textBoxPrecioHora
            // 
            textBoxPrecioHora.Location = new Point(149, 89);
            textBoxPrecioHora.Margin = new Padding(3, 4, 3, 4);
            textBoxPrecioHora.Name = "textBoxPrecioHora";
            textBoxPrecioHora.Size = new Size(171, 27);
            textBoxPrecioHora.TabIndex = 3;
            // 
            // labelHoras
            // 
            labelHoras.AutoSize = true;
            labelHoras.Location = new Point(34, 147);
            labelHoras.Name = "labelHoras";
            labelHoras.Size = new Size(94, 20);
            labelHoras.TabIndex = 4;
            labelHoras.Text = "Horas Extras:";
            // 
            // textBoxHoras
            // 
            textBoxHoras.Location = new Point(149, 143);
            textBoxHoras.Margin = new Padding(3, 4, 3, 4);
            textBoxHoras.Name = "textBoxHoras";
            textBoxHoras.Size = new Size(171, 27);
            textBoxHoras.TabIndex = 5;
            // 
            // botonAgregar
            // 
            botonAgregar.Location = new Point(34, 200);
            botonAgregar.Margin = new Padding(3, 4, 3, 4);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(137, 40);
            botonAgregar.TabIndex = 6;
            botonAgregar.Text = "Agregar";
            botonAgregar.UseVisualStyleBackColor = true;
            botonAgregar.Click += BotonAgregar_Click;
            // 
            // botonModificar
            // 
            botonModificar.Location = new Point(183, 200);
            botonModificar.Margin = new Padding(3, 4, 3, 4);
            botonModificar.Name = "botonModificar";
            botonModificar.Size = new Size(137, 40);
            botonModificar.TabIndex = 7;
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
            botonEliminar.TabIndex = 8;
            botonEliminar.Text = "Eliminar Seleccionado";
            botonEliminar.UseVisualStyleBackColor = true;
            botonEliminar.Click += BotonEliminar_Click;
            // 
            // listBoxEmpleados
            // 
            listBoxEmpleados.FormattingEnabled = true;
            listBoxEmpleados.Location = new Point(343, 36);
            listBoxEmpleados.Margin = new Padding(3, 4, 3, 4);
            listBoxEmpleados.Name = "listBoxEmpleados";
            listBoxEmpleados.Size = new Size(399, 204);
            listBoxEmpleados.TabIndex = 9;
            listBoxEmpleados.SelectedIndexChanged += ListBoxEmpleados_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 320);
            Controls.Add(listBoxEmpleados);
            Controls.Add(botonEliminar);
            Controls.Add(botonModificar);
            Controls.Add(botonAgregar);
            Controls.Add(textBoxHoras);
            Controls.Add(labelHoras);
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
        private System.Windows.Forms.Label labelHoras;
        private System.Windows.Forms.TextBox textBoxHoras;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.ListBox listBoxEmpleados;
    }
}
