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

            cb_Tipo.SelectedIndex = 0;

            cb_ListaParentesco.DropDownStyle = ComboBoxStyle.DropDownList;

            cb_ListaParentesco.Items.AddRange(new string[]
        {
            "Sem Parentesco",
            "Mãe",
            "Pai",
            "Avó",
            "Avô",
            "Tio",
            "Tia",
            "Outro"
        });
            cb_ListaParentesco.SelectedIndex = 0;

            rb_Sim.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rb_Nao.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Sim.Checked)
            {
                cb_ListaParentesco.SelectedIndex = 0;
                cb_ListaParentesco.Enabled = false;
            }
            else if (rb_Nao.Checked)
            {
                cb_ListaParentesco.Enabled = true;
            }
        }

        public enum tipo_Parentesco
        {
            [Description("Aluno")]
            Aluno,
            [Description("Professor")]
            Professor,
            [Description("Não Docente")]
            NaoDocente
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

                if (rb_Nao.Checked == true)
                {
                    if (maskedTextNIF.Text == maskedTextNIFEE.Text)
                    {
                        MessageBox.Show("O NIF e o NIFEE do responsável não podem ser iguais.");
                        return;
                    }
                }

                if (rb_Sim.Checked == true)
                {
                    if (maskedTextNIF.Text != maskedTextNIFEE.Text)
                    {
                        MessageBox.Show("O NIF e o NIFEE do responsável têm de ser iguais.");
                        return;
                    }
                }

                bool encarregadoDeEducacao = rb_Sim.Checked || rb_Nao.Checked;

                bool todosOsCamposPreenchidos = !maskedTextNIF.Text.Equals("") &&
                                !textNome.Text.Equals("") &&
                                !textProcesso.Text.Equals("") &&
                                !maskedTextNIFEE.Text.Equals("") &&
                                !textNomeEE.Text.Equals("");


                if (todosOsCamposPreenchidos && encarregadoDeEducacao)
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

                    if (rb_Sim.Checked == true)
                    {
                        inResponsavel.Parentesco = cb_ListaParentesco.SelectedItem.ToString();
                    }
                    else if (rb_Nao.Checked == true)
                    {
                        inResponsavel.Parentesco = cb_ListaParentesco.SelectedItem.ToString();
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
                        MessageBox.Show($" O(A) utilizador(a) {inResponsavel.Nome} responsável pela avaria foi registrada com sucesso.");
                        rb_Sim.Checked = false;
                        rb_Nao.Checked = false;
                        maskedTextNIF.Clear();
                        textNome.Clear();
                        textProcesso.Clear();
                        maskedTextNIFEE.Clear();
                        textNomeEE.Clear();
                        textEmailEE.Clear();
                        maskedTextNIF.Focus();
                        cb_ListaParentesco.Enabled = true;
                        cb_ListaParentesco.SelectedIndex = 0;
                        cb_Tipo.Enabled = true;
                        cb_Tipo.SelectedIndex = 0;

                        // Passando NIF e Nome para o QueixaForm
                        QueixaForm queixaForm = new QueixaForm(inResponsavel.NIF, inResponsavel.Nome);
                        queixaForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel regista utilizador da avaria.");
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
                    cb_ListaParentesco.SelectedIndex = 0;
                    cb_Tipo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro ao resgista utilizador(a) da avaria: " + ex.Message);
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
            cb_ListaParentesco.Enabled = true;
            cb_ListaParentesco.SelectedIndex = 0;
            cb_Tipo.Enabled = true;
            cb_Tipo.SelectedIndex = 0;
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
                    MessageBox.Show("Limpar todos os campos antes de mudar de página.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível ir para a página de Queixa: " + ex.Message);
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
                    MessageBox.Show("Limpar todos os campos antes de mudar de página.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível ir para a página de Busca: " + ex.Message);
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
                    MessageBox.Show("Limpar todos os campos antes de mudar de página.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível ir para a página de Inicial: " + ex.Message);
            }
        }

        private void btnPageEquipamentos_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextNIF.Text.Equals("") && textNome.Text.Equals("") && textProcesso.Text.Equals("") && maskedTextNIFEE.Text.Equals("") && textNomeEE.Text.Equals("") && textEmailEE.Text.Equals(""))
                {
                    EquipRecebido equipamentorecebido = new EquipRecebido();
                    equipamentorecebido.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Limpar todos os campos antes de mudar de página.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível ir para a página de Equipamentos: " + ex.Message);
            }
        }

        private void btn_Contato_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextNIF.Text.Equals("") && textNome.Text.Equals("") && textProcesso.Text.Equals("") && maskedTextNIFEE.Text.Equals("") && textNomeEE.Text.Equals("") && textEmailEE.Text.Equals(""))
                {
                    ContatoForm contatoForm = new ContatoForm();
                    contatoForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Limpar todos os campos antes de mudar de página.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível ir para a página de Contacto: " + ex.Message);
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
