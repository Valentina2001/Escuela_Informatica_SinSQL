using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2SinSQL
{
    public partial class FormAlumnos : Form
    {
        private AlumnoManager _Manager;
        public FormAlumnos()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            _Manager = new AlumnoManager();
        }

        public void LimpiarTexto()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
            }
        }

        private void btnReadAlmno_Click(object sender, EventArgs e)
        {
            listAlumno.Items.Clear();
            List<Alumno> alumnos = _Manager.GetAlumnos(this.buscarText.Text);
            foreach (Alumno alumno in alumnos)
            {
                ListViewItem item = listAlumno.Items.Add(alumno.Num_Matricula.ToString());
                item.SubItems.Add(alumno.Dni.ToString());
                item.SubItems.Add(alumno.Nombre);
            }
        }

        private void listAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            _Manager.Write(
                int.Parse(this.txtDNI.Text),
                this.txtNombreAlumno.Text
            );
            btnReadAlmno_Click(this, new EventArgs());
            LimpiarTexto();
        }

        private void btnActualizarAlumno_Click(object sender, EventArgs e)
        {
            _Manager.Update(
                int.Parse(this.txtNumMatricula.Text),
                int.Parse(this.txtDNI.Text),
                this.txtNombreAlumno.Text
            );
            btnReadAlmno_Click(this, new EventArgs());
            LimpiarTexto();
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            _Manager.Delete(int.Parse(txtNumMatricula.Text));
            btnReadAlmno_Click(this, new EventArgs());
            LimpiarTexto();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            menu_principal form = new menu_principal();
            this.Dispose(false);
            form.Show();
        }
    }
}
