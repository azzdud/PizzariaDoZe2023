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
        // readonly UserControlFuncoes userControlFuncoes = new();

        /// <summary>
        /// Inicializa o formul�rio principal
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            Funcoes.AjustaResourcesItem(contextMenuStripPrincipal);
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
            Funcoes.AjustaResourcesItem(contextMenuStripPrincipal);
        }

        private void FormPrincipal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;

                notifyIconSystemTray.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
            }
        }

        private void abrirAplicacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // C�digo para encerrar a aplica��o
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exibe uma caixa de di�logo com informa��es sobre o aplicativo
            string mensagemSobre = "Pizzaria do Z�\nVers�o 1.0\nDesenvolvido por @azzdud\n� 2023 @azzdud";
            MessageBox.Show(mensagemSobre, "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void notifyIconSystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }
    }
}