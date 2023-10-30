namespace PizzariaDoZe
{
    public partial class FormPrincipal : Form
    {
        readonly FormFuncionario formFuncionario = new();
        readonly FormCliente formCliente = new();
        readonly FormIngrediente formIngrediente = new();
        readonly FormSabores formSabores = new();
        readonly FormValores formValores = new();
        readonly FormProduto formProduto = new();
        readonly FormLogin formLogin = new();
        FormConfiguracoes formConfiguracoes = new();
        readonly UserControlFuncoes userControlFuncoes = new();

        /// <summary>
        /// Inicializa o formulário principal
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            formFuncionario.ShowDialog();
         //TESTE
            Funcoes.AjustaResourcesControl(this);
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            formCliente.ShowDialog();
            Funcoes.AjustaResourcesControl(this);
        }

        private void BtnIngredientes_Click(object sender, EventArgs e)
        {
            formIngrediente.ShowDialog();
        }

        private void BtnSabores_Click(object sender, EventArgs e)
        {
            formSabores.ShowDialog();
        }

        private void BtnValores_Click(object sender, EventArgs e)
        {
            formValores.ShowDialog();
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            formProduto.ShowDialog();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            formLogin.ShowDialog();
        }

        private void BtnConfiguracoes_Click(object sender, EventArgs e)
        {
            formConfiguracoes = new();

            _ = formConfiguracoes.ShowDialog();
            // remove todos os controles e recria a tela, aplicando assim o novo idioma
            Controls.Clear();
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

    }
}