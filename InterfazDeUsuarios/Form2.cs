using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InterfazDeUsuarios
{
    public partial class Form2 : Form
    {
        private List<Alumno> listaAlumnos;

        public Form2()
        {
            InitializeComponent();
            listaAlumnos = new List<Alumno>();
            cargarAlumnos();
        }

        private void cargarAlumnos()
        {
            listaAlumnos.Add(new Alumno { ID = 1, Nombre = "Juan", Apellido = "Pérez" });
            listaAlumnos.Add(new Alumno { ID = 2, Nombre = "Ana", Apellido = "García" });
            listaAlumnos.Add(new Alumno { ID = 3, Nombre = "Pedro", Apellido = "Martínez" });

            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = listaAlumnos;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text.ToLower();

            var resultados = listaAlumnos.FindAll(alumno =>
                alumno.Nombre.ToLower().Contains(criterio) || alumno.Apellido.ToLower().Contains(criterio));

            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = resultados;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                int alumnoID = (int)dgvAlumnos.SelectedRows[0].Cells[0].Value;

                Form3 form3 = new Form3(alumnoID);
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un alumno para editar.");
            }
        }
    }

    public class Alumno
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
