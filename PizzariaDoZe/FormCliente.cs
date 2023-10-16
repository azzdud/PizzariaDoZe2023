using PizzariaDoZe.Properties;
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
    /// <summary>
    /// Abre o formulário de Clientes
    /// </summary>
    public partial class FormCliente : Form
    {
        /// <summary>
        /// Abre o formulário de Clientes
        /// </summary>
        public FormCliente()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }
    }
}
