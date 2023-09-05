using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Funcionarios_Farmacia.Entidades;
using Funcionarios_Farmacia.Telas;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Funcionarios_Farmacia
{
    public partial class TelaFuncionario : Form
    {
        List<Funcionario> tabelaFuncionario = new List<Funcionario>();

        public TelaFuncionario()
        {
            InitializeComponent();
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario a = new Funcionario();
                a.Nome = tb_nome.Text;
                a.Email = tb_email.Text;
                a.Senha = tb_senha.Text;
                a.Cpf = mtb_cpf.Text;
                a.Sexo = cb_sexo.Text;
                a.DataNascimento = dtp_nasc.Value.Date;
                a.Cargo = cb_cargo.Text;
                
                //idDoFuncionario = a.ID;

                tabelaFuncionario.Add(a);
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = tabelaFuncionario;

                SalvarExcel(dataGridView1);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
            finally
            {

            }
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_email.Clear();
            tb_senha.Clear();
            mtb_cpf.Clear();
            cb_sexo.SelectedItem = null;
            cb_cargo.SelectedItem = null;
            
        }

        private void TelaFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void button_telainicio_Click(object sender, EventArgs e)
        {
            TelaInicio telainic = new TelaInicio();
            telainic.ShowDialog();
        }

        public static void SalvarExcel(DataGridView dataGridView)
        {
            try
            {
                int linha;
                string caminhoArquivo = @"C:\Users\cti\Desktop\DadosFuncionarios\Tabela.xlsx";

                //se diferente de true
                if (!File.Exists(caminhoArquivo))
                {
                    Excel.Application app = new Excel.Application();//instanciando uma aplicacao excel
                    Excel.Workbook pasta = app.Workbooks.Add();//instanciando um Workbook --> planilha como um todo
                    Excel.Worksheet plan;//um Workbook tem varias Worksheets
                    plan = pasta.Worksheets.Add();//cria automaticamente um nome
                    plan.Name = "Funcionários";//nomeando planilha

                    //nomeando as linhas das colunas                 
                    plan.Cells[1, 1].Value = "Nome";
                    plan.Cells[1, 2].Value = "Email";
                    plan.Cells[1, 3].Value = "Senha";
                    plan.Cells[1, 4].Value = "CPF";
                    plan.Cells[1, 5].Value = "DataNascimento";
                    plan.Cells[1, 6].Value = "Sexo";
                    plan.Cells[1, 7].Value = "Cargo";

                    //começa na segunda linha pq primeira linha já contém os nomes das colunas
                    linha = 2;

                    //prcorrendo DataGridView
                    foreach (DataGridViewRow r in dataGridView.Rows)
                    {
                        plan.Cells[linha, 1].Value = r.Cells["Nome"].Value;
                        plan.Cells[linha, 2].Value = r.Cells["Email"].Value;
                        plan.Cells[linha, 3].Value = r.Cells["Senha"].Value;
                        plan.Cells[linha, 4].Value = r.Cells["CPF"].Value;
                        plan.Cells[linha, 5].Value = r.Cells["DataNascimento"].Value;
                        plan.Cells[linha, 5].NumberFormat = "dd/MM/yyyy";
                        plan.Cells[linha, 6].Value = r.Cells["Sexo"].Value;
                        plan.Cells[linha, 7].Value = r.Cells["Cargo"].Value;
                        linha++;
                    }

                    //salvando o arquivo Excel no caminho especificado
                    pasta.SaveAs(@"C:\Users\cti\Desktop\DadosFuncionarios\Tabela.xlsx");
                    pasta.Close(); //fechando pasta
                    app.Quit(); //fechando aplicação

                    MessageBox.Show($"Dados exportados com sucesso!");

                   
                }
                else
                {
                    Excel.Application app = new Excel.Application();
                    Excel.Workbook pasta = app.Workbooks.Open(caminhoArquivo); //abrindo a pasta existente
                    Excel.Worksheet plan = pasta.Worksheets["Funcionários"]; //acessando a planilha "Funcionários" diretamente

                    int ultimaLinha = plan.UsedRange.Rows.Count; //encontrando a última linha ocupada                    
                    ultimaLinha++;

                    foreach (DataGridViewRow r in dataGridView.Rows)
                    {
                        plan.Cells[ultimaLinha, 1].Value = r.Cells["Nome"].Value;
                        plan.Cells[ultimaLinha, 2].Value = r.Cells["Email"].Value;
                        plan.Cells[ultimaLinha, 3].Value = r.Cells["Senha"].Value;
                        plan.Cells[ultimaLinha, 4].Value = r.Cells["CPF"].Value;
                        plan.Cells[ultimaLinha, 5].Value = r.Cells["DataNascimento"].Value;
                        plan.Cells[ultimaLinha, 5].NumberFormat = "dd/MM/yyyy";
                        plan.Cells[ultimaLinha, 6].Value = r.Cells["Sexo"].Value;
                        plan.Cells[ultimaLinha, 7].Value = r.Cells["Cargo"].Value;
                        ultimaLinha++;
                    }

                    pasta.Save(); //salva as alterações na planilha
                    pasta.Close(); //fecha a pasta
                    app.Quit(); //fecha o aplicação Excel

                    MessageBox.Show($"Dados exportados com sucesso para sua planilha!");

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao exportar para o Excel: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}