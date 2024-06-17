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
            label3 = new Label();
            label4 = new Label();
            cb_listaClientes = new ComboBox();
            label5 = new Label();
            btn_Limpar = new Button();
            btn_Inserir = new Button();
            TipoEquip = new Label();
            N_S = new Label();
            DtQueixa = new Label();
            Descricao = new Label();
            Decisao = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Location = new Point(99, 37);
            textNome.Name = "textNome";
            textNome.ReadOnly = true;
            textNome.Size = new Size(136, 23);
            textNome.TabIndex = 0;
            // 
            // textNIF
            // 
            textNIF.Location = new Point(327, 37);
            textNIF.Name = "textNIF";
            textNIF.ReadOnly = true;
            textNIF.Size = new Size(136, 23);
            textNIF.TabIndex = 1;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(16, 40);
            Nome.Name = "Nome";
            Nome.Size = new Size(43, 15);
            Nome.TabIndex = 2;
            Nome.Text = "Nome:";
            // 
            // NIF
            // 
            NIF.AutoSize = true;
            NIF.Location = new Point(274, 40);
            NIF.Name = "NIF";
            NIF.Size = new Size(28, 15);
            NIF.TabIndex = 2;
            NIF.Text = "NIF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(242, 23);
            label3.TabIndex = 3;
            label3.Text = "Continuar Quiexa do Cliente.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 84);
            label4.Name = "label4";
            label4.Size = new Size(291, 23);
            label4.TabIndex = 3;
            label4.Text = "Inserir Queixa do cliente desejado.:";
            // 
            // cb_listaClientes
            // 
            cb_listaClientes.FormattingEnabled = true;
            cb_listaClientes.Items.AddRange(new object[] { "Selecione um Cliente" });
            cb_listaClientes.Location = new Point(172, 122);
            cb_listaClientes.Name = "cb_listaClientes";
            cb_listaClientes.Size = new Size(301, 23);
            cb_listaClientes.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 130);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 5;
            label5.Text = "Clientes:";
            // 
            // btn_Limpar
            // 
            btn_Limpar.Location = new Point(284, 466);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(179, 34);
            btn_Limpar.TabIndex = 6;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = true;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // btn_Inserir
            // 
            btn_Inserir.Location = new Point(99, 466);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(168, 34);
            btn_Inserir.TabIndex = 7;
            btn_Inserir.Text = "Inserir";
            btn_Inserir.UseVisualStyleBackColor = true;
            btn_Inserir.Click += btn_Inserir_Click;
            // 
            // TipoEquip
            // 
            TipoEquip.AutoSize = true;
            TipoEquip.Location = new Point(21, 170);
            TipoEquip.Name = "TipoEquip";
            TipoEquip.Size = new Size(123, 15);
            TipoEquip.TabIndex = 8;
            TipoEquip.Text = "Tipo de Equipamento:";
            // 
            // N_S
            // 
            N_S.AutoSize = true;
            N_S.Location = new Point(21, 213);
            N_S.Name = "N_S";
            N_S.Size = new Size(30, 15);
            N_S.TabIndex = 9;
            N_S.Text = "N-S:";
            // 
            // DtQueixa
            // 
            DtQueixa.AutoSize = true;
            DtQueixa.Location = new Point(21, 256);
            DtQueixa.Name = "DtQueixa";
            DtQueixa.Size = new Size(90, 15);
            DtQueixa.TabIndex = 10;
            DtQueixa.Text = "Data da Queixa:";
            // 
            // Descricao
            // 
            Descricao.AutoSize = true;
            Descricao.Location = new Point(21, 303);
            Descricao.Name = "Descricao";
            Descricao.Size = new Size(61, 15);
            Descricao.TabIndex = 11;
            Descricao.Text = "Descrição:";
            // 
            // Decisao
            // 
            Decisao.AutoSize = true;
            Decisao.Location = new Point(21, 348);
            Decisao.Name = "Decisao";
            Decisao.Size = new Size(51, 15);
            Decisao.TabIndex = 12;
            Decisao.Text = "Decisão:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 167);
            textBox1.MaxLength = 255;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 23);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 205);
            textBox2.MaxLength = 255;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(301, 23);
            textBox2.TabIndex = 14;
            // 
            // QueixaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 538);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Decisao);
            Controls.Add(Descricao);
            Controls.Add(DtQueixa);
            Controls.Add(N_S);
            Controls.Add(TipoEquip);
            Controls.Add(btn_Inserir);
            Controls.Add(btn_Limpar);
            Controls.Add(label5);
            Controls.Add(cb_listaClientes);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(NIF);
            Controls.Add(Nome);
            Controls.Add(textNIF);
            Controls.Add(textNome);
            Name = "QueixaForm";
            Text = "Formulário de Queixa";
            Load += QueixaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNome;
        private TextBox textNIF;
        private Label Nome;
        private Label NIF;
        private Label label3;
        private Label label4;
        private ComboBox cb_listaClientes;
        private Label label5;
        private Button btn_Limpar;
        private Button btn_Inserir;
        private Label TipoEquip;
        private Label N_S;
        private Label DtQueixa;
        private Label Descricao;
        private Label Decisao;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}