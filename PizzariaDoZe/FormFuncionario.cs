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
using System.Data.SqlClient;
using System.Diagnostics;

namespace PizzariaDoZe
{
    /// <summary>
    /// Inicializa o modal dos Funcionários
    /// </summary>
    public partial class FormFuncionario : Form
    {
        private readonly FuncionarioDAO dao;
        /// <summary>
        /// Inicializa o modal dos Funcionários
        /// </summary>
        public FormFuncionario()
        {
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            dao = new FuncionarioDAO(provider, strConnection);
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario()
            {
                Id = 0,
                CPF = TextBoxCPF.Text,
                Matricula = TextBoxMatricula.Text,
                Nome = TextBoxNome.Text,
                Telefone = TextBoxTelefone.Text,
                Email = TextBoxEmail.Text,
                Senha = TextBoxSenha.Text,
                CarteiraDeMotorista = TextBoxCarteiraMotorista.Text,
                Validade = TextBoxValidade.Text,
                Observacao = TextBoxObservacoes.Text,
                Numero = TextBoxNumero.Text,
                Complemento = TextBoxComplemento.Text,
            };

            try
            {
                // chama o método para inserir da camada model
                dao.Inserir(funcionario);
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
            string pathArquivo = ClassGeraPdf.pathArquivo("RelFuncionarios");
            // gera o pdf
            ClassGeraPdf.PdfFuncionario(pathArquivo, 0);
            // abre o pdf gerado
            _ = new Process { StartInfo = new ProcessStartInfo(pathArquivo) { UseShellExecute = true } }.Start();
        }
    }
}
