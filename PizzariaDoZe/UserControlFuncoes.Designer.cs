namespace PizzariaDoZe
{
    partial class UserControlFuncoes
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            BtnSalvar = new Button();
            BtnEditar = new Button();
            BtnExcluir = new Button();
            BtnFechar = new Button();
            SuspendLayout();
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(27, 25);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(104, 77);
            BtnSalvar.TabIndex = 0;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(152, 25);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(104, 77);
            BtnEditar.TabIndex = 1;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(278, 25);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(104, 77);
            BtnExcluir.TabIndex = 2;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(403, 25);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(104, 77);
            BtnFechar.TabIndex = 3;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // UserControlFuncoes
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnFechar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnSalvar);
            Name = "UserControlFuncoes";
            Size = new Size(527, 126);
            ResumeLayout(false);
        }

        #endregion
        /// <summary>
        /// Botão para salvar o formulário atual.
        /// </summary>
        public Button BtnSalvar;
        /// <summary>
        /// Botão para editar o item do formulário atual.
        /// </summary>
        public Button BtnEditar;
        /// <summary>
        /// Botão para excluir item do formulário atual.
        /// </summary>
        public Button BtnExcluir;
        /// <summary>
        /// Botão para fechar o formulário atual.
        /// </summary>
        public Button BtnFechar;
    }
}
