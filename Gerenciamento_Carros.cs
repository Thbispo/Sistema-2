using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sitema2
{
    public partial class Gerenciamento_Carros : Form
    {
        public Gerenciamento_Carros()
        {
            InitializeComponent();
        }

        private void button_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_pesquisarCliente_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost; Port=3306; Database=bd_sistema; Uid=root; Pwd=;";

            try
            {

                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    consulta.Open();

                    string listagem = "SELECT Id_carros, Proprietario, Ano, Modelo FROM tb_carros";

                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {

                        MySqlDataReader reader = cmd.ExecuteReader();

                        DataTable dadosCarros = new DataTable();
                        dadosCarros.Load(reader);

                        dgvCarros.DataSource = dadosCarros;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os Carros" + ex.Message);
            }
        }

        private void button_removerCliente_Click(object sender, EventArgs e)
        {
            if (dgvCarros.SelectedRows.Count > 0)
            {

                int carroID = Convert.ToInt32(dgvCarros.SelectedRows[0].Cells["Id_carros"].Value);
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este carro?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=localhost; Port=3306; Database=bd_sistema; Uid=root; Pwd=;";

                    try
                    {
  
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {

                            consulta.Open();

                            string listagem = "DELETE FROM tb_carros WHERE Id_carros = @Id_carros";


                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("Id_carros", carroID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Carro excluído com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o carro.");
                                }
                            }
                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma carro poara excluir");
                }

            }
        }
    }
}
