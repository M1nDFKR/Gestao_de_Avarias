using System;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Reflection;
using System.Globalization;


namespace Pap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cb_Tipo.DropDownStyle = ComboBoxStyle.DropDownList;

            cb_Tipo.DisplayMember = "Description";
            cb_Tipo.ValueMember = "Value";
            cb_Tipo.DataSource = Enum.GetValues(typeof(tipo_Parentesco))
                             .Cast<Enum>()
                             .Select(e => e.GetEnumDescription())
                             .ToList();

            rb_Parentesco_Sim.CheckedChanged += new EventHandler(rb_Parentesco_Sim_CheckedChanged);
            rb_Parentesco_Nao.CheckedChanged += new EventHandler(rb_Parentesco_Nao_CheckedChanged);

        }

        public enum tipo_Parentesco
        {
            [Description("Sem parentesco")]
            Semparentesco,
            [Description("Aluno")]
            Aluno,
            [Description("Professor")]
            Professor,
            [Description("N�o Docente")]
            NaoDocente
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextNIF.Text.Replace(maskedTextNIF.PromptChar.ToString(), "").Length != 9)
                {
                    MessageBox.Show("O NIF deve conter exatamente 9 n�meros.");
                    return;
                }
                if (maskedTextNIFEE.Text.Replace(maskedTextNIFEE.PromptChar.ToString(), "").Length != 9)
                {
                    MessageBox.Show("O NIFEE deve conter exatamente 9 n�meros.");
                    return;
                }

                if (rb_Nao.Checked == true)
                {
                    if (maskedTextNIF.Text == maskedTextNIFEE.Text)
                    {
                        MessageBox.Show("O NIF e o NIFEE do respons�vel n�o podem ser iguais.");
                        return;
                    }
                }

                if (rb_Sim.Checked == true)
                {
                    if (maskedTextNIF.Text != maskedTextNIFEE.Text)
                    {
                        MessageBox.Show("O NIF e o NIFEE do respons�vel t�m de ser iguais.");
                        return;
                    }
                }

                bool encarregadoDeEducacao = rb_Sim.Checked || rb_Nao.Checked;

                bool todosOsCamposPreenchidos = !maskedTextNIF.Text.Equals("") &&
                                !textNome.Text.Equals("") &&
                                !textProcesso.Text.Equals("") &&
                                !maskedTextNIFEE.Text.Equals("") &&
                                !textNomeEE.Text.Equals("");

                bool parentescoSelecionado = rb_Parentesco_Sim.Checked || rb_Parentesco_Nao.Checked;

                if (todosOsCamposPreenchidos && parentescoSelecionado && encarregadoDeEducacao)
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
                        // Lidar com o caso em que o texto n�o � um n�mero v�lido
                        MessageBox.Show("Por favor, insira um n�mero de processo v�lido.");
                    }

                    inResponsavel.NIFEE = maskedTextNIFEE.Text;
                    inResponsavel.NomeEE = textNomeEE.Text;
                    inResponsavel.EmailEE = textEmailEE.Text;

                    if (rb_Parentesco_Sim.Checked)
                    {
                        inResponsavel.Parentesco = "Sim";
                    }
                    else if (rb_Parentesco_Nao.Checked)
                    {
                        inResponsavel.Parentesco = "N�o";
                    }

                    inResponsavel.Tipo = cb_Tipo.SelectedItem.ToString();

                    DateTime dataAtual = DateTime.Now.Date;
                    CultureInfo culture = CultureInfo.InvariantCulture;
                    string dataFormatoMySQL = dataAtual.ToString("yyyy-MM-dd", culture);

                    if (DateTime.TryParseExact(dataFormatoMySQL, "yyyy-MM-dd", culture, DateTimeStyles.None, out DateTime dataInsercao))
                    {
                        inResponsavel.DataInsercao = dataInsercao;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao converter data.");
                    }



                    if (inResponsavel.inserirResponsavel())
                    {
                        MessageBox.Show($" O(A) utilizador(a) {inResponsavel.Nome} respons�vel pela avaria foi registrada com sucesso.");
                        rb_Sim.Checked = false;
                        rb_Nao.Checked = false;
                        maskedTextNIF.Clear();
                        textNome.Clear();
                        textProcesso.Clear();
                        maskedTextNIFEE.Clear();
                        textNomeEE.Clear();
                        textEmailEE.Clear();
                        maskedTextNIF.Focus();
                        rb_Parentesco_Sim.Checked = false;
                        rb_Parentesco_Nao.Checked = false;
                        cb_Tipo.Enabled = true;
                        cb_Tipo.SelectedIndex = 0;

                        // Passando NIF e Nome para o QueixaForm
                        QueixaForm queixaForm = new QueixaForm(inResponsavel.NIF, inResponsavel.Nome);
                        queixaForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("N�o foi possivel regista utilizador da avaria.");
                    }
                }
                else
                {
                    MessageBox.Show(" Preencher todos os campos antes de inserir.");
                    rb_Sim.Checked = false;
                    rb_Nao.Checked = false;
                    maskedTextNIF.Clear();
                    textNome.Clear();
                    textProcesso.Clear();
                    maskedTextNIFEE.Clear();
                    textNomeEE.Clear();
                    textEmailEE.Clear();
                    maskedTextNIF.Focus();
                    rb_Parentesco_Sim.Checked = false;
                    rb_Parentesco_Nao.Checked = false;
                    cb_Tipo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro ao resgista utilizador(a) da avaria: " + ex.Message);
            }
        }

        private void rb_Parentesco_Sim_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Parentesco_Sim.Checked)
            {
                cb_Tipo.Enabled = true;
            }
        }

        private void rb_Parentesco_Nao_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Parentesco_Nao.Checked)
            {
                cb_Tipo.SelectedIndex = 0;
                cb_Tipo.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rb_Sim.Checked = false;
            rb_Nao.Checked = false;
            maskedTextNIF.Clear();
            textNome.Clear();
            textProcesso.Clear();
            maskedTextNIFEE.Clear();
            textNomeEE.Clear();
            textEmailEE.Clear();
            maskedTextNIF.Focus();
            rb_Parentesco_Sim.Checked = false;
            rb_Parentesco_Nao.Checked = false;
            cb_Tipo.Enabled = true;
            cb_Tipo.SelectedIndex = 0;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(maskedTextNIF.Text) &&
                    string.IsNullOrWhiteSpace(textNome.Text) &&
                    string.IsNullOrWhiteSpace(textProcesso.Text) &&
                    string.IsNullOrWhiteSpace(maskedTextNIFEE.Text) &&
                    string.IsNullOrWhiteSpace(textNomeEE.Text) &&
                    string.IsNullOrWhiteSpace(textEmailEE.Text))
                {
                    QueixaForm queixaForm = new QueixaForm();
                    queixaForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Limpar todos os campos antes de mudar de p�gina.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel ir para a pr�xima p�gina: " + ex.Message);
            }
        }

        private void btnPageQueixa_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Limpar todos os campos antes de mudar de p�gina.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel ir para a p�gina de busca: " + ex.Message);
            }
        }

        private void btnPageBusca_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextNIF.Text.Equals("") && textNome.Text.Equals("") && textProcesso.Text.Equals("") && maskedTextNIFEE.Text.Equals("") && textNomeEE.Text.Equals("") && textEmailEE.Text.Equals(""))
                {
                    BuscarForm buscarForm = new BuscarForm();
                    buscarForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Limpar todos os campos antes de mudar de p�gina.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel ir para a p�gina de busca: " + ex.Message);
            }
        }

        private void btnPageHome_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextNIF.Text.Equals("") && textNome.Text.Equals("") && textProcesso.Text.Equals("") && maskedTextNIFEE.Text.Equals("") && textNomeEE.Text.Equals("") && textEmailEE.Text.Equals(""))
                {
                    home Home = new home();
                    Home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Limpar todos os campos antes de mudar de p�gina.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel ir para a p�gina de busca: " + ex.Message);
            }
        }
    }
    public static class EnumExtensions
    {
        public static string GetEnumDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
