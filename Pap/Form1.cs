using MySql.Data.MySqlClient;

namespace Pap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;pwd=292822;database=gestao_de_avaria";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                MessageBox.Show("Conexão OK");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao conectar a DB: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Hello {textBox1.Text} {textBox2.Text}");
        }
    }
}
