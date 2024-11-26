namespace InterfazDeUsuarios
{
    partial class Form2
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

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            dgvAlumnos = new DataGridView();
            btnBuscar = new Button();
            btnEditar = new Button();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(70, 85);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 62;
            dgvAlumnos.Size = new Size(737, 317);
            dgvAlumnos.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(428, 25);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 35);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(705, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(102, 62);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(70, 25);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(300, 35);
            txtBuscar.TabIndex = 3;
            // 
            // Form2
            // 
            ClientSize = new Size(875, 421);
            Controls.Add(txtBuscar);
            Controls.Add(btnEditar);
            Controls.Add(btnBuscar);
            Controls.Add(dgvAlumnos);
            Name = "Form2";
            Text = "Cercador d'Alumnes";
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}
