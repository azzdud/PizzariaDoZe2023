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
            LabelFoto = new Label();
            PictureBoxFoto = new PictureBox();
            CheckedListBoxIngredientes = new CheckedListBox();
            ComboBoxTipo = new ComboBox();
            LabelTipo = new Label();
            ComboBoxCategoria = new ComboBox();
            LabelCategoria = new Label();
            TextBoxNome = new TextBox();
            LabelNome = new Label();
            TextBoxID = new TextBox();
            LabelIngredientes = new Label();
            LabelID = new Label();
            userControlFuncoes1 = new UserControlFuncoes();
            PanelCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxFoto).BeginInit();
            SuspendLayout();
            // 
            // PanelCadastro
            // 
            PanelCadastro.BackColor = Color.LightBlue;
            PanelCadastro.Controls.Add(LabelFoto);
            PanelCadastro.Controls.Add(PictureBoxFoto);
            PanelCadastro.Controls.Add(CheckedListBoxIngredientes);
            PanelCadastro.Controls.Add(ComboBoxTipo);
            PanelCadastro.Controls.Add(LabelTipo);
            PanelCadastro.Controls.Add(ComboBoxCategoria);
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
            // CheckedListBoxIngredientes
            // 
            CheckedListBoxIngredientes.FormattingEnabled = true;
            CheckedListBoxIngredientes.Location = new Point(384, 45);
            CheckedListBoxIngredientes.Name = "CheckedListBoxIngredientes";
            CheckedListBoxIngredientes.Size = new Size(220, 340);
            CheckedListBoxIngredientes.TabIndex = 4;
            // 
            // ComboBoxTipo
            // 
            ComboBoxTipo.FormattingEnabled = true;
            ComboBoxTipo.Items.AddRange(new object[] { "Doce", "Salgada" });
            ComboBoxTipo.Location = new Point(209, 115);
            ComboBoxTipo.Name = "ComboBoxTipo";
            ComboBoxTipo.Size = new Size(149, 27);
            ComboBoxTipo.TabIndex = 3;
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
            // ComboBoxCategoria
            // 
            ComboBoxCategoria.FormattingEnabled = true;
            ComboBoxCategoria.Items.AddRange(new object[] { "Tradicional", "Especial" });
            ComboBoxCategoria.Location = new Point(14, 115);
            ComboBoxCategoria.Name = "ComboBoxCategoria";
            ComboBoxCategoria.Size = new Size(176, 27);
            ComboBoxCategoria.TabIndex = 2;
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
            // FormSabores
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 525);
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
        private ComboBox ComboBoxTipo;
        private Label LabelTipo;
        private ComboBox ComboBoxCategoria;
        private Label LabelCategoria;
        private TextBox TextBoxNome;
        private Label LabelNome;
        private TextBox TextBoxID;
        private Label LabelID;
        private Label LabelFoto;
        private PictureBox PictureBoxFoto;
        private CheckedListBox CheckedListBoxIngredientes;
        private Label LabelIngredientes;
        private UserControlFuncoes userControlFuncoes1;
    }
}