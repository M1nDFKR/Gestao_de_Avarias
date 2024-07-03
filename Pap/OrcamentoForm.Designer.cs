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
            painelPagamento.SuspendLayout();
            SuspendLayout();
            // 
            // cb_Lista_Queixa
            // 
            cb_Lista_Queixa.FormattingEnabled = true;
            cb_Lista_Queixa.Items.AddRange(new object[] { "Selecione a Queixa e o NIF" });
            cb_Lista_Queixa.Location = new Point(187, 198);
            cb_Lista_Queixa.Name = "cb_Lista_Queixa";
            cb_Lista_Queixa.Size = new Size(213, 23);
            cb_Lista_Queixa.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 117);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "NIF do Cliente:";
            // 
            // txt_NSA_Queixa
            // 
            txt_NSA_Queixa.Location = new Point(187, 154);
            txt_NSA_Queixa.Name = "txt_NSA_Queixa";
            txt_NSA_Queixa.ReadOnly = true;
            txt_NSA_Queixa.Size = new Size(36, 23);
            txt_NSA_Queixa.TabIndex = 2;
            // 
            // txt_NIF_Utilizador
            // 
            txt_NIF_Utilizador.Location = new Point(187, 114);
            txt_NIF_Utilizador.Name = "txt_NIF_Utilizador";
            txt_NIF_Utilizador.ReadOnly = true;
            txt_NIF_Utilizador.Size = new Size(130, 23);
            txt_NIF_Utilizador.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 157);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 4;
            label2.Text = "NSA da Queixa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 201);
            label3.Name = "label3";
            label3.Size = new Size(149, 15);
            label3.TabIndex = 5;
            label3.Text = "Selecione a Queixa e o NIF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 246);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 6;
            label4.Text = "Data do Orçamento:";
            // 
            // DataDoOrcamento
            // 
            DataDoOrcamento.Location = new Point(187, 240);
            DataDoOrcamento.Name = "DataDoOrcamento";
            DataDoOrcamento.Size = new Size(200, 23);
            DataDoOrcamento.TabIndex = 7;
            // 
            // DataDaResposta
            // 
            DataDaResposta.Location = new Point(614, 320);
            DataDaResposta.Name = "DataDaResposta";
            DataDaResposta.Size = new Size(200, 23);
            DataDaResposta.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(482, 326);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 8;
            label5.Text = "Data da Resposta:";
            // 
            // DataDePagamento
            // 
            DataDePagamento.Location = new Point(614, 460);
            DataDePagamento.Name = "DataDePagamento";
            DataDePagamento.Size = new Size(200, 23);
            DataDePagamento.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(482, 466);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 10;
            label6.Text = "Data de Pagamento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 296);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 12;
            label7.Text = "Comunicado:";
            // 
            // txt_Comunicado
            // 
            txt_Comunicado.Location = new Point(187, 293);
            txt_Comunicado.MaxLength = 255;
            txt_Comunicado.Name = "txt_Comunicado";
            txt_Comunicado.Size = new Size(263, 23);
            txt_Comunicado.TabIndex = 13;
            // 
            // txt_Forma_Comunicacao
            // 
            txt_Forma_Comunicacao.Location = new Point(187, 338);
            txt_Forma_Comunicacao.MaxLength = 50;
            txt_Forma_Comunicacao.Name = "txt_Forma_Comunicacao";
            txt_Forma_Comunicacao.Size = new Size(263, 23);
            txt_Forma_Comunicacao.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 341);
            label8.Name = "label8";
            label8.Size = new Size(137, 15);
            label8.TabIndex = 14;
            label8.Text = "Forma de Comunicação:";
            // 
            // richTxt_Resumo
            // 
            richTxt_Resumo.Location = new Point(187, 385);
            richTxt_Resumo.Name = "richTxt_Resumo";
            richTxt_Resumo.Size = new Size(263, 96);
            richTxt_Resumo.TabIndex = 16;
            richTxt_Resumo.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 388);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 17;
            label9.Text = "Resumo:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(475, 204);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 19;
            label10.Text = "Resposta:";
            // 
            // richTxt_Resposta
            // 
            richTxt_Resposta.Location = new Point(546, 198);
            richTxt_Resposta.Name = "richTxt_Resposta";
            richTxt_Resposta.Size = new Size(268, 96);
            richTxt_Resposta.TabIndex = 18;
            richTxt_Resposta.Text = "";
            // 
            // painelPagamento
            // 
            painelPagamento.Controls.Add(rb_Sim);
            painelPagamento.Controls.Add(rb_Nao);
            painelPagamento.Controls.Add(label11);
            painelPagamento.Location = new Point(473, 359);
            painelPagamento.Name = "painelPagamento";
            painelPagamento.Size = new Size(341, 84);
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
            label11.Location = new Point(9, 16);
            label11.Name = "label11";
            label11.Size = new Size(150, 15);
            label11.TabIndex = 0;
            label11.Text = "Foi efetuado o Pagamento:";
            // 
            // btn_Inserir
            // 
            btn_Inserir.Location = new Point(302, 556);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(112, 38);
            btn_Inserir.TabIndex = 21;
            btn_Inserir.Text = "Inserir";
            btn_Inserir.UseVisualStyleBackColor = true;
            btn_Inserir.Click += btn_Inserir_Click;
            // 
            // btn_Limpar
            // 
            btn_Limpar.Location = new Point(482, 556);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(114, 38);
            btn_Limpar.TabIndex = 22;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = true;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // OrcamentoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 748);
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
            Name = "OrcamentoForm";
            Text = "Formulário de Orçamento";
            WindowState = FormWindowState.Maximized;
            Load += OrcamentoForm_Load;
            painelPagamento.ResumeLayout(false);
            painelPagamento.PerformLayout();
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
    }
}