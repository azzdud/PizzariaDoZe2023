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

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            userControlFuncoes1.BtnFechar.Click += BtnFechar_Click;

            // Fecha o formulário
            Close();
        }


        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            userControlFuncoes1.BtnSalvar.Click += BtnSalvar_Click;

            // Fecha o formulário
            Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            userControlFuncoes1.BtnEditar.Click += BtnEditar_Click;

            // Fecha o formulário
            Close();
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            userControlFuncoes1.BtnExcluir.Click += BtnExcluir_Click;

            // Fecha o formulário
            Close();
        }

    }
}
