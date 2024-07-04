namespace Pap
{
    partial class OrcamentoForm
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
            cb_Lista_Queixa = new ComboBox();
            label1 = new Label();
            txt_NSA_Queixa = new TextBox();
            txt_NIF_Utilizador = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DataDoOrcamento = new DateTimePicker();
            DataDaResposta = new DateTimePicker();
            label5 = new Label();
            DataDePagamento = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            txt_Comunicado = new TextBox();
            txt_Forma_Comunicacao = new TextBox();
            label8 = new Label();
            richTxt_Resumo = new RichTextBox();
            label9 = new Label();
            label10 = new Label();
            richTxt_Resposta = new RichTextBox();
            painelPagamento = new Panel();
            rb_Sim = new RadioButton();
            rb_Nao = new RadioButton();
            label11 = new Label();
            btn_Inserir = new Button();
            btn_Limpar = new Button();
            Pesquisa = new Label();
            btn_Limpar_Pesquisa = new Button();
            txt_Buscar = new TextBox();
            btn_Pesquisar = new Button();
            lstDados = new ListView();
            panel1 = new Panel();
            btn_Devolucao = new Button();
            btn_home = new Button();
            btn_Envio = new Button();
            btn_Contato = new Button();
            btnPageEquipamentos = new Button();
            Gestao_De_Avaria = new TextBox();
            btnPageBusca = new Button();
            btnPageInsercao = new Button();
            btnPageQueixa = new Button();
            painelPagamento.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cb_Lista_Queixa
            // 
            cb_Lista_Queixa.FormattingEnabled = true;
            cb_Lista_Queixa.Items.AddRange(new object[] { "Selecione a Queixa e o NIF" });
            cb_Lista_Queixa.Location = new Point(214, 151);
            cb_Lista_Queixa.Name = "cb_Lista_Queixa";
            cb_Lista_Queixa.Size = new Size(231, 23);
            cb_Lista_Queixa.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 1;
            label1.Text = "NIF do Cliente:";
            // 
            // txt_NSA_Queixa
            // 
            txt_NSA_Queixa.Location = new Point(182, 107);
            txt_NSA_Queixa.Name = "txt_NSA_Queixa";
            txt_NSA_Queixa.ReadOnly = true;
            txt_NSA_Queixa.Size = new Size(36, 23);
            txt_NSA_Queixa.TabIndex = 2;
            // 
            // txt_NIF_Utilizador
            // 
            txt_NIF_Utilizador.Location = new Point(182, 67);
            txt_NIF_Utilizador.Name = "txt_NIF_Utilizador";
            txt_NIF_Utilizador.ReadOnly = true;
            txt_NIF_Utilizador.Size = new Size(130, 23);
            txt_NIF_Utilizador.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 4;
            label2.Text = "NSA da Queixa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label3.Location = new Point(12, 154);
            label3.Name = "label3";
            label3.Size = new Size(196, 15);
            label3.TabIndex = 5;
            label3.Text = "Selecione a Queixa e o NIF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label4.Location = new Point(12, 199);
            label4.Name = "label4";
            label4.Size = new Size(133, 15);
            label4.TabIndex = 6;
            label4.Text = "Data do Orçamento:";
            // 
            // DataDoOrcamento
            // 
            DataDoOrcamento.Location = new Point(182, 193);
            DataDoOrcamento.Name = "DataDoOrcamento";
            DataDoOrcamento.Size = new Size(200, 23);
            DataDoOrcamento.TabIndex = 7;
            // 
            // DataDaResposta
            // 
            DataDaResposta.Location = new Point(182, 512);
            DataDaResposta.Name = "DataDaResposta";
            DataDaResposta.Size = new Size(200, 23);
            DataDaResposta.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label5.Location = new Point(12, 518);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 8;
            label5.Text = "Data da Resposta:";
            // 
            // DataDePagamento
            // 
            DataDePagamento.Location = new Point(182, 637);
            DataDePagamento.Name = "DataDePagamento";
            DataDePagamento.Size = new Size(200, 23);
            DataDePagamento.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label6.Location = new Point(12, 643);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 10;
            label6.Text = "Data de Pagamento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label7.Location = new Point(12, 235);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 12;
            label7.Text = "Comunicado:";
            // 
            // txt_Comunicado
            // 
            txt_Comunicado.Location = new Point(182, 232);
            txt_Comunicado.MaxLength = 255;
            txt_Comunicado.Name = "txt_Comunicado";
            txt_Comunicado.Size = new Size(263, 23);
            txt_Comunicado.TabIndex = 13;
            // 
            // txt_Forma_Comunicacao
            // 
            txt_Forma_Comunicacao.Location = new Point(182, 277);
            txt_Forma_Comunicacao.MaxLength = 50;
            txt_Forma_Comunicacao.Name = "txt_Forma_Comunicacao";
            txt_Forma_Comunicacao.Size = new Size(263, 23);
            txt_Forma_Comunicacao.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label8.Location = new Point(12, 280);
            label8.Name = "label8";
            label8.Size = new Size(154, 15);
            label8.TabIndex = 14;
            label8.Text = "Forma de Comunicação:";
            // 
            // richTxt_Resumo
            // 
            richTxt_Resumo.Location = new Point(182, 306);
            richTxt_Resumo.Name = "richTxt_Resumo";
            richTxt_Resumo.Size = new Size(263, 96);
            richTxt_Resumo.TabIndex = 16;
            richTxt_Resumo.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label9.Location = new Point(12, 309);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 17;
            label9.Text = "Resumo:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label10.Location = new Point(12, 411);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 19;
            label10.Text = "Resposta:";
            // 
            // richTxt_Resposta
            // 
            richTxt_Resposta.Location = new Point(182, 408);
            richTxt_Resposta.Name = "richTxt_Resposta";
            richTxt_Resposta.Size = new Size(263, 96);
            richTxt_Resposta.TabIndex = 18;
            richTxt_Resposta.Text = "";
            // 
            // painelPagamento
            // 
            painelPagamento.Controls.Add(rb_Sim);
            painelPagamento.Controls.Add(rb_Nao);
            painelPagamento.Controls.Add(label11);
            painelPagamento.Location = new Point(7, 541);
            painelPagamento.Name = "painelPagamento";
            painelPagamento.Size = new Size(346, 84);
            painelPagamento.TabIndex = 20;
            // 
            // rb_Sim
            // 
            rb_Sim.AutoSize = true;
            rb_Sim.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_Sim.Location = new Point(223, 61);
            rb_Sim.Name = "rb_Sim";
            rb_Sim.Size = new Size(48, 21);
            rb_Sim.TabIndex = 2;
            rb_Sim.TabStop = true;
            rb_Sim.Text = "Sim";
            rb_Sim.UseVisualStyleBackColor = true;
            // 
            // rb_Nao
            // 
            rb_Nao.AutoSize = true;
            rb_Nao.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_Nao.Location = new Point(82, 58);
            rb_Nao.Name = "rb_Nao";
            rb_Nao.Size = new Size(51, 21);
            rb_Nao.TabIndex = 1;
            rb_Nao.TabStop = true;
            rb_Nao.Text = "Não";
            rb_Nao.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 16);
            label11.Name = "label11";
            label11.Size = new Size(182, 15);
            label11.TabIndex = 0;
            label11.Text = "Foi efetuado o Pagamento:";
            // 
            // btn_Inserir
            // 
            btn_Inserir.BackColor = Color.RoyalBlue;
            btn_Inserir.FlatStyle = FlatStyle.Flat;
            btn_Inserir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Inserir.ForeColor = Color.White;
            btn_Inserir.Location = new Point(182, 688);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(112, 38);
            btn_Inserir.TabIndex = 21;
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
            btn_Limpar.Location = new Point(331, 688);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(114, 38);
            btn_Limpar.TabIndex = 22;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = false;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // Pesquisa
            // 
            Pesquisa.AutoSize = true;
            Pesquisa.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pesquisa.Location = new Point(504, 129);
            Pesquisa.Name = "Pesquisa";
            Pesquisa.Size = new Size(110, 22);
            Pesquisa.TabIndex = 42;
            Pesquisa.Text = "Pesquisar:";
            // 
            // btn_Limpar_Pesquisa
            // 
            btn_Limpar_Pesquisa.BackColor = Color.RoyalBlue;
            btn_Limpar_Pesquisa.FlatStyle = FlatStyle.Popup;
            btn_Limpar_Pesquisa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Limpar_Pesquisa.ForeColor = Color.White;
            btn_Limpar_Pesquisa.Location = new Point(1154, 129);
            btn_Limpar_Pesquisa.Name = "btn_Limpar_Pesquisa";
            btn_Limpar_Pesquisa.Size = new Size(120, 24);
            btn_Limpar_Pesquisa.TabIndex = 41;
            btn_Limpar_Pesquisa.Text = "Limpar";
            btn_Limpar_Pesquisa.UseVisualStyleBackColor = false;
            btn_Limpar_Pesquisa.Click += btn_Limpar_Pesquisa_Click;
            // 
            // txt_Buscar
            // 
            txt_Buscar.Location = new Point(618, 130);
            txt_Buscar.MaxLength = 255;
            txt_Buscar.Name = "txt_Buscar";
            txt_Buscar.Size = new Size(415, 23);
            txt_Buscar.TabIndex = 40;
            // 
            // btn_Pesquisar
            // 
            btn_Pesquisar.BackColor = Color.RoyalBlue;
            btn_Pesquisar.FlatStyle = FlatStyle.Popup;
            btn_Pesquisar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Pesquisar.ForeColor = Color.White;
            btn_Pesquisar.Location = new Point(1039, 129);
            btn_Pesquisar.Name = "btn_Pesquisar";
            btn_Pesquisar.Size = new Size(109, 24);
            btn_Pesquisar.TabIndex = 39;
            btn_Pesquisar.Text = "Pesquisar";
            btn_Pesquisar.UseVisualStyleBackColor = false;
            btn_Pesquisar.Click += btn_Pesquisar_Click;
            // 
            // lstDados
            // 
            lstDados.Location = new Point(504, 159);
            lstDados.Name = "lstDados";
            lstDados.Size = new Size(854, 578);
            lstDados.TabIndex = 38;
            lstDados.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btn_Devolucao);
            panel1.Controls.Add(btn_home);
            panel1.Controls.Add(btn_Envio);
            panel1.Controls.Add(btn_Contato);
            panel1.Controls.Add(btnPageEquipamentos);
            panel1.Controls.Add(Gestao_De_Avaria);
            panel1.Controls.Add(btnPageBusca);
            panel1.Controls.Add(btnPageInsercao);
            panel1.Controls.Add(btnPageQueixa);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1383, 62);
            panel1.TabIndex = 43;
            // 
            // btn_Devolucao
            // 
            btn_Devolucao.FlatStyle = FlatStyle.Flat;
            btn_Devolucao.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Devolucao.Location = new Point(360, 18);
            btn_Devolucao.Name = "btn_Devolucao";
            btn_Devolucao.Size = new Size(112, 31);
            btn_Devolucao.TabIndex = 8;
            btn_Devolucao.Text = "Devolução";
            btn_Devolucao.UseVisualStyleBackColor = true;
            btn_Devolucao.Click += btn_Devolucao_Click;
            // 
            // btn_home
            // 
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_home.Location = new Point(1221, 17);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(137, 32);
            btn_home.TabIndex = 7;
            btn_home.Text = "Página Inicial";
            btn_home.UseVisualStyleBackColor = true;
            btn_home.Click += btn_home_Click;
            // 
            // btn_Envio
            // 
            btn_Envio.FlatStyle = FlatStyle.Flat;
            btn_Envio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Envio.Location = new Point(478, 18);
            btn_Envio.Name = "btn_Envio";
            btn_Envio.Size = new Size(63, 32);
            btn_Envio.TabIndex = 6;
            btn_Envio.Text = "Envio";
            btn_Envio.UseVisualStyleBackColor = true;
            btn_Envio.Click += btn_Envio_Click;
            // 
            // btn_Contato
            // 
            btn_Contato.FlatStyle = FlatStyle.Flat;
            btn_Contato.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Contato.Location = new Point(547, 17);
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
            btnPageEquipamentos.Location = new Point(645, 17);
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
            btnPageBusca.Location = new Point(877, 17);
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
            btnPageInsercao.Location = new Point(1039, 17);
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
            btnPageQueixa.Location = new Point(788, 17);
            btnPageQueixa.Name = "btnPageQueixa";
            btnPageQueixa.Size = new Size(83, 32);
            btnPageQueixa.TabIndex = 1;
            btnPageQueixa.Text = "Queixa";
            btnPageQueixa.UseVisualStyleBackColor = false;
            btnPageQueixa.Click += btnPageQueixa_Click;
            // 
            // OrcamentoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel1);
            Controls.Add(Pesquisa);
            Controls.Add(btn_Limpar_Pesquisa);
            Controls.Add(txt_Buscar);
            Controls.Add(btn_Pesquisar);
            Controls.Add(lstDados);
            Controls.Add(btn_Limpar);
            Controls.Add(btn_Inserir);
            Controls.Add(painelPagamento);
            Controls.Add(label10);
            Controls.Add(richTxt_Resposta);
            Controls.Add(label9);
            Controls.Add(richTxt_Resumo);
            Controls.Add(txt_Forma_Comunicacao);
            Controls.Add(label8);
            Controls.Add(txt_Comunicado);
            Controls.Add(label7);
            Controls.Add(DataDePagamento);
            Controls.Add(label6);
            Controls.Add(DataDaResposta);
            Controls.Add(label5);
            Controls.Add(DataDoOrcamento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_NIF_Utilizador);
            Controls.Add(txt_NSA_Queixa);
            Controls.Add(label1);
            Controls.Add(cb_Lista_Queixa);
            Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            Name = "OrcamentoForm";
            Text = "Gestão de Avarias - Orçamento";
            WindowState = FormWindowState.Maximized;
            Load += OrcamentoForm_Load;
            painelPagamento.ResumeLayout(false);
            painelPagamento.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_Lista_Queixa;
        private Label label1;
        private TextBox txt_NSA_Queixa;
        private TextBox txt_NIF_Utilizador;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker DataDoOrcamento;
        private DateTimePicker DataDaResposta;
        private Label label5;
        private DateTimePicker DataDePagamento;
        private Label label6;
        private Label label7;
        private TextBox txt_Comunicado;
        private TextBox txt_Forma_Comunicacao;
        private Label label8;
        private RichTextBox richTxt_Resumo;
        private Label label9;
        private Label label10;
        private RichTextBox richTxt_Resposta;
        private Panel painelPagamento;
        private RadioButton rb_Sim;
        private RadioButton rb_Nao;
        private Label label11;
        private Button btn_Inserir;
        private Button btn_Limpar;
        private Label Pesquisa;
        private Button btn_Limpar_Pesquisa;
        private TextBox txt_Buscar;
        private Button btn_Pesquisar;
        private ListView lstDados;
        private Panel panel1;
        private Button btn_Devolucao;
        private Button btn_home;
        private Button btn_Envio;
        private Button btn_Contato;
        private Button btnPageEquipamentos;
        private TextBox Gestao_De_Avaria;
        private Button btnPageBusca;
        private Button btnPageInsercao;
        private Button btnPageQueixa;
    }
}