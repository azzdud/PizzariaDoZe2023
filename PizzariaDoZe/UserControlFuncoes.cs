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
    public partial class UserControlFuncoes : UserControl
    {
        public UserControlFuncoes()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Form form = FindForm();

            // Fecha o formulário
            form?.Close();
        }
    }
}
