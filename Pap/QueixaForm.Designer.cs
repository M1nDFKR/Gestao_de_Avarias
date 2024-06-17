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
            // ContinuarQueixa
            // 
            ContinuarQueixa.AutoSize = true;
            ContinuarQueixa.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContinuarQueixa.Location = new Point(12, 9);
            ContinuarQueixa.Name = "ContinuarQueixa";
            ContinuarQueixa.Size = new Size(242, 23);
            ContinuarQueixa.TabIndex = 3;
            ContinuarQueixa.Text = "Continuar Quiexa do Cliente.:";
            // 
            // EscolherCliente
            // 
            EscolherCliente.AutoSize = true;
            EscolherCliente.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EscolherCliente.Location = new Point(12, 84);
            EscolherCliente.Name = "EscolherCliente";
            EscolherCliente.Size = new Size(291, 23);
            EscolherCliente.TabIndex = 3;
            EscolherCliente.Text = "Inserir Queixa do cliente desejado.:";
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
            // Clientes
            // 
            Clientes.AutoSize = true;
            Clientes.Location = new Point(21, 130);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(52, 15);
            Clientes.TabIndex = 5;
            Clientes.Text = "Clientes:";
            // 
            // btn_Limpar
            // 
            btn_Limpar.Location = new Point(284, 492);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(179, 34);
            btn_Limpar.TabIndex = 6;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = true;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // btn_Inserir
            // 
            btn_Inserir.Location = new Point(99, 492);
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
            Descricao.Location = new Point(21, 300);
            Descricao.Name = "Descricao";
            Descricao.Size = new Size(61, 15);
            Descricao.TabIndex = 11;
            Descricao.Text = "Descrição:";
            // 
            // Decisao
            // 
            Decisao.AutoSize = true;
            Decisao.Location = new Point(21, 388);
            Decisao.Name = "Decisao";
            Decisao.Size = new Size(51, 15);
            Decisao.TabIndex = 12;
            Decisao.Text = "Decisão:";
            // 
            // textTipoEquip
            // 
            textTipoEquip.Location = new Point(172, 167);
            textTipoEquip.MaxLength = 255;
            textTipoEquip.Name = "textTipoEquip";
            textTipoEquip.Size = new Size(301, 23);
            textTipoEquip.TabIndex = 13;
            // 
            // textN_S
            // 
            textN_S.Location = new Point(172, 205);
            textN_S.MaxLength = 255;
            textN_S.Name = "textN_S";
            textN_S.Size = new Size(301, 23);
            textN_S.TabIndex = 14;
            // 
            // dateQueixa
            // 
            dateQueixa.Location = new Point(172, 250);
            dateQueixa.Name = "dateQueixa";
            dateQueixa.Size = new Size(176, 23);
            dateQueixa.TabIndex = 15;
            // 
            // richTextDescricao
            // 
            richTextDescricao.Location = new Point(171, 300);
            richTextDescricao.Name = "richTextDescricao";
            richTextDescricao.Size = new Size(302, 79);
            richTextDescricao.TabIndex = 16;
            richTextDescricao.Text = "";
            // 
            // richTextDecisao
            // 
            richTextDecisao.Location = new Point(171, 388);
            richTextDecisao.Name = "richTextDecisao";
            richTextDecisao.Size = new Size(302, 85);
            richTextDecisao.TabIndex = 17;
            richTextDecisao.Text = "";
            // 
            // QueixaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 564);
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
            Load += QueixaForm_Load;
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
    }
}