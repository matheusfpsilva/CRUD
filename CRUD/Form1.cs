using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using System.Drawing.Text;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void limparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtCPF.Clear();
            label5.Text = " ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtCPF.Text))
                {
                    MessageBox.Show("Preencha todos os campos.");
                    return;
                }

                if (txtCPF.Text.Length != 11 || !txtCPF.Text.All(char.IsDigit))
                {
                    MessageBox.Show("CPF inv�lido! Digite um CPF com 11 n�meros.");
                    return;
                }
                Aluno cadastrarAluno = new Aluno();
                cadastrarAluno.Nome = txtNome.Text;
                cadastrarAluno.Email = txtEmail.Text;
                cadastrarAluno.Cpf = txtCPF.Text;

                if (cadastrarAluno.cadastrarAluno())
                {
                    MessageBox.Show($"Aluno {cadastrarAluno.Nome}  cadastrado com sucesso!");
                    limparCampos();
                    txtNome.Focus();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                    limparCampos();
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar aluno: " + ex.Message);
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCPF.Text))
                {
                    MessageBox.Show("Preencha o campo CPF para pesquisar.");
                    txtCPF.Focus();
                    return;
                }
                Aluno aluno = new Aluno { Cpf = txtCPF.Text };
                Aluno alunoEncontrado = aluno.procurarAlunoPeloCpf();

                if (alunoEncontrado != null)
                {
                    txtNome.Text = alunoEncontrado.Nome;
                    txtEmail.Text = alunoEncontrado.Email;
                    label5.Text = alunoEncontrado.Id.ToString();
                }
                else
                {
                    MessageBox.Show("Aluno n�o encontrado.");
                    limparCampos();
                    txtCPF.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar aluno: " + ex.Message);
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtCPF.Text))
                {
                    MessageBox.Show("Preencha todos os campos.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(label5.Text))
                {
                    MessageBox.Show("Procurar o aluno antes de atualizar seus dados!");
                    return;
                }
                Aluno aluno = new Aluno
                {
                    Id = Convert.ToInt32(label5.Text),
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    Cpf = txtCPF.Text
                };
                if (aluno.atualizarAluno())
                {
                    MessageBox.Show("Aluno atualizado com sucesso!");
                    limparCampos();
                    txtNome.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar aluno.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao atualizar aluno: " + ex.Message);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text) ||
                   string.IsNullOrEmpty(txtEmail.Text) ||
                   string.IsNullOrEmpty(txtCPF.Text))
                {
                    MessageBox.Show("Preencha todos os campos.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(label5.Text))
                {
                    MessageBox.Show("Procurar o aluno antes de deletar seus dados!");
                    return;
                }
                Aluno aluno = new Aluno
                {
                    Id = Convert.ToInt32(label5.Text),
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    Cpf = txtCPF.Text
                };
                if (aluno.deletarAluno())
                {
                    MessageBox.Show("Aluno exclu�do com sucesso!");
                    limparCampos();
                    txtNome.Focus();
                    label5.Text = " ";
                }
                else
                {
                    MessageBox.Show("Erro ao deletar aluno.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("N�o foi poss�vel deletar o aluno: " + ex);
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            txtNome.Focus();
        }
    }
}
