namespace InterfazDeUsuarios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para la compatibilidad con el Diseñador.
        /// No se puede modificar el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            btnAcceder = new Button();
            linkCentro = new LinkLabel();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(60, 69);
            lblUsuario.Margin = new Padding(6, 0, 6, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(88, 30);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(200, 62);
            txtUsuario.Margin = new Padding(6, 7, 6, 7);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(296, 35);
            txtUsuario.TabIndex = 1;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(60, 162);
            lblContrasena.Margin = new Padding(6, 0, 6, 0);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(123, 30);
            lblContrasena.TabIndex = 2;
            lblContrasena.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(200, 155);
            txtContrasena.Margin = new Padding(6, 7, 6, 7);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(296, 35);
            txtContrasena.TabIndex = 3;
            // 
            // btnAcceder
            // 
            btnAcceder.Location = new Point(210, 270);
            btnAcceder.Margin = new Padding(6, 7, 6, 7);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(150, 53);
            btnAcceder.TabIndex = 4;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // linkCentro
            // 
            linkCentro.AutoSize = true;
            linkCentro.Location = new Point(164, 382);
            linkCentro.Margin = new Padding(6, 0, 6, 0);
            linkCentro.Name = "linkCentro";
            linkCentro.Size = new Size(235, 30);
            linkCentro.TabIndex = 5;
            linkCentro.TabStop = true;
            linkCentro.Text = "Página oficial del centro";
            linkCentro.LinkClicked += linkCentro_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 462);
            Controls.Add(linkCentro);
            Controls.Add(btnAcceder);
            Controls.Add(txtContrasena);
            Controls.Add(lblContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Acceso a la Aplicación";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.LinkLabel linkCentro;
    }
}
