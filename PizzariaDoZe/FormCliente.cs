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
using PizzariaDoZe.DAO;
using System.Configuration;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics;

namespace PizzariaDoZe
{

    /// <summary>
    /// Abre o formulário de Clientes
    /// </summary>
    public partial class FormCliente : Form
    {
        private readonly ClienteDAO dao;

        /// <summary>
        /// Abre o formulário de Clientes
        /// </summary>
        public FormCliente()
        {
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            dao = new ClienteDAO(provider, strConnection);
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente()
            {
                Id = 0,
                CPF = TextBoxCPF.Text,
                Nome = TextBoxNome.Text,
                Email = TextBoxEmail.Text,
                Telefone = TextBoxTelefone.Text,
                /// IdEndereco = TextBoxComplemento.Text,
                Numero = TextBoxNumero.Text,
                Complemento = TextBoxComplemento.Text,
            };

            try
            {
                // chama o método para inserir da camada model
                dao.Inserir(cliente);
                MessageBox.Show("Dados inseridos com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonPdfCompleto_Click(object sender, EventArgs e)
        {
            // escolhe onde salvar
            string pathArquivo = ClassGeraPdf.pathArquivo("RelClientes");
            // gera o pdf
            ClassGeraPdf.PdfCliente(pathArquivo, 0);
            // abre o pdf gerado
            _ = new Process { StartInfo = new ProcessStartInfo(pathArquivo) { UseShellExecute = true } }.Start();
        }
    }
}
