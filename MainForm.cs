using System;
using System.Data;
using System.Windows.Forms;

namespace SeuNamespace
{
    public partial class MainForm : Form
    {
        // Declaração da conexão
        private SQLiteConnection connection;

        public MainForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void InitializeDatabaseConnection()
        {
            // Inicializa a conexão com o banco de dados SQLite
            string connectionString = "Caminho";
            connection = new SQLiteConnection(connectionString);

            // Abre a conexão com o banco de dados
            try
            {
                connection.Open();
                MessageBox.Show("Conexão com o banco de dados estabelecida com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Coloque aqui o código que deseja executar quando o formulário é carregado
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Fecha a conexão com o banco de dados quando o formulário é fechado
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void CadastroDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedoresForm cadastroForm = new CadastroFornecedoresForm();
            cadastroForm.Show();
        }
    }
}
