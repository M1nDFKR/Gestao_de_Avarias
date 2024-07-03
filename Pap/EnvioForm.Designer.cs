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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 133);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "NIF Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 174);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "NSA Queixa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 211);
            label3.Name = "label3";
            label3.Size = new Size(253, 15);
            label3.TabIndex = 2;
            label3.Text = "Selecione a Queixa com o NIF correspondente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 253);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "Referência:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 292);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
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
            label6.Location = new Point(18, 330);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 8;
            label6.Text = "NSA Transporte:";
            // 
            // cb_Lista_Queixa
            // 
            cb_Lista_Queixa.FormattingEnabled = true;
            cb_Lista_Queixa.Items.AddRange(new object[] { "Selecione a Queixa" });
            cb_Lista_Queixa.Location = new Point(284, 208);
            cb_Lista_Queixa.Name = "cb_Lista_Queixa";
            cb_Lista_Queixa.Size = new Size(171, 23);
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
            btn_Limpar.Location = new Point(152, 427);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(100, 37);
            btn_Limpar.TabIndex = 12;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = true;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // btn_Inserir
            // 
            btn_Inserir.Location = new Point(284, 427);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(100, 37);
            btn_Inserir.TabIndex = 13;
            btn_Inserir.Text = "Inserir";
            btn_Inserir.UseVisualStyleBackColor = true;
            btn_Inserir.Click += btn_Inserir_Click;
            // 
            // Pesquisa
            // 
            Pesquisa.AutoSize = true;
            Pesquisa.Location = new Point(504, 131);
            Pesquisa.Name = "Pesquisa";
            Pesquisa.Size = new Size(60, 15);
            Pesquisa.TabIndex = 37;
            Pesquisa.Text = "Pesquisar:";
            // 
            // btn_Limpar_Pesquisa
            // 
            btn_Limpar_Pesquisa.Location = new Point(1179, 124);
            btn_Limpar_Pesquisa.Name = "btn_Limpar_Pesquisa";
            btn_Limpar_Pesquisa.Size = new Size(132, 29);
            btn_Limpar_Pesquisa.TabIndex = 36;
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
            txt_Buscar.TabIndex = 35;
            // 
            // btn_Pesquisar
            // 
            btn_Pesquisar.Location = new Point(1041, 124);
            btn_Pesquisar.Name = "btn_Pesquisar";
            btn_Pesquisar.Size = new Size(132, 29);
            btn_Pesquisar.TabIndex = 34;
            btn_Pesquisar.Text = "Pesquisar";
            btn_Pesquisar.UseVisualStyleBackColor = true;
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
            // EnvioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
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
            Text = "Formulário de Envio";
            WindowState = FormWindowState.Maximized;
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
    }
}