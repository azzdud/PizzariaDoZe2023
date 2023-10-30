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
    /// Inicializa o modal de Funções
    /// </summary>
    public partial class UserControlFuncoes : UserControl
    {
        /// <summary>
        /// Inicializa o modal de Funções
        /// </summary>
        public UserControlFuncoes()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        public void BtnFechar_Click(object sender, EventArgs e)
        {
            var form = FindForm();
                         
            // Fecha o formulário
            form?.Close();
        }
    }
}
