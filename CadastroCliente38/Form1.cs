using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CadastroCliente38
{
    public partial class Form1 : Form
    {

        MySqlConnection Conexao;
        //FONTE DE DADOS - HOST - USERNAME - PASSWORD - BD
        string dataSource = "datasource=localhost,username=root,password=root,database=bd_clientes";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                //SALVAR OS DADOS DO FORMULÁRIO
                string nome = txtNome.Text;
                string cpf = mskCpf.Text;
                string endereco = txtEndereco.Text;
                string bairro = txtBairro.Text;
                string numero = txtNumero.Text;
                string estado = cmbEstado.Text;
                string celular = mskCelular.Text;
                string email = txtEmail.Text;

                //CRIAR UM OBJETO DO TIPO MYSQLCONNECTION
                //CONFIGURAÇÃO DA FONTE DE DADOS PARA A CONEXÃO

                Conexao = new MySqlConnection(dataSource);



                //CRIAR UMA STRING PARA RECEBER UM INSERT
                string sql = $"INSERT INTO Clientes (nome, cpf, endereco, bairro, numero, estado, celular, email)" +
                    $"VALUES ('{txtNome.Text}'," +
                    $"'{mskCpf.Text}     '," +
                    $"'{txtEndereco.Text}'," +
                    $"'{txtBairro.Text}  '," +
                    $"'{txtNumero.Text}  '," +
                    $"'{cmbEstado.Text}  '," +
                    $"'{mskCelular.Text} '," +
                    $"'{txtEmail.Text}   ')";

                //CONFIGURAR - CRIAR O COMANDO PARA EXECUTAR A INSTRUÇÃO SQL
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                //ABRIR O CONEXÃO COM O BANCO DE DADOS
                Conexao.Open();

                //EXECUTAR O CÓDIGO SQL
                comando.ExecuteReader();

                MessageBox.Show("Comando executado com sucesso!. Os dados foram armazenados.");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Deu pepino! Dê os seus pulos para resolver! Se vira!");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //FECHANDO A CONEXAO COM O BANCO
                Conexao.Close();
            }
        }
    }
}
