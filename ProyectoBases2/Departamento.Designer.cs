namespace ProyectoBases2
{
    partial class Departamento
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
            this.tpDep = new System.Windows.Forms.TabControl();
            this.tDepAdgregar = new System.Windows.Forms.TabPage();
            this.tDepEditar = new System.Windows.Forms.TabPage();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.lblDep = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tpDep.SuspendLayout();
            this.tDepAdgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpDep
            // 
            this.tpDep.Controls.Add(this.tDepAdgregar);
            this.tpDep.Controls.Add(this.tDepEditar);
            this.tpDep.Location = new System.Drawing.Point(0, 0);
            this.tpDep.Name = "tpDep";
            this.tpDep.SelectedIndex = 0;
            this.tpDep.Size = new System.Drawing.Size(282, 183);
            this.tpDep.TabIndex = 0;
            // 
            // tDepAdgregar
            // 
            this.tDepAdgregar.Controls.Add(this.btnGuardar);
            this.tDepAdgregar.Controls.Add(this.lblDep);
            this.tDepAdgregar.Controls.Add(this.txtDepartamento);
            this.tDepAdgregar.Location = new System.Drawing.Point(4, 22);
            this.tDepAdgregar.Name = "tDepAdgregar";
            this.tDepAdgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tDepAdgregar.Size = new System.Drawing.Size(274, 157);
            this.tDepAdgregar.TabIndex = 0;
            this.tDepAdgregar.Text = "Agregar";
            this.tDepAdgregar.UseVisualStyleBackColor = true;
            // 
            // tDepEditar
            // 
            this.tDepEditar.Location = new System.Drawing.Point(4, 22);
            this.tDepEditar.Name = "tDepEditar";
            this.tDepEditar.Padding = new System.Windows.Forms.Padding(3);
            this.tDepEditar.Size = new System.Drawing.Size(274, 230);
            this.tDepEditar.TabIndex = 1;
            this.tDepEditar.Text = "Editar";
            this.tDepEditar.UseVisualStyleBackColor = true;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(93, 45);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(149, 20);
            this.txtDepartamento.TabIndex = 0;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Location = new System.Drawing.Point(10, 48);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(77, 13);
            this.lblDep.TabIndex = 1;
            this.lblDep.Text = "Departamento:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(167, 128);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 195);
            this.Controls.Add(this.tpDep);
            this.Name = "Departamento";
            this.Text = "Departamento";
            this.tpDep.ResumeLayout(false);
            this.tDepAdgregar.ResumeLayout(false);
            this.tDepAdgregar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpDep;
        private System.Windows.Forms.TabPage tDepAdgregar;
        private System.Windows.Forms.TabPage tDepEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.TextBox txtDepartamento;
    }
}