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
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelSalario = new System.Windows.Forms.Label();
            this.textBoxSalario = new System.Windows.Forms.TextBox();
            this.labelHoras = new System.Windows.Forms.Label();
            this.textBoxHoras = new System.Windows.Forms.TextBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.listBoxEmpleados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            
            // labelNombre
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(30, 30);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(54, 15);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            
            // textBoxNombre
            this.textBoxNombre.Location = new System.Drawing.Point(130, 27);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(150, 23);
            this.textBoxNombre.TabIndex = 1;
            
            // labelSalario
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(30, 70);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(71, 15);
            this.labelSalario.TabIndex = 2;
            this.labelSalario.Text = "Salario Base:";
            
            // textBoxSalario
            this.textBoxSalario.Location = new System.Drawing.Point(130, 67);
            this.textBoxSalario.Name = "textBoxSalario";
            this.textBoxSalario.Size = new System.Drawing.Size(150, 23);
            this.textBoxSalario.TabIndex = 3;
            
            // labelHoras
            this.labelHoras.AutoSize = true;
            this.labelHoras.Location = new System.Drawing.Point(30, 110);
            this.labelHoras.Name = "labelHoras";
            this.labelHoras.Size = new System.Drawing.Size(75, 15);
            this.labelHoras.TabIndex = 4;
            this.labelHoras.Text = "Horas Extras:";
            
            // textBoxHoras
            this.textBoxHoras.Location = new System.Drawing.Point(130, 107);
            this.textBoxHoras.Name = "textBoxHoras";
            this.textBoxHoras.Size = new System.Drawing.Size(150, 23);
            this.textBoxHoras.TabIndex = 5;
            
            // botonAgregar
            this.botonAgregar.Location = new System.Drawing.Point(130, 150);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(150, 30);
            this.botonAgregar.TabIndex = 6;
            this.botonAgregar.Text = "Agregar Empleado";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            
            // listBoxEmpleados
            this.listBoxEmpleados.FormattingEnabled = true;
            this.listBoxEmpleados.ItemHeight = 15;
            this.listBoxEmpleados.Location = new System.Drawing.Point(300, 27);
            this.listBoxEmpleados.Name = "listBoxEmpleados";
            this.listBoxEmpleados.Size = new System.Drawing.Size(350, 154);
            this.listBoxEmpleados.TabIndex = 7;
            
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 220);
            this.Controls.Add(this.listBoxEmpleados);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.textBoxHoras);
            this.Controls.Add(this.labelHoras);
            this.Controls.Add(this.textBoxSalario);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Name = "Form1";
            this.Text = "Sistema de Nómina";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.TextBox textBoxSalario;
        private System.Windows.Forms.Label labelHoras;
        private System.Windows.Forms.TextBox textBoxHoras;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.ListBox listBoxEmpleados;
    }
}
