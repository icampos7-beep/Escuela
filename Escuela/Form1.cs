using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace Escuela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validamos que los campos de texto no esten vacios
            if (string.IsNullOrWhiteSpace(txtMatricula.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtGrupo.Text) ||
                string.IsNullOrWhiteSpace(txtEspecialidad.Text))
            {
                MessageBox.Show(
                    "Completa todos los campos antes de guardar.",
                    "Datos Incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            try
            {
                using (OleDbConnection conexion =
                    ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta=
                        "INSERT INTO Alumno "+
                        "(Matricula, Nombre, Semestre, Grupo, Especialidad) "+
                        "VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand comando=
                        new OleDbCommand(consulta, conexion))
                    {
                        //Con OleDB importa el orden de los parametros
                        comando.Parameters.Add(
                            "?", OleDbType.VarWChar, 20
                            ).Value = txtMatricula.Text.Trim();

                        comando.Parameters.Add(
                            "?", OleDbType.VarWChar, 20
                            ).Value = txtNombre.Text.Trim();

                        comando.Parameters.Add(
                            "?", OleDbType.Integer
                            ).Value = (int)numericUpDown1.Value;

                        comando.Parameters.Add(
                            "?", OleDbType.VarWChar, 20
                            ).Value = txtGrupo.Text.Trim();

                        comando.Parameters.Add(
                            "?", OleDbType.VarWChar, 20
                            ).Value = txtEspecialidad.Text.Trim();

                        comando.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al guardar el alumno: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void CargarAlumnos()
        {
            try
            {
                using (OleDbConnection conexion =
                    ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta =
                        "SELECT idAlumno, Matricula, Nombre,"+
                        "Semestre, Grupo, Especialidad "+
                        "FROM Alumno Order By IdAlumno";
                    using (OleDbDataAdapter Adaptador =
                        new OleDbDataAdapter(consulta, conexion))
                    {
                        DataTable tabla = new DataTable();
                        Adaptador.Fill(tabla);

                        dgvAlumnos.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al guardar el alumno: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
