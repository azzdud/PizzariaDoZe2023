namespace PizzariaDoZe
{
    partial class FormProduto
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
            PanelProduto = new Panel();
            ComboBoxML = new ComboBox();
            ListBoxTipo = new ListBox();
            TextBoxValor = new TextBox();
            LabelValor = new Label();
            TextBoxNome = new TextBox();
            LabelNome = new Label();
            LabelML = new Label();
            TextBoxID = new TextBox();
            LabelTipo = new Label();
            LabelID = new Label();
            userControlFuncoes1 = new UserControlFuncoes();
            PanelProduto.SuspendLayout();
            SuspendLayout();
            // 
            // PanelProduto
            // 
            PanelProduto.BackColor = Color.LightBlue;
            PanelProduto.Controls.Add(ComboBoxML);
            PanelProduto.Controls.Add(ListBoxTipo);
            PanelProduto.Controls.Add(TextBoxValor);
            PanelProduto.Controls.Add(LabelValor);
            PanelProduto.Controls.Add(TextBoxNome);
            PanelProduto.Controls.Add(LabelNome);
            PanelProduto.Controls.Add(LabelML);
            PanelProduto.Controls.Add(TextBoxID);
            PanelProduto.Controls.Add(LabelTipo);
            PanelProduto.Controls.Add(LabelID);
            PanelProduto.Location = new Point(12, 12);
            PanelProduto.Name = "PanelProduto";
            PanelProduto.Size = new Size(539, 267);
            PanelProduto.TabIndex = 4;
            // 
            // ComboBoxML
            // 
            ComboBoxML.FormattingEnabled = true;
            ComboBoxML.Items.AddRange(new object[] { "150", "300", "600", "1000", "1500", "2000" });
            ComboBoxML.Location = new Point(383, 214);
            ComboBoxML.Name = "ComboBoxML";
            ComboBoxML.Size = new Size(97, 27);
            ComboBoxML.TabIndex = 4;
            // 
            // ListBoxTipo
            // 
            ListBoxTipo.FormattingEnabled = true;
            ListBoxTipo.ItemHeight = 19;
            ListBoxTipo.Items.AddRange(new object[] { "Refrigerante", "Cerveja", "Suco", "Água", "Outros" });
            ListBoxTipo.Location = new Point(383, 43);
            ListBoxTipo.Name = "ListBoxTipo";
            ListBoxTipo.Size = new Size(97, 118);
            ListBoxTipo.TabIndex = 3;
            // 
            // TextBoxValor
            // 
            TextBoxValor.Location = new Point(30, 215);
            TextBoxValor.Name = "TextBoxValor";
            TextBoxValor.Size = new Size(289, 26);
            TextBoxValor.TabIndex = 2;
            // 
            // LabelValor
            // 
            LabelValor.AutoSize = true;
            LabelValor.Location = new Point(30, 192);
            LabelValor.Name = "LabelValor";
            LabelValor.Size = new Size(46, 20);
            LabelValor.TabIndex = 0;
            LabelValor.Text = "Valor:";
            // 
            // TextBoxNome
            // 
            TextBoxNome.Location = new Point(30, 128);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(289, 26);
            TextBoxNome.TabIndex = 1;
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Location = new Point(30, 105);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(53, 20);
            LabelNome.TabIndex = 0;
            LabelNome.Text = "Nome:";
            // 
            // LabelML
            // 
            LabelML.AutoSize = true;
            LabelML.Location = new Point(383, 191);
            LabelML.Name = "LabelML";
            LabelML.Size = new Size(38, 20);
            LabelML.TabIndex = 0;
            LabelML.Text = "MLs:";
            // 
            // TextBoxID
            // 
            TextBoxID.Location = new Point(30, 43);
            TextBoxID.Name = "TextBoxID";
            TextBoxID.Size = new Size(86, 26);
            TextBoxID.TabIndex = 0;
            // 
            // LabelTipo
            // 
            LabelTipo.AutoSize = true;
            LabelTipo.Location = new Point(383, 16);
            LabelTipo.Name = "LabelTipo";
            LabelTipo.Size = new Size(42, 20);
            LabelTipo.TabIndex = 0;
            LabelTipo.Text = "Tipo:";
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Location = new Point(30, 20);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(27, 20);
            LabelID.TabIndex = 0;
            LabelID.Text = "ID:";
            // 
            // userControlFuncoes1
            // 
            userControlFuncoes1.Location = new Point(12, 271);
            userControlFuncoes1.Name = "userControlFuncoes1";
            userControlFuncoes1.Size = new Size(524, 119);
            userControlFuncoes1.TabIndex = 5;
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 386);
            Controls.Add(PanelProduto);
            Controls.Add(userControlFuncoes1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormProduto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormProduto";
            Load += FormProduto_Load;
            PanelProduto.ResumeLayout(false);
            PanelProduto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelProduto;
        private ListBox ListBoxTipo;
        private TextBox TextBoxValor;
        private Label LabelValor;
        private TextBox TextBoxNome;
        private Label LabelNome;
        private Label LabelML;
        private TextBox TextBoxID;
        private Label LabelTipo;
        private Label LabelID;
        private ComboBox ComboBoxML;
        private UserControlFuncoes userControlFuncoes1;
    }
}