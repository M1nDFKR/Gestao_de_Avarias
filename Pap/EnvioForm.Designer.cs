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
            txt_NSA_Transporter = new TextBox();
            txt_Referencia_Envio = new TextBox();
            Data_de_Envio = new DateTimePicker();
            label6 = new Label();
            cb_Lista_Queixa = new ComboBox();
            txt_NSA_Queixa = new TextBox();
            txt_NIF_Utilizador = new TextBox();
            btn_Limpar = new Button();
            btn_Inserir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 110);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "NIF Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 151);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "NSA Queixa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 188);
            label3.Name = "label3";
            label3.Size = new Size(253, 15);
            label3.TabIndex = 2;
            label3.Text = "Selecione a Queixa com o NIF correspondente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 230);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "Referência:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 269);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 4;
            label5.Text = "Data de Envio:";
            // 
            // txt_NSA_Transporter
            // 
            txt_NSA_Transporter.Location = new Point(278, 308);
            txt_NSA_Transporter.Name = "txt_NSA_Transporter";
            txt_NSA_Transporter.Size = new Size(171, 23);
            txt_NSA_Transporter.TabIndex = 5;
            // 
            // txt_Referencia_Envio
            // 
            txt_Referencia_Envio.Location = new Point(278, 227);
            txt_Referencia_Envio.Name = "txt_Referencia_Envio";
            txt_Referencia_Envio.Size = new Size(171, 23);
            txt_Referencia_Envio.TabIndex = 6;
            // 
            // Data_de_Envio
            // 
            Data_de_Envio.Location = new Point(278, 266);
            Data_de_Envio.Name = "Data_de_Envio";
            Data_de_Envio.Size = new Size(171, 23);
            Data_de_Envio.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 307);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 8;
            label6.Text = "NSA Transporte:";
            // 
            // cb_Lista_Queixa
            // 
            cb_Lista_Queixa.FormattingEnabled = true;
            cb_Lista_Queixa.Items.AddRange(new object[] { "Selecione a Queixa" });
            cb_Lista_Queixa.Location = new Point(278, 185);
            cb_Lista_Queixa.Name = "cb_Lista_Queixa";
            cb_Lista_Queixa.Size = new Size(171, 23);
            cb_Lista_Queixa.TabIndex = 9;
            // 
            // txt_NSA_Queixa
            // 
            txt_NSA_Queixa.Location = new Point(278, 148);
            txt_NSA_Queixa.Name = "txt_NSA_Queixa";
            txt_NSA_Queixa.ReadOnly = true;
            txt_NSA_Queixa.Size = new Size(35, 23);
            txt_NSA_Queixa.TabIndex = 10;
            // 
            // txt_NIF_Utilizador
            // 
            txt_NIF_Utilizador.Location = new Point(278, 107);
            txt_NIF_Utilizador.Name = "txt_NIF_Utilizador";
            txt_NIF_Utilizador.ReadOnly = true;
            txt_NIF_Utilizador.Size = new Size(171, 23);
            txt_NIF_Utilizador.TabIndex = 11;
            // 
            // btn_Limpar
            // 
            btn_Limpar.Location = new Point(146, 404);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(100, 37);
            btn_Limpar.TabIndex = 12;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = true;
            // 
            // btn_Inserir
            // 
            btn_Inserir.Location = new Point(278, 404);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(100, 37);
            btn_Inserir.TabIndex = 13;
            btn_Inserir.Text = "Inserir";
            btn_Inserir.UseVisualStyleBackColor = true;
            // 
            // EnvioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 543);
            Controls.Add(btn_Inserir);
            Controls.Add(btn_Limpar);
            Controls.Add(txt_NIF_Utilizador);
            Controls.Add(txt_NSA_Queixa);
            Controls.Add(cb_Lista_Queixa);
            Controls.Add(label6);
            Controls.Add(Data_de_Envio);
            Controls.Add(txt_Referencia_Envio);
            Controls.Add(txt_NSA_Transporter);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EnvioForm";
            Text = "Formulário de Envio";
            Load += EnvioForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_NSA_Transporter;
        private TextBox txt_Referencia_Envio;
        private DateTimePicker Data_de_Envio;
        private Label label6;
        private ComboBox cb_Lista_Queixa;
        private TextBox txt_NSA_Queixa;
        private TextBox txt_NIF_Utilizador;
        private Button btn_Limpar;
        private Button btn_Inserir;
    }
}