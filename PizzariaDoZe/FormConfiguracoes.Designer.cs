namespace PizzariaDoZe
{
    partial class FormConfiguracoes
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
            tabControl1 = new TabControl();
            TabPageIdioma = new TabPage();
            BtnSalvarIdioma = new Button();
            GroupBoxIdioma = new GroupBox();
            ComboBoxIdioma = new ComboBox();
            LabelIdioma = new Label();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            TabPageIdioma.SuspendLayout();
            GroupBoxIdioma.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabPageIdioma);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 53);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(792, 384);
            tabControl1.TabIndex = 0;
            // 
            // TabPageIdioma
            // 
            TabPageIdioma.Controls.Add(BtnSalvarIdioma);
            TabPageIdioma.Controls.Add(GroupBoxIdioma);
            TabPageIdioma.Location = new Point(4, 28);
            TabPageIdioma.Name = "TabPageIdioma";
            TabPageIdioma.Padding = new Padding(3);
            TabPageIdioma.Size = new Size(784, 352);
            TabPageIdioma.TabIndex = 0;
            TabPageIdioma.Text = "Idioma/Região";
            TabPageIdioma.UseVisualStyleBackColor = true;
            // 
            // BtnSalvarIdioma
            // 
            BtnSalvarIdioma.Location = new Point(25, 280);
            BtnSalvarIdioma.Name = "BtnSalvarIdioma";
            BtnSalvarIdioma.Size = new Size(90, 53);
            BtnSalvarIdioma.TabIndex = 2;
            BtnSalvarIdioma.Text = "Salvar";
            BtnSalvarIdioma.UseVisualStyleBackColor = true;
            BtnSalvarIdioma.Click += BtnSalvarIdioma_Click;
            // 
            // GroupBoxIdioma
            // 
            GroupBoxIdioma.Controls.Add(ComboBoxIdioma);
            GroupBoxIdioma.Controls.Add(LabelIdioma);
            GroupBoxIdioma.Location = new Point(25, 20);
            GroupBoxIdioma.Name = "GroupBoxIdioma";
            GroupBoxIdioma.Size = new Size(727, 167);
            GroupBoxIdioma.TabIndex = 1;
            GroupBoxIdioma.TabStop = false;
            GroupBoxIdioma.Text = "Idioma/Região";
            // 
            // ComboBoxIdioma
            // 
            ComboBoxIdioma.FormattingEnabled = true;
            ComboBoxIdioma.Items.AddRange(new object[] { "en-US", "es", "pt-BR" });
            ComboBoxIdioma.Location = new Point(22, 89);
            ComboBoxIdioma.Name = "ComboBoxIdioma";
            ComboBoxIdioma.Size = new Size(145, 27);
            ComboBoxIdioma.TabIndex = 1;
            // 
            // LabelIdioma
            // 
            LabelIdioma.AutoSize = true;
            LabelIdioma.Location = new Point(22, 57);
            LabelIdioma.Name = "LabelIdioma";
            LabelIdioma.Size = new Size(109, 20);
            LabelIdioma.TabIndex = 0;
            LabelIdioma.Text = "Idioma/Região";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(784, 352);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormConfiguracoes
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 449);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConfiguracoes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Configurações";
            tabControl1.ResumeLayout(false);
            TabPageIdioma.ResumeLayout(false);
            GroupBoxIdioma.ResumeLayout(false);
            GroupBoxIdioma.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TabPageIdioma;
        private TabPage tabPage2;
        private Button BtnSalvarIdioma;
        private GroupBox GroupBoxIdioma;
        private ComboBox ComboBoxIdioma;
        private Label LabelIdioma;
    }
}