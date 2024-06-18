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
            dtGridViewQueixas = new DataGridView();
            textBox2 = new TextBox();
            btnInserir = new Button();
            btnLimpar = new Button();
            textBoxPesquisa = new TextBox();
            textBox3 = new TextBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            btnPageBusca = new Button();
            btnPageInsercao = new Button();
            btnPageQueixa = new Button();
            Clientes = new Label();
            cb_listaClientes = new ComboBox();
            TipoEquip = new Label();
            cb_ListadeEquip_NS = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGridViewQueixas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(415, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 92);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // dtGridViewQueixas
            // 
            dtGridViewQueixas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtGridViewQueixas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridViewQueixas.Location = new Point(463, 261);
            dtGridViewQueixas.Name = "dtGridViewQueixas";
            dtGridViewQueixas.ReadOnly = true;
            dtGridViewQueixas.Size = new Size(733, 373);
            dtGridViewQueixas.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(12, 261);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(320, 26);
            textBox2.TabIndex = 18;
            textBox2.Text = "Informações das últimas 5 queixas.:";
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.RoyalBlue;
            btnInserir.BackgroundImageLayout = ImageLayout.Center;
            btnInserir.FlatStyle = FlatStyle.Popup;
            btnInserir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserir.ForeColor = Color.White;
            btnInserir.Location = new Point(463, 192);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(218, 32);
            btnInserir.TabIndex = 34;
            btnInserir.Text = "Pesquisar";
            btnInserir.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.RoyalBlue;
            btnLimpar.BackgroundImageLayout = ImageLayout.Center;
            btnLimpar.FlatStyle = FlatStyle.Popup;
            btnLimpar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(687, 192);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(137, 32);
            btnLimpar.TabIndex = 35;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.BackColor = SystemColors.Control;
            textBoxPesquisa.BorderStyle = BorderStyle.None;
            textBoxPesquisa.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPesquisa.Location = new Point(463, 230);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(100, 23);
            textBoxPesquisa.TabIndex = 36;
            textBoxPesquisa.Text = "Pesquisar:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(565, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(499, 23);
            textBox3.TabIndex = 37;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnPageBusca);
            panel1.Controls.Add(btnPageInsercao);
            panel1.Controls.Add(btnPageQueixa);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1209, 57);
            panel1.TabIndex = 38;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.RoyalBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 33);
            textBox1.TabIndex = 15;
            textBox1.Text = "Gestão de avarias";
            // 
            // btnPageBusca
            // 
            btnPageBusca.BackColor = Color.RoyalBlue;
            btnPageBusca.BackgroundImageLayout = ImageLayout.Center;
            btnPageBusca.FlatStyle = FlatStyle.Flat;
            btnPageBusca.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnPageInsercao.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageInsercao.Location = new Point(895, 13);
            btnPageInsercao.Name = "btnPageInsercao";
            btnPageInsercao.Size = new Size(176, 32);
            btnPageInsercao.TabIndex = 6;
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
            btnPageQueixa.Location = new Point(632, 13);
            btnPageQueixa.Name = "btnPageQueixa";
            btnPageQueixa.Size = new Size(95, 32);
            btnPageQueixa.TabIndex = 12;
            btnPageQueixa.Text = " Queixa";
            btnPageQueixa.UseVisualStyleBackColor = false;
            btnPageQueixa.Click += btnPageQueixa_Click;
            // 
            // Clientes
            // 
            Clientes.AutoSize = true;
            Clientes.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clientes.Location = new Point(12, 307);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(70, 15);
            Clientes.TabIndex = 39;
            Clientes.Text = "Clientes:";
            // 
            // cb_listaClientes
            // 
            cb_listaClientes.FormattingEnabled = true;
            cb_listaClientes.Items.AddRange(new object[] { "Vizualize os últimos 5 Cliente com os seus respetivos NIF e Nome" });
            cb_listaClientes.Location = new Point(88, 301);
            cb_listaClientes.Name = "cb_listaClientes";
            cb_listaClientes.Size = new Size(369, 23);
            cb_listaClientes.TabIndex = 40;
            // 
            // TipoEquip
            // 
            TipoEquip.AutoSize = true;
            TipoEquip.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TipoEquip.Location = new Point(12, 348);
            TipoEquip.Name = "TipoEquip";
            TipoEquip.Size = new Size(231, 15);
            TipoEquip.TabIndex = 41;
            TipoEquip.Text = "Tipo de Equipamento e o seu N-S:";
            // 
            // cb_ListadeEquip_NS
            // 
            cb_ListadeEquip_NS.FormattingEnabled = true;
            cb_ListadeEquip_NS.Items.AddRange(new object[] { "Vizualize os últimos 5 Equipamentos com os seus respetivos N-S" });
            cb_ListadeEquip_NS.Location = new Point(12, 375);
            cb_ListadeEquip_NS.Name = "cb_ListadeEquip_NS";
            cb_ListadeEquip_NS.Size = new Size(445, 23);
            cb_ListadeEquip_NS.TabIndex = 47;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 646);
            Controls.Add(cb_ListadeEquip_NS);
            Controls.Add(TipoEquip);
            Controls.Add(cb_listaClientes);
            Controls.Add(Clientes);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Controls.Add(textBoxPesquisa);
            Controls.Add(btnLimpar);
            Controls.Add(btnInserir);
            Controls.Add(textBox2);
            Controls.Add(dtGridViewQueixas);
            Controls.Add(pictureBox1);
            Name = "home";
            Text = "Gestão de avarias - Home";
            WindowState = FormWindowState.Maximized;
            Load += home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGridViewQueixas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private DataGridView dtGridViewQueixas;
        private TextBox textBox2;
        private Button btnInserir;
        private Button btnLimpar;
        private TextBox textBoxPesquisa;
        private TextBox textBox3;
        private Panel panel1;
        private TextBox textBox1;
        private Button btnPageBusca;
        private Button btnPageInsercao;
        private Button btnPageQueixa;
        private Label Clientes;
        private ComboBox cb_listaClientes;
        private Label TipoEquip;
        private ComboBox cb_ListadeEquip_NS;
    }
}