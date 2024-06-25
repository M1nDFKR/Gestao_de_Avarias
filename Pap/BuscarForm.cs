using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pap
{
    public partial class BuscarForm : Form
    {
        public BuscarForm()
        {
            InitializeComponent();

            lstDados.View = View.Details;
            lstDados.LabelEdit = true;
            lstDados.AllowColumnReorder = true;
            lstDados.FullRowSelect = true;
            lstDados.GridLines = true;

            // Adiciona colunas ao ListView
            lstDados.Columns.Add("NIF", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("Nome_Utilizador", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("Processo", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("NIFEE", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("NomeEE", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("EmailEE", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("Parentesco", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("Tipo", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("Data de Inserção", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("NSA", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("TipoEquip", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("N-S", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("DtQueixa", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("Descricao", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("Decisao", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("DtEntrada_EquipRecebido", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("TipoEquip_EquipRecebido", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("Ref_Quei_Empr", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("DtContact", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("HrContacto", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("Forma", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("Resumo_Contacto", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("InfoContacto", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("NSA-Empresa", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("Referencia", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("DtEnvio", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("NSA_Transp", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("DtOrcamento", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("Comunicado", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("FormaCom", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("Resumo_Orcamento", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("Resposta", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("DtResposta", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("Pago", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("DtPagamento", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("DtDevolucao", 40, HorizontalAlignment.Left);
            lstDados.Columns.Add("DtEntrega", 40, HorizontalAlignment.Left);

        }

        private void BuscarForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_NIF_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarNIF buscarNIF = new BuscarNIF();
                buscarNIF.txt_buscar = txtBuscaNIF.Text;

                buscarNIF.lst_dados = lstDados;

                if (!buscarNIF.BuscarNaBD())
                {
                    MessageBox.Show("Nenhum dado foi encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao executar a busca:" + ex.Message);
            }
        }

        private void btnBuscar_Nome_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarNome buscarNome = new BuscarNome();
                buscarNome.txt_buscar = txtBuscaNome.Text;

                buscarNome.lst_dados = lstDados;

                if (!buscarNome.BuscarNaBD())
                {
                    MessageBox.Show("Nenhum dado foi encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao executar a busca:" + ex.Message);
            }
        }

        private void btnPage_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscaNIF.Text.Equals("") && txtBuscaNome.Text.Equals(""))
                {
                    Form1 form1 = new Form1();
                    form1.Show();
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBuscaNIF.Clear();
            txtBuscaNome.Clear();
            txtBuscaNIF.Focus();
        }

        private void btnPageQueixa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscaNIF.Text.Equals("") && txtBuscaNome.Text.Equals(""))
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

        private void btnPageHome_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscaNIF.Text.Equals("") && txtBuscaNome.Text.Equals(""))
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
                MessageBox.Show("Não foi possível ir para a próxima página: " + ex.Message);
            }
        }

        private void btnPageEquipamentos_Click(object sender, EventArgs e)
        {
            EquipRecebido equipamentorecebido = new EquipRecebido();
            equipamentorecebido.Show();
            this.Hide();
        }

        private void btn_Contato_Click(object sender, EventArgs e)
        {
            ContatoForm contatoForm = new ContatoForm();
            contatoForm.Show();
            this.Hide();
        }
    }
}
