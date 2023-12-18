namespace PizzariaDoZe
{
    partial class FormEndereco
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
            ButtonBuscar = new Button();
            textBoxFiltro = new TextBox();
            dataGridViewDados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).BeginInit();
            SuspendLayout();
            // 
            // ButtonBuscar
            // 
            ButtonBuscar.Location = new Point(355, 21);
            ButtonBuscar.Name = "ButtonBuscar";
            ButtonBuscar.Size = new Size(95, 26);
            ButtonBuscar.TabIndex = 0;
            ButtonBuscar.Text = "Buscar";
            ButtonBuscar.UseVisualStyleBackColor = true;
            ButtonBuscar.Click += ButtonBuscar_Click;
            // 
            // textBoxFiltro
            // 
            textBoxFiltro.Location = new Point(21, 21);
            textBoxFiltro.Name = "textBoxFiltro";
            textBoxFiltro.Size = new Size(319, 26);
            textBoxFiltro.TabIndex = 1;
            // 
            // dataGridViewDados
            // 
            dataGridViewDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados.Location = new Point(12, 77);
            dataGridViewDados.Name = "dataGridViewDados";
            dataGridViewDados.RowHeadersWidth = 49;
            dataGridViewDados.RowTemplate.Height = 28;
            dataGridViewDados.Size = new Size(776, 361);
            dataGridViewDados.TabIndex = 2;
            // 
            // FormEndereco
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewDados);
            Controls.Add(textBoxFiltro);
            Controls.Add(ButtonBuscar);
            Name = "FormEndereco";
            Text = "FormEndereco";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonBuscar;
        private TextBox textBoxFiltro;
        private DataGridView dataGridViewDados;
    }
}