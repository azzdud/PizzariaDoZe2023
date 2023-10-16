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
    /// Inicializa o modal de Valores
    /// </summary>
    public partial class FormValores : Form
    {
        /// <summary>
        /// Inicializa o modal de Valores
        /// </summary>
        public FormValores()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void FormValores_Load(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }
    }
}
