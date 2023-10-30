using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    /// <summary>
    /// Inicializa o modal de Sabores
    /// </summary>
    public partial class FormSabores : Form
    {
        /// <summary>
        /// Inicializa o modal de Sabores
        /// </summary>
        public FormSabores()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
        }

        private void FormSabores_Load(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }
    }
}
