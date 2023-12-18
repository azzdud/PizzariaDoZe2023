using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    public partial class FormPedidos : Form
    {
        public FormPedidos()
        {
            InitializeComponent();
        }

        private void buttonIniciarPedido_Click(object sender, EventArgs e)
        {
            tabControlPedido.SelectedIndex += 1;
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            tabControlPedido.SelectedIndex -= 1;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            tabControlPedido.SelectedIndex += 1;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            tabControlPedido.SelectedIndex -= 1;
        }

        private void buttonAvancar_Click(object sender, EventArgs e)
        {
            tabControlPedido.SelectedIndex += 1;
        }
    }
}
