namespace PizzariaDoZe
{
    partial class UserControlLogradouro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelID = new Label();
            TextBoxID = new TextBox();
            TextBoxNome = new TextBox();
            LabelCEP = new Label();
            TextBoxLogradouro = new TextBox();
            LabelLogradouro = new Label();
            TextBoxPais = new TextBox();
            LabelPais = new Label();
            LabelUF = new Label();
            LabelBairro = new Label();
            ComboBoxPais = new ComboBox();
            ComboBoxUF = new ComboBox();
            comboBox1 = new ComboBox();
            LabelCidade = new Label();
            SuspendLayout();
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Location = new Point(25, 29);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(27, 20);
            LabelID.TabIndex = 0;
            LabelID.Text = "ID:";
            // 
            // TextBoxID
            // 
            TextBoxID.Location = new Point(25, 52);
            TextBoxID.Name = "TextBoxID";
            TextBoxID.Size = new Size(120, 26);
            TextBoxID.TabIndex = 0;
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(172, 52);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(120, 26);
            TextBoxNome.TabIndex = 2;
            // 
            // LabelCEP
            // 
            LabelCEP.AutoSize = true;
            LabelCEP.Location = new Point(172, 29);
            LabelCEP.Name = "LabelCEP";
            LabelCEP.Size = new Size(37, 20);
            LabelCEP.TabIndex = 2;
            LabelCEP.Text = "CEP:";
            // 
            // TextBoxLogradouro
            // 
            TextBoxLogradouro.Location = new Point(324, 52);
            TextBoxLogradouro.Name = "TextBoxLogradouro";
            TextBoxLogradouro.Size = new Size(292, 26);
            TextBoxLogradouro.TabIndex = 3;
            // 
            // LabelLogradouro
            // 
            LabelLogradouro.AutoSize = true;
            LabelLogradouro.Location = new Point(324, 29);
            LabelLogradouro.Name = "LabelLogradouro";
            LabelLogradouro.Size = new Size(90, 20);
            LabelLogradouro.TabIndex = 4;
            LabelLogradouro.Text = "Logradouro:";
            // 
            // TextBoxPais
            // 
            TextBoxPais.Location = new Point(324, 200);
            TextBoxPais.Name = "TextBoxPais";
            TextBoxPais.Size = new Size(292, 26);
            TextBoxPais.TabIndex = 7;
            // 
            // LabelPais
            // 
            LabelPais.AutoSize = true;
            LabelPais.Location = new Point(25, 98);
            LabelPais.Name = "LabelPais";
            LabelPais.Size = new Size(37, 20);
            LabelPais.TabIndex = 6;
            LabelPais.Text = "País:";
            // 
            // LabelUF
            // 
            LabelUF.AutoSize = true;
            LabelUF.Location = new Point(426, 98);
            LabelUF.Name = "LabelUF";
            LabelUF.Size = new Size(29, 20);
            LabelUF.TabIndex = 8;
            LabelUF.Text = "UF:";
            // 
            // LabelBairro
            // 
            LabelBairro.AutoSize = true;
            LabelBairro.Location = new Point(324, 177);
            LabelBairro.Name = "LabelBairro";
            LabelBairro.Size = new Size(52, 20);
            LabelBairro.TabIndex = 9;
            LabelBairro.Text = "Bairro:";
            // 
            // ComboBoxPais
            // 
            ComboBoxPais.FormattingEnabled = true;
            ComboBoxPais.Location = new Point(25, 121);
            ComboBoxPais.Name = "ComboBoxPais";
            ComboBoxPais.Size = new Size(368, 27);
            ComboBoxPais.TabIndex = 10;
            // 
            // ComboBoxUF
            // 
            ComboBoxUF.FormattingEnabled = true;
            ComboBoxUF.Location = new Point(426, 121);
            ComboBoxUF.Name = "ComboBoxUF";
            ComboBoxUF.Size = new Size(190, 27);
            ComboBoxUF.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(25, 199);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(267, 27);
            comboBox1.TabIndex = 12;
            // 
            // LabelCidade
            // 
            LabelCidade.AutoSize = true;
            LabelCidade.Location = new Point(25, 176);
            LabelCidade.Name = "LabelCidade";
            LabelCidade.Size = new Size(59, 20);
            LabelCidade.TabIndex = 11;
            LabelCidade.Text = "Cidade:";
            // 
            // UserControlLogradouro
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(646, 261);
            Controls.Add(comboBox1);
            Controls.Add(LabelCidade);
            Controls.Add(ComboBoxUF);
            Controls.Add(ComboBoxPais);
            Controls.Add(LabelBairro);
            Controls.Add(LabelUF);
            Controls.Add(TextBoxPais);
            Controls.Add(LabelPais);
            Controls.Add(TextBoxLogradouro);
            Controls.Add(LabelLogradouro);
            Controls.Add(TextBoxNome);
            Controls.Add(LabelCEP);
            Controls.Add(TextBoxID);
            Controls.Add(LabelID);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserControlLogradouro";
            Text = "UserControlLogradouro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelID;
        private TextBox TextBoxID;
        private TextBox TextBoxNome;
        private Label LabelCEP;
        private TextBox TextBoxLogradouro;
        private Label LabelLogradouro;
        private TextBox TextBoxPais;
        private Label LabelPais;
        private Label LabelUF;
        private Label LabelBairro;
        private ComboBox ComboBoxPais;
        private ComboBox ComboBoxUF;
        private ComboBox comboBox1;
        private Label LabelCidade;
    }
}