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
            SuspendLayout();
            // 
            // dataDeContato
            // 
            dataDeContato.Location = new Point(169, 239);
            dataDeContato.Name = "dataDeContato";
            dataDeContato.Size = new Size(193, 23);
            dataDeContato.TabIndex = 0;
            dataDeContato.Value = new DateTime(2024, 6, 24, 15, 42, 35, 0);
            // 
            // maskedTextHora
            // 
            maskedTextHora.Location = new Point(170, 284);
            maskedTextHora.Mask = "90:00";
            maskedTextHora.Name = "maskedTextHora";
            maskedTextHora.Size = new Size(39, 23);
            maskedTextHora.TabIndex = 1;
            maskedTextHora.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 91);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "NSA Queixa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 3;
            label2.Text = "NIF do Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 169);
            label3.Name = "label3";
            label3.Size = new Size(149, 15);
            label3.TabIndex = 4;
            label3.Text = "Selecione a Queixa e o NIF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 206);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 5;
            label4.Text = "NSA da Empresa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 245);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 6;
            label5.Text = "Data de Contato:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 287);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 7;
            label6.Text = "Hora de Contato";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 333);
            label7.Name = "label7";
            label7.Size = new Size(116, 15);
            label7.TabIndex = 8;
            label7.Text = "Resumo do Contato:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 464);
            label8.Name = "label8";
            label8.Size = new Size(106, 15);
            label8.TabIndex = 9;
            label8.Text = "Forma de Contato:";
            // 
            // txt_NSA_Empresa
            // 
            txt_NSA_Empresa.Location = new Point(169, 203);
            txt_NSA_Empresa.Name = "txt_NSA_Empresa";
            txt_NSA_Empresa.Size = new Size(246, 23);
            txt_NSA_Empresa.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 522);
            label9.Name = "label9";
            label9.Size = new Size(93, 15);
            label9.TabIndex = 11;
            label9.Text = "Info de Contato:";
            // 
            // cb_Lista_Queixa_NIF
            // 
            cb_Lista_Queixa_NIF.FormattingEnabled = true;
            cb_Lista_Queixa_NIF.Items.AddRange(new object[] { "Selecione a Queixa" });
            cb_Lista_Queixa_NIF.Location = new Point(169, 166);
            cb_Lista_Queixa_NIF.Name = "cb_Lista_Queixa_NIF";
            cb_Lista_Queixa_NIF.Size = new Size(246, 23);
            cb_Lista_Queixa_NIF.TabIndex = 12;
            // 
            // txt_NIF_Utilizador
            // 
            txt_NIF_Utilizador.Location = new Point(170, 128);
            txt_NIF_Utilizador.Name = "txt_NIF_Utilizador";
            txt_NIF_Utilizador.ReadOnly = true;
            txt_NIF_Utilizador.Size = new Size(246, 23);
            txt_NIF_Utilizador.TabIndex = 13;
            // 
            // NSA_Queixa
            // 
            NSA_Queixa.AutoSize = true;
            NSA_Queixa.Location = new Point(170, 91);
            NSA_Queixa.Name = "NSA_Queixa";
            NSA_Queixa.Size = new Size(0, 15);
            NSA_Queixa.TabIndex = 14;
            // 
            // richTextResumo
            // 
            richTextResumo.Location = new Point(169, 330);
            richTextResumo.MaxLength = 255;
            richTextResumo.Name = "richTextResumo";
            richTextResumo.Size = new Size(245, 107);
            richTextResumo.TabIndex = 15;
            richTextResumo.Text = "";
            // 
            // txt_Forma
            // 
            txt_Forma.Location = new Point(170, 461);
            txt_Forma.MaxLength = 50;
            txt_Forma.Name = "txt_Forma";
            txt_Forma.Size = new Size(246, 23);
            txt_Forma.TabIndex = 16;
            // 
            // richTextInfoContato
            // 
            richTextInfoContato.Location = new Point(169, 519);
            richTextInfoContato.Name = "richTextInfoContato";
            richTextInfoContato.Size = new Size(245, 108);
            richTextInfoContato.TabIndex = 17;
            richTextInfoContato.Text = "";
            // 
            // btn_Limpar
            // 
            btn_Limpar.Location = new Point(165, 655);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(133, 39);
            btn_Limpar.TabIndex = 18;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = true;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // btn_Inserir
            // 
            btn_Inserir.Location = new Point(330, 655);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(133, 39);
            btn_Inserir.TabIndex = 19;
            btn_Inserir.Text = "Inserir";
            btn_Inserir.UseVisualStyleBackColor = true;
            btn_Inserir.Click += btn_Inserir_Click;
            // 
            // ContatoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 718);
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
            Load += ContatoForm_Load;
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
    }
}