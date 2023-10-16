namespace PizzariaDoZe
{
    partial class UserControlEndereco
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
            ComboBoxCidade = new ComboBox();
            LabelCidade = new Label();
            ComboBoxUF = new ComboBox();
            ComboBoxPais = new ComboBox();
            LabelBairro = new Label();
            LabelUF = new Label();
            TextBoxPais = new TextBox();
            LabelPais = new Label();
            TextBoxLogradouro = new TextBox();
            LabelLogradouro = new Label();
            TextBoxNome = new TextBox();
            LabelCEP = new Label();
            TextBoxID = new TextBox();
            LabelID = new Label();
            TextBoxComplemento = new TextBox();
            LabelComplemento = new Label();
            LabelNumero = new Label();
            TextBoxNumero = new TextBox();
            SuspendLayout();
            // 
            // ComboBoxCidade
            // 
            ComboBoxCidade.FormattingEnabled = true;
            ComboBoxCidade.Location = new Point(22, 185);
            ComboBoxCidade.Name = "ComboBoxCidade";
            ComboBoxCidade.Size = new Size(267, 27);
            ComboBoxCidade.TabIndex = 5;
            // 
            // LabelCidade
            // 
            LabelCidade.AutoSize = true;
            LabelCidade.Location = new Point(22, 162);
            LabelCidade.Name = "LabelCidade";
            LabelCidade.Size = new Size(59, 20);
            LabelCidade.TabIndex = 25;
            LabelCidade.Text = "Cidade:";
            // 
            // ComboBoxUF
            // 
            ComboBoxUF.FormattingEnabled = true;
            ComboBoxUF.Location = new Point(423, 114);
            ComboBoxUF.Name = "ComboBoxUF";
            ComboBoxUF.Size = new Size(190, 27);
            ComboBoxUF.TabIndex = 4;
            // 
            // ComboBoxPais
            // 
            ComboBoxPais.FormattingEnabled = true;
            ComboBoxPais.Location = new Point(22, 114);
            ComboBoxPais.Name = "ComboBoxPais";
            ComboBoxPais.Size = new Size(368, 27);
            ComboBoxPais.TabIndex = 3;
            // 
            // LabelBairro
            // 
            LabelBairro.AutoSize = true;
            LabelBairro.Location = new Point(321, 163);
            LabelBairro.Name = "LabelBairro";
            LabelBairro.Size = new Size(52, 20);
            LabelBairro.TabIndex = 22;
            LabelBairro.Text = "Bairro:";
            // 
            // LabelUF
            // 
            LabelUF.AutoSize = true;
            LabelUF.Location = new Point(423, 91);
            LabelUF.Name = "LabelUF";
            LabelUF.Size = new Size(29, 20);
            LabelUF.TabIndex = 21;
            LabelUF.Text = "UF:";
            // 
            // TextBoxPais
            // 
            TextBoxPais.Location = new Point(321, 186);
            TextBoxPais.Name = "TextBoxPais";
            TextBoxPais.Size = new Size(292, 26);
            TextBoxPais.TabIndex = 6;
            // 
            // LabelPais
            // 
            LabelPais.AutoSize = true;
            LabelPais.Location = new Point(22, 91);
            LabelPais.Name = "LabelPais";
            LabelPais.Size = new Size(37, 20);
            LabelPais.TabIndex = 19;
            LabelPais.Text = "País:";
            // 
            // TextBoxLogradouro
            // 
            TextBoxLogradouro.Location = new Point(321, 47);
            TextBoxLogradouro.Name = "TextBoxLogradouro";
            TextBoxLogradouro.Size = new Size(292, 26);
            TextBoxLogradouro.TabIndex = 2;
            // 
            // LabelLogradouro
            // 
            LabelLogradouro.AutoSize = true;
            LabelLogradouro.Location = new Point(321, 24);
            LabelLogradouro.Name = "LabelLogradouro";
            LabelLogradouro.Size = new Size(90, 20);
            LabelLogradouro.TabIndex = 18;
            LabelLogradouro.Text = "Logradouro:";
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(169, 47);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(120, 26);
            TextBoxNome.TabIndex = 1;
            // 
            // LabelCEP
            // 
            LabelCEP.AutoSize = true;
            LabelCEP.Location = new Point(169, 24);
            LabelCEP.Name = "LabelCEP";
            LabelCEP.Size = new Size(37, 20);
            LabelCEP.TabIndex = 16;
            LabelCEP.Text = "CEP:";
            // 
            // TextBoxID
            // 
            TextBoxID.Location = new Point(22, 47);
            TextBoxID.Name = "TextBoxID";
            TextBoxID.Size = new Size(120, 26);
            TextBoxID.TabIndex = 0;
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Location = new Point(22, 24);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(27, 20);
            LabelID.TabIndex = 14;
            LabelID.Text = "ID:";
            // 
            // TextBoxComplemento
            // 
            TextBoxComplemento.Location = new Point(186, 258);
            TextBoxComplemento.Name = "TextBoxComplemento";
            TextBoxComplemento.Size = new Size(427, 26);
            TextBoxComplemento.TabIndex = 8;
            // 
            // LabelComplemento
            // 
            LabelComplemento.AutoSize = true;
            LabelComplemento.Location = new Point(186, 235);
            LabelComplemento.Name = "LabelComplemento";
            LabelComplemento.Size = new Size(107, 20);
            LabelComplemento.TabIndex = 22;
            LabelComplemento.Text = "Complemento:";
            // 
            // LabelNumero
            // 
            LabelNumero.AutoSize = true;
            LabelNumero.Location = new Point(22, 235);
            LabelNumero.Name = "LabelNumero";
            LabelNumero.Size = new Size(66, 20);
            LabelNumero.TabIndex = 25;
            LabelNumero.Text = "Número:";
            // 
            // TextBoxNumero
            // 
            TextBoxNumero.Location = new Point(22, 258);
            TextBoxNumero.Name = "TextBoxNumero";
            TextBoxNumero.Size = new Size(137, 26);
            TextBoxNumero.TabIndex = 7;
            // 
            // UserControlEndereco
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TextBoxNumero);
            Controls.Add(LabelNumero);
            Controls.Add(ComboBoxCidade);
            Controls.Add(LabelCidade);
            Controls.Add(ComboBoxUF);
            Controls.Add(LabelComplemento);
            Controls.Add(ComboBoxPais);
            Controls.Add(LabelBairro);
            Controls.Add(TextBoxComplemento);
            Controls.Add(LabelUF);
            Controls.Add(TextBoxPais);
            Controls.Add(LabelPais);
            Controls.Add(TextBoxLogradouro);
            Controls.Add(LabelLogradouro);
            Controls.Add(TextBoxNome);
            Controls.Add(LabelCEP);
            Controls.Add(TextBoxID);
            Controls.Add(LabelID);
            Name = "UserControlEndereco";
            Size = new Size(631, 302);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBoxCidade;
        private Label LabelCidade;
        private ComboBox ComboBoxUF;
        private ComboBox ComboBoxPais;
        private Label LabelBairro;
        private Label LabelUF;
        private TextBox TextBoxPais;
        private Label LabelPais;
        private TextBox TextBoxLogradouro;
        private Label LabelLogradouro;
        private TextBox TextBoxNome;
        private Label LabelCEP;
        private TextBox TextBoxID;
        private Label LabelID;
        private TextBox TextBoxComplemento;
        private Label LabelComplemento;
        private Label LabelNumero;
        private TextBox TextBoxNumero;
    }
}
