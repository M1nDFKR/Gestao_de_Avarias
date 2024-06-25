namespace Pap
{
    partial class home
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
            pictureBox1 = new PictureBox();
            Informacao = new TextBox();
            btnPesquisar = new Button();
            btnLimpar = new Button();
            Pesquisar = new TextBox();
            txt_buscar = new TextBox();
            panel1 = new Panel();
            btn_Contato = new Button();
            btnPageEquipamentos = new Button();
            Gestao_De_Avaria = new TextBox();
            btnPageBusca = new Button();
            btnPageInsercao = new Button();
            btnPageQueixa = new Button();
            Clientes = new Label();
            cb_listaClientes = new ComboBox();
            TipoEquip = new Label();
            cb_ListadeEquip_NS = new ComboBox();
            lstDados = new ListView();
            btn_Envio = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 113);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Informacao
            // 
            Informacao.BackColor = SystemColors.Control;
            Informacao.BorderStyle = BorderStyle.None;
            Informacao.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Informacao.Location = new Point(38, 301);
            Informacao.Name = "Informacao";
            Informacao.Size = new Size(320, 26);
            Informacao.TabIndex = 0;
            Informacao.Text = "Informações das últimas 5 queixas.:";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.RoyalBlue;
            btnPesquisar.BackgroundImageLayout = ImageLayout.Center;
            btnPesquisar.FlatStyle = FlatStyle.Popup;
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(1172, 132);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(98, 23);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.RoyalBlue;
            btnLimpar.BackgroundImageLayout = ImageLayout.Center;
            btnLimpar.FlatStyle = FlatStyle.Popup;
            btnLimpar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(1276, 132);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(76, 23);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Pesquisar
            // 
            Pesquisar.BackColor = SystemColors.Control;
            Pesquisar.BorderStyle = BorderStyle.None;
            Pesquisar.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pesquisar.Location = new Point(565, 130);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(100, 23);
            Pesquisar.TabIndex = 0;
            Pesquisar.Text = "Pesquisar:";
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(667, 132);
            txt_buscar.MaxLength = 255;
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(499, 23);
            txt_buscar.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btn_Envio);
            panel1.Controls.Add(btn_Contato);
            panel1.Controls.Add(btnPageEquipamentos);
            panel1.Controls.Add(Gestao_De_Avaria);
            panel1.Controls.Add(btnPageBusca);
            panel1.Controls.Add(btnPageInsercao);
            panel1.Controls.Add(btnPageQueixa);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 57);
            panel1.TabIndex = 6;
            // 
            // btn_Contato
            // 
            btn_Contato.FlatStyle = FlatStyle.Flat;
            btn_Contato.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Contato.Location = new Point(690, 12);
            btn_Contato.Name = "btn_Contato";
            btn_Contato.Size = new Size(92, 32);
            btn_Contato.TabIndex = 5;
            btn_Contato.Text = "Contacto";
            btn_Contato.UseVisualStyleBackColor = true;
            btn_Contato.Click += btn_Contato_Click;
            // 
            // btnPageEquipamentos
            // 
            btnPageEquipamentos.FlatStyle = FlatStyle.Flat;
            btnPageEquipamentos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageEquipamentos.Location = new Point(788, 12);
            btnPageEquipamentos.Name = "btnPageEquipamentos";
            btnPageEquipamentos.Size = new Size(137, 32);
            btnPageEquipamentos.TabIndex = 4;
            btnPageEquipamentos.Text = "Equipamentos";
            btnPageEquipamentos.UseVisualStyleBackColor = true;
            btnPageEquipamentos.Click += btnPageEquipamentos_Click;
            // 
            // Gestao_De_Avaria
            // 
            Gestao_De_Avaria.BackColor = Color.RoyalBlue;
            Gestao_De_Avaria.BorderStyle = BorderStyle.None;
            Gestao_De_Avaria.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Gestao_De_Avaria.Location = new Point(12, 12);
            Gestao_De_Avaria.Name = "Gestao_De_Avaria";
            Gestao_De_Avaria.Size = new Size(260, 33);
            Gestao_De_Avaria.TabIndex = 0;
            Gestao_De_Avaria.Text = "Gestão de avarias";
            // 
            // btnPageBusca
            // 
            btnPageBusca.BackColor = Color.RoyalBlue;
            btnPageBusca.BackgroundImageLayout = ImageLayout.Center;
            btnPageBusca.FlatStyle = FlatStyle.Flat;
            btnPageBusca.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageBusca.Location = new Point(1020, 12);
            btnPageBusca.Name = "btnPageBusca";
            btnPageBusca.Size = new Size(156, 32);
            btnPageBusca.TabIndex = 2;
            btnPageBusca.Text = "Página de Busca";
            btnPageBusca.UseVisualStyleBackColor = false;
            btnPageBusca.Click += btnPageBusca_Click;
            // 
            // btnPageInsercao
            // 
            btnPageInsercao.FlatStyle = FlatStyle.Flat;
            btnPageInsercao.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageInsercao.Location = new Point(1182, 12);
            btnPageInsercao.Name = "btnPageInsercao";
            btnPageInsercao.Size = new Size(176, 32);
            btnPageInsercao.TabIndex = 3;
            btnPageInsercao.Text = "Página de inserção";
            btnPageInsercao.UseVisualStyleBackColor = true;
            btnPageInsercao.Click += btnPageInsercao_Click;
            // 
            // btnPageQueixa
            // 
            btnPageQueixa.BackColor = Color.RoyalBlue;
            btnPageQueixa.BackgroundImageLayout = ImageLayout.Center;
            btnPageQueixa.FlatStyle = FlatStyle.Flat;
            btnPageQueixa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageQueixa.Location = new Point(931, 12);
            btnPageQueixa.Name = "btnPageQueixa";
            btnPageQueixa.Size = new Size(83, 32);
            btnPageQueixa.TabIndex = 1;
            btnPageQueixa.Text = "Queixa";
            btnPageQueixa.UseVisualStyleBackColor = false;
            btnPageQueixa.Click += btnPageQueixa_Click;
            // 
            // Clientes
            // 
            Clientes.AutoSize = true;
            Clientes.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clientes.Location = new Point(38, 347);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(70, 15);
            Clientes.TabIndex = 0;
            Clientes.Text = "Clientes:";
            // 
            // cb_listaClientes
            // 
            cb_listaClientes.FormattingEnabled = true;
            cb_listaClientes.Items.AddRange(new object[] { "Vizualize os últimos 5 Cliente com os seus respetivos NIF e Nome" });
            cb_listaClientes.Location = new Point(114, 341);
            cb_listaClientes.Name = "cb_listaClientes";
            cb_listaClientes.Size = new Size(404, 23);
            cb_listaClientes.TabIndex = 1;
            // 
            // TipoEquip
            // 
            TipoEquip.AutoSize = true;
            TipoEquip.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TipoEquip.Location = new Point(38, 388);
            TipoEquip.Name = "TipoEquip";
            TipoEquip.Size = new Size(231, 15);
            TipoEquip.TabIndex = 0;
            TipoEquip.Text = "Tipo de Equipamento e o seu N-S:";
            // 
            // cb_ListadeEquip_NS
            // 
            cb_ListadeEquip_NS.FormattingEnabled = true;
            cb_ListadeEquip_NS.Items.AddRange(new object[] { "Vizualize os últimos 5 Equipamentos com os seus respetivos N-S" });
            cb_ListadeEquip_NS.Location = new Point(38, 415);
            cb_ListadeEquip_NS.Name = "cb_ListadeEquip_NS";
            cb_ListadeEquip_NS.Size = new Size(480, 23);
            cb_ListadeEquip_NS.TabIndex = 2;
            // 
            // lstDados
            // 
            lstDados.Location = new Point(565, 161);
            lstDados.Name = "lstDados";
            lstDados.Size = new Size(793, 576);
            lstDados.TabIndex = 0;
            lstDados.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Envio
            // 
            btn_Envio.FlatStyle = FlatStyle.Flat;
            btn_Envio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Envio.Location = new Point(592, 13);
            btn_Envio.Name = "btn_Envio";
            btn_Envio.Size = new Size(92, 32);
            btn_Envio.TabIndex = 6;
            btn_Envio.Text = "Envio";
            btn_Envio.UseVisualStyleBackColor = true;
            btn_Envio.Click += btn_Envio_Click;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(lstDados);
            Controls.Add(cb_ListadeEquip_NS);
            Controls.Add(TipoEquip);
            Controls.Add(cb_listaClientes);
            Controls.Add(Clientes);
            Controls.Add(panel1);
            Controls.Add(txt_buscar);
            Controls.Add(Pesquisar);
            Controls.Add(btnLimpar);
            Controls.Add(btnPesquisar);
            Controls.Add(Informacao);
            Controls.Add(pictureBox1);
            Name = "home";
            Text = "Gestão de avarias - Home";
            WindowState = FormWindowState.Maximized;
            Load += home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox Informacao;
        private Button btnPesquisar;
        private Button btnLimpar;
        private TextBox Pesquisar;
        private TextBox txt_buscar;
        private Panel panel1;
        private TextBox Gestao_De_Avaria;
        private Button btnPageBusca;
        private Button btnPageInsercao;
        private Button btnPageQueixa;
        private Label Clientes;
        private ComboBox cb_listaClientes;
        private Label TipoEquip;
        private ComboBox cb_ListadeEquip_NS;
        private ListView lstDados;
        private Button btnPageEquipamentos;
        private Button btn_Contato;
        private Button btn_Envio;
    }
}