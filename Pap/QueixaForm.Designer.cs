namespace Pap
{
    partial class QueixaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textNome = new TextBox();
            textNIF = new TextBox();
            Nome = new Label();
            NIF = new Label();
            ContinuarQueixa = new Label();
            EscolherCliente = new Label();
            cb_listaClientes = new ComboBox();
            Clientes = new Label();
            btn_Limpar = new Button();
            btn_Inserir = new Button();
            TipoEquip = new Label();
            N_S = new Label();
            DtQueixa = new Label();
            Descricao = new Label();
            Decisao = new Label();
            textTipoEquip = new TextBox();
            textN_S = new TextBox();
            dateQueixa = new DateTimePicker();
            richTextDescricao = new RichTextBox();
            richTextDecisao = new RichTextBox();
            panel1 = new Panel();
            btn_Contato = new Button();
            btnPageEquipamentos = new Button();
            textBox1 = new TextBox();
            btnPageBusca = new Button();
            btnPageInsercao = new Button();
            btnPageHome = new Button();
            lstDados = new ListView();
            txt_Buscar = new TextBox();
            Pesquisar = new TextBox();
            btn_Limpar_Pesquisa = new Button();
            btn_Pesquisar = new Button();
            btn_Envio = new Button();
            btn_Orcamento = new Button();
            btn_Devolucao = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Location = new Point(60, 136);
            textNome.Name = "textNome";
            textNome.ReadOnly = true;
            textNome.Size = new Size(136, 23);
            textNome.TabIndex = 1;
            // 
            // textNIF
            // 
            textNIF.Location = new Point(298, 136);
            textNIF.Name = "textNIF";
            textNIF.ReadOnly = true;
            textNIF.Size = new Size(136, 23);
            textNIF.TabIndex = 2;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nome.Location = new Point(16, 139);
            Nome.Name = "Nome";
            Nome.Size = new Size(42, 15);
            Nome.TabIndex = 0;
            Nome.Text = "Nome:";
            // 
            // NIF
            // 
            NIF.AutoSize = true;
            NIF.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NIF.Location = new Point(257, 139);
            NIF.Name = "NIF";
            NIF.Size = new Size(35, 15);
            NIF.TabIndex = 0;
            NIF.Text = "NIF:";
            // 
            // ContinuarQueixa
            // 
            ContinuarQueixa.AutoSize = true;
            ContinuarQueixa.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContinuarQueixa.Location = new Point(16, 100);
            ContinuarQueixa.Name = "ContinuarQueixa";
            ContinuarQueixa.Size = new Size(242, 23);
            ContinuarQueixa.TabIndex = 0;
            ContinuarQueixa.Text = "Continuar Queixa do Cliente.:";
            // 
            // EscolherCliente
            // 
            EscolherCliente.AutoSize = true;
            EscolherCliente.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EscolherCliente.Location = new Point(16, 184);
            EscolherCliente.Name = "EscolherCliente";
            EscolherCliente.Size = new Size(291, 23);
            EscolherCliente.TabIndex = 0;
            EscolherCliente.Text = "Inserir Queixa do cliente desejado.:";
            // 
            // cb_listaClientes
            // 
            cb_listaClientes.FormattingEnabled = true;
            cb_listaClientes.Items.AddRange(new object[] { "Selecione um Cliente" });
            cb_listaClientes.Location = new Point(86, 222);
            cb_listaClientes.Name = "cb_listaClientes";
            cb_listaClientes.Size = new Size(366, 23);
            cb_listaClientes.TabIndex = 3;
            // 
            // Clientes
            // 
            Clientes.AutoSize = true;
            Clientes.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clientes.Location = new Point(10, 225);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(70, 15);
            Clientes.TabIndex = 0;
            Clientes.Text = "Clientes:";
            // 
            // btn_Limpar
            // 
            btn_Limpar.BackColor = Color.RoyalBlue;
            btn_Limpar.FlatStyle = FlatStyle.Flat;
            btn_Limpar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Limpar.ForeColor = Color.White;
            btn_Limpar.Location = new Point(284, 592);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(168, 34);
            btn_Limpar.TabIndex = 10;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = false;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // btn_Inserir
            // 
            btn_Inserir.BackColor = Color.RoyalBlue;
            btn_Inserir.FlatStyle = FlatStyle.Flat;
            btn_Inserir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Inserir.ForeColor = Color.White;
            btn_Inserir.Location = new Point(64, 592);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(168, 34);
            btn_Inserir.TabIndex = 9;
            btn_Inserir.Text = "Inserir";
            btn_Inserir.UseVisualStyleBackColor = false;
            btn_Inserir.Click += btn_Inserir_Click;
            // 
            // TipoEquip
            // 
            TipoEquip.AutoSize = true;
            TipoEquip.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TipoEquip.Location = new Point(7, 261);
            TipoEquip.Name = "TipoEquip";
            TipoEquip.Size = new Size(147, 15);
            TipoEquip.TabIndex = 0;
            TipoEquip.Text = "Tipo de Equipamento:";
            // 
            // N_S
            // 
            N_S.AutoSize = true;
            N_S.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            N_S.Location = new Point(10, 296);
            N_S.Name = "N_S";
            N_S.Size = new Size(35, 15);
            N_S.TabIndex = 0;
            N_S.Text = "N-S:";
            // 
            // DtQueixa
            // 
            DtQueixa.AutoSize = true;
            DtQueixa.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DtQueixa.Location = new Point(7, 339);
            DtQueixa.Name = "DtQueixa";
            DtQueixa.Size = new Size(112, 15);
            DtQueixa.TabIndex = 0;
            DtQueixa.Text = "Data da Queixa:";
            // 
            // Descricao
            // 
            Descricao.AutoSize = true;
            Descricao.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Descricao.Location = new Point(3, 370);
            Descricao.Name = "Descricao";
            Descricao.Size = new Size(77, 15);
            Descricao.TabIndex = 0;
            Descricao.Text = "Descrição:";
            // 
            // Decisao
            // 
            Decisao.AutoSize = true;
            Decisao.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Decisao.Location = new Point(7, 462);
            Decisao.Name = "Decisao";
            Decisao.Size = new Size(63, 15);
            Decisao.TabIndex = 0;
            Decisao.Text = "Decisão:";
            // 
            // textTipoEquip
            // 
            textTipoEquip.Location = new Point(151, 258);
            textTipoEquip.MaxLength = 255;
            textTipoEquip.Name = "textTipoEquip";
            textTipoEquip.Size = new Size(301, 23);
            textTipoEquip.TabIndex = 4;
            // 
            // textN_S
            // 
            textN_S.Location = new Point(44, 293);
            textN_S.MaxLength = 255;
            textN_S.Name = "textN_S";
            textN_S.Size = new Size(408, 23);
            textN_S.TabIndex = 5;
            // 
            // dateQueixa
            // 
            dateQueixa.Location = new Point(141, 333);
            dateQueixa.Name = "dateQueixa";
            dateQueixa.Size = new Size(176, 23);
            dateQueixa.TabIndex = 6;
            // 
            // richTextDescricao
            // 
            richTextDescricao.Location = new Point(79, 370);
            richTextDescricao.Name = "richTextDescricao";
            richTextDescricao.Size = new Size(373, 86);
            richTextDescricao.TabIndex = 7;
            richTextDescricao.Text = "";
            // 
            // richTextDecisao
            // 
            richTextDecisao.Location = new Point(79, 462);
            richTextDecisao.Name = "richTextDecisao";
            richTextDecisao.Size = new Size(373, 85);
            richTextDecisao.TabIndex = 8;
            richTextDecisao.Text = "";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btn_Devolucao);
            panel1.Controls.Add(btn_Orcamento);
            panel1.Controls.Add(btn_Envio);
            panel1.Controls.Add(btn_Contato);
            panel1.Controls.Add(btnPageEquipamentos);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnPageBusca);
            panel1.Controls.Add(btnPageInsercao);
            panel1.Controls.Add(btnPageHome);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1376, 59);
            panel1.TabIndex = 0;
            // 
            // btn_Contato
            // 
            btn_Contato.FlatStyle = FlatStyle.Flat;
            btn_Contato.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Contato.Location = new Point(683, 17);
            btn_Contato.Name = "btn_Contato";
            btn_Contato.Size = new Size(94, 32);
            btn_Contato.TabIndex = 11;
            btn_Contato.Text = "Contacto";
            btn_Contato.UseVisualStyleBackColor = true;
            btn_Contato.Click += btn_Contato_Click;
            // 
            // btnPageEquipamentos
            // 
            btnPageEquipamentos.FlatStyle = FlatStyle.Flat;
            btnPageEquipamentos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageEquipamentos.Location = new Point(783, 17);
            btnPageEquipamentos.Name = "btnPageEquipamentos";
            btnPageEquipamentos.Size = new Size(134, 32);
            btnPageEquipamentos.TabIndex = 1;
            btnPageEquipamentos.Text = "Equipamentos";
            btnPageEquipamentos.UseVisualStyleBackColor = true;
            btnPageEquipamentos.Click += btnPageEquipamentos_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.RoyalBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 33);
            textBox1.TabIndex = 0;
            textBox1.Text = "Gestão de avarias";
            // 
            // btnPageBusca
            // 
            btnPageBusca.BackColor = Color.RoyalBlue;
            btnPageBusca.BackgroundImageLayout = ImageLayout.Center;
            btnPageBusca.FlatStyle = FlatStyle.Flat;
            btnPageBusca.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageBusca.Location = new Point(1091, 17);
            btnPageBusca.Name = "btnPageBusca";
            btnPageBusca.Size = new Size(145, 32);
            btnPageBusca.TabIndex = 3;
            btnPageBusca.Text = "Página de Busca";
            btnPageBusca.UseVisualStyleBackColor = false;
            btnPageBusca.Click += btnPageBusca_Click;
            // 
            // btnPageInsercao
            // 
            btnPageInsercao.FlatStyle = FlatStyle.Flat;
            btnPageInsercao.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageInsercao.Location = new Point(923, 17);
            btnPageInsercao.Name = "btnPageInsercao";
            btnPageInsercao.Size = new Size(162, 32);
            btnPageInsercao.TabIndex = 2;
            btnPageInsercao.Text = "Página de inserção";
            btnPageInsercao.UseVisualStyleBackColor = true;
            btnPageInsercao.Click += btnPageInsercao_Click;
            // 
            // btnPageHome
            // 
            btnPageHome.BackColor = Color.RoyalBlue;
            btnPageHome.BackgroundImageLayout = ImageLayout.Center;
            btnPageHome.FlatStyle = FlatStyle.Flat;
            btnPageHome.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageHome.Location = new Point(1242, 17);
            btnPageHome.Name = "btnPageHome";
            btnPageHome.Size = new Size(118, 32);
            btnPageHome.TabIndex = 4;
            btnPageHome.Text = "Página Inicial";
            btnPageHome.UseVisualStyleBackColor = false;
            btnPageHome.Click += btnPageHome_Click;
            // 
            // lstDados
            // 
            lstDados.Location = new Point(565, 161);
            lstDados.Name = "lstDados";
            lstDados.Size = new Size(793, 576);
            lstDados.TabIndex = 11;
            lstDados.UseCompatibleStateImageBehavior = false;
            // 
            // txt_Buscar
            // 
            txt_Buscar.Location = new Point(667, 132);
            txt_Buscar.MaxLength = 255;
            txt_Buscar.Name = "txt_Buscar";
            txt_Buscar.Size = new Size(499, 23);
            txt_Buscar.TabIndex = 15;
            // 
            // Pesquisar
            // 
            Pesquisar.BackColor = SystemColors.Control;
            Pesquisar.BorderStyle = BorderStyle.None;
            Pesquisar.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pesquisar.Location = new Point(565, 130);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(100, 23);
            Pesquisar.TabIndex = 12;
            Pesquisar.Text = "Pesquisar:";
            // 
            // btn_Limpar_Pesquisa
            // 
            btn_Limpar_Pesquisa.BackColor = Color.RoyalBlue;
            btn_Limpar_Pesquisa.BackgroundImageLayout = ImageLayout.Center;
            btn_Limpar_Pesquisa.FlatStyle = FlatStyle.Popup;
            btn_Limpar_Pesquisa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Limpar_Pesquisa.ForeColor = Color.White;
            btn_Limpar_Pesquisa.Location = new Point(1276, 132);
            btn_Limpar_Pesquisa.Name = "btn_Limpar_Pesquisa";
            btn_Limpar_Pesquisa.Size = new Size(76, 23);
            btn_Limpar_Pesquisa.TabIndex = 14;
            btn_Limpar_Pesquisa.Text = "Limpar";
            btn_Limpar_Pesquisa.UseVisualStyleBackColor = false;
            btn_Limpar_Pesquisa.Click += btn_Limpar_Pesquisa_Click;
            // 
            // btn_Pesquisar
            // 
            btn_Pesquisar.BackColor = Color.RoyalBlue;
            btn_Pesquisar.BackgroundImageLayout = ImageLayout.Center;
            btn_Pesquisar.FlatStyle = FlatStyle.Popup;
            btn_Pesquisar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Pesquisar.ForeColor = Color.White;
            btn_Pesquisar.Location = new Point(1172, 132);
            btn_Pesquisar.Name = "btn_Pesquisar";
            btn_Pesquisar.Size = new Size(98, 23);
            btn_Pesquisar.TabIndex = 13;
            btn_Pesquisar.Text = "Pesquisar";
            btn_Pesquisar.UseVisualStyleBackColor = false;
            btn_Pesquisar.Click += btn_Pesquisar_Click;
            // 
            // btn_Envio
            // 
            btn_Envio.FlatStyle = FlatStyle.Flat;
            btn_Envio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Envio.Location = new Point(585, 17);
            btn_Envio.Name = "btn_Envio";
            btn_Envio.Size = new Size(92, 32);
            btn_Envio.TabIndex = 16;
            btn_Envio.Text = "Envio";
            btn_Envio.UseVisualStyleBackColor = true;
            btn_Envio.Click += btn_Envio_Click;
            // 
            // btn_Orcamento
            // 
            btn_Orcamento.FlatStyle = FlatStyle.Flat;
            btn_Orcamento.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Orcamento.Location = new Point(471, 17);
            btn_Orcamento.Name = "btn_Orcamento";
            btn_Orcamento.Size = new Size(108, 32);
            btn_Orcamento.TabIndex = 17;
            btn_Orcamento.Text = "Orçamento";
            btn_Orcamento.UseVisualStyleBackColor = true;
            btn_Orcamento.Click += btn_Orcamento_Click;
            // 
            // btn_Devolucao
            // 
            btn_Devolucao.FlatStyle = FlatStyle.Flat;
            btn_Devolucao.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Devolucao.Location = new Point(362, 17);
            btn_Devolucao.Name = "btn_Devolucao";
            btn_Devolucao.Size = new Size(103, 32);
            btn_Devolucao.TabIndex = 18;
            btn_Devolucao.Text = "Devolução";
            btn_Devolucao.UseVisualStyleBackColor = true;
            btn_Devolucao.Click += btn_Devolucao_Click;
            // 
            // QueixaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(lstDados);
            Controls.Add(txt_Buscar);
            Controls.Add(Pesquisar);
            Controls.Add(btn_Limpar_Pesquisa);
            Controls.Add(btn_Pesquisar);
            Controls.Add(panel1);
            Controls.Add(richTextDecisao);
            Controls.Add(richTextDescricao);
            Controls.Add(dateQueixa);
            Controls.Add(textN_S);
            Controls.Add(textTipoEquip);
            Controls.Add(Decisao);
            Controls.Add(Descricao);
            Controls.Add(DtQueixa);
            Controls.Add(N_S);
            Controls.Add(TipoEquip);
            Controls.Add(btn_Inserir);
            Controls.Add(btn_Limpar);
            Controls.Add(Clientes);
            Controls.Add(cb_listaClientes);
            Controls.Add(EscolherCliente);
            Controls.Add(ContinuarQueixa);
            Controls.Add(NIF);
            Controls.Add(Nome);
            Controls.Add(textNIF);
            Controls.Add(textNome);
            Name = "QueixaForm";
            Text = "Gestão de avarias - Inserir queixa";
            WindowState = FormWindowState.Maximized;
            Load += QueixaForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNome;
        private TextBox textNIF;
        private Label Nome;
        private Label NIF;
        private Label ContinuarQueixa;
        private Label EscolherCliente;
        private ComboBox cb_listaClientes;
        private Label Clientes;
        private Button btn_Limpar;
        private Button btn_Inserir;
        private Label TipoEquip;
        private Label N_S;
        private Label DtQueixa;
        private Label Descricao;
        private Label Decisao;
        private TextBox textTipoEquip;
        private TextBox textN_S;
        private DateTimePicker dateQueixa;
        private RichTextBox richTextDescricao;
        private RichTextBox richTextDecisao;
        private Panel panel1;
        private TextBox textBox1;
        private Button btnPageBusca;
        private Button btnPageInsercao;
        private Button btnPageHome;
        private Button btnPageEquipamentos;
        private Button btn_Contato;
        private ListView lstDados;
        private TextBox txt_Buscar;
        private TextBox Pesquisar;
        private Button btn_Limpar_Pesquisa;
        private Button btn_Pesquisar;
        private Button btn_Envio;
        private Button btn_Orcamento;
        private Button btn_Devolucao;
    }
}