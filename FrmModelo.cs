using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Projeto_Locadora_Finalizado
{
    public partial class FrmModelo : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;

        public FrmModelo()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string desc;
                // int id;

                desc = txtDesc.Text;

                string sql_insert = @"insert into tb_modelo
                                 (
                                    TB_MODELO_DESC
                                 )
                                   values
                                 (
                                    @MODELO_DESC
                                 )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@MODELO_DESC", desc);
                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();

                string sql_select_modelo = @"select tb_modelo.TB_MODELO_ID as 'ID DO MODELO',
                                             tb_modelo.TB_MODELO_DESC as 'DESCRIÇÃO',
                                             tb_modelo.TB_MODELO_STATUS as 'STATUS'
                                             from tb_modelo
                                             where TB_MODELO_STATUS = 'ATIVO'";

                MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
                executacmdMySql_select_modelo.ExecuteNonQuery();

                DataTable tabela_modelo = new DataTable();

                MySqlDataAdapter da_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
                da_modelo.Fill(tabela_modelo);

                con.Close();
                MessageBox.Show("Cadastrado com sucesso!");

                txtId.Clear();
                txtDesc.Clear();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void FrmModelo_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_modelo = @"select tb_modelo.TB_MODELO_ID as 'ID DO MODELO',
                                             tb_modelo.TB_MODELO_DESC as 'DESCRIÇÃO',
                                             tb_modelo.TB_MODELO_STATUS as 'STATUS'
                                             from tb_modelo
                                             where TB_MODELO_STATUS = 'ATIVO'";

            MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
            executacmdMySql_select_modelo.ExecuteNonQuery();

            DataTable tabela_modelo = new DataTable();

            MySqlDataAdapter da_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
            da_modelo.Fill(tabela_modelo);

            DgvListarModelos.DataSource = tabela_modelo;
            con.Close();
        }

        private void BtnInativos_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_modelo = @"select tb_modelo.TB_MODELO_ID as 'ID DO MODELO',
                                             tb_modelo.TB_MODELO_DESC as 'DESCRIÇÃO',
                                             tb_modelo.TB_MODELO_STATUS as 'STATUS'
                                             from tb_modelo
                                             where TB_MODELO_STATUS = 'INATIVO'";

            MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
            executacmdMySql_select_modelo.ExecuteNonQuery();

            DataTable tabela_modelo_status = new DataTable();

            DgvListarModelos.DataSource = tabela_modelo_status;

            MySqlDataAdapter da_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
            da_modelo.Fill(tabela_modelo_status);

            con.Close();
        }

        private void BtnAtualizar_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string desc, status;
                int id;

                desc = txtDesc.Text;
                id = int.Parse(txtId.Text);
                status = CmbStatus.Text;


                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_modelo = @"update tb_modelo
                                set TB_MODELO_DESC = @MODELO_DESC,
                                    TB_MODELO_STATUS = @MODELO_STATUS
                                where TB_MODELO_ID = @MODELO_ID";

                MySqlCommand executacmdMySql_update_modelo = new MySqlCommand(sql_update_modelo, con);

                executacmdMySql_update_modelo.Parameters.AddWithValue("@MODELO_ID", id);
                executacmdMySql_update_modelo.Parameters.AddWithValue("@MODELO_DESC", desc);
                executacmdMySql_update_modelo.Parameters.AddWithValue("@MODELO_STATUS", status);
                executacmdMySql_update_modelo.ExecuteNonQuery();

                string sql_select_modelo = @"select tb_modelo.TB_MODELO_ID as 'ID DO MODELO',
                                             tb_modelo.TB_MODELO_DESC as 'DESCRIÇÃO',
                                             tb_modelo.TB_MODELO_STATUS as 'STATUS'
                                             from tb_modelo
                                             where TB_MODELO_STATUS = 'ATIVO'";

                MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
                executacmdMySql_select_modelo.ExecuteNonQuery();

                DataTable tabela_modelo = new DataTable();

                MySqlDataAdapter da_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
                da_modelo.Fill(tabela_modelo);

                DgvListarModelos.DataSource = tabela_modelo;
                //con.Close();
                //con.Close()


                MessageBox.Show("Registro Atualizado!");

                con.Close();

                txtId.Clear();
                txtDesc.Clear();
                CmbStatus.Text = string.Empty;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void DgvListarModelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = DgvListarModelos.CurrentRow.Cells[0].Value.ToString();
            txtDesc.Text = DgvListarModelos.CurrentRow.Cells[1].Value.ToString();
            CmbStatus.Text = DgvListarModelos.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnAtivos_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_modelo = @"select tb_modelo.TB_MODELO_ID as 'ID DO MODELO',
                                         tb_modelo.TB_MODELO_DESC as 'DESCRIÇÃO',
                                         tb_modelo.TB_MODELO_STATUS as 'STATUS'
                                         from tb_modelo
                                         where TB_MODELO_STATUS = 'ATIVO'";

            MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
            executacmdMySql_select_modelo.ExecuteNonQuery();

            DataTable tabela_modelo = new DataTable();

            MySqlDataAdapter da_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
            da_modelo.Fill(tabela_modelo);

            DgvListarModelos.DataSource = tabela_modelo;
            con.Close();
        }

        private void PcbVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FrmAutomovel FrmAutomovel = new FrmAutomovel();
        }
    }
}
