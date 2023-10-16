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
    /// Inicializa o modal de Endereços
    /// </summary>
    public partial class UserControlEndereco : UserControl
    {
        /// <summary>
        /// Inicializa o modal de Endereços
        /// </summary>
        public UserControlEndereco()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }
    }
}
