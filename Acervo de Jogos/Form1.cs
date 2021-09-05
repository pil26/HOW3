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

namespace Acervo_de_Jogos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "acervo jogos";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
        
            {
            tbNome.Clear();
            tbCategoria.Clear();
            tbPlataforma.Clear();
            tbMidia.Clear();
            tbCondic.Clear();
            tbValor.Clear();
            tbData.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }
        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaocomBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaocomBD.Open();

                MySqlCommand comandoMySql = realizaConexaocomBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM jogos";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgAcervo.Rows.Clear();

                while (reader.Read()) 
                {
                    DataGridViewRow row = (DataGridViewRow)dgAcervo.Rows[0].Clone();//REPLICA AS LINHAS DA TABELA PRA BAIXO
                    row.Cells[0].Value = reader.GetInt32(0);//CODIGO
                    row.Cells[1].Value = reader.GetString(1);//NOME DO JOGO
                    row.Cells[2].Value = reader.GetString(2);//CATEGORIA
                    row.Cells[3].Value = reader.GetString(3);//PLATAFORMA
                    row.Cells[4].Value = reader.GetString(4);//TIPO DA MIDIA
                    row.Cells[5].Value = reader.GetString(5);//VALOR
                    row.Cells[6].Value = reader.GetString(6);//CONDIÇÃO
                    row.Cells[7].Value = reader.GetDateTime(7).ToString("dd/MM/yyyy"); //DATA DA COMPRA
                    
                    dgAcervo.Rows.Add(row);
                }
                realizaConexaocomBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na conexão com o banco de dados ! ");
                Console.WriteLine(ex.Message);
            }
       }

        private void btInserir_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacomBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacomBD.Open();

                MySqlCommand comandoMySql = realizaConexacomBD.CreateCommand();

                comandoMySql.CommandText = "INSERT INTO jogos (NomeJogo,CategoriaJogo,PlataformaJogo,Midia,ValorJogo,CondicaoJogo,DataCompra)" +
                    "VALUES('" + tbNome.Text + "', '" + tbCategoria.Text + "', '" + tbPlataforma.Text + "', '" + tbMidia.Text + "', '" + tbValor.Text + "', '" + tbCondic.Text + "', '" + tbData.Text + "');";             

                comandoMySql.ExecuteNonQuery();
                realizaConexacomBD.Close();
                MessageBox.Show("Jogo adicionado com sucesso ! ");
                atualizarGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
        }
    }
}
