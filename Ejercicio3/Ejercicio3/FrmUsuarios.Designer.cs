namespace Ejercicio3
{
    partial class FrmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CodigoTextBox1 = new System.Windows.Forms.TextBox();
            this.NombreTextBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClaveTextBox4 = new System.Windows.Forms.TextBox();
            this.Nuevobutton1 = new System.Windows.Forms.Button();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton3 = new System.Windows.Forms.Button();
            this.Eliminarbutton4 = new System.Windows.Forms.Button();
            this.RolcomboBox1 = new System.Windows.Forms.ComboBox();
            this.Cancelarbutton5 = new System.Windows.Forms.Button();
            this.UsuariosdataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rol:";
            // 
            // CodigoTextBox1
            // 
            this.CodigoTextBox1.Enabled = false;
            this.CodigoTextBox1.Location = new System.Drawing.Point(135, 60);
            this.CodigoTextBox1.Name = "CodigoTextBox1";
            this.CodigoTextBox1.Size = new System.Drawing.Size(318, 20);
            this.CodigoTextBox1.TabIndex = 3;
            // 
            // NombreTextBox2
            // 
            this.NombreTextBox2.Enabled = false;
            this.NombreTextBox2.Location = new System.Drawing.Point(135, 115);
            this.NombreTextBox2.Name = "NombreTextBox2";
            this.NombreTextBox2.Size = new System.Drawing.Size(318, 20);
            this.NombreTextBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Clave: ";
            // 
            // ClaveTextBox4
            // 
            this.ClaveTextBox4.Enabled = false;
            this.ClaveTextBox4.Location = new System.Drawing.Point(135, 235);
            this.ClaveTextBox4.Name = "ClaveTextBox4";
            this.ClaveTextBox4.Size = new System.Drawing.Size(318, 20);
            this.ClaveTextBox4.TabIndex = 7;
            // 
            // Nuevobutton1
            // 
            this.Nuevobutton1.Location = new System.Drawing.Point(88, 286);
            this.Nuevobutton1.Name = "Nuevobutton1";
            this.Nuevobutton1.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton1.TabIndex = 8;
            this.Nuevobutton1.Text = "Nuevo";
            this.Nuevobutton1.UseVisualStyleBackColor = true;
            this.Nuevobutton1.Click += new System.EventHandler(this.Aceptarbutton1_Click);
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(181, 286);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(75, 23);
            this.Modificarbutton.TabIndex = 9;
            this.Modificarbutton.Text = "Modificar ";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            this.Modificarbutton.Click += new System.EventHandler(this.Modificarbutton_Click);
            // 
            // Guardarbutton3
            // 
            this.Guardarbutton3.Enabled = false;
            this.Guardarbutton3.Location = new System.Drawing.Point(274, 286);
            this.Guardarbutton3.Name = "Guardarbutton3";
            this.Guardarbutton3.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton3.TabIndex = 10;
            this.Guardarbutton3.Text = "Guardar";
            this.Guardarbutton3.UseVisualStyleBackColor = true;
            this.Guardarbutton3.Click += new System.EventHandler(this.Guardarbutton3_Click);
            // 
            // Eliminarbutton4
            // 
            this.Eliminarbutton4.Location = new System.Drawing.Point(369, 286);
            this.Eliminarbutton4.Name = "Eliminarbutton4";
            this.Eliminarbutton4.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton4.TabIndex = 11;
            this.Eliminarbutton4.Text = "Eliminar";
            this.Eliminarbutton4.UseVisualStyleBackColor = true;
            this.Eliminarbutton4.Click += new System.EventHandler(this.Eliminarbutton4_Click);
            // 
            // RolcomboBox1
            // 
            this.RolcomboBox1.Enabled = false;
            this.RolcomboBox1.FormattingEnabled = true;
            this.RolcomboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.RolcomboBox1.Location = new System.Drawing.Point(135, 172);
            this.RolcomboBox1.Name = "RolcomboBox1";
            this.RolcomboBox1.Size = new System.Drawing.Size(318, 21);
            this.RolcomboBox1.TabIndex = 12;
            // 
            // Cancelarbutton5
            // 
            this.Cancelarbutton5.Enabled = false;
            this.Cancelarbutton5.Location = new System.Drawing.Point(463, 286);
            this.Cancelarbutton5.Name = "Cancelarbutton5";
            this.Cancelarbutton5.Size = new System.Drawing.Size(75, 23);
            this.Cancelarbutton5.TabIndex = 13;
            this.Cancelarbutton5.Text = "Cancelar";
            this.Cancelarbutton5.UseVisualStyleBackColor = true;
            this.Cancelarbutton5.Click += new System.EventHandler(this.Cancelarbutton5_Click);
            // 
            // UsuariosdataGridView1
            // 
            this.UsuariosdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosdataGridView1.Location = new System.Drawing.Point(2, 324);
            this.UsuariosdataGridView1.Name = "UsuariosdataGridView1";
            this.UsuariosdataGridView1.Size = new System.Drawing.Size(593, 150);
            this.UsuariosdataGridView1.TabIndex = 14;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 476);
            this.Controls.Add(this.UsuariosdataGridView1);
            this.Controls.Add(this.Cancelarbutton5);
            this.Controls.Add(this.RolcomboBox1);
            this.Controls.Add(this.Eliminarbutton4);
            this.Controls.Add(this.Guardarbutton3);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.Nuevobutton1);
            this.Controls.Add(this.ClaveTextBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NombreTextBox2);
            this.Controls.Add(this.CodigoTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CodigoTextBox1;
        private System.Windows.Forms.TextBox NombreTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClaveTextBox4;
        private System.Windows.Forms.Button Nuevobutton1;
        private System.Windows.Forms.Button Modificarbutton;
        private System.Windows.Forms.Button Guardarbutton3;
        private System.Windows.Forms.Button Eliminarbutton4;
        private System.Windows.Forms.ComboBox RolcomboBox1;
        private System.Windows.Forms.Button Cancelarbutton5;
        private System.Windows.Forms.DataGridView UsuariosdataGridView1;
    }
}