namespace PizzariaDoZe
{
    partial class FormPedidos
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
            TextBoxID = new TextBox();
            tabControlPedido = new TabControl();
            tabPageCliente = new TabPage();
            button2 = new Button();
            dataGridViewDadosCliente = new DataGridView();
            buttonIniciarPedido = new Button();
            buttonBuscar = new Button();
            groupBox1 = new GroupBox();
            radioButtonNome = new RadioButton();
            radioButtonTelefone = new RadioButton();
            radioButtonCPF = new RadioButton();
            tabPagePizza = new TabPage();
            labelInfos = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            buttonPrevious = new Button();
            buttonNext = new Button();
            label2 = new Label();
            dataGridViewDados4 = new DataGridView();
            label1 = new Label();
            textBox2 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            Button_Salvar = new Button();
            checkedListBoxIngredientes = new CheckedListBox();
            groupBox2 = new GroupBox();
            listBoxTamanho = new ListBox();
            textBox3 = new TextBox();
            labelID = new Label();
            tabPageProdutos = new TabPage();
            buttonVoltar = new Button();
            buttonAvancar = new Button();
            groupBox4 = new GroupBox();
            button3 = new Button();
            label7 = new Label();
            textBoxProduto = new TextBox();
            button7 = new Button();
            dataGridViewProduto = new DataGridView();
            tabPageFinalizar = new TabPage();
            label16 = new Label();
            dataGridView5 = new DataGridView();
            button4 = new Button();
            label15 = new Label();
            dataGridView4 = new DataGridView();
            label14 = new Label();
            dataGridView3 = new DataGridView();
            textBox6 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            dataGridView2 = new DataGridView();
            label11 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            label9 = new Label();
            textBox5 = new TextBox();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            tabControlPedido.SuspendLayout();
            tabPageCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDadosCliente).BeginInit();
            groupBox1.SuspendLayout();
            tabPagePizza.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados4).BeginInit();
            tabPageProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).BeginInit();
            tabPageFinalizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TextBoxID
            // 
            TextBoxID.Location = new Point(302, 52);
            TextBoxID.Name = "TextBoxID";
            TextBoxID.Size = new Size(455, 26);
            TextBoxID.TabIndex = 0;
            // 
            // tabControlPedido
            // 
            tabControlPedido.Controls.Add(tabPageCliente);
            tabControlPedido.Controls.Add(tabPagePizza);
            tabControlPedido.Controls.Add(tabPageProdutos);
            tabControlPedido.Controls.Add(tabPageFinalizar);
            tabControlPedido.Location = new Point(12, 12);
            tabControlPedido.Name = "tabControlPedido";
            tabControlPedido.SelectedIndex = 0;
            tabControlPedido.Size = new Size(1104, 553);
            tabControlPedido.TabIndex = 2;
            // 
            // tabPageCliente
            // 
            tabPageCliente.BackColor = Color.LightBlue;
            tabPageCliente.Controls.Add(button2);
            tabPageCliente.Controls.Add(dataGridViewDadosCliente);
            tabPageCliente.Controls.Add(buttonIniciarPedido);
            tabPageCliente.Controls.Add(buttonBuscar);
            tabPageCliente.Controls.Add(groupBox1);
            tabPageCliente.Controls.Add(TextBoxID);
            tabPageCliente.Location = new Point(4, 28);
            tabPageCliente.Name = "tabPageCliente";
            tabPageCliente.Padding = new Padding(3);
            tabPageCliente.Size = new Size(1096, 521);
            tabPageCliente.TabIndex = 0;
            tabPageCliente.Text = "Cliente";
            // 
            // button2
            // 
            button2.Location = new Point(915, 24);
            button2.Name = "button2";
            button2.Size = new Size(118, 54);
            button2.TabIndex = 79;
            button2.Text = "Cadastrar Novo Cliente";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDadosCliente
            // 
            dataGridViewDadosCliente.AllowUserToAddRows = false;
            dataGridViewDadosCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDadosCliente.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewDadosCliente.Location = new Point(19, 102);
            dataGridViewDadosCliente.MultiSelect = false;
            dataGridViewDadosCliente.Name = "dataGridViewDadosCliente";
            dataGridViewDadosCliente.RowHeadersWidth = 51;
            dataGridViewDadosCliente.RowTemplate.Height = 29;
            dataGridViewDadosCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDadosCliente.Size = new Size(1056, 321);
            dataGridViewDadosCliente.TabIndex = 78;
            // 
            // buttonIniciarPedido
            // 
            buttonIniciarPedido.Location = new Point(899, 444);
            buttonIniciarPedido.Name = "buttonIniciarPedido";
            buttonIniciarPedido.Size = new Size(151, 50);
            buttonIniciarPedido.TabIndex = 77;
            buttonIniciarPedido.Text = "Iniciar Pedido";
            buttonIniciarPedido.UseVisualStyleBackColor = true;
            buttonIniciarPedido.Click += buttonIniciarPedido_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(786, 24);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(100, 54);
            buttonBuscar.TabIndex = 76;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonNome);
            groupBox1.Controls.Add(radioButtonTelefone);
            groupBox1.Controls.Add(radioButtonCPF);
            groupBox1.Location = new Point(19, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 54);
            groupBox1.TabIndex = 75;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar por:";
            // 
            // radioButtonNome
            // 
            radioButtonNome.AutoSize = true;
            radioButtonNome.Location = new Point(21, 25);
            radioButtonNome.Name = "radioButtonNome";
            radioButtonNome.Size = new Size(68, 24);
            radioButtonNome.TabIndex = 14;
            radioButtonNome.TabStop = true;
            radioButtonNome.Text = "Nome";
            radioButtonNome.UseVisualStyleBackColor = true;
            // 
            // radioButtonTelefone
            // 
            radioButtonTelefone.AutoSize = true;
            radioButtonTelefone.Location = new Point(155, 25);
            radioButtonTelefone.Name = "radioButtonTelefone";
            radioButtonTelefone.Size = new Size(84, 24);
            radioButtonTelefone.TabIndex = 13;
            radioButtonTelefone.TabStop = true;
            radioButtonTelefone.Text = "Telefone";
            radioButtonTelefone.UseVisualStyleBackColor = true;
            // 
            // radioButtonCPF
            // 
            radioButtonCPF.AutoSize = true;
            radioButtonCPF.Location = new Point(97, 25);
            radioButtonCPF.Name = "radioButtonCPF";
            radioButtonCPF.Size = new Size(51, 24);
            radioButtonCPF.TabIndex = 12;
            radioButtonCPF.TabStop = true;
            radioButtonCPF.Text = "CPF";
            radioButtonCPF.UseVisualStyleBackColor = true;
            // 
            // tabPagePizza
            // 
            tabPagePizza.BackColor = Color.LightBlue;
            tabPagePizza.Controls.Add(labelInfos);
            tabPagePizza.Controls.Add(textBox1);
            tabPagePizza.Controls.Add(label4);
            tabPagePizza.Controls.Add(groupBox3);
            tabPagePizza.Controls.Add(textBox3);
            tabPagePizza.Controls.Add(labelID);
            tabPagePizza.Location = new Point(4, 28);
            tabPagePizza.Name = "tabPagePizza";
            tabPagePizza.Padding = new Padding(3);
            tabPagePizza.Size = new Size(1096, 521);
            tabPagePizza.TabIndex = 1;
            tabPagePizza.Text = "Pizza";
            // 
            // labelInfos
            // 
            labelInfos.AutoSize = true;
            labelInfos.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfos.Location = new Point(18, 8);
            labelInfos.Name = "labelInfos";
            labelInfos.Size = new Size(232, 30);
            labelInfos.TabIndex = 87;
            labelInfos.Text = "Informações do Pedido:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(486, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 29);
            textBox1.TabIndex = 85;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(419, 15);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 86;
            label4.Text = "Cliente:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightSteelBlue;
            groupBox3.Controls.Add(buttonPrevious);
            groupBox3.Controls.Add(buttonNext);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(dataGridViewDados4);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(checkedListBox1);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(Button_Salvar);
            groupBox3.Controls.Add(checkedListBoxIngredientes);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(listBoxTamanho);
            groupBox3.Location = new Point(18, 51);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1058, 456);
            groupBox3.TabIndex = 84;
            groupBox3.TabStop = false;
            groupBox3.Text = "Pizza";
            // 
            // buttonPrevious
            // 
            buttonPrevious.Location = new Point(904, 401);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(60, 38);
            buttonPrevious.TabIndex = 93;
            buttonPrevious.Text = "<<<";
            buttonPrevious.UseVisualStyleBackColor = true;
            buttonPrevious.Click += buttonPrevious_Click;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(979, 401);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(60, 38);
            buttonNext.TabIndex = 92;
            buttonNext.Text = ">>>";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 272);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 91;
            label2.Text = "Comanda";
            // 
            // dataGridViewDados4
            // 
            dataGridViewDados4.AllowUserToAddRows = false;
            dataGridViewDados4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDados4.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewDados4.Location = new Point(18, 297);
            dataGridViewDados4.MultiSelect = false;
            dataGridViewDados4.Name = "dataGridViewDados4";
            dataGridViewDados4.RowHeadersWidth = 51;
            dataGridViewDados4.RowTemplate.Height = 29;
            dataGridViewDados4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDados4.Size = new Size(829, 142);
            dataGridViewDados4.TabIndex = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(578, 28);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 89;
            label1.Text = "Observações:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(582, 57);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 224);
            textBox2.TabIndex = 88;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI", 8.139131F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Sem Borda", "Catupiry", "Cheddar", "Chocolate Branco", "Chocolate Preto" });
            checkedListBox1.Location = new Point(401, 57);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(142, 124);
            checkedListBox1.TabIndex = 79;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(397, 28);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 78;
            label6.Text = "Borda:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 28);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 77;
            label5.Text = "Tamanho:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(146, 28);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 76;
            label3.Text = "Sabores:";
            // 
            // Button_Salvar
            // 
            Button_Salvar.BackColor = Color.Orange;
            Button_Salvar.Location = new Point(881, 226);
            Button_Salvar.Name = "Button_Salvar";
            Button_Salvar.Size = new Size(158, 55);
            Button_Salvar.TabIndex = 61;
            Button_Salvar.Text = "Adicionar Pizza";
            Button_Salvar.UseVisualStyleBackColor = false;
            // 
            // checkedListBoxIngredientes
            // 
            checkedListBoxIngredientes.Font = new Font("Segoe UI", 8.139131F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBoxIngredientes.FormattingEnabled = true;
            checkedListBoxIngredientes.Items.AddRange(new object[] { "Margherita", "Calabresa", "Quatro Queijos", "Frango com Catupiry", "Pepperoni", "Portuguesa", "Margherita Especial", "Vegetariana", "Frango com Bacon", "Margherita Supreme" });
            checkedListBoxIngredientes.Location = new Point(151, 57);
            checkedListBoxIngredientes.Name = "checkedListBoxIngredientes";
            checkedListBoxIngredientes.Size = new Size(203, 224);
            checkedListBoxIngredientes.TabIndex = 50;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Bisque;
            groupBox2.Location = new Point(881, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(158, 172);
            groupBox2.TabIndex = 75;
            groupBox2.TabStop = false;
            groupBox2.Text = "Valor da Pizza";
            // 
            // listBoxTamanho
            // 
            listBoxTamanho.FormattingEnabled = true;
            listBoxTamanho.ItemHeight = 19;
            listBoxTamanho.Items.AddRange(new object[] { "Pequena", "Média", "Grande", "Família" });
            listBoxTamanho.Location = new Point(18, 57);
            listBoxTamanho.Name = "listBoxTamanho";
            listBoxTamanho.Size = new Size(88, 99);
            listBoxTamanho.TabIndex = 59;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(296, 12);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(94, 29);
            textBox3.TabIndex = 82;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelID.Location = new Point(262, 15);
            labelID.Name = "labelID";
            labelID.Size = new Size(28, 21);
            labelID.TabIndex = 83;
            labelID.Text = "ID:";
            // 
            // tabPageProdutos
            // 
            tabPageProdutos.BackColor = Color.LightBlue;
            tabPageProdutos.Controls.Add(buttonVoltar);
            tabPageProdutos.Controls.Add(buttonAvancar);
            tabPageProdutos.Controls.Add(groupBox4);
            tabPageProdutos.Controls.Add(button3);
            tabPageProdutos.Controls.Add(label7);
            tabPageProdutos.Controls.Add(textBoxProduto);
            tabPageProdutos.Controls.Add(button7);
            tabPageProdutos.Controls.Add(dataGridViewProduto);
            tabPageProdutos.Location = new Point(4, 28);
            tabPageProdutos.Name = "tabPageProdutos";
            tabPageProdutos.Padding = new Padding(3);
            tabPageProdutos.Size = new Size(1096, 521);
            tabPageProdutos.TabIndex = 2;
            tabPageProdutos.Text = "Produtos";
            // 
            // buttonVoltar
            // 
            buttonVoltar.Location = new Point(940, 459);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(60, 38);
            buttonVoltar.TabIndex = 95;
            buttonVoltar.Text = "<<<";
            buttonVoltar.UseVisualStyleBackColor = true;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // buttonAvancar
            // 
            buttonAvancar.Location = new Point(1015, 459);
            buttonAvancar.Name = "buttonAvancar";
            buttonAvancar.Size = new Size(60, 38);
            buttonAvancar.TabIndex = 94;
            buttonAvancar.Text = ">>>";
            buttonAvancar.UseVisualStyleBackColor = true;
            buttonAvancar.Click += buttonAvancar_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Bisque;
            groupBox4.Location = new Point(844, 26);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(231, 403);
            groupBox4.TabIndex = 91;
            groupBox4.TabStop = false;
            groupBox4.Text = "Produtos adicionados:";
            // 
            // button3
            // 
            button3.BackColor = Color.Orange;
            button3.Location = new Point(615, 23);
            button3.Name = "button3";
            button3.Size = new Size(201, 68);
            button3.TabIndex = 89;
            button3.Text = "Adicionar Produto";
            button3.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(32, 26);
            label7.Name = "label7";
            label7.Size = new Size(228, 25);
            label7.TabIndex = 88;
            label7.Text = "Digite o nome do produto:";
            // 
            // textBoxProduto
            // 
            textBoxProduto.Location = new Point(32, 53);
            textBoxProduto.Multiline = true;
            textBoxProduto.Name = "textBoxProduto";
            textBoxProduto.Size = new Size(309, 29);
            textBoxProduto.TabIndex = 48;
            // 
            // button7
            // 
            button7.Location = new Point(356, 42);
            button7.Name = "button7";
            button7.Size = new Size(89, 49);
            button7.TabIndex = 47;
            button7.Text = "Buscar";
            button7.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProduto
            // 
            dataGridViewProduto.AllowUserToAddRows = false;
            dataGridViewProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduto.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewProduto.Location = new Point(32, 97);
            dataGridViewProduto.MultiSelect = false;
            dataGridViewProduto.Name = "dataGridViewProduto";
            dataGridViewProduto.RowHeadersWidth = 51;
            dataGridViewProduto.RowTemplate.Height = 29;
            dataGridViewProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProduto.Size = new Size(784, 400);
            dataGridViewProduto.TabIndex = 46;
            // 
            // tabPageFinalizar
            // 
            tabPageFinalizar.BackColor = Color.LightBlue;
            tabPageFinalizar.Controls.Add(label16);
            tabPageFinalizar.Controls.Add(dataGridView5);
            tabPageFinalizar.Controls.Add(button4);
            tabPageFinalizar.Controls.Add(label15);
            tabPageFinalizar.Controls.Add(dataGridView4);
            tabPageFinalizar.Controls.Add(label14);
            tabPageFinalizar.Controls.Add(dataGridView3);
            tabPageFinalizar.Controls.Add(textBox6);
            tabPageFinalizar.Controls.Add(label13);
            tabPageFinalizar.Controls.Add(label12);
            tabPageFinalizar.Controls.Add(dataGridView2);
            tabPageFinalizar.Controls.Add(label11);
            tabPageFinalizar.Controls.Add(label8);
            tabPageFinalizar.Controls.Add(textBox4);
            tabPageFinalizar.Controls.Add(label9);
            tabPageFinalizar.Controls.Add(textBox5);
            tabPageFinalizar.Controls.Add(label10);
            tabPageFinalizar.Controls.Add(dataGridView1);
            tabPageFinalizar.Location = new Point(4, 28);
            tabPageFinalizar.Name = "tabPageFinalizar";
            tabPageFinalizar.Padding = new Padding(3);
            tabPageFinalizar.Size = new Size(1096, 521);
            tabPageFinalizar.TabIndex = 3;
            tabPageFinalizar.Text = "Finalizar Pedido";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(895, 258);
            label16.Name = "label16";
            label16.Size = new Size(162, 21);
            label16.TabIndex = 105;
            label16.Text = "Forma de pagamento:";
            // 
            // dataGridView5
            // 
            dataGridView5.AllowUserToAddRows = false;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView5.Location = new Point(899, 286);
            dataGridView5.MultiSelect = false;
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.RowTemplate.Height = 29;
            dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView5.Size = new Size(164, 53);
            dataGridView5.TabIndex = 104;
            // 
            // button4
            // 
            button4.BackColor = Color.Orange;
            button4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(638, 386);
            button4.Name = "button4";
            button4.Size = new Size(425, 90);
            button4.TabIndex = 103;
            button4.Text = "Finalizar Pedido";
            button4.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(634, 153);
            label15.Name = "label15";
            label15.Size = new Size(77, 21);
            label15.TabIndex = 102;
            label15.Text = "Endereço:";
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView4.Location = new Point(638, 185);
            dataGridView4.MultiSelect = false;
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 29;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.Size = new Size(222, 154);
            dataGridView4.TabIndex = 101;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(895, 157);
            label14.Name = "label14";
            label14.Size = new Size(85, 21);
            label14.TabIndex = 100;
            label14.Text = "Valor Total:";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView3.Location = new Point(899, 185);
            dataGridView3.MultiSelect = false;
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(164, 44);
            dataGridView3.TabIndex = 99;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(386, 59);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(353, 29);
            textBox6.TabIndex = 97;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(194, 62);
            label13.Name = "label13";
            label13.Size = new Size(186, 21);
            label13.TabIndex = 98;
            label13.Text = "Funcionário Responsável:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(346, 153);
            label12.Name = "label12";
            label12.Size = new Size(76, 21);
            label12.TabIndex = 96;
            label12.Text = "Produtos:";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView2.Location = new Point(350, 185);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(232, 291);
            dataGridView2.TabIndex = 95;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(50, 153);
            label11.Name = "label11";
            label11.Size = new Size(55, 21);
            label11.TabIndex = 94;
            label11.Text = "Pizzas:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(47, 19);
            label8.Name = "label8";
            label8.Size = new Size(232, 30);
            label8.TabIndex = 92;
            label8.Text = "Informações do Pedido:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(117, 101);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(518, 29);
            textBox4.TabIndex = 90;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(50, 104);
            label9.Name = "label9";
            label9.Size = new Size(61, 21);
            label9.TabIndex = 91;
            label9.Text = "Cliente:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(84, 59);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(88, 29);
            textBox5.TabIndex = 88;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(50, 62);
            label10.Name = "label10";
            label10.Size = new Size(28, 21);
            label10.TabIndex = 89;
            label10.Text = "ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(54, 185);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(232, 291);
            dataGridView1.TabIndex = 84;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1128, 577);
            Controls.Add(tabControlPedido);
            Name = "FormPedidos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pedidos";
            tabControlPedido.ResumeLayout(false);
            tabPageCliente.ResumeLayout(false);
            tabPageCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDadosCliente).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPagePizza.ResumeLayout(false);
            tabPagePizza.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDados4).EndInit();
            tabPageProdutos.ResumeLayout(false);
            tabPageProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).EndInit();
            tabPageFinalizar.ResumeLayout(false);
            tabPageFinalizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox TextBoxID;
        private TabControl tabControlPedido;
        private TabPage tabPageCliente;
        private TabPage tabPagePizza;
        private GroupBox groupBox1;
        private RadioButton radioButtonNome;
        private RadioButton radioButtonTelefone;
        private RadioButton radioButtonCPF;
        private Button buttonBuscar;
        private Button button2;
        private DataGridView dataGridViewDadosCliente;
        private Button buttonIniciarPedido;
        private GroupBox groupBox3;
        private Label label3;
        private Button Button_Salvar;
        private CheckedListBox checkedListBoxIngredientes;
        private GroupBox groupBox2;
        private ListBox listBoxTamanho;
        private TextBox textBox3;
        private Label labelID;
        private Label labelInfos;
        private TextBox textBox1;
        private Label label4;
        private Label label6;
        private Label label5;
        private DataGridView dataGridViewDados4;
        private Label label1;
        private TextBox textBox2;
        private CheckedListBox checkedListBox1;
        private TabPage tabPageProdutos;
        private Label label2;
        private GroupBox groupBox4;
        private Button button3;
        private Label label7;
        private TextBox textBoxProduto;
        private Button button7;
        private DataGridView dataGridViewProduto;
        private TabPage tabPageFinalizar;
        private Button button4;
        private Label label15;
        private DataGridView dataGridView4;
        private Label label14;
        private DataGridView dataGridView3;
        private TextBox textBox6;
        private Label label13;
        private Label label12;
        private DataGridView dataGridView2;
        private Label label11;
        private Label label8;
        private TextBox textBox4;
        private Label label9;
        private TextBox textBox5;
        private Label label10;
        private DataGridView dataGridView1;
        private Label label16;
        private DataGridView dataGridView5;
        private Button buttonPrevious;
        private Button buttonNext;
        private Button buttonVoltar;
        private Button buttonAvancar;
    }
}