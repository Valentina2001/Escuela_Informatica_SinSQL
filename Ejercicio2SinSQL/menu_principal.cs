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
    public partial class menu_principal : Form
    {
        public menu_principal()
        {
            InitializeComponent();
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            FormAlumnos form = new FormAlumnos();
            this.Dispose(false);
            form.Show();
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTribunal_Click(object sender, EventArgs e)
        {
            FormTribunales form = new FormTribunales();
            this.Dispose(false);
            form.Show();
        }

        private void btnTfc_Click(object sender, EventArgs e)
        {
            FormTFC form = new FormTFC();
            this.Dispose(false);
            form.Show();
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            FormGrupos form = new FormGrupos();
            this.Dispose(false);
            form.Show();
        }
    }
}

