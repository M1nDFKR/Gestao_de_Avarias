namespace Pap
{
    partial class ContatoForm
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
            dataDeContato = new DateTimePicker();
            maskedTextHora = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_NSA_Empresa = new TextBox();
            label9 = new Label();
            cb_Lista_Queixa_NIF = new ComboBox();
            txt_NIF_Utilizador = new TextBox();
            NSA_Queixa = new Label();
            richTextResumo = new RichTextBox();
            txt_Forma = new TextBox();
            richTextInfoContato = new RichTextBox();
            btn_Limpar = new Button();
            btn_Inserir = new Button();
            panel1 = new Panel();
            btnPageQueixa = new Button();
            btnPageEquipamentos = new Button();
            textBox1 = new TextBox();
            btnPageBusca = new Button();
            btnPageInsercao = new Button();
            btnPageHome = new Button();
            Pesquisa = new Label();
            btn_Limpar_Pesquisa = new Button();
            txt_Buscar = new TextBox();
            btn_Pesquisar = new Button();
            lstDados = new ListView();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataDeContato
            // 
            dataDeContato.Location = new Point(169, 239);
            dataDeContato.Name = "dataDeContato";
            dataDeContato.Size = new Size(193, 23);
            dataDeContato.TabIndex = 5;
            dataDeContato.Value = new DateTime(2024, 6, 24, 15, 42, 35, 0);
            // 
            // maskedTextHora
            // 
            maskedTextHora.Location = new Point(170, 284);
            maskedTextHora.Mask = "90:00";
            maskedTextHora.Name = "maskedTextHora";
            maskedTextHora.Size = new Size(49, 23);
            maskedTextHora.TabIndex = 6;
            maskedTextHora.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 91);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "NSA Queixa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 0;
            label2.Text = "NIF do Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 169);
            label3.Name = "label3";
            label3.Size = new Size(196, 15);
            label3.TabIndex = 0;
            label3.Text = "Selecione a Queixa e o NIF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 206);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 0;
            label4.Text = "NSA da Empresa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 245);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 0;
            label5.Text = "Data de Contato:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 287);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 0;
            label6.Text = "Hora de Contato";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 333);
            label7.Name = "label7";
            label7.Size = new Size(133, 15);
            label7.TabIndex = 0;
            label7.Text = "Resumo do Contato:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 464);
            label8.Name = "label8";
            label8.Size = new Size(126, 15);
            label8.TabIndex = 0;
            label8.Text = "Forma de Contato:";
            // 
            // txt_NSA_Empresa
            // 
            txt_NSA_Empresa.Location = new Point(169, 203);
            txt_NSA_Empresa.Name = "txt_NSA_Empresa";
            txt_NSA_Empresa.Size = new Size(281, 23);
            txt_NSA_Empresa.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 522);
            label9.Name = "label9";
            label9.Size = new Size(119, 15);
            label9.TabIndex = 0;
            label9.Text = "Info de Contato:";
            // 
            // cb_Lista_Queixa_NIF
            // 
            cb_Lista_Queixa_NIF.FormattingEnabled = true;
            cb_Lista_Queixa_NIF.Items.AddRange(new object[] { "Selecione a Queixa" });
            cb_Lista_Queixa_NIF.Location = new Point(204, 166);
            cb_Lista_Queixa_NIF.Name = "cb_Lista_Queixa_NIF";
            cb_Lista_Queixa_NIF.Size = new Size(246, 23);
            cb_Lista_Queixa_NIF.TabIndex = 3;
            // 
            // txt_NIF_Utilizador
            // 
            txt_NIF_Utilizador.Location = new Point(170, 128);
            txt_NIF_Utilizador.Name = "txt_NIF_Utilizador";
            txt_NIF_Utilizador.ReadOnly = true;
            txt_NIF_Utilizador.Size = new Size(280, 23);
            txt_NIF_Utilizador.TabIndex = 2;
            // 
            // NSA_Queixa
            // 
            NSA_Queixa.AutoSize = true;
            NSA_Queixa.Location = new Point(170, 91);
            NSA_Queixa.Name = "NSA_Queixa";
            NSA_Queixa.Size = new Size(0, 15);
            NSA_Queixa.TabIndex = 1;
            // 
            // richTextResumo
            // 
            richTextResumo.Location = new Point(169, 330);
            richTextResumo.MaxLength = 255;
            richTextResumo.Name = "richTextResumo";
            richTextResumo.Size = new Size(281, 107);
            richTextResumo.TabIndex = 7;
            richTextResumo.Text = "";
            // 
            // txt_Forma
            // 
            txt_Forma.Location = new Point(170, 461);
            txt_Forma.MaxLength = 50;
            txt_Forma.Name = "txt_Forma";
            txt_Forma.Size = new Size(280, 23);
            txt_Forma.TabIndex = 8;
            // 
            // richTextInfoContato
            // 
            richTextInfoContato.Location = new Point(169, 519);
            richTextInfoContato.Name = "richTextInfoContato";
            richTextInfoContato.Size = new Size(281, 108);
            richTextInfoContato.TabIndex = 9;
            richTextInfoContato.Text = "";
            // 
            // btn_Limpar
            // 
            btn_Limpar.BackColor = Color.RoyalBlue;
            btn_Limpar.FlatStyle = FlatStyle.Flat;
            btn_Limpar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Limpar.ForeColor = Color.White;
            btn_Limpar.Location = new Point(165, 655);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(133, 39);
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
            btn_Inserir.Location = new Point(330, 655);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(133, 39);
            btn_Inserir.TabIndex = 11;
            btn_Inserir.Text = "Inserir";
            btn_Inserir.UseVisualStyleBackColor = false;
            btn_Inserir.Click += btn_Inserir_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btnPageQueixa);
            panel1.Controls.Add(btnPageEquipamentos);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnPageBusca);
            panel1.Controls.Add(btnPageInsercao);
            panel1.Controls.Add(btnPageHome);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1376, 59);
            panel1.TabIndex = 0;
            // 
            // btnPageQueixa
            // 
            btnPageQueixa.BackColor = Color.RoyalBlue;
            btnPageQueixa.BackgroundImageLayout = ImageLayout.Center;
            btnPageQueixa.FlatStyle = FlatStyle.Flat;
            btnPageQueixa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageQueixa.Location = new Point(839, 17);
            btnPageQueixa.Name = "btnPageQueixa";
            btnPageQueixa.Size = new Size(79, 32);
            btnPageQueixa.TabIndex = 2;
            btnPageQueixa.Text = "Queixa";
            btnPageQueixa.UseVisualStyleBackColor = false;
            btnPageQueixa.Click += btnPageQueixa_Click;
            // 
            // btnPageEquipamentos
            // 
            btnPageEquipamentos.FlatStyle = FlatStyle.Flat;
            btnPageEquipamentos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageEquipamentos.Location = new Point(698, 17);
            btnPageEquipamentos.Name = "btnPageEquipamentos";
            btnPageEquipamentos.Size = new Size(135, 32);
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
            btnPageBusca.Location = new Point(1092, 17);
            btnPageBusca.Name = "btnPageBusca";
            btnPageBusca.Size = new Size(144, 32);
            btnPageBusca.TabIndex = 4;
            btnPageBusca.Text = "Página de Busca";
            btnPageBusca.UseVisualStyleBackColor = false;
            btnPageBusca.Click += btnPageBusca_Click;
            // 
            // btnPageInsercao
            // 
            btnPageInsercao.FlatStyle = FlatStyle.Flat;
            btnPageInsercao.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageInsercao.Location = new Point(924, 17);
            btnPageInsercao.Name = "btnPageInsercao";
            btnPageInsercao.Size = new Size(162, 32);
            btnPageInsercao.TabIndex = 3;
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
            btnPageHome.TabIndex = 5;
            btnPageHome.Text = "Página Inicial";
            btnPageHome.UseVisualStyleBackColor = false;
            btnPageHome.Click += btnPageHome_Click;
            // 
            // Pesquisa
            // 
            Pesquisa.AutoSize = true;
            Pesquisa.Location = new Point(504, 131);
            Pesquisa.Name = "Pesquisa";
            Pesquisa.Size = new Size(60, 15);
            Pesquisa.TabIndex = 32;
            Pesquisa.Text = "Pesquisar:";
            // 
            // btn_Limpar_Pesquisa
            // 
            btn_Limpar_Pesquisa.Location = new Point(1179, 124);
            btn_Limpar_Pesquisa.Name = "btn_Limpar_Pesquisa";
            btn_Limpar_Pesquisa.Size = new Size(132, 29);
            btn_Limpar_Pesquisa.TabIndex = 31;
            btn_Limpar_Pesquisa.Text = "Limpar";
            btn_Limpar_Pesquisa.UseVisualStyleBackColor = true;
            btn_Limpar_Pesquisa.Click += btn_Limpar_Pesquisa_Click;
            // 
            // txt_Buscar
            // 
            txt_Buscar.Location = new Point(610, 128);
            txt_Buscar.MaxLength = 255;
            txt_Buscar.Name = "txt_Buscar";
            txt_Buscar.Size = new Size(425, 23);
            txt_Buscar.TabIndex = 30;
            // 
            // btn_Pesquisar
            // 
            btn_Pesquisar.Location = new Point(1041, 124);
            btn_Pesquisar.Name = "btn_Pesquisar";
            btn_Pesquisar.Size = new Size(132, 29);
            btn_Pesquisar.TabIndex = 29;
            btn_Pesquisar.Text = "Pesquisar";
            btn_Pesquisar.UseVisualStyleBackColor = true;
            btn_Pesquisar.Click += btn_Pesquisar_Click;
            // 
            // lstDados
            // 
            lstDados.Location = new Point(507, 159);
            lstDados.Name = "lstDados";
            lstDados.Size = new Size(851, 578);
            lstDados.TabIndex = 28;
            lstDados.UseCompatibleStateImageBehavior = false;
            // 
            // ContatoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(Pesquisa);
            Controls.Add(btn_Limpar_Pesquisa);
            Controls.Add(txt_Buscar);
            Controls.Add(btn_Pesquisar);
            Controls.Add(lstDados);
            Controls.Add(panel1);
            Controls.Add(btn_Inserir);
            Controls.Add(btn_Limpar);
            Controls.Add(richTextInfoContato);
            Controls.Add(txt_Forma);
            Controls.Add(richTextResumo);
            Controls.Add(NSA_Queixa);
            Controls.Add(txt_NIF_Utilizador);
            Controls.Add(cb_Lista_Queixa_NIF);
            Controls.Add(label9);
            Controls.Add(txt_NSA_Empresa);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextHora);
            Controls.Add(dataDeContato);
            Name = "ContatoForm";
            Text = "Formulário de Contato";
            WindowState = FormWindowState.Maximized;
            Load += ContatoForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dataDeContato;
        private MaskedTextBox maskedTextHora;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_NSA_Empresa;
        private Label label9;
        private ComboBox cb_Lista_Queixa_NIF;
        private TextBox txt_NIF_Utilizador;
        private Label NSA_Queixa;
        private RichTextBox richTextResumo;
        private TextBox txt_Forma;
        private RichTextBox richTextInfoContato;
        private Button btn_Limpar;
        private Button btn_Inserir;
        private Panel panel1;
        private Button btnPageEquipamentos;
        private TextBox textBox1;
        private Button btnPageBusca;
        private Button btnPageInsercao;
        private Button btnPageHome;
        private Button btnPageQueixa;
        private Label Pesquisa;
        private Button btn_Limpar_Pesquisa;
        private TextBox txt_Buscar;
        private Button btn_Pesquisar;
        private ListView lstDados;
    }
}