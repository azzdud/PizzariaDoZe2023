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
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 562);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizzaria do Zé";
            Load += FormPrincipal_Load;
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
    }
}