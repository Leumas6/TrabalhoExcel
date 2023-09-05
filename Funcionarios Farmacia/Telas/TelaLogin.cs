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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
            
        }

        private void button_iniciotela_Click(object sender, EventArgs e)
        {
            TelaInicio telainic = new TelaInicio();
            telainic.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_id_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tb_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}