using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    public partial class FormConfiguracoes : Form
    {
        /// <summary>
        /// Inicializa o modal de Configurações
        /// </summary>
        public FormConfiguracoes()
        {
            InitializeComponent();

            Funcoes.AjustaResourcesControl(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);


            //seleciona no comboBox o idioma/cultura atual
            ComboBoxIdioma.SelectedItem = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
        }

        private void BtnSalvarIdioma_Click(object sender, EventArgs e)
        {
            //abre o arquivo local como leitura/escrita e salva as alterações em ProjetoPastelariaDoZe_2023.dll.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", ComboBoxIdioma.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            //atualiza a cultura corrente
            Program.AjustaIdiomaRegiao();
            Close();
            _ = MessageBox.Show("Idioma/região alterada com sucesso!");
            Refresh();
        }
    }
}
