namespace Pap
{
    partial class EquipRecebido
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
            cb_ListaDeQueixas = new ComboBox();
            dataDeEntrada = new DateTimePicker();
            txt_referencia = new TextBox();
            txt_NS = new TextBox();
            txt_TipoDeEquipamento = new TextBox();
            NS = new Label();
            label4 = new Label();
            NSA_Queixas = new Label();
            btn_Limpar = new Button();
            btn_Inserir = new Button();
            label5 = new Label();
            panel1 = new Panel();
            btnPage = new Button();
            textBox1 = new TextBox();
            btnPageBusca = new Button();
            btnPageHome = new Button();
            btnPageQueixa = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 346);
            label1.Name = "label1";
            label1.Size = new Size(210, 15);
            label1.TabIndex = 0;
            label1.Text = "Data de Equipamento Recebido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 301);
            label2.Name = "label2";
            label2.Size = new Size(252, 15);
            label2.TabIndex = 0;
            label2.Text = "Selecione a Queixa e o Equipamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 382);
            label3.Name = "label3";
            label3.Size = new Size(224, 15);
            label3.TabIndex = 0;
            label3.Text = "Referência da Queixa a Empresa:";
            // 
            // cb_ListaDeQueixas
            // 
            cb_ListaDeQueixas.FormattingEnabled = true;
            cb_ListaDeQueixas.Items.AddRange(new object[] { "Selecione um Equipamento" });
            cb_ListaDeQueixas.Location = new Point(272, 298);
            cb_ListaDeQueixas.Name = "cb_ListaDeQueixas";
            cb_ListaDeQueixas.Size = new Size(290, 23);
            cb_ListaDeQueixas.TabIndex = 3;
            // 
            // dataDeEntrada
            // 
            dataDeEntrada.Location = new Point(235, 340);
            dataDeEntrada.Name = "dataDeEntrada";
            dataDeEntrada.Size = new Size(207, 23);
            dataDeEntrada.TabIndex = 4;
            // 
            // txt_referencia
            // 
            txt_referencia.Location = new Point(244, 379);
            txt_referencia.Name = "txt_referencia";
            txt_referencia.Size = new Size(278, 23);
            txt_referencia.TabIndex = 5;
            // 
            // txt_NS
            // 
            txt_NS.Location = new Point(160, 256);
            txt_NS.Name = "txt_NS";
            txt_NS.Size = new Size(178, 23);
            txt_NS.TabIndex = 1;
            // 
            // txt_TipoDeEquipamento
            // 
            txt_TipoDeEquipamento.Location = new Point(500, 256);
            txt_TipoDeEquipamento.Name = "txt_TipoDeEquipamento";
            txt_TipoDeEquipamento.Size = new Size(178, 23);
            txt_TipoDeEquipamento.TabIndex = 2;
            // 
            // NS
            // 
            NS.AutoSize = true;
            NS.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NS.Location = new Point(14, 259);
            NS.Name = "NS";
            NS.Size = new Size(140, 15);
            NS.TabIndex = 0;
            NS.Text = "N-S do Equipamento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(347, 259);
            label4.Name = "label4";
            label4.Size = new Size(147, 15);
            label4.TabIndex = 0;
            label4.Text = "Tipo do Equipamento:";
            // 
            // NSA_Queixas
            // 
            NSA_Queixas.AutoSize = true;
            NSA_Queixas.Location = new Point(104, 223);
            NSA_Queixas.Name = "NSA_Queixas";
            NSA_Queixas.Size = new Size(0, 15);
            NSA_Queixas.TabIndex = 0;
            // 
            // btn_Limpar
            // 
            btn_Limpar.BackColor = Color.RoyalBlue;
            btn_Limpar.FlatStyle = FlatStyle.Flat;
            btn_Limpar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Limpar.ForeColor = Color.White;
            btn_Limpar.Location = new Point(347, 428);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(103, 35);
            btn_Limpar.TabIndex = 7;
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
            btn_Inserir.Location = new Point(121, 428);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(103, 35);
            btn_Inserir.TabIndex = 6;
            btn_Inserir.Text = "Inserir";
            btn_Inserir.UseVisualStyleBackColor = false;
            btn_Inserir.Click += btn_Inserir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 223);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 0;
            label5.Text = "NSA Queixa:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btnPage);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnPageBusca);
            panel1.Controls.Add(btnPageHome);
            panel1.Controls.Add(btnPageQueixa);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1372, 61);
            panel1.TabIndex = 0;
            // 
            // btnPage
            // 
            btnPage.FlatStyle = FlatStyle.Flat;
            btnPage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPage.Location = new Point(737, 17);
            btnPage.Name = "btnPage";
            btnPage.Size = new Size(176, 32);
            btnPage.TabIndex = 1;
            btnPage.Text = "Página de inserção";
            btnPage.UseVisualStyleBackColor = true;
            btnPage.Click += btnPage_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.RoyalBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 33);
            textBox1.TabIndex = 0;
            textBox1.Text = "Gestão de avarias";
            // 
            // btnPageBusca
            // 
            btnPageBusca.BackColor = Color.RoyalBlue;
            btnPageBusca.BackgroundImageLayout = ImageLayout.Center;
            btnPageBusca.FlatStyle = FlatStyle.Flat;
            btnPageBusca.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageBusca.Location = new Point(1020, 17);
            btnPageBusca.Name = "btnPageBusca";
            btnPageBusca.Size = new Size(156, 32);
            btnPageBusca.TabIndex = 3;
            btnPageBusca.Text = "Página de Busca";
            btnPageBusca.UseVisualStyleBackColor = false;
            btnPageBusca.Click += btnPageBusca_Click;
            // 
            // btnPageHome
            // 
            btnPageHome.FlatStyle = FlatStyle.Flat;
            btnPageHome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageHome.Location = new Point(1182, 17);
            btnPageHome.Name = "btnPageHome";
            btnPageHome.Size = new Size(176, 32);
            btnPageHome.TabIndex = 4;
            btnPageHome.Text = "Página de Inicial";
            btnPageHome.UseVisualStyleBackColor = true;
            btnPageHome.Click += btnPageHome_Click;
            // 
            // btnPageQueixa
            // 
            btnPageQueixa.BackColor = Color.RoyalBlue;
            btnPageQueixa.BackgroundImageLayout = ImageLayout.Center;
            btnPageQueixa.FlatStyle = FlatStyle.Flat;
            btnPageQueixa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageQueixa.Location = new Point(919, 17);
            btnPageQueixa.Name = "btnPageQueixa";
            btnPageQueixa.Size = new Size(95, 32);
            btnPageQueixa.TabIndex = 2;
            btnPageQueixa.Text = "Queixa";
            btnPageQueixa.UseVisualStyleBackColor = false;
            btnPageQueixa.Click += btnPageQueixa_Click;
            // 
            // EquipRecebido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(btn_Inserir);
            Controls.Add(btn_Limpar);
            Controls.Add(NSA_Queixas);
            Controls.Add(label4);
            Controls.Add(NS);
            Controls.Add(txt_TipoDeEquipamento);
            Controls.Add(txt_NS);
            Controls.Add(txt_referencia);
            Controls.Add(dataDeEntrada);
            Controls.Add(cb_ListaDeQueixas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EquipRecebido";
            Text = "Gestão de avarias - Formulário de Equipamentos";
            WindowState = FormWindowState.Minimized;
            Load += EquipRecebido_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cb_ListaDeQueixas;
        private DateTimePicker dataDeEntrada;
        private TextBox txt_referencia;
        private TextBox txt_NS;
        private TextBox txt_TipoDeEquipamento;
        private Label NS;
        private Label label4;
        private Label NSA_Queixas;
        private Button btn_Limpar;
        private Button btn_Inserir;
        private Label label5;
        private Panel panel1;
        private TextBox textBox1;
        private Button btnPageBusca;
        private Button btnPageHome;
        private Button btnPageQueixa;
        private Button btnPage;
    }
}