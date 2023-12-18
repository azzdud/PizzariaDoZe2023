using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzariaDoZe.DAO;
using static PizzariaDoZe.ClassEnum;

namespace PizzariaDoZe
{
    /// <summary>
    /// Inicializa o modal de Sabores
    /// </summary>
    public partial class FormSabores : Form
    {
        private IngredienteDAO ingredienteDAO;
        private readonly SaborDAO dao;
        /// <summary>
        /// Inicializa o modal de Sabores
        /// </summary>
        public FormSabores()
        {

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            ingredienteDAO = new IngredienteDAO(provider, strConnection);

            InitializeComponent();
            CarregaIngredientesCheckedListBox(); //Carrega os ingredientes no checkedListBox
            Funcoes.AjustaResourcesControl(this); //Ajusta os textos dos controles
            Funcoes.EventoFocoCampos(this); //Evento para focar no primeiro campo
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!); //Evento para capturar a tecla ESC
            dao = new SaborDAO(provider, strConnection);
        }

        private void FormSabores_Load(object sender, EventArgs e) //Evento de carregamento do formulário 
        {
            Controls.Clear(); //Limpa os controles
            InitializeComponent(); //Inicializa os controles
            Funcoes.AjustaResourcesControl(this); //Ajusta os textos dos controles
        }

        private void CarregaIngredientesCheckedListBox() //Carrega os ingredientes no checkedListBox
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = ingredienteDAO.Buscar(ingrediente);
                // carrega os dados, como objeto, no checkedListBox
                CheckedListBoxIngredientes.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    int idIngrediente = int.Parse(row["Id"].ToString() ?? "0");
                    string nomeIngrediente = row["Nome"].ToString() ?? "";
                    CheckedListBoxIngredientes.Items.Add(new Ingrediente(idIngrediente, nomeIngrediente));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor()
            {
                Id = 0,
                Descricao = TextBoxNome.Text,
                Foto = "",
                Categoria = ListBoxCategoria.Text,
                Tipo = ListBoxTipo.Text,
            };

            try
            {
                // chama o método para inserir da camada model
                dao.Inserir(sabor);
                MessageBox.Show("Dados inseridos com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregaEnumListBox()
        {
            //popular listBoxCategoria
            ListBoxCategoria.Items.Clear();
            ListBoxCategoria.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
            //popular listBoxTipo
            ListBoxTipo.Items.Clear();
            ListBoxTipo.DataSource = Enum.GetValues(typeof(EnumSaborTipo));
        }

        private void ButtonPdfCompleto_Click(object sender, EventArgs e)
        {
            // escolhe onde salvar
            string pathArquivo = ClassGeraPdf.pathArquivo("RelSabores");
            // gera o pdf
            ClassGeraPdf.PdfSabor(pathArquivo, 0);
            // abre o pdf gerado
            _ = new Process { StartInfo = new ProcessStartInfo(pathArquivo) { UseShellExecute = true } }.Start();
        }
    }
}
