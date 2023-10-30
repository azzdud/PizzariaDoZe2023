namespace PizzariaDoZe
{
    /// <summary>
    /// Inicializa o modal dos Ingredientes
    /// </summary>
    public partial class FormIngrediente : Form
    {
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
    }
}
