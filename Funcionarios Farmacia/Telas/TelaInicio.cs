using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Funcionarios_Farmacia.Telas
{
    public partial class TelaInicio : Form
    {
        public TelaInicio()
        {
            InitializeComponent();
        }

        private void bt_cadastro_Click(object sender, EventArgs e)
        {
            TelaFuncionario telafunc = new TelaFuncionario();
            telafunc.ShowDialog();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            TelaLogin telalog = new TelaLogin();
            telalog.ShowDialog();
        }

        private void TelaInicio_Load(object sender, EventArgs e)
        {

        }
    }
}