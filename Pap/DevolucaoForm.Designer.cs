namespace Pap
{
    partial class DevolucaoForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_Inserir = new Button();
            btn_Limpar = new Button();
            DataDeDevolucao = new DateTimePicker();
            DataDeEntrega = new DateTimePicker();
            cb_Lista_NSA_NIF_NIFEE = new ComboBox();
            txt_NIFEE = new TextBox();
            txt_NIF = new TextBox();
            txt_NSA_Queixa = new TextBox();
            lstDados = new ListView();
            label7 = new Label();
            txt_Buscar = new TextBox();
            btn_Pesquisar = new Button();
            btn_Limpar_Pesquisa = new Button();
            panel1 = new Panel();
            btn_home = new Button();
            btn_Orcamento = new Button();
            btn_Envio = new Button();
            btn_Contato = new Button();
            btnPageEquipamentos = new Button();
            Gestao_De_Avaria = new TextBox();
            btnPageBusca = new Button();
            btnPageInsercao = new Button();
            btnPageQueixa = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label1.Location = new Point(12, 156);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "NSA Queixa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label2.Location = new Point(12, 217);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "NIF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label3.Location = new Point(12, 265);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "NIFEE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label4.Location = new Point(12, 316);
            label4.Name = "label4";
            label4.Size = new Size(133, 15);
            label4.TabIndex = 3;
            label4.Text = "Selecione o dados:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label5.Location = new Point(12, 378);
            label5.Name = "label5";
            label5.Size = new Size(133, 15);
            label5.TabIndex = 4;
            label5.Text = "Data de Devolução:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label6.Location = new Point(12, 435);
            label6.Name = "label6";
            label6.Size = new Size(119, 15);
            label6.TabIndex = 5;
            label6.Text = "Data de Entrega:";
            // 
            // btn_Inserir
            // 
            btn_Inserir.BackColor = Color.RoyalBlue;
            btn_Inserir.FlatStyle = FlatStyle.Flat;
            btn_Inserir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Inserir.ForeColor = Color.White;
            btn_Inserir.Location = new Point(152, 508);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(116, 37);
            btn_Inserir.TabIndex = 6;
            btn_Inserir.Text = "Inserir";
            btn_Inserir.UseVisualStyleBackColor = false;
            btn_Inserir.Click += btn_Inserir_Click;
            // 
            // btn_Limpar
            // 
            btn_Limpar.BackColor = Color.RoyalBlue;
            btn_Limpar.FlatStyle = FlatStyle.Flat;
            btn_Limpar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Limpar.ForeColor = Color.White;
            btn_Limpar.Location = new Point(319, 508);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(116, 37);
            btn_Limpar.TabIndex = 7;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = false;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // DataDeDevolucao
            // 
            DataDeDevolucao.Location = new Point(152, 372);
            DataDeDevolucao.Name = "DataDeDevolucao";
            DataDeDevolucao.Size = new Size(200, 23);
            DataDeDevolucao.TabIndex = 8;
            // 
            // DataDeEntrega
            // 
            DataDeEntrega.Location = new Point(152, 429);
            DataDeEntrega.Name = "DataDeEntrega";
            DataDeEntrega.Size = new Size(200, 23);
            DataDeEntrega.TabIndex = 9;
            // 
            // cb_Lista_NSA_NIF_NIFEE
            // 
            cb_Lista_NSA_NIF_NIFEE.FormattingEnabled = true;
            cb_Lista_NSA_NIF_NIFEE.Items.AddRange(new object[] { "Selecione o NSA da Queixa o NIF e o NIFEE" });
            cb_Lista_NSA_NIF_NIFEE.Location = new Point(152, 313);
            cb_Lista_NSA_NIF_NIFEE.Name = "cb_Lista_NSA_NIF_NIFEE";
            cb_Lista_NSA_NIF_NIFEE.Size = new Size(266, 23);
            cb_Lista_NSA_NIF_NIFEE.TabIndex = 10;
            // 
            // txt_NIFEE
            // 
            txt_NIFEE.Location = new Point(152, 262);
            txt_NIFEE.Name = "txt_NIFEE";
            txt_NIFEE.ReadOnly = true;
            txt_NIFEE.Size = new Size(200, 23);
            txt_NIFEE.TabIndex = 11;
            // 
            // txt_NIF
            // 
            txt_NIF.Location = new Point(152, 214);
            txt_NIF.Name = "txt_NIF";
            txt_NIF.ReadOnly = true;
            txt_NIF.Size = new Size(200, 23);
            txt_NIF.TabIndex = 12;
            // 
            // txt_NSA_Queixa
            // 
            txt_NSA_Queixa.Location = new Point(152, 153);
            txt_NSA_Queixa.Name = "txt_NSA_Queixa";
            txt_NSA_Queixa.ReadOnly = true;
            txt_NSA_Queixa.Size = new Size(55, 23);
            txt_NSA_Queixa.TabIndex = 13;
            // 
            // lstDados
            // 
            lstDados.Location = new Point(490, 179);
            lstDados.Name = "lstDados";
            lstDados.Size = new Size(868, 558);
            lstDados.TabIndex = 14;
            lstDados.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(491, 151);
            label7.Name = "label7";
            label7.Size = new Size(110, 22);
            label7.TabIndex = 15;
            label7.Text = "Pesquisar:";
            // 
            // txt_Buscar
            // 
            txt_Buscar.Location = new Point(597, 153);
            txt_Buscar.Name = "txt_Buscar";
            txt_Buscar.Size = new Size(463, 23);
            txt_Buscar.TabIndex = 16;
            // 
            // btn_Pesquisar
            // 
            btn_Pesquisar.BackColor = Color.RoyalBlue;
            btn_Pesquisar.FlatStyle = FlatStyle.Popup;
            btn_Pesquisar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Pesquisar.ForeColor = Color.White;
            btn_Pesquisar.Location = new Point(1066, 153);
            btn_Pesquisar.Name = "btn_Pesquisar";
            btn_Pesquisar.Size = new Size(118, 23);
            btn_Pesquisar.TabIndex = 17;
            btn_Pesquisar.Text = "Pesquisar";
            btn_Pesquisar.UseVisualStyleBackColor = false;
            btn_Pesquisar.Click += btn_Pesquisar_Click;
            // 
            // btn_Limpar_Pesquisa
            // 
            btn_Limpar_Pesquisa.BackColor = Color.RoyalBlue;
            btn_Limpar_Pesquisa.FlatStyle = FlatStyle.Popup;
            btn_Limpar_Pesquisa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Limpar_Pesquisa.ForeColor = Color.White;
            btn_Limpar_Pesquisa.Location = new Point(1190, 153);
            btn_Limpar_Pesquisa.Name = "btn_Limpar_Pesquisa";
            btn_Limpar_Pesquisa.Size = new Size(118, 23);
            btn_Limpar_Pesquisa.TabIndex = 18;
            btn_Limpar_Pesquisa.Text = "Limpar";
            btn_Limpar_Pesquisa.UseVisualStyleBackColor = false;
            btn_Limpar_Pesquisa.Click += btn_Limpar_Pesquisa_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btn_home);
            panel1.Controls.Add(btn_Orcamento);
            panel1.Controls.Add(btn_Envio);
            panel1.Controls.Add(btn_Contato);
            panel1.Controls.Add(btnPageEquipamentos);
            panel1.Controls.Add(Gestao_De_Avaria);
            panel1.Controls.Add(btnPageBusca);
            panel1.Controls.Add(btnPageInsercao);
            panel1.Controls.Add(btnPageQueixa);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 57);
            panel1.TabIndex = 19;
            // 
            // btn_home
            // 
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_home.Location = new Point(1221, 13);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(137, 32);
            btn_home.TabIndex = 8;
            btn_home.Text = "Página Inicial";
            btn_home.UseVisualStyleBackColor = true;
            btn_home.Click += btn_home_Click;
            // 
            // btn_Orcamento
            // 
            btn_Orcamento.FlatStyle = FlatStyle.Flat;
            btn_Orcamento.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Orcamento.Location = new Point(362, 12);
            btn_Orcamento.Name = "btn_Orcamento";
            btn_Orcamento.Size = new Size(108, 32);
            btn_Orcamento.TabIndex = 7;
            btn_Orcamento.Text = "Orçamento";
            btn_Orcamento.UseVisualStyleBackColor = true;
            btn_Orcamento.Click += btn_Orcamento_Click;
            // 
            // btn_Envio
            // 
            btn_Envio.FlatStyle = FlatStyle.Flat;
            btn_Envio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Envio.Location = new Point(476, 13);
            btn_Envio.Name = "btn_Envio";
            btn_Envio.Size = new Size(65, 32);
            btn_Envio.TabIndex = 6;
            btn_Envio.Text = "Envio";
            btn_Envio.UseVisualStyleBackColor = true;
            btn_Envio.Click += btn_Envio_Click;
            // 
            // btn_Contato
            // 
            btn_Contato.FlatStyle = FlatStyle.Flat;
            btn_Contato.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Contato.Location = new Point(547, 12);
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
            btnPageEquipamentos.Location = new Point(645, 12);
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
            btnPageBusca.Location = new Point(877, 12);
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
            btnPageInsercao.Location = new Point(1039, 12);
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
            btnPageQueixa.Location = new Point(788, 12);
            btnPageQueixa.Name = "btnPageQueixa";
            btnPageQueixa.Size = new Size(83, 32);
            btnPageQueixa.TabIndex = 1;
            btnPageQueixa.Text = "Queixa";
            btnPageQueixa.UseVisualStyleBackColor = false;
            btnPageQueixa.Click += btnPageQueixa_Click;
            // 
            // DevolucaoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel1);
            Controls.Add(btn_Limpar_Pesquisa);
            Controls.Add(btn_Pesquisar);
            Controls.Add(txt_Buscar);
            Controls.Add(label7);
            Controls.Add(lstDados);
            Controls.Add(txt_NSA_Queixa);
            Controls.Add(txt_NIF);
            Controls.Add(txt_NIFEE);
            Controls.Add(cb_Lista_NSA_NIF_NIFEE);
            Controls.Add(DataDeEntrega);
            Controls.Add(DataDeDevolucao);
            Controls.Add(btn_Limpar);
            Controls.Add(btn_Inserir);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DevolucaoForm";
            Text = "Gestão de Avarias - Devolução";
            WindowState = FormWindowState.Maximized;
            Load += DevolucaoForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_Inserir;
        private Button btn_Limpar;
        private DateTimePicker DataDeDevolucao;
        private DateTimePicker DataDeEntrega;
        private ComboBox cb_Lista_NSA_NIF_NIFEE;
        private TextBox txt_NIFEE;
        private TextBox txt_NIF;
        private TextBox txt_NSA_Queixa;
        private ListView lstDados;
        private Label label7;
        private TextBox txt_Buscar;
        private Button btn_Pesquisar;
        private Button btn_Limpar_Pesquisa;
        private Panel panel1;
        private Button btn_home;
        private Button btn_Orcamento;
        private Button btn_Envio;
        private Button btn_Contato;
        private Button btnPageEquipamentos;
        private TextBox Gestao_De_Avaria;
        private Button btnPageBusca;
        private Button btnPageInsercao;
        private Button btnPageQueixa;
    }
}