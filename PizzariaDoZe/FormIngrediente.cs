using PizzariaDoZe.DAO;

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
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
        }

        private void FormIngrediente_Load(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void ButtonSalvar_Click(object? sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
