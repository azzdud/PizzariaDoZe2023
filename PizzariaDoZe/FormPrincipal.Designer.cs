namespace PizzariaDoZe
{
    /// <summary>
    /// Inicializa o formulário principal
    /// </summary>
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            BtnInicio = new Button();
            BtnEndereco = new Button();
            BtnFuncionarios = new Button();
            BtnClientes = new Button();
            BtnIngredientes = new Button();
            BtnSabores = new Button();
            BtnValores = new Button();
            BtnProdutos = new Button();
            userControlFuncoes1 = new UserControlFuncoes();
            BtnConfiguracoes = new Button();
            contextMenuStripPrincipal = new ContextMenuStrip(components);
            enderecoToolStripMenuItem = new ToolStripMenuItem();
            funcionariosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            ingredientesToolStripMenuItem = new ToolStripMenuItem();
            saboresToolStripMenuItem = new ToolStripMenuItem();
            valoresDasPizzasToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            configToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            notifyIconSystemTray = new NotifyIcon(components);
            contextMenuStripSystemTray = new ContextMenuStrip(components);
            abrirAplicacaoToolStripMenuItem = new ToolStripMenuItem();
            encerrarToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStripPrincipal.SuspendLayout();
            contextMenuStripSystemTray.SuspendLayout();
            SuspendLayout();
            // 
            // BtnInicio
            // 
            BtnInicio.Location = new Point(12, 12);
            BtnInicio.Name = "BtnInicio";
            BtnInicio.Size = new Size(99, 60);
            BtnInicio.TabIndex = 0;
            BtnInicio.Text = "Login";
            BtnInicio.UseVisualStyleBackColor = true;
            BtnInicio.Click += BtnInicio_Click;
            // 
            // BtnEndereco
            // 
            BtnEndereco.Location = new Point(12, 88);
            BtnEndereco.Name = "BtnEndereco";
            BtnEndereco.Size = new Size(118, 60);
            BtnEndereco.TabIndex = 1;
            BtnEndereco.Text = "Endereço";
            BtnEndereco.UseVisualStyleBackColor = true;
            // 
            // BtnFuncionarios
            // 
            BtnFuncionarios.Location = new Point(12, 154);
            BtnFuncionarios.Name = "BtnFuncionarios";
            BtnFuncionarios.Size = new Size(118, 60);
            BtnFuncionarios.TabIndex = 2;
            BtnFuncionarios.Text = "Funcionários";
            BtnFuncionarios.UseVisualStyleBackColor = true;
            BtnFuncionarios.Click += BtnFuncionarios_Click;
            // 
            // BtnClientes
            // 
            BtnClientes.Location = new Point(12, 221);
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Size = new Size(118, 60);
            BtnClientes.TabIndex = 3;
            BtnClientes.Text = "Clientes";
            BtnClientes.UseVisualStyleBackColor = true;
            BtnClientes.Click += BtnClientes_Click;
            // 
            // BtnIngredientes
            // 
            BtnIngredientes.Location = new Point(12, 287);
            BtnIngredientes.Name = "BtnIngredientes";
            BtnIngredientes.Size = new Size(118, 60);
            BtnIngredientes.TabIndex = 4;
            BtnIngredientes.Text = "Ingredientes";
            BtnIngredientes.UseVisualStyleBackColor = true;
            BtnIngredientes.Click += BtnIngredientes_Click;
            // 
            // BtnSabores
            // 
            BtnSabores.Location = new Point(12, 355);
            BtnSabores.Name = "BtnSabores";
            BtnSabores.Size = new Size(118, 60);
            BtnSabores.TabIndex = 5;
            BtnSabores.Text = "Sabores";
            BtnSabores.UseVisualStyleBackColor = true;
            BtnSabores.Click += BtnSabores_Click;
            // 
            // BtnValores
            // 
            BtnValores.Location = new Point(12, 421);
            BtnValores.Name = "BtnValores";
            BtnValores.Size = new Size(118, 60);
            BtnValores.TabIndex = 6;
            BtnValores.Text = "Valores das Pizzas";
            BtnValores.UseVisualStyleBackColor = true;
            BtnValores.Click += BtnValores_Click;
            // 
            // BtnProdutos
            // 
            BtnProdutos.Location = new Point(12, 488);
            BtnProdutos.Name = "BtnProdutos";
            BtnProdutos.Size = new Size(118, 60);
            BtnProdutos.TabIndex = 7;
            BtnProdutos.Text = "Produtos";
            BtnProdutos.UseVisualStyleBackColor = true;
            BtnProdutos.Click += BtnProdutos_Click;
            // 
            // userControlFuncoes1
            // 
            userControlFuncoes1.Location = new Point(514, 446);
            userControlFuncoes1.Name = "userControlFuncoes1";
            userControlFuncoes1.Size = new Size(532, 118);
            userControlFuncoes1.TabIndex = 9;
            // 
            // BtnConfiguracoes
            // 
            BtnConfiguracoes.Location = new Point(957, 12);
            BtnConfiguracoes.Name = "BtnConfiguracoes";
            BtnConfiguracoes.Size = new Size(76, 47);
            BtnConfiguracoes.TabIndex = 8;
            BtnConfiguracoes.Text = "Config";
            BtnConfiguracoes.UseVisualStyleBackColor = true;
            BtnConfiguracoes.Click += BtnConfiguracoes_Click;
            // 
            // contextMenuStripPrincipal
            // 
            contextMenuStripPrincipal.ImageScalingSize = new Size(19, 19);
            contextMenuStripPrincipal.Items.AddRange(new ToolStripItem[] { enderecoToolStripMenuItem, funcionariosToolStripMenuItem, clientesToolStripMenuItem, ingredientesToolStripMenuItem, saboresToolStripMenuItem, valoresDasPizzasToolStripMenuItem, produtosToolStripMenuItem, configToolStripMenuItem, sairToolStripMenuItem });
            contextMenuStripPrincipal.Name = "contextMenuStripPrincipal";
            contextMenuStripPrincipal.Size = new Size(198, 220);
            // 
            // enderecoToolStripMenuItem
            // 
            enderecoToolStripMenuItem.Name = "enderecoToolStripMenuItem";
            enderecoToolStripMenuItem.Size = new Size(197, 24);
            enderecoToolStripMenuItem.Text = "Endereço";
            // 
            // funcionariosToolStripMenuItem
            // 
            funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            funcionariosToolStripMenuItem.Size = new Size(197, 24);
            funcionariosToolStripMenuItem.Text = "Funcionários";
            funcionariosToolStripMenuItem.Click += BtnFuncionarios_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(197, 24);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += BtnClientes_Click;
            // 
            // ingredientesToolStripMenuItem
            // 
            ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            ingredientesToolStripMenuItem.Size = new Size(197, 24);
            ingredientesToolStripMenuItem.Text = "Ingredientes";
            ingredientesToolStripMenuItem.Click += BtnIngredientes_Click;
            // 
            // saboresToolStripMenuItem
            // 
            saboresToolStripMenuItem.Name = "saboresToolStripMenuItem";
            saboresToolStripMenuItem.Size = new Size(197, 24);
            saboresToolStripMenuItem.Text = "Sabores";
            saboresToolStripMenuItem.Click += BtnSabores_Click;
            // 
            // valoresDasPizzasToolStripMenuItem
            // 
            valoresDasPizzasToolStripMenuItem.Name = "valoresDasPizzasToolStripMenuItem";
            valoresDasPizzasToolStripMenuItem.Size = new Size(197, 24);
            valoresDasPizzasToolStripMenuItem.Text = "Valores das Pizzas";
            valoresDasPizzasToolStripMenuItem.Click += BtnValores_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(197, 24);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += BtnProdutos_Click;
            // 
            // configToolStripMenuItem
            // 
            configToolStripMenuItem.Name = "configToolStripMenuItem";
            configToolStripMenuItem.Size = new Size(197, 24);
            configToolStripMenuItem.Text = "Config";
            configToolStripMenuItem.Click += BtnConfiguracoes_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(197, 24);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // notifyIconSystemTray
            // 
            notifyIconSystemTray.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconSystemTray.BalloonTipText = "Aplicação continua executando na bandeja";
            notifyIconSystemTray.BalloonTipTitle = "Pizzaria do Zé";
            notifyIconSystemTray.ContextMenuStrip = contextMenuStripSystemTray;
            notifyIconSystemTray.Icon = (Icon)resources.GetObject("notifyIconSystemTray.Icon");
            notifyIconSystemTray.Text = "Pizzaria do Zé";
            notifyIconSystemTray.BalloonTipClicked += abrirAplicacaoToolStripMenuItem_Click;
            notifyIconSystemTray.MouseDoubleClick += notifyIconSystemTray_MouseDoubleClick;
            // 
            // contextMenuStripSystemTray
            // 
            contextMenuStripSystemTray.ImageScalingSize = new Size(19, 19);
            contextMenuStripSystemTray.Items.AddRange(new ToolStripItem[] { abrirAplicacaoToolStripMenuItem, encerrarToolStripMenuItem, sobreToolStripMenuItem });
            contextMenuStripSystemTray.Name = "contextMenuStripSystemTray";
            contextMenuStripSystemTray.Size = new Size(182, 76);
            // 
            // abrirAplicacaoToolStripMenuItem
            // 
            abrirAplicacaoToolStripMenuItem.Name = "abrirAplicacaoToolStripMenuItem";
            abrirAplicacaoToolStripMenuItem.Size = new Size(181, 24);
            abrirAplicacaoToolStripMenuItem.Text = "Abrir Aplicação";
            abrirAplicacaoToolStripMenuItem.Click += abrirAplicacaoToolStripMenuItem_Click;
            // 
            // encerrarToolStripMenuItem
            // 
            encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            encerrarToolStripMenuItem.Size = new Size(181, 24);
            encerrarToolStripMenuItem.Text = "Encerrar";
            encerrarToolStripMenuItem.Click += encerrarToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(181, 24);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 562);
            ContextMenuStrip = contextMenuStripPrincipal;
            Controls.Add(userControlFuncoes1);
            Controls.Add(BtnConfiguracoes);
            Controls.Add(BtnProdutos);
            Controls.Add(BtnIngredientes);
            Controls.Add(BtnValores);
            Controls.Add(BtnClientes);
            Controls.Add(BtnSabores);
            Controls.Add(BtnFuncionarios);
            Controls.Add(BtnEndereco);
            Controls.Add(BtnInicio);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizzaria do Zé";
            Load += FormPrincipal_Load;
            Resize += FormPrincipal_Resize;
            contextMenuStripPrincipal.ResumeLayout(false);
            contextMenuStripSystemTray.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BtnInicio;
        private Button BtnEndereco;
        private Button BtnFuncionarios;
        private Button BtnClientes;
        private Button BtnIngredientes;
        private Button BtnSabores;
        private Button BtnValores;
        private Button BtnProdutos;
        private UserControlFuncoes userControlFuncoes1;
        private Button BtnConfiguracoes;
        private ContextMenuStrip contextMenuStripPrincipal;
        private ToolStripMenuItem enderecoToolStripMenuItem;
        private ToolStripMenuItem funcionariosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem ingredientesToolStripMenuItem;
        private ToolStripMenuItem saboresToolStripMenuItem;
        private ToolStripMenuItem valoresDasPizzasToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem configToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private NotifyIcon notifyIconSystemTray;
        private ContextMenuStrip contextMenuStripSystemTray;
        private ToolStripMenuItem abrirAplicacaoToolStripMenuItem;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
    }
}