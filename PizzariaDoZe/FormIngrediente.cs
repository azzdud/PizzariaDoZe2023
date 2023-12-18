using PizzariaDoZe.DAO;
using System.Configuration;
using System.Diagnostics;

namespace PizzariaDoZe
{
    /// <summary>
    /// Inicializa o modal dos Ingredientes
    /// </summary>
    public partial class FormIngrediente : Form
    {
        private readonly IngredienteDAO dao;

        /// <summary>
        /// Inicializa o modal dos Ingredientes
        /// </summary>
        public FormIngrediente()
        {
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            dao = new IngredienteDAO(provider, strConnection);
        }

        private void FormIngrediente_Load(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente()
            {
                Id = 0,
                Nome = TextBoxNome.Text,
            };

            try
            {
                // chama o método para inserir da camada model
                dao.Inserir(ingrediente);
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
            string pathArquivo = ClassGeraPdf.pathArquivo("RelIngredientes");
            // gera o pdf
            ClassGeraPdf.PdfIngrediente(pathArquivo, 0);
            // abre o pdf gerado
            _ = new Process { StartInfo = new ProcessStartInfo(pathArquivo) { UseShellExecute = true } }.Start();
        }
    }
}
