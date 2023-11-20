namespace PizzariaDoZe
{
    partial class FormIngrediente
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
            PanelCadastro = new Panel();
            TextBoxNome = new TextBox();
            LabelNome = new Label();
            TextBoxID = new TextBox();
            LabelID = new Label();
            userControlFuncoes = new UserControlFuncoes();
            btnSalvar = new Button();
            PanelCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // PanelCadastro
            // 
            PanelCadastro.BackColor = Color.LightBlue;
            PanelCadastro.Controls.Add(TextBoxNome);
            PanelCadastro.Controls.Add(LabelNome);
            PanelCadastro.Controls.Add(TextBoxID);
            PanelCadastro.Controls.Add(LabelID);
            PanelCadastro.Location = new Point(12, 12);
            PanelCadastro.Name = "PanelCadastro";
            PanelCadastro.Size = new Size(560, 96);
            PanelCadastro.TabIndex = 1;
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(178, 45);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(364, 26);
            TextBoxNome.TabIndex = 1;
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Location = new Point(178, 22);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(53, 20);
            LabelNome.TabIndex = 0;
            LabelNome.Text = "Nome:";
            // 
            // TextBoxID
            // 
            TextBoxID.Enabled = false;
            TextBoxID.Location = new Point(14, 45);
            TextBoxID.Name = "TextBoxID";
            TextBoxID.Size = new Size(147, 26);
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
            // userControlFuncoes
            // 
            userControlFuncoes.Location = new Point(15, 114);
            userControlFuncoes.Name = "userControlFuncoes";
            userControlFuncoes.Size = new Size(631, 151);
            userControlFuncoes.TabIndex = 2;
            userControlFuncoes.Click += BtnSalvar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(43, 138);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(103, 77);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // FormIngrediente
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 226);
            Controls.Add(btnSalvar);
            Controls.Add(userControlFuncoes);
            Controls.Add(PanelCadastro);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormIngrediente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormIngrediente";
            Load += FormIngrediente_Load;
            PanelCadastro.ResumeLayout(false);
            PanelCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelCadastro;
        private TextBox TextBoxNome;
        private Label LabelNome;
        private TextBox TextBoxID;
        private Label LabelID;
        private UserControlFuncoes userControlFuncoes;
        private Button btnSalvar;
    }
}