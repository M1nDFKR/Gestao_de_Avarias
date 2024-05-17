using MySql.Data.MySqlClient;

namespace Pap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextNIF.Text.Replace(maskedTextNIF.PromptChar.ToString(), "").Length != 9)
                {
                    MessageBox.Show("O NIF deve conter exatamente 9 números.");
                    return;
                }
                if (maskedTextNIFEE.Text.Replace(maskedTextNIFEE.PromptChar.ToString(), "").Length != 9)
                {
                    MessageBox.Show("O NIFEE deve conter exatamente 9 números.");
                    return;
                }

                if (!maskedTextNIF.Text.Equals("") && !textNome.Text.Equals("") && !textProcesso.Text.Equals("") && !maskedTextNIFEE.Text.Equals("") && !textNomeEE.Text.Equals(""))
                {
                    Inserir inResponsavel = new Inserir();
                    inResponsavel.NIF = maskedTextNIF.Text;
                    inResponsavel.Nome = textNome.Text;

                    // converter o texto do TextBox para int
                    if (int.TryParse(textProcesso.Text, out int numeroProcesso))
                    {
                        inResponsavel.Processo = numeroProcesso;
                    }
                    else
                    {
                        // Lidar com o caso em que o texto não é um número válido
                        MessageBox.Show("Por favor, insira um número de processo válido.");
                    }

                    inResponsavel.NIFEE = maskedTextNIFEE.Text;
                    inResponsavel.NomeEE = textNomeEE.Text;
                    inResponsavel.EmailEE = textEmailEE.Text;

                    if (inResponsavel.inserirResponsavel())
                    {
                        MessageBox.Show($" O(A) utilizador(a) {inResponsavel.Nome} responsável pela avaria foi registrada com sucesso.");
                        maskedTextNIF.Clear();
                        textNome.Clear();
                        textProcesso.Clear();
                        maskedTextNIFEE.Clear();
                        textNomeEE.Clear();
                        textEmailEE.Clear();
                        maskedTextNIF.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel regista utilizador da avaria.");
                    }
                }
                else
                {
                    MessageBox.Show(" Preencher todos os campos antes de inserir.");
                    maskedTextNIF.Clear();
                    textNome.Clear();
                    textProcesso.Clear();
                    maskedTextNIFEE.Clear();
                    textNomeEE.Clear();
                    textEmailEE.Clear();
                    maskedTextNIF.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro ao resgista utilizador(a) da avaria: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            maskedTextNIF.Clear();
            textNome.Clear();
            textProcesso.Clear();
            maskedTextNIFEE.Clear();
            textNomeEE.Clear();
            textEmailEE.Clear();
            maskedTextNIF.Focus();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextNIF.Text.Equals("") && textNome.Text.Equals("") && textProcesso.Text.Equals("") && maskedTextNIFEE.Text.Equals("") && textNomeEE.Text.Equals("") && textEmailEE.Text.Equals(""))
                {
                    QueixaForm queixaForm = new QueixaForm();
                    queixaForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Limpar todos os campos antes de mudar de página.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível ir para a próxima página: " + ex.Message);
            }
        }
    }
}
