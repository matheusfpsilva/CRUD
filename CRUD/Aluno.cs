using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUD
{
    internal class Aluno
    {
        private int id;
        private string nome;
        private string email;
        private string cpf;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }

        public bool cadastrarAluno()
        {
            try
            {
                using (MySqlConnection MySqlConexao = new MySqlConnection(ConexaoBanco.conexaoBanco))
                {
                    MySqlConexao.Open();
                    string insert = "INSERT INTO Alunos (nome, email, cpf) VALUES (@Nome, @Email, @Cpf)";
                    using (MySqlCommand comando = new MySqlCommand(insert, MySqlConexao))
                    {
                        comando.Parameters.AddWithValue("@Nome", Nome);
                        comando.Parameters.AddWithValue("@Email", Email);
                        comando.Parameters.AddWithValue("@Cpf", Cpf);
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar aluno: " + ex.Message);
                return false;
            }
        }
        public Aluno procurarAlunoPeloCpf()
        {
            Aluno aluno = null;
            try
            {
                using (MySqlConnection MySqlConexao = new MySqlConnection(ConexaoBanco.conexaoBanco))
                {
                    MySqlConexao.Open();
                    string select = "SELECT id_aluno, nome, cpf, email FROM Alunos WHERE cpf = @Cpf";

                    using (MySqlCommand comando = new MySqlCommand(select, MySqlConexao))
                    {
                        comando.Parameters.AddWithValue("@Cpf", Cpf);

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader != null && reader.Read())
                            {
                                aluno = new Aluno
                                {
                                    Id = Convert.ToInt32(reader["id_aluno"]),
                                    Nome = reader["nome"].ToString(),
                                    Email = reader["email"].ToString(),
                                    Cpf = reader["cpf"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar aluno: " + ex.Message);
            }
            return aluno;
        }
        public bool atualizarAluno()
        {
            try
            {
                using (MySqlConnection MySqlConexao = new MySqlConnection(ConexaoBanco.conexaoBanco))
                {
                    MySqlConexao.Open();
                    string update = "UPDATE Alunos SET nome = @Nome, email = @Email WHERE id_aluno = @Id";
                    using (MySqlCommand comando = new MySqlCommand(update, MySqlConexao))
                    {
                        comando.Parameters.AddWithValue("@Nome", Nome);
                        comando.Parameters.AddWithValue("@Email", Email);
                        comando.Parameters.AddWithValue("@Id", Id);
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar aluno: " + ex.Message);
                return false;
            }
        }
        public bool deletarAluno()
        {
            try
            {
                using (MySqlConnection MySqlConexao = new MySqlConnection(ConexaoBanco.conexaoBanco))
                {
                    MySqlConexao.Open();
                    string delete = "DELETE FROM Alunos WHERE id_aluno = @Id";
                    using (MySqlCommand comando = new MySqlCommand(delete, MySqlConexao))
                    {
                        comando.Parameters.AddWithValue("@Id", Id);
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar aluno: " + ex.Message);
                return false;
            }
        }
    }
}
