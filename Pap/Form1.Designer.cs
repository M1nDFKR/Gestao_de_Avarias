namespace Pap
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NIF = new Label();
            textNome = new TextBox();
            Nome = new Label();
            Processo = new Label();
            textProcesso = new TextBox();
            NIFEE = new Label();
            NomeEE = new Label();
            textNomeEE = new TextBox();
            EmailEE = new Label();
            textEmailEE = new TextBox();
            btnInserir = new Button();
            btnLimpar = new Button();
            maskedTextNIF = new MaskedTextBox();
            maskedTextNIFEE = new MaskedTextBox();
            painel_de_EE = new Panel();
            rb_Nao = new RadioButton();
            rb_Sim = new RadioButton();
            label1 = new Label();
            painel_Parentesco = new Panel();
            rb_Parentesco_Nao = new RadioButton();
            rb_Parentesco_Sim = new RadioButton();
            label2 = new Label();
            cb_Tipo = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            btnPage = new Button();
            btnNextPage = new Button();
            painel_de_EE.SuspendLayout();
            painel_Parentesco.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NIF
            // 
            NIF.AutoSize = true;
            NIF.Font = new Font("Consolas", 9F, FontStyle.Bold);
            NIF.Location = new Point(33, 175);
            NIF.Name = "NIF";
            NIF.Size = new Size(35, 14);
            NIF.TabIndex = 0;
            NIF.Text = "NIF:";
            // 
            // textNome
            // 
            textNome.Location = new Point(127, 205);
            textNome.MaxLength = 255;
            textNome.Name = "textNome";
            textNome.Size = new Size(331, 23);
            textNome.TabIndex = 3;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Font = new Font("Consolas", 9F, FontStyle.Bold);
            Nome.Location = new Point(29, 208);
            Nome.Name = "Nome";
            Nome.Size = new Size(42, 14);
            Nome.TabIndex = 0;
            Nome.Text = "Nome:";
            // 
            // Processo
            // 
            Processo.AutoSize = true;
            Processo.Font = new Font("Consolas", 9F, FontStyle.Bold);
            Processo.Location = new Point(29, 246);
            Processo.Name = "Processo";
            Processo.Size = new Size(70, 14);
            Processo.TabIndex = 0;
            Processo.Text = "Processo:";
            // 
            // textProcesso
            // 
            textProcesso.Location = new Point(127, 243);
            textProcesso.MaxLength = 5;
            textProcesso.Name = "textProcesso";
            textProcesso.Size = new Size(76, 23);
            textProcesso.TabIndex = 4;
            // 
            // NIFEE
            // 
            NIFEE.AutoSize = true;
            NIFEE.Font = new Font("Consolas", 9F, FontStyle.Bold);
            NIFEE.Location = new Point(29, 285);
            NIFEE.Name = "NIFEE";
            NIFEE.Size = new Size(49, 14);
            NIFEE.TabIndex = 0;
            NIFEE.Text = "NIFEE:";
            // 
            // NomeEE
            // 
            NomeEE.AutoSize = true;
            NomeEE.Font = new Font("Consolas", 9F, FontStyle.Bold);
            NomeEE.Location = new Point(29, 324);
            NomeEE.Name = "NomeEE";
            NomeEE.Size = new Size(56, 14);
            NomeEE.TabIndex = 0;
            NomeEE.Text = "NomeEE:";
            // 
            // textNomeEE
            // 
            textNomeEE.Location = new Point(127, 321);
            textNomeEE.MaxLength = 255;
            textNomeEE.Name = "textNomeEE";
            textNomeEE.Size = new Size(331, 23);
            textNomeEE.TabIndex = 6;
            // 
            // EmailEE
            // 
            EmailEE.AutoSize = true;
            EmailEE.Font = new Font("Consolas", 9F, FontStyle.Bold);
            EmailEE.Location = new Point(29, 367);
            EmailEE.Name = "EmailEE";
            EmailEE.Size = new Size(63, 14);
            EmailEE.TabIndex = 0;
            EmailEE.Text = "EmailEE:";
            // 
            // textEmailEE
            // 
            textEmailEE.Location = new Point(127, 364);
            textEmailEE.MaxLength = 255;
            textEmailEE.Name = "textEmailEE";
            textEmailEE.Size = new Size(331, 23);
            textEmailEE.TabIndex = 7;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.RoyalBlue;
            btnInserir.BackgroundImageLayout = ImageLayout.Center;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserir.Location = new Point(387, 525);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(137, 32);
            btnInserir.TabIndex = 10;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.RoyalBlue;
            btnLimpar.BackgroundImageLayout = ImageLayout.Center;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(587, 525);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(130, 32);
            btnLimpar.TabIndex = 11;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // maskedTextNIF
            // 
            maskedTextNIF.Location = new Point(127, 171);
            maskedTextNIF.Mask = "000000000";
            maskedTextNIF.Name = "maskedTextNIF";
            maskedTextNIF.Size = new Size(76, 23);
            maskedTextNIF.TabIndex = 2;
            // 
            // maskedTextNIFEE
            // 
            maskedTextNIFEE.Location = new Point(127, 281);
            maskedTextNIFEE.Mask = "000000000";
            maskedTextNIFEE.Name = "maskedTextNIFEE";
            maskedTextNIFEE.Size = new Size(76, 23);
            maskedTextNIFEE.TabIndex = 5;
            // 
            // painel_de_EE
            // 
            painel_de_EE.Controls.Add(rb_Nao);
            painel_de_EE.Controls.Add(rb_Sim);
            painel_de_EE.Controls.Add(label1);
            painel_de_EE.Location = new Point(33, 86);
            painel_de_EE.Name = "painel_de_EE";
            painel_de_EE.Size = new Size(280, 68);
            painel_de_EE.TabIndex = 1;
            // 
            // rb_Nao
            // 
            rb_Nao.AutoSize = true;
            rb_Nao.Location = new Point(119, 36);
            rb_Nao.Name = "rb_Nao";
            rb_Nao.Size = new Size(47, 19);
            rb_Nao.TabIndex = 2;
            rb_Nao.TabStop = true;
            rb_Nao.Text = "Não";
            rb_Nao.UseVisualStyleBackColor = true;
            // 
            // rb_Sim
            // 
            rb_Sim.AutoSize = true;
            rb_Sim.Location = new Point(3, 36);
            rb_Sim.Name = "rb_Sim";
            rb_Sim.Size = new Size(45, 19);
            rb_Sim.TabIndex = 1;
            rb_Sim.TabStop = true;
            rb_Sim.Text = "Sim";
            rb_Sim.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 15);
            label1.TabIndex = 0;
            label1.Text = "É o proprio Encarregado de Educação.:";
            // 
            // painel_Parentesco
            // 
            painel_Parentesco.Controls.Add(rb_Parentesco_Nao);
            painel_Parentesco.Controls.Add(rb_Parentesco_Sim);
            painel_Parentesco.Location = new Point(124, 405);
            painel_Parentesco.Name = "painel_Parentesco";
            painel_Parentesco.Size = new Size(280, 41);
            painel_Parentesco.TabIndex = 8;
            // 
            // rb_Parentesco_Nao
            // 
            rb_Parentesco_Nao.AutoSize = true;
            rb_Parentesco_Nao.Location = new Point(119, 12);
            rb_Parentesco_Nao.Name = "rb_Parentesco_Nao";
            rb_Parentesco_Nao.Size = new Size(47, 19);
            rb_Parentesco_Nao.TabIndex = 1;
            rb_Parentesco_Nao.TabStop = true;
            rb_Parentesco_Nao.Text = "Não";
            rb_Parentesco_Nao.UseVisualStyleBackColor = true;
            // 
            // rb_Parentesco_Sim
            // 
            rb_Parentesco_Sim.AutoSize = true;
            rb_Parentesco_Sim.Location = new Point(12, 12);
            rb_Parentesco_Sim.Name = "rb_Parentesco_Sim";
            rb_Parentesco_Sim.Size = new Size(45, 19);
            rb_Parentesco_Sim.TabIndex = 0;
            rb_Parentesco_Sim.TabStop = true;
            rb_Parentesco_Sim.Text = "Sim";
            rb_Parentesco_Sim.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9F, FontStyle.Bold);
            label2.Location = new Point(26, 417);
            label2.Name = "label2";
            label2.Size = new Size(84, 14);
            label2.TabIndex = 0;
            label2.Text = "Parentesco:";
            // 
            // cb_Tipo
            // 
            cb_Tipo.FormattingEnabled = true;
            cb_Tipo.Location = new Point(127, 469);
            cb_Tipo.Name = "cb_Tipo";
            cb_Tipo.Size = new Size(166, 23);
            cb_Tipo.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 9F, FontStyle.Bold);
            label3.Location = new Point(33, 473);
            label3.Name = "label3";
            label3.Size = new Size(42, 14);
            label3.TabIndex = 0;
            label3.Text = "Tipo:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnPage);
            panel1.Controls.Add(btnNextPage);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 57);
            panel1.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.RoyalBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Calisto MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 35);
            textBox1.TabIndex = 15;
            textBox1.Text = "Gestão de avarias";
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(733, 13);
            button1.Name = "button1";
            button1.Size = new Size(156, 32);
            button1.TabIndex = 14;
            button1.Text = "Página de Busca";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnPage
            // 
            btnPage.FlatStyle = FlatStyle.Flat;
            btnPage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPage.Location = new Point(895, 13);
            btnPage.Name = "btnPage";
            btnPage.Size = new Size(176, 32);
            btnPage.TabIndex = 6;
            btnPage.Text = "Página de inserção";
            btnPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            btnNextPage.BackColor = Color.RoyalBlue;
            btnNextPage.BackgroundImageLayout = ImageLayout.Center;
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextPage.Location = new Point(632, 13);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(95, 32);
            btnNextPage.TabIndex = 12;
            btnNextPage.Text = " Queixa";
            btnNextPage.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 607);
            Controls.Add(panel1);
            Controls.Add(painel_de_EE);
            Controls.Add(label3);
            Controls.Add(cb_Tipo);
            Controls.Add(label2);
            Controls.Add(painel_Parentesco);
            Controls.Add(maskedTextNIFEE);
            Controls.Add(maskedTextNIF);
            Controls.Add(btnLimpar);
            Controls.Add(btnInserir);
            Controls.Add(textEmailEE);
            Controls.Add(textNomeEE);
            Controls.Add(EmailEE);
            Controls.Add(NomeEE);
            Controls.Add(textProcesso);
            Controls.Add(NIFEE);
            Controls.Add(textNome);
            Controls.Add(Processo);
            Controls.Add(Nome);
            Controls.Add(NIF);
            Name = "Form1";
            Text = "Inserção de utilizador";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            painel_de_EE.ResumeLayout(false);
            painel_de_EE.PerformLayout();
            painel_Parentesco.ResumeLayout(false);
            painel_Parentesco.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NIF;
        private TextBox textNome;
        private Label Nome;
        private Label Processo;
        private TextBox textProcesso;
        private Label NIFEE;
        private Label NomeEE;
        private TextBox textNomeEE;
        private Label EmailEE;
        private TextBox textEmailEE;
        private Button btnInserir;
        private Button btnLimpar;
        private MaskedTextBox maskedTextNIF;
        private MaskedTextBox maskedTextNIFEE;
        private Panel painel_de_EE;
        private Label label1;
        private RadioButton rb_Nao;
        private RadioButton rb_Sim;
        private Panel painel_Parentesco;
        private Label label2;
        private RadioButton rb_Parentesco_Nao;
        private RadioButton rb_Parentesco_Sim;
        private ComboBox cb_Tipo;
        private Label label3;
        private Button button2;
        private Panel panel1;
        private TextBox textBox1;
        private Button button1;
        private Button btnPage;
        private Button btnNextPage;
    }
}
