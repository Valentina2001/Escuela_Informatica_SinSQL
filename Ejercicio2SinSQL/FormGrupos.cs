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
    public partial class FormGrupos : Form
    {
        private GrupoManager _Manager;
        public FormGrupos()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            _Manager = new GrupoManager();
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

        private void btnLeerGrupo_Click(object sender, EventArgs e)
        {
            listGrupos.Items.Clear();
            List<Grupo> grupos = _Manager.GetGrupos(this.buscarText.Text);
            foreach (Grupo grupo in grupos)
            {
                ListViewItem item = listGrupos.Items.Add(grupo.Num_grupo.ToString());
                item.SubItems.Add(grupo.Nombre_grupo);
                item.SubItems.Add(grupo.Num_componente.ToString());
            }
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            menu_principal form = new menu_principal();
            this.Dispose(false);
            form.Show();
        }

        private void btnAgregarGrupo_Click(object sender, EventArgs e)
        {
            _Manager.Write(
                this.txtNombreGrupo.Text,
                int.Parse(this.txtNumeroComponente.Text)
                );
        }

        private void btnActualizarGrupo_Click(object sender, EventArgs e)
        {
            _Manager.Update(
                int.Parse(this.txtNumGrupo.Text),
                this.txtNombreGrupo.Text,
                int.Parse(this.txtNumeroComponente.Text)
                );
        }

        private void btnEliminarGrupo_Click(object sender, EventArgs e)
        {
            _Manager.Delete(int.Parse(txtNumGrupo.Text));
        }
    }
}