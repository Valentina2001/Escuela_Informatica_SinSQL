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
    public partial class FormTribunales : Form
    {
        private TribunalManager _Manager;
        public FormTribunales()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            _Manager = new TribunalManager();
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

        private void btnLeerTribunal_Click(object sender, EventArgs e)
        {
            listTribunales.Items.Clear();
            List<Tribunal> tribunales = _Manager.GetTribunales(this.buscarText.Text);
            foreach (Tribunal tribunal in tribunales)
            {
                ListViewItem item = listTribunales.Items.Add(tribunal.Num.ToString());
                item.SubItems.Add(tribunal.Lugar_Examen);
                item.SubItems.Add(tribunal.Num_Componentes.ToString());
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            menu_principal form = new menu_principal();
            this.Dispose(false);
            form.Show();
        }

        private void btnAgregarTribunal_Click(object sender, EventArgs e)
        {
            _Manager.Write(
                this.txtLugarExamen.Text,
                int.Parse(this.txtNumComponentes.Text)
            );
            btnLeerTribunal_Click(this, new EventArgs());
            LimpiarTexto();
        }

        private void btnActualizarTribunal_Click(object sender, EventArgs e)
        {
            _Manager.Update(
                int.Parse(this.txtNumTribunal.Text),
                this.txtLugarExamen.Text,
                int.Parse(this.txtNumComponentes.Text)
            );
            btnLeerTribunal_Click(this, new EventArgs());
            LimpiarTexto();
        }

        private void btnEliminarTribunal_Click(object sender, EventArgs e)
        {
            _Manager.Delete(int.Parse(this.txtNumTribunal.Text));
            btnLeerTribunal_Click(this, new EventArgs());
            LimpiarTexto();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
