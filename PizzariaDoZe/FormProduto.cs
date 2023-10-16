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
    /// Inicializa o modal dos Produtos
    /// </summary>
    public partial class FormProduto : Form
    {
        /// <summary>
        /// Inicializa o modal dos Produtos
        /// </summary>
        public FormProduto()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }
    }
}
