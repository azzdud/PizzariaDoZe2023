namespace PizzariaDoZe
{
    partial class FormValores
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
            PanelValores = new Panel();
            ListBoxCategoria = new ListBox();
            ListBoxTamanho = new ListBox();
            TextBoxValorAdc = new TextBox();
            LabelValorAdc = new Label();
            TextBoxValor = new TextBox();
            LabelValor = new Label();
            LabelCategoria = new Label();
            TextBoxID = new TextBox();
            LabelTamanho = new Label();
            LabelID = new Label();
            userControlFuncoes1 = new UserControlFuncoes();
            PanelValores.SuspendLayout();
            SuspendLayout();
            // 
            // PanelValores
            // 
            PanelValores.BackColor = Color.LightBlue;
            PanelValores.Controls.Add(ListBoxCategoria);
            PanelValores.Controls.Add(ListBoxTamanho);
            PanelValores.Controls.Add(TextBoxValorAdc);
            PanelValores.Controls.Add(LabelValorAdc);
            PanelValores.Controls.Add(TextBoxValor);
            PanelValores.Controls.Add(LabelValor);
            PanelValores.Controls.Add(LabelCategoria);
            PanelValores.Controls.Add(TextBoxID);
            PanelValores.Controls.Add(LabelTamanho);
            PanelValores.Controls.Add(LabelID);
            PanelValores.Location = new Point(12, 12);
            PanelValores.Name = "PanelValores";
            PanelValores.Size = new Size(525, 267);
            PanelValores.TabIndex = 3;
            // 
            // ListBoxCategoria
            // 
            ListBoxCategoria.FormattingEnabled = true;
            ListBoxCategoria.ItemHeight = 19;
            ListBoxCategoria.Items.AddRange(new object[] { "Tradicional", "Especial" });
            ListBoxCategoria.Location = new Point(383, 195);
            ListBoxCategoria.Name = "ListBoxCategoria";
            ListBoxCategoria.Size = new Size(97, 42);
            ListBoxCategoria.TabIndex = 4;
            // 
            // ListBoxTamanho
            // 
            ListBoxTamanho.FormattingEnabled = true;
            ListBoxTamanho.ItemHeight = 19;
            ListBoxTamanho.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Família" });
            ListBoxTamanho.Location = new Point(383, 43);
            ListBoxTamanho.Name = "ListBoxTamanho";
            ListBoxTamanho.Size = new Size(97, 99);
            ListBoxTamanho.TabIndex = 3;
            // 
            // TextBoxValorAdc
            // 
            TextBoxValorAdc.Location = new Point(30, 215);
            TextBoxValorAdc.Name = "TextBoxValorAdc";
            TextBoxValorAdc.Size = new Size(289, 26);
            TextBoxValorAdc.TabIndex = 2;
            // 
            // LabelValorAdc
            // 
            LabelValorAdc.AutoSize = true;
            LabelValorAdc.Location = new Point(30, 192);
            LabelValorAdc.Name = "LabelValorAdc";
            LabelValorAdc.Size = new Size(110, 20);
            LabelValorAdc.TabIndex = 0;
            LabelValorAdc.Text = "Valor Adicional";
            // 
            // TextBoxValor
            // 
            TextBoxValor.Location = new Point(30, 128);
            TextBoxValor.Name = "TextBoxValor";
            TextBoxValor.Size = new Size(289, 26);
            TextBoxValor.TabIndex = 1;
            // 
            // LabelValor
            // 
            LabelValor.AutoSize = true;
            LabelValor.Location = new Point(30, 105);
            LabelValor.Name = "LabelValor";
            LabelValor.Size = new Size(46, 20);
            LabelValor.TabIndex = 0;
            LabelValor.Text = "Valor:";
            // 
            // LabelCategoria
            // 
            LabelCategoria.AutoSize = true;
            LabelCategoria.Location = new Point(383, 172);
            LabelCategoria.Name = "LabelCategoria";
            LabelCategoria.Size = new Size(77, 20);
            LabelCategoria.TabIndex = 0;
            LabelCategoria.Text = "Categoria:";
            // 
            // TextBoxID
            // 
            TextBoxID.Location = new Point(30, 43);
            TextBoxID.Name = "TextBoxID";
            TextBoxID.Size = new Size(86, 26);
            TextBoxID.TabIndex = 0;
            // 
            // LabelTamanho
            // 
            LabelTamanho.AutoSize = true;
            LabelTamanho.Location = new Point(383, 16);
            LabelTamanho.Name = "LabelTamanho";
            LabelTamanho.Size = new Size(72, 20);
            LabelTamanho.TabIndex = 0;
            LabelTamanho.Text = "Tamanho:";
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
            userControlFuncoes1.Location = new Point(15, 270);
            userControlFuncoes1.Name = "userControlFuncoes1";
            userControlFuncoes1.Size = new Size(525, 119);
            userControlFuncoes1.TabIndex = 4;
            // 
            // FormValores
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 389);
            Controls.Add(PanelValores);
            Controls.Add(userControlFuncoes1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormValores";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormValores";
            Load += FormValores_Load;
            PanelValores.ResumeLayout(false);
            PanelValores.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelValores;
        private TextBox TextBoxValorAdc;
        private Label LabelValorAdc;
        private TextBox TextBoxValor;
        private Label LabelValor;
        private Label LabelCategoria;
        private TextBox TextBoxID;
        private Label LabelTamanho;
        private Label LabelID;
        private ListBox ListBoxCategoria;
        private ListBox ListBoxTamanho;
        private UserControlFuncoes userControlFuncoes1;
    }
}