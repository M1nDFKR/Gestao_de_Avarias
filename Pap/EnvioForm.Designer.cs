namespace Pap
{
    partial class EnvioForm
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
            txt_NSA_Transporte = new TextBox();
            txt_Referencia_Envio = new TextBox();
            Data_de_Envio = new DateTimePicker();
            label6 = new Label();
            cb_Lista_Queixa = new ComboBox();
            txt_NSA_Queixa = new TextBox();
            txt_NIF_Utilizador = new TextBox();
            btn_Limpar = new Button();
            btn_Inserir = new Button();
            Pesquisa = new Label();
            btn_Limpar_Pesquisa = new Button();
            txt_Buscar = new TextBox();
            btn_Pesquisar = new Button();
            lstDados = new ListView();
            panel1 = new Panel();
            btn_Devolucao = new Button();
            btn_Orcamento = new Button();
            btn_home = new Button();
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
            label1.Location = new Point(18, 133);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "NIF Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label2.Location = new Point(18, 174);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "NSA Queixa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label3.Location = new Point(18, 211);
            label3.Name = "label3";
            label3.Size = new Size(315, 15);
            label3.TabIndex = 2;
            label3.Text = "Selecione a Queixa com o NIF correspondente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label4.Location = new Point(18, 253);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 3;
            label4.Text = "Referência:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label5.Location = new Point(18, 292);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 4;
            label5.Text = "Data de Envio:";
            // 
            // txt_NSA_Transporte
            // 
            txt_NSA_Transporte.Location = new Point(284, 331);
            txt_NSA_Transporte.Name = "txt_NSA_Transporte";
            txt_NSA_Transporte.Size = new Size(171, 23);
            txt_NSA_Transporte.TabIndex = 5;
            // 
            // txt_Referencia_Envio
            // 
            txt_Referencia_Envio.Location = new Point(284, 250);
            txt_Referencia_Envio.Name = "txt_Referencia_Envio";
            txt_Referencia_Envio.Size = new Size(171, 23);
            txt_Referencia_Envio.TabIndex = 6;
            // 
            // Data_de_Envio
            // 
            Data_de_Envio.Location = new Point(284, 289);
            Data_de_Envio.Name = "Data_de_Envio";
            Data_de_Envio.Size = new Size(171, 23);
            Data_de_Envio.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 9.75F, FontStyle.Bold);
            label6.Location = new Point(18, 330);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 8;
            label6.Text = "NSA Transporte:";
            // 
            // cb_Lista_Queixa
            // 
            cb_Lista_Queixa.FormattingEnabled = true;
            cb_Lista_Queixa.Items.AddRange(new object[] { "Selecione a Queixa" });
            cb_Lista_Queixa.Location = new Point(330, 208);
            cb_Lista_Queixa.Name = "cb_Lista_Queixa";
            cb_Lista_Queixa.Size = new Size(159, 23);
            cb_Lista_Queixa.TabIndex = 9;
            // 
            // txt_NSA_Queixa
            // 
            txt_NSA_Queixa.Location = new Point(284, 171);
            txt_NSA_Queixa.Name = "txt_NSA_Queixa";
            txt_NSA_Queixa.ReadOnly = true;
            txt_NSA_Queixa.Size = new Size(32, 23);
            txt_NSA_Queixa.TabIndex = 10;
            // 
            // txt_NIF_Utilizador
            // 
            txt_NIF_Utilizador.Location = new Point(284, 130);
            txt_NIF_Utilizador.Name = "txt_NIF_Utilizador";
            txt_NIF_Utilizador.ReadOnly = true;
            txt_NIF_Utilizador.Size = new Size(171, 23);
            txt_NIF_Utilizador.TabIndex = 11;
            // 
            // btn_Limpar
            // 
            btn_Limpar.BackColor = Color.RoyalBlue;
            btn_Limpar.FlatStyle = FlatStyle.Flat;
            btn_Limpar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Limpar.ForeColor = Color.White;
            btn_Limpar.Location = new Point(152, 427);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(100, 37);
            btn_Limpar.TabIndex = 12;
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
            btn_Inserir.Location = new Point(284, 427);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(100, 37);
            btn_Inserir.TabIndex = 13;
            btn_Inserir.Text = "Inserir";
            btn_Inserir.UseVisualStyleBackColor = false;
            btn_Inserir.Click += btn_Inserir_Click;
            // 
            // Pesquisa
            // 
            Pesquisa.AutoSize = true;
            Pesquisa.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pesquisa.Location = new Point(504, 131);
            Pesquisa.Name = "Pesquisa";
            Pesquisa.Size = new Size(110, 22);
            Pesquisa.TabIndex = 37;
            Pesquisa.Text = "Pesquisar:";
            // 
            // btn_Limpar_Pesquisa
            // 
            btn_Limpar_Pesquisa.BackColor = Color.RoyalBlue;
            btn_Limpar_Pesquisa.FlatStyle = FlatStyle.Popup;
            btn_Limpar_Pesquisa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Limpar_Pesquisa.ForeColor = Color.White;
            btn_Limpar_Pesquisa.Location = new Point(1169, 130);
            btn_Limpar_Pesquisa.Name = "btn_Limpar_Pesquisa";
            btn_Limpar_Pesquisa.Size = new Size(118, 25);
            btn_Limpar_Pesquisa.TabIndex = 36;
            btn_Limpar_Pesquisa.Text = "Limpar";
            btn_Limpar_Pesquisa.UseVisualStyleBackColor = false;
            btn_Limpar_Pesquisa.Click += btn_Limpar_Pesquisa_Click;
            // 
            // txt_Buscar
            // 
            txt_Buscar.Location = new Point(616, 131);
            txt_Buscar.MaxLength = 255;
            txt_Buscar.Name = "txt_Buscar";
            txt_Buscar.Size = new Size(425, 23);
            txt_Buscar.TabIndex = 35;
            // 
            // btn_Pesquisar
            // 
            btn_Pesquisar.BackColor = Color.RoyalBlue;
            btn_Pesquisar.FlatStyle = FlatStyle.Popup;
            btn_Pesquisar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Pesquisar.ForeColor = Color.White;
            btn_Pesquisar.Location = new Point(1047, 131);
            btn_Pesquisar.Name = "btn_Pesquisar";
            btn_Pesquisar.Size = new Size(116, 24);
            btn_Pesquisar.TabIndex = 34;
            btn_Pesquisar.Text = "Pesquisar";
            btn_Pesquisar.UseVisualStyleBackColor = false;
            btn_Pesquisar.Click += btn_Pesquisar_Click;
            // 
            // lstDados
            // 
            lstDados.Location = new Point(507, 159);
            lstDados.Name = "lstDados";
            lstDados.Size = new Size(851, 578);
            lstDados.TabIndex = 33;
            lstDados.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btn_Devolucao);
            panel1.Controls.Add(btn_Orcamento);
            panel1.Controls.Add(btn_home);
            panel1.Controls.Add(btn_Contato);
            panel1.Controls.Add(btnPageEquipamentos);
            panel1.Controls.Add(Gestao_De_Avaria);
            panel1.Controls.Add(btnPageBusca);
            panel1.Controls.Add(btnPageInsercao);
            panel1.Controls.Add(btnPageQueixa);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 57);
            panel1.TabIndex = 38;
            // 
            // btn_Devolucao
            // 
            btn_Devolucao.FlatStyle = FlatStyle.Flat;
            btn_Devolucao.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Devolucao.Location = new Point(330, 11);
            btn_Devolucao.Name = "btn_Devolucao";
            btn_Devolucao.Size = new Size(106, 32);
            btn_Devolucao.TabIndex = 8;
            btn_Devolucao.Text = "Devolução";
            btn_Devolucao.UseVisualStyleBackColor = true;
            btn_Devolucao.Click += btn_Devolucao_Click;
            // 
            // btn_Orcamento
            // 
            btn_Orcamento.FlatStyle = FlatStyle.Flat;
            btn_Orcamento.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Orcamento.Location = new Point(442, 12);
            btn_Orcamento.Name = "btn_Orcamento";
            btn_Orcamento.Size = new Size(107, 32);
            btn_Orcamento.TabIndex = 7;
            btn_Orcamento.Text = "Orçamento";
            btn_Orcamento.UseVisualStyleBackColor = true;
            btn_Orcamento.Click += btn_Orcamento_Click;
            // 
            // btn_home
            // 
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_home.Location = new Point(1230, 12);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(128, 32);
            btn_home.TabIndex = 6;
            btn_home.Text = "Pagina Inicial";
            btn_home.UseVisualStyleBackColor = true;
            btn_home.Click += btn_home_Click;
            // 
            // btn_Contato
            // 
            btn_Contato.FlatStyle = FlatStyle.Flat;
            btn_Contato.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Contato.Location = new Point(555, 12);
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
            btnPageEquipamentos.Location = new Point(653, 12);
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
            btnPageBusca.Location = new Point(885, 12);
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
            btnPageInsercao.Location = new Point(1047, 12);
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
            btnPageQueixa.Location = new Point(796, 12);
            btnPageQueixa.Name = "btnPageQueixa";
            btnPageQueixa.Size = new Size(83, 32);
            btnPageQueixa.TabIndex = 1;
            btnPageQueixa.Text = "Queixa";
            btnPageQueixa.UseVisualStyleBackColor = false;
            btnPageQueixa.Click += btnPageQueixa_Click;
            // 
            // EnvioForm
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
            Controls.Add(btn_Inserir);
            Controls.Add(btn_Limpar);
            Controls.Add(txt_NIF_Utilizador);
            Controls.Add(txt_NSA_Queixa);
            Controls.Add(cb_Lista_Queixa);
            Controls.Add(label6);
            Controls.Add(Data_de_Envio);
            Controls.Add(txt_Referencia_Envio);
            Controls.Add(txt_NSA_Transporte);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EnvioForm";
            Text = "Gestão de Avarias - Envio";
            WindowState = FormWindowState.Maximized;
            Load += EnvioForm_Load;
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
        private TextBox txt_NSA_Transporte;
        private TextBox txt_Referencia_Envio;
        private DateTimePicker Data_de_Envio;
        private Label label6;
        private ComboBox cb_Lista_Queixa;
        private TextBox txt_NSA_Queixa;
        private TextBox txt_NIF_Utilizador;
        private Button btn_Limpar;
        private Button btn_Inserir;
        private Label Pesquisa;
        private Button btn_Limpar_Pesquisa;
        private TextBox txt_Buscar;
        private Button btn_Pesquisar;
        private ListView lstDados;
        private Panel panel1;
        private Button btn_Devolucao;
        private Button btn_Orcamento;
        private Button btn_home;
        private Button btn_Contato;
        private Button btnPageEquipamentos;
        private TextBox Gestao_De_Avaria;
        private Button btnPageBusca;
        private Button btnPageInsercao;
        private Button btnPageQueixa;
    }
}