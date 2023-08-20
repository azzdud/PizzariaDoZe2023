namespace PizzariaDoZe
{
    public partial class FormPrincipal : Form
    {
        FormFuncionario formFuncionario = new();
        FormCliente formCliente = new();
        FormIngrediente formIngrediente = new();
        FormSabores formSabores = new();
        FormValores formValores = new();
        FormProduto formProduto = new();
        FormLogin formLogin = new();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            formFuncionario.ShowDialog();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            formCliente.ShowDialog();
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
    }
}