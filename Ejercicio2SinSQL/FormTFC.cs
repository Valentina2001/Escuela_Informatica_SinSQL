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
    public partial class FormTFC : Form
    {
        private TFCManager _Manager;
        public FormTFC()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            _Manager = new TFCManager();
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

        private void btnLeer_Click(object sender, EventArgs e)
        {
            listTFC.Items.Clear();
            List<TFC> tfcs = _Manager.GetTFC(this.buscarText.Text);
            foreach (TFC tfc in tfcs)
            {
                ListViewItem items = listTFC.Items.Add(tfc.Num_orden.ToString());
                items.SubItems.Add(tfc.Tema);
                items.SubItems.Add(tfc.Fecha);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _Manager.Write(
                this.txtTema.Text,
                this.txtFecha.Text
                );
            btnLeer_Click(this, new EventArgs());
            LimpiarTexto();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            _Manager.Update(
                int.Parse(this.txtNum_orden.Text),
                this.txtTema.Text,
                this.txtFecha.Text
                );
            btnLeer_Click(this, new EventArgs());
            LimpiarTexto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _Manager.Delete(int.Parse(txtNum_orden.Text));
            btnLeer_Click(this, new EventArgs());
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
