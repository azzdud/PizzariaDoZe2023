using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

       
    }
}
