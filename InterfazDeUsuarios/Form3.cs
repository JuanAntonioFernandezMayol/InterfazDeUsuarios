using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InterfazDeUsuarios
{
    public partial class Form3 : Form
    {
        private int alumnoID;

        private List<Calificacion> calificaciones;

        public Form3(int id)
        {
            InitializeComponent();
            alumnoID = id;
            cargarDatosAlumno();
            calificaciones = new List<Calificacion>();
            cargarCalificaciones();
        }
        private void cargarDatosAlumno()
        {
            txtID.Text = alumnoID.ToString();
            txtNombre.Text = "Juan";
            txtApellido.Text = "Pérez";
            dtpFechaNacimiento.Value = new DateTime(2000, 5, 15);

            pictureBoxFoto.Image = Image.FromFile("C:\\Users\\pukyt\\source\\repos\\InterfazDeUsuarios\\InterfazDeUsuarios\\default_photo.png"); // Aquí deberías poner la ruta correcta
        }

        private void cargarCalificaciones()
        {
            calificaciones.Add(new Calificacion { Asignatura = "Matemáticas", Nota = 8 });
            calificaciones.Add(new Calificacion { Asignatura = "Lengua", Nota = 7 });
            calificaciones.Add(new Calificacion { Asignatura = "Ciencias", Nota = 9 });

            dgvCalificaciones.DataSource = null;
            dgvCalificaciones.DataSource = calificaciones;
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxFoto.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos del alumno guardados correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Calificacion
    {
        public string Asignatura { get; set; }
        public int Nota { get; set; }
    }
}
