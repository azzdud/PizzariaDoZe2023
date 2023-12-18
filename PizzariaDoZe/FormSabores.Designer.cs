namespace PizzariaDoZe
{
    partial class FormSabores
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
            ListBoxTipo = new ListBox();
            ListBoxCategoria = new ListBox();
            CheckedListBoxIngredientes = new CheckedListBox();
            LabelFoto = new Label();
            PictureBoxFoto = new PictureBox();
            LabelTipo = new Label();
            LabelCategoria = new Label();
            TextBoxNome = new TextBox();
            LabelNome = new Label();
            TextBoxID = new TextBox();
            LabelIngredientes = new Label();
            LabelID = new Label();
            userControlFuncoes1 = new UserControlFuncoes();
            BtnSalvar = new Button();
            ButtonPdfCompleto = new Button();
            PanelCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxFoto).BeginInit();
            SuspendLayout();
            // 
            // PanelCadastro
            // 
            PanelCadastro.BackColor = Color.LightBlue;
            PanelCadastro.Controls.Add(ListBoxTipo);
            PanelCadastro.Controls.Add(ListBoxCategoria);
            PanelCadastro.Controls.Add(CheckedListBoxIngredientes);
            PanelCadastro.Controls.Add(LabelFoto);
            PanelCadastro.Controls.Add(PictureBoxFoto);
            PanelCadastro.Controls.Add(LabelTipo);
            PanelCadastro.Controls.Add(LabelCategoria);
            PanelCadastro.Controls.Add(TextBoxNome);
            PanelCadastro.Controls.Add(LabelNome);
            PanelCadastro.Controls.Add(TextBoxID);
            PanelCadastro.Controls.Add(LabelIngredientes);
            PanelCadastro.Controls.Add(LabelID);
            PanelCadastro.Location = new Point(12, 12);
            PanelCadastro.Name = "PanelCadastro";
            PanelCadastro.Size = new Size(624, 405);
            PanelCadastro.TabIndex = 2;
            // 
            // ListBoxTipo
            // 
            ListBoxTipo.FormattingEnabled = true;
            ListBoxTipo.ItemHeight = 19;
            ListBoxTipo.Items.AddRange(new object[] { "Doce", "Salgada" });
            ListBoxTipo.Location = new Point(209, 115);
            ListBoxTipo.Name = "ListBoxTipo";
            ListBoxTipo.Size = new Size(133, 42);
            ListBoxTipo.TabIndex = 8;
            // 
            // ListBoxCategoria
            // 
            ListBoxCategoria.FormattingEnabled = true;
            ListBoxCategoria.ItemHeight = 19;
            ListBoxCategoria.Items.AddRange(new object[] { "Tradicional", "Especial" });
            ListBoxCategoria.Location = new Point(14, 115);
            ListBoxCategoria.Name = "ListBoxCategoria";
            ListBoxCategoria.Size = new Size(133, 42);
            ListBoxCategoria.TabIndex = 7;
            // 
            // CheckedListBoxIngredientes
            // 
            CheckedListBoxIngredientes.FormattingEnabled = true;
            CheckedListBoxIngredientes.Location = new Point(384, 45);
            CheckedListBoxIngredientes.Name = "CheckedListBoxIngredientes";
            CheckedListBoxIngredientes.Size = new Size(223, 340);
            CheckedListBoxIngredientes.TabIndex = 6;
            // 
            // LabelFoto
            // 
            LabelFoto.AutoSize = true;
            LabelFoto.Location = new Point(14, 159);
            LabelFoto.Name = "LabelFoto";
            LabelFoto.Size = new Size(42, 20);
            LabelFoto.TabIndex = 5;
            LabelFoto.Text = "Foto:";
            // 
            // PictureBoxFoto
            // 
            PictureBoxFoto.Location = new Point(14, 182);
            PictureBoxFoto.Name = "PictureBoxFoto";
            PictureBoxFoto.Size = new Size(237, 203);
            PictureBoxFoto.TabIndex = 4;
            PictureBoxFoto.TabStop = false;
            // 
            // LabelTipo
            // 
            LabelTipo.AutoSize = true;
            LabelTipo.Location = new Point(209, 92);
            LabelTipo.Name = "LabelTipo";
            LabelTipo.Size = new Size(42, 20);
            LabelTipo.TabIndex = 0;
            LabelTipo.Text = "Tipo:";
            // 
            // LabelCategoria
            // 
            LabelCategoria.AutoSize = true;
            LabelCategoria.Location = new Point(14, 92);
            LabelCategoria.Name = "LabelCategoria";
            LabelCategoria.Size = new Size(77, 20);
            LabelCategoria.TabIndex = 0;
            LabelCategoria.Text = "Categoria:";
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(118, 45);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(240, 26);
            TextBoxNome.TabIndex = 1;
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Location = new Point(118, 22);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(53, 20);
            LabelNome.TabIndex = 0;
            LabelNome.Text = "Nome:";
            // 
            // TextBoxID
            // 
            TextBoxID.Location = new Point(14, 45);
            TextBoxID.Name = "TextBoxID";
            TextBoxID.Size = new Size(86, 26);
            TextBoxID.TabIndex = 0;
            // 
            // LabelIngredientes
            // 
            LabelIngredientes.AutoSize = true;
            LabelIngredientes.Location = new Point(384, 22);
            LabelIngredientes.Name = "LabelIngredientes";
            LabelIngredientes.Size = new Size(94, 20);
            LabelIngredientes.TabIndex = 0;
            LabelIngredientes.Text = "Ingredientes:";
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
            // userControlFuncoes1
            // 
            userControlFuncoes1.Location = new Point(54, 407);
            userControlFuncoes1.Name = "userControlFuncoes1";
            userControlFuncoes1.Size = new Size(534, 125);
            userControlFuncoes1.TabIndex = 3;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(80, 432);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(104, 76);
            BtnSalvar.TabIndex = 9;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // ButtonPdfCompleto
            // 
            ButtonPdfCompleto.Location = new Point(580, 432);
            ButtonPdfCompleto.Name = "ButtonPdfCompleto";
            ButtonPdfCompleto.Size = new Size(54, 44);
            ButtonPdfCompleto.TabIndex = 9;
            ButtonPdfCompleto.Text = "PDF";
            ButtonPdfCompleto.UseVisualStyleBackColor = true;
            ButtonPdfCompleto.Click += ButtonPdfCompleto_Click;
            // 
            // FormSabores
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 525);
            Controls.Add(ButtonPdfCompleto);
            Controls.Add(BtnSalvar);
            Controls.Add(PanelCadastro);
            Controls.Add(userControlFuncoes1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSabores";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormSabores";
            Load += FormSabores_Load;
            PanelCadastro.ResumeLayout(false);
            PanelCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelCadastro;
        private Label LabelTipo;
        private Label LabelCategoria;
        private TextBox TextBoxNome;
        private Label LabelNome;
        private TextBox TextBoxID;
        private Label LabelID;
        private Label LabelFoto;
        private PictureBox PictureBoxFoto;
        private Label LabelIngredientes;
        private UserControlFuncoes userControlFuncoes1;
        private CheckedListBox CheckedListBoxIngredientes;
        private ListBox ListBoxCategoria;
        private ListBox ListBoxTipo;
        private Button BtnSalvar;
        private Button ButtonPdfCompleto;
    }
}