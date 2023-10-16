namespace PizzariaDoZe
{
    partial class FormLogin
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
            LabelLogin = new Label();
            PanelLogin = new Panel();
            BtnAcessar = new Button();
            TextBoxSenha = new TextBox();
            LabelSenha = new Label();
            TextBoxUsuario = new TextBox();
            LabelUsuario = new Label();
            PanelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // LabelLogin
            // 
            LabelLogin.AutoSize = true;
            LabelLogin.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LabelLogin.Location = new Point(264, 41);
            LabelLogin.Name = "LabelLogin";
            LabelLogin.Size = new Size(73, 32);
            LabelLogin.TabIndex = 0;
            LabelLogin.Text = "Login";
            // 
            // PanelLogin
            // 
            PanelLogin.Controls.Add(BtnAcessar);
            PanelLogin.Controls.Add(TextBoxSenha);
            PanelLogin.Controls.Add(LabelSenha);
            PanelLogin.Controls.Add(TextBoxUsuario);
            PanelLogin.Controls.Add(LabelUsuario);
            PanelLogin.Location = new Point(15, 110);
            PanelLogin.Name = "PanelLogin";
            PanelLogin.Size = new Size(579, 256);
            PanelLogin.TabIndex = 1;
            // 
            // BtnAcessar
            // 
            BtnAcessar.Location = new Point(455, 210);
            BtnAcessar.Name = "BtnAcessar";
            BtnAcessar.Size = new Size(90, 28);
            BtnAcessar.TabIndex = 2;
            BtnAcessar.Text = "Acessar";
            BtnAcessar.UseVisualStyleBackColor = true;
            // 
            // TextBoxSenha
            // 
            TextBoxSenha.Location = new Point(40, 156);
            TextBoxSenha.Name = "TextBoxSenha";
            TextBoxSenha.Size = new Size(491, 26);
            TextBoxSenha.TabIndex = 1;
            // 
            // LabelSenha
            // 
            LabelSenha.AutoSize = true;
            LabelSenha.Location = new Point(40, 122);
            LabelSenha.Name = "LabelSenha";
            LabelSenha.Size = new Size(49, 20);
            LabelSenha.TabIndex = 0;
            LabelSenha.Text = "Senha";
            LabelSenha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBoxUsuario
            // 
            TextBoxUsuario.Location = new Point(40, 69);
            TextBoxUsuario.Name = "TextBoxUsuario";
            TextBoxUsuario.Size = new Size(491, 26);
            TextBoxUsuario.TabIndex = 0;
            // 
            // LabelUsuario
            // 
            LabelUsuario.AutoSize = true;
            LabelUsuario.Location = new Point(40, 35);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(59, 20);
            LabelUsuario.TabIndex = 0;
            LabelUsuario.Text = "Usuário";
            LabelUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 380);
            Controls.Add(PanelLogin);
            Controls.Add(LabelLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormLogin";
            Load += FormLogin_Load;
            PanelLogin.ResumeLayout(false);
            PanelLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelLogin;
        private Panel PanelLogin;
        private Button BtnAcessar;
        private TextBox TextBoxSenha;
        private Label LabelSenha;
        private TextBox TextBoxUsuario;
        private Label LabelUsuario;
    }
}