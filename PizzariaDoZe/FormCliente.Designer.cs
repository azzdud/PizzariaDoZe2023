namespace PizzariaDoZe
{
    partial class FormCliente
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
            PanelCliente = new Panel();
            TextBoxCPF = new TextBox();
            LabelCPF = new Label();
            TextBoxEmail = new TextBox();
            LabelEmail = new Label();
            TextBoxTelefone = new TextBox();
            LabelTelefone = new Label();
            TextBoxNome = new TextBox();
            LabelNome = new Label();
            TextBoxID = new TextBox();
            LabelID = new Label();
            userControlEndereco1 = new UserControlEndereco();
            userControlFuncoes1 = new UserControlFuncoes();
            PanelCliente.SuspendLayout();
            SuspendLayout();
            // 
            // PanelCliente
            // 
            PanelCliente.BackColor = Color.LightBlue;
            PanelCliente.Controls.Add(TextBoxCPF);
            PanelCliente.Controls.Add(LabelCPF);
            PanelCliente.Controls.Add(TextBoxEmail);
            PanelCliente.Controls.Add(LabelEmail);
            PanelCliente.Controls.Add(TextBoxTelefone);
            PanelCliente.Controls.Add(LabelTelefone);
            PanelCliente.Controls.Add(TextBoxNome);
            PanelCliente.Controls.Add(LabelNome);
            PanelCliente.Controls.Add(TextBoxID);
            PanelCliente.Controls.Add(LabelID);
            PanelCliente.Location = new Point(12, 12);
            PanelCliente.Name = "PanelCliente";
            PanelCliente.Size = new Size(422, 305);
            PanelCliente.TabIndex = 1;
            // 
            // TextBoxCPF
            // 
            TextBoxCPF.Location = new Point(207, 45);
            TextBoxCPF.Name = "TextBoxCPF";
            TextBoxCPF.Size = new Size(193, 26);
            TextBoxCPF.TabIndex = 1;
            // 
            // LabelCPF
            // 
            LabelCPF.AutoSize = true;
            LabelCPF.Location = new Point(207, 22);
            LabelCPF.Name = "LabelCPF";
            LabelCPF.Size = new Size(36, 20);
            LabelCPF.TabIndex = 0;
            LabelCPF.Text = "CPF:";
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(14, 182);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(275, 26);
            TextBoxEmail.TabIndex = 3;
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(14, 159);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(55, 20);
            LabelEmail.TabIndex = 0;
            LabelEmail.Text = "E-mail:";
            // 
            // TextBoxTelefone
            // 
            TextBoxTelefone.Location = new Point(14, 246);
            TextBoxTelefone.Name = "TextBoxTelefone";
            TextBoxTelefone.Size = new Size(176, 26);
            TextBoxTelefone.TabIndex = 4;
            // 
            // LabelTelefone
            // 
            LabelTelefone.AutoSize = true;
            LabelTelefone.Location = new Point(14, 223);
            LabelTelefone.Name = "LabelTelefone";
            LabelTelefone.Size = new Size(69, 20);
            LabelTelefone.TabIndex = 0;
            LabelTelefone.Text = "Telefone:";
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(14, 112);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(386, 26);
            TextBoxNome.TabIndex = 2;
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Location = new Point(14, 89);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(53, 20);
            LabelNome.TabIndex = 0;
            LabelNome.Text = "Nome:";
            // 
            // TextBoxID
            // 
            TextBoxID.Location = new Point(14, 45);
            TextBoxID.Name = "TextBoxID";
            TextBoxID.Size = new Size(176, 26);
            TextBoxID.TabIndex = 0;
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Location = new Point(14, 22);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(27, 20);
            LabelID.TabIndex = 0;
            LabelID.Text = "ID:";
            // 
            // userControlEndereco1
            // 
            userControlEndereco1.Location = new Point(440, 12);
            userControlEndereco1.Name = "userControlEndereco1";
            userControlEndereco1.Size = new Size(639, 305);
            userControlEndereco1.TabIndex = 5;
            // 
            // userControlFuncoes1
            // 
            userControlFuncoes1.Location = new Point(523, 309);
            userControlFuncoes1.Name = "userControlFuncoes1";
            userControlFuncoes1.Size = new Size(527, 121);
            userControlFuncoes1.TabIndex = 6;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 451);
            Controls.Add(userControlFuncoes1);
            Controls.Add(userControlEndereco1);
            Controls.Add(PanelCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormClientes";
            Load += FormCliente_Load;
            PanelCliente.ResumeLayout(false);
            PanelCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelCliente;
        private TextBox TextBoxCPF;
        private Label LabelCPF;
        private TextBox TextBoxEmail;
        private Label LabelEmail;
        private TextBox TextBoxTelefone;
        private Label LabelTelefone;
        private TextBox TextBoxNome;
        private Label LabelNome;
        private TextBox TextBoxID;
        private Label LabelID;
        private UserControlEndereco userControlEndereco1;
        private UserControlFuncoes userControlFuncoes1;
    }
}