using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using PizzariaDoZe.DAO;
using System.Configuration;
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
        private readonly ProdutoDAO dao;
        /// <summary>
        /// Inicializa o modal dos Produtos
        /// </summary>
        public FormProduto()
        {
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            dao = new ProdutoDAO(provider, strConnection);
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

        private void BtnSalvar1_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto()
            {
                Id = 0,
                Descricao = TextBoxNome.Text,
                Tipo = ListBoxTipo.Text,
                Medida = ComboBoxML.Text,
            };

            // Verifica se o valor digitado é um número decimal válido
            if (decimal.TryParse(TextBoxValor.Text, out decimal valor))
            {
                produto.Valor = valor;
            }
            else
            {
                // Lida com a situação em que o valor não é um número decimal válido
                // Por exemplo, você pode exibir uma mensagem ao usuário informando que o valor não é válido.
                MessageBox.Show("Por favor, insira um valor válido para o produto.");
                return; // Ou tome a ação apropriada para sua aplicação.
            }

            try
            {
                // chama o método para inserir da camada model
                dao.Inserir(produto);
                MessageBox.Show("Dados inseridos com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
