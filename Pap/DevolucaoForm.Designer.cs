namespace Pap
{
    partial class DevolucaoForm
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
            label6 = new Label();
            btn_Inserir = new Button();
            btn_Limpar = new Button();
            DataDeDevolucao = new DateTimePicker();
            DataDeEntrega = new DateTimePicker();
            cb_Lista_NSA_NIF_NIFEE = new ComboBox();
            txt_NIFEE = new TextBox();
            txt_NIF = new TextBox();
            txt_NSA_Queixa = new TextBox();
            lstDados = new ListView();
            label7 = new Label();
            txt_Buscar = new TextBox();
            btn_Pesquisar = new Button();
            btn_Limpar_Pesquisa = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 156);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "NSA Queixa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 217);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "NIF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 265);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "NIFEE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 316);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 3;
            label4.Text = "Selecione o dados:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 378);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 4;
            label5.Text = "Data de Devolução:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 435);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 5;
            label6.Text = "Data de Entrega:";
            // 
            // btn_Inserir
            // 
            btn_Inserir.Location = new Point(152, 508);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(116, 37);
            btn_Inserir.TabIndex = 6;
            btn_Inserir.Text = "Inserir";
            btn_Inserir.UseVisualStyleBackColor = true;
            btn_Inserir.Click += btn_Inserir_Click;
            // 
            // btn_Limpar
            // 
            btn_Limpar.Location = new Point(319, 508);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(116, 37);
            btn_Limpar.TabIndex = 7;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = true;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // DataDeDevolucao
            // 
            DataDeDevolucao.Location = new Point(152, 372);
            DataDeDevolucao.Name = "DataDeDevolucao";
            DataDeDevolucao.Size = new Size(200, 23);
            DataDeDevolucao.TabIndex = 8;
            // 
            // DataDeEntrega
            // 
            DataDeEntrega.Location = new Point(152, 429);
            DataDeEntrega.Name = "DataDeEntrega";
            DataDeEntrega.Size = new Size(200, 23);
            DataDeEntrega.TabIndex = 9;
            // 
            // cb_Lista_NSA_NIF_NIFEE
            // 
            cb_Lista_NSA_NIF_NIFEE.FormattingEnabled = true;
            cb_Lista_NSA_NIF_NIFEE.Items.AddRange(new object[] { "Selecione o NSA da Queixa o NIF e o NIFEE" });
            cb_Lista_NSA_NIF_NIFEE.Location = new Point(152, 313);
            cb_Lista_NSA_NIF_NIFEE.Name = "cb_Lista_NSA_NIF_NIFEE";
            cb_Lista_NSA_NIF_NIFEE.Size = new Size(266, 23);
            cb_Lista_NSA_NIF_NIFEE.TabIndex = 10;
            // 
            // txt_NIFEE
            // 
            txt_NIFEE.Location = new Point(152, 262);
            txt_NIFEE.Name = "txt_NIFEE";
            txt_NIFEE.ReadOnly = true;
            txt_NIFEE.Size = new Size(200, 23);
            txt_NIFEE.TabIndex = 11;
            // 
            // txt_NIF
            // 
            txt_NIF.Location = new Point(152, 214);
            txt_NIF.Name = "txt_NIF";
            txt_NIF.ReadOnly = true;
            txt_NIF.Size = new Size(200, 23);
            txt_NIF.TabIndex = 12;
            // 
            // txt_NSA_Queixa
            // 
            txt_NSA_Queixa.Location = new Point(152, 153);
            txt_NSA_Queixa.Name = "txt_NSA_Queixa";
            txt_NSA_Queixa.ReadOnly = true;
            txt_NSA_Queixa.Size = new Size(55, 23);
            txt_NSA_Queixa.TabIndex = 13;
            // 
            // lstDados
            // 
            lstDados.Location = new Point(490, 179);
            lstDados.Name = "lstDados";
            lstDados.Size = new Size(868, 558);
            lstDados.TabIndex = 14;
            lstDados.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(491, 151);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 15;
            label7.Text = "Pesquisar:";
            // 
            // txt_Buscar
            // 
            txt_Buscar.Location = new Point(593, 150);
            txt_Buscar.Name = "txt_Buscar";
            txt_Buscar.Size = new Size(463, 23);
            txt_Buscar.TabIndex = 16;
            // 
            // btn_Pesquisar
            // 
            btn_Pesquisar.Location = new Point(1088, 142);
            btn_Pesquisar.Name = "btn_Pesquisar";
            btn_Pesquisar.Size = new Size(118, 33);
            btn_Pesquisar.TabIndex = 17;
            btn_Pesquisar.Text = "Pesquisar";
            btn_Pesquisar.UseVisualStyleBackColor = true;
            btn_Pesquisar.Click += btn_Pesquisar_Click;
            // 
            // btn_Limpar_Pesquisa
            // 
            btn_Limpar_Pesquisa.Location = new Point(1212, 142);
            btn_Limpar_Pesquisa.Name = "btn_Limpar_Pesquisa";
            btn_Limpar_Pesquisa.Size = new Size(118, 33);
            btn_Limpar_Pesquisa.TabIndex = 18;
            btn_Limpar_Pesquisa.Text = "Limpar";
            btn_Limpar_Pesquisa.UseVisualStyleBackColor = true;
            btn_Limpar_Pesquisa.Click += btn_Limpar_Pesquisa_Click;
            // 
            // DevolucaoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(btn_Limpar_Pesquisa);
            Controls.Add(btn_Pesquisar);
            Controls.Add(txt_Buscar);
            Controls.Add(label7);
            Controls.Add(lstDados);
            Controls.Add(txt_NSA_Queixa);
            Controls.Add(txt_NIF);
            Controls.Add(txt_NIFEE);
            Controls.Add(cb_Lista_NSA_NIF_NIFEE);
            Controls.Add(DataDeEntrega);
            Controls.Add(DataDeDevolucao);
            Controls.Add(btn_Limpar);
            Controls.Add(btn_Inserir);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DevolucaoForm";
            Text = "Formulário de Devolução";
            WindowState = FormWindowState.Maximized;
            Load += DevolucaoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_Inserir;
        private Button btn_Limpar;
        private DateTimePicker DataDeDevolucao;
        private DateTimePicker DataDeEntrega;
        private ComboBox cb_Lista_NSA_NIF_NIFEE;
        private TextBox txt_NIFEE;
        private TextBox txt_NIF;
        private TextBox txt_NSA_Queixa;
        private ListView lstDados;
        private Label label7;
        private TextBox txt_Buscar;
        private Button btn_Pesquisar;
        private Button btn_Limpar_Pesquisa;
    }
}