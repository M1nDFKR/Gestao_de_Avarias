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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 168);
            label1.Name = "label1";
            label1.Size = new Size(176, 15);
            label1.TabIndex = 0;
            label1.Text = "Data de Equipamento Recebido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(202, 15);
            label2.TabIndex = 1;
            label2.Text = "Selecione a Queixa e o Equipamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 204);
            label3.Name = "label3";
            label3.Size = new Size(178, 15);
            label3.TabIndex = 2;
            label3.Text = "Referência da Queixa a Empresa:";
            // 
            // cb_ListaDeQueixas
            // 
            cb_ListaDeQueixas.FormattingEnabled = true;
            cb_ListaDeQueixas.Items.AddRange(new object[] { "Selecione um Equipamento" });
            cb_ListaDeQueixas.Location = new Point(233, 120);
            cb_ListaDeQueixas.Name = "cb_ListaDeQueixas";
            cb_ListaDeQueixas.Size = new Size(278, 23);
            cb_ListaDeQueixas.TabIndex = 3;
            // 
            // dataDeEntrada
            // 
            dataDeEntrada.Location = new Point(233, 162);
            dataDeEntrada.Name = "dataDeEntrada";
            dataDeEntrada.Size = new Size(200, 23);
            dataDeEntrada.TabIndex = 4;
            // 
            // txt_referencia
            // 
            txt_referencia.Location = new Point(233, 201);
            txt_referencia.Name = "txt_referencia";
            txt_referencia.Size = new Size(278, 23);
            txt_referencia.TabIndex = 5;
            // 
            // txt_NS
            // 
            txt_NS.Location = new Point(148, 78);
            txt_NS.Name = "txt_NS";
            txt_NS.Size = new Size(178, 23);
            txt_NS.TabIndex = 6;
            // 
            // txt_TipoDeEquipamento
            // 
            txt_TipoDeEquipamento.Location = new Point(475, 78);
            txt_TipoDeEquipamento.Name = "txt_TipoDeEquipamento";
            txt_TipoDeEquipamento.Size = new Size(192, 23);
            txt_TipoDeEquipamento.TabIndex = 7;
            // 
            // NS
            // 
            NS.AutoSize = true;
            NS.Location = new Point(12, 81);
            NS.Name = "NS";
            NS.Size = new Size(121, 15);
            NS.TabIndex = 8;
            NS.Text = "N-S do Equipamento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(345, 81);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 9;
            label4.Text = "Tipo do Equipamento:";
            // 
            // NSA_Queixas
            // 
            NSA_Queixas.AutoSize = true;
            NSA_Queixas.Location = new Point(148, 45);
            NSA_Queixas.Name = "NSA_Queixas";
            NSA_Queixas.Size = new Size(0, 15);
            NSA_Queixas.TabIndex = 10;
            // 
            // btn_Limpar
            // 
            btn_Limpar.Location = new Point(119, 304);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(75, 23);
            btn_Limpar.TabIndex = 11;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = true;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // btn_Inserir
            // 
            btn_Inserir.Location = new Point(233, 304);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(75, 23);
            btn_Inserir.TabIndex = 12;
            btn_Inserir.Text = "Inserir";
            btn_Inserir.UseVisualStyleBackColor = true;
            btn_Inserir.Click += btn_Inserir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 45);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 13;
            label5.Text = "NSA Queixa:";
            // 
            // EquipRecebido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 566);
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
            Text = "Formulário de Equipamentos";
            Load += EquipRecebido_Load;
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
    }
}