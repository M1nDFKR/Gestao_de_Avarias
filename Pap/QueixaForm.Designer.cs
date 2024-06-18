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
            textBox1 = new TextBox();
            btnPageBusca = new Button();
            btnPageInsercao = new Button();
            btnPageHome = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Location = new Point(60, 136);
            textNome.Name = "textNome";
            textNome.ReadOnly = true;
            textNome.Size = new Size(136, 23);
            textNome.TabIndex = 0;
            // 
            // textNIF
            // 
            textNIF.Location = new Point(298, 136);
            textNIF.Name = "textNIF";
            textNIF.ReadOnly = true;
            textNIF.Size = new Size(136, 23);
            textNIF.TabIndex = 1;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nome.Location = new Point(16, 139);
            Nome.Name = "Nome";
            Nome.Size = new Size(42, 15);
            Nome.TabIndex = 2;
            Nome.Text = "Nome:";
            // 
            // NIF
            // 
            NIF.AutoSize = true;
            NIF.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NIF.Location = new Point(257, 139);
            NIF.Name = "NIF";
            NIF.Size = new Size(35, 15);
            NIF.TabIndex = 2;
            NIF.Text = "NIF:";
            // 
            // ContinuarQueixa
            // 
            ContinuarQueixa.AutoSize = true;
            ContinuarQueixa.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContinuarQueixa.Location = new Point(16, 100);
            ContinuarQueixa.Name = "ContinuarQueixa";
            ContinuarQueixa.Size = new Size(242, 23);
            ContinuarQueixa.TabIndex = 3;
            ContinuarQueixa.Text = "Continuar Quiexa do Cliente.:";
            // 
            // EscolherCliente
            // 
            EscolherCliente.AutoSize = true;
            EscolherCliente.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EscolherCliente.Location = new Point(16, 184);
            EscolherCliente.Name = "EscolherCliente";
            EscolherCliente.Size = new Size(291, 23);
            EscolherCliente.TabIndex = 3;
            EscolherCliente.Text = "Inserir Queixa do cliente desejado.:";
            // 
            // cb_listaClientes
            // 
            cb_listaClientes.FormattingEnabled = true;
            cb_listaClientes.Items.AddRange(new object[] { "Selecione um Cliente" });
            cb_listaClientes.Location = new Point(86, 222);
            cb_listaClientes.Name = "cb_listaClientes";
            cb_listaClientes.Size = new Size(366, 23);
            cb_listaClientes.TabIndex = 4;
            // 
            // Clientes
            // 
            Clientes.AutoSize = true;
            Clientes.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clientes.Location = new Point(10, 225);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(70, 15);
            Clientes.TabIndex = 5;
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
            btn_Limpar.TabIndex = 6;
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
            btn_Inserir.TabIndex = 7;
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
            TipoEquip.TabIndex = 8;
            TipoEquip.Text = "Tipo de Equipamento:";
            // 
            // N_S
            // 
            N_S.AutoSize = true;
            N_S.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            N_S.Location = new Point(10, 296);
            N_S.Name = "N_S";
            N_S.Size = new Size(35, 15);
            N_S.TabIndex = 9;
            N_S.Text = "N-S:";
            // 
            // DtQueixa
            // 
            DtQueixa.AutoSize = true;
            DtQueixa.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DtQueixa.Location = new Point(7, 339);
            DtQueixa.Name = "DtQueixa";
            DtQueixa.Size = new Size(112, 15);
            DtQueixa.TabIndex = 10;
            DtQueixa.Text = "Data da Queixa:";
            // 
            // Descricao
            // 
            Descricao.AutoSize = true;
            Descricao.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Descricao.Location = new Point(3, 370);
            Descricao.Name = "Descricao";
            Descricao.Size = new Size(77, 15);
            Descricao.TabIndex = 11;
            Descricao.Text = "Descrição:";
            // 
            // Decisao
            // 
            Decisao.AutoSize = true;
            Decisao.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Decisao.Location = new Point(7, 462);
            Decisao.Name = "Decisao";
            Decisao.Size = new Size(63, 15);
            Decisao.TabIndex = 12;
            Decisao.Text = "Decisão:";
            // 
            // textTipoEquip
            // 
            textTipoEquip.Location = new Point(151, 258);
            textTipoEquip.MaxLength = 255;
            textTipoEquip.Name = "textTipoEquip";
            textTipoEquip.Size = new Size(301, 23);
            textTipoEquip.TabIndex = 13;
            // 
            // textN_S
            // 
            textN_S.Location = new Point(44, 293);
            textN_S.MaxLength = 255;
            textN_S.Name = "textN_S";
            textN_S.Size = new Size(408, 23);
            textN_S.TabIndex = 14;
            // 
            // dateQueixa
            // 
            dateQueixa.Location = new Point(141, 333);
            dateQueixa.Name = "dateQueixa";
            dateQueixa.Size = new Size(176, 23);
            dateQueixa.TabIndex = 15;
            // 
            // richTextDescricao
            // 
            richTextDescricao.Location = new Point(79, 370);
            richTextDescricao.Name = "richTextDescricao";
            richTextDescricao.Size = new Size(373, 86);
            richTextDescricao.TabIndex = 16;
            richTextDescricao.Text = "";
            // 
            // richTextDecisao
            // 
            richTextDecisao.Location = new Point(79, 462);
            richTextDecisao.Name = "richTextDecisao";
            richTextDecisao.Size = new Size(373, 85);
            richTextDecisao.TabIndex = 17;
            richTextDecisao.Text = "";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnPageBusca);
            panel1.Controls.Add(btnPageInsercao);
            panel1.Controls.Add(btnPageHome);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1090, 59);
            panel1.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.RoyalBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 33);
            textBox1.TabIndex = 15;
            textBox1.Text = "Gestão de avarias";
            // 
            // btnPageBusca
            // 
            btnPageBusca.BackColor = Color.RoyalBlue;
            btnPageBusca.BackgroundImageLayout = ImageLayout.Center;
            btnPageBusca.FlatStyle = FlatStyle.Flat;
            btnPageBusca.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageBusca.Location = new Point(733, 13);
            btnPageBusca.Name = "btnPageBusca";
            btnPageBusca.Size = new Size(156, 32);
            btnPageBusca.TabIndex = 14;
            btnPageBusca.Text = "Página de Busca";
            btnPageBusca.UseVisualStyleBackColor = false;
            btnPageBusca.Click += btnPageBusca_Click;
            // 
            // btnPageInsercao
            // 
            btnPageInsercao.FlatStyle = FlatStyle.Flat;
            btnPageInsercao.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageInsercao.Location = new Point(895, 13);
            btnPageInsercao.Name = "btnPageInsercao";
            btnPageInsercao.Size = new Size(176, 32);
            btnPageInsercao.TabIndex = 6;
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
            btnPageHome.Location = new Point(577, 13);
            btnPageHome.Name = "btnPageHome";
            btnPageHome.Size = new Size(150, 32);
            btnPageHome.TabIndex = 12;
            btnPageHome.Text = "Página Inicial";
            btnPageHome.UseVisualStyleBackColor = false;
            btnPageHome.Click += btnPageHome_Click;
            // 
            // QueixaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 638);
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
            Text = "Formulário de Queixa";
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
    }
}