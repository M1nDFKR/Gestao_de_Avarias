namespace Pap
{
    partial class home
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
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            painel_de_EE = new Panel();
            rb_Nao = new RadioButton();
            rb_Sim = new RadioButton();
            label1 = new Label();
            NIF = new Label();
            maskedTextNIF = new MaskedTextBox();
            Nome = new Label();
            textNome = new TextBox();
            Processo = new Label();
            textProcesso = new TextBox();
            NIFEE = new Label();
            textNomeEE = new TextBox();
            EmailEE = new Label();
            textEmailEE = new TextBox();
            label2 = new Label();
            painel_Parentesco = new Panel();
            rb_Parentesco_Nao = new RadioButton();
            rb_Parentesco_Sim = new RadioButton();
            label3 = new Label();
            cb_Tipo = new ComboBox();
            btnInserir = new Button();
            btnLimpar = new Button();
            textBoxPesquisa = new TextBox();
            textBox3 = new TextBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            btnPage = new Button();
            btnNextPage = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            painel_de_EE.SuspendLayout();
            painel_Parentesco.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(415, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 92);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += this.pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(463, 261);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(601, 373);
            dataGridView1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(37, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 26);
            textBox2.TabIndex = 18;
            textBox2.Text = "Inserir cliente";
            // 
            // painel_de_EE
            // 
            painel_de_EE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            painel_de_EE.Controls.Add(rb_Nao);
            painel_de_EE.Controls.Add(rb_Sim);
            painel_de_EE.Controls.Add(label1);
            painel_de_EE.Location = new Point(37, 148);
            painel_de_EE.Name = "painel_de_EE";
            painel_de_EE.Size = new Size(216, 66);
            painel_de_EE.TabIndex = 19;
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
            // NIF
            // 
            NIF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NIF.AutoSize = true;
            NIF.Font = new Font("Consolas", 9F, FontStyle.Bold);
            NIF.Location = new Point(37, 230);
            NIF.Name = "NIF";
            NIF.Size = new Size(35, 14);
            NIF.TabIndex = 20;
            NIF.Text = "NIF:";
            // 
            // maskedTextNIF
            // 
            maskedTextNIF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextNIF.Location = new Point(107, 226);
            maskedTextNIF.Mask = "000000000";
            maskedTextNIF.Name = "maskedTextNIF";
            maskedTextNIF.Size = new Size(100, 23);
            maskedTextNIF.TabIndex = 21;
            // 
            // Nome
            // 
            Nome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Nome.AutoSize = true;
            Nome.Font = new Font("Consolas", 9F, FontStyle.Bold);
            Nome.Location = new Point(37, 265);
            Nome.Name = "Nome";
            Nome.Size = new Size(42, 14);
            Nome.TabIndex = 22;
            Nome.Text = "Nome:";
            // 
            // textNome
            // 
            textNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textNome.Location = new Point(107, 261);
            textNome.MaxLength = 255;
            textNome.Name = "textNome";
            textNome.Size = new Size(273, 23);
            textNome.TabIndex = 23;
            // 
            // Processo
            // 
            Processo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Processo.AutoSize = true;
            Processo.Font = new Font("Consolas", 9F, FontStyle.Bold);
            Processo.Location = new Point(37, 299);
            Processo.Name = "Processo";
            Processo.Size = new Size(70, 14);
            Processo.TabIndex = 24;
            Processo.Text = "Processo:";
            // 
            // textProcesso
            // 
            textProcesso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textProcesso.Location = new Point(107, 295);
            textProcesso.MaxLength = 5;
            textProcesso.Name = "textProcesso";
            textProcesso.Size = new Size(76, 23);
            textProcesso.TabIndex = 25;
            // 
            // NIFEE
            // 
            NIFEE.AutoSize = true;
            NIFEE.Font = new Font("Consolas", 9F, FontStyle.Bold);
            NIFEE.Location = new Point(37, 331);
            NIFEE.Name = "NIFEE";
            NIFEE.Size = new Size(56, 14);
            NIFEE.TabIndex = 26;
            NIFEE.Text = "NIF EE:";
            // 
            // textNomeEE
            // 
            textNomeEE.Location = new Point(107, 327);
            textNomeEE.MaxLength = 255;
            textNomeEE.Name = "textNomeEE";
            textNomeEE.Size = new Size(331, 23);
            textNomeEE.TabIndex = 27;
            // 
            // EmailEE
            // 
            EmailEE.AutoSize = true;
            EmailEE.Font = new Font("Consolas", 9F, FontStyle.Bold);
            EmailEE.Location = new Point(37, 361);
            EmailEE.Name = "EmailEE";
            EmailEE.Size = new Size(70, 14);
            EmailEE.TabIndex = 28;
            EmailEE.Text = "Email EE:";
            // 
            // textEmailEE
            // 
            textEmailEE.Location = new Point(107, 357);
            textEmailEE.MaxLength = 255;
            textEmailEE.Name = "textEmailEE";
            textEmailEE.Size = new Size(331, 23);
            textEmailEE.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9F, FontStyle.Bold);
            label2.Location = new Point(37, 406);
            label2.Name = "label2";
            label2.Size = new Size(84, 14);
            label2.TabIndex = 30;
            label2.Text = "Parentesco:";
            // 
            // painel_Parentesco
            // 
            painel_Parentesco.Controls.Add(rb_Parentesco_Nao);
            painel_Parentesco.Controls.Add(rb_Parentesco_Sim);
            painel_Parentesco.Location = new Point(127, 394);
            painel_Parentesco.Name = "painel_Parentesco";
            painel_Parentesco.Size = new Size(311, 41);
            painel_Parentesco.TabIndex = 31;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 9F, FontStyle.Bold);
            label3.Location = new Point(40, 450);
            label3.Name = "label3";
            label3.Size = new Size(42, 14);
            label3.TabIndex = 32;
            label3.Text = "Tipo:";
            // 
            // cb_Tipo
            // 
            cb_Tipo.FormattingEnabled = true;
            cb_Tipo.Location = new Point(107, 446);
            cb_Tipo.Name = "cb_Tipo";
            cb_Tipo.Size = new Size(166, 23);
            cb_Tipo.TabIndex = 33;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.RoyalBlue;
            btnInserir.BackgroundImageLayout = ImageLayout.Center;
            btnInserir.FlatStyle = FlatStyle.Popup;
            btnInserir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserir.ForeColor = Color.White;
            btnInserir.Location = new Point(136, 544);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(137, 32);
            btnInserir.TabIndex = 34;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.RoyalBlue;
            btnLimpar.BackgroundImageLayout = ImageLayout.Center;
            btnLimpar.FlatStyle = FlatStyle.Popup;
            btnLimpar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(301, 544);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(137, 32);
            btnLimpar.TabIndex = 35;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.BackColor = SystemColors.Control;
            textBoxPesquisa.BorderStyle = BorderStyle.None;
            textBoxPesquisa.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPesquisa.Location = new Point(463, 230);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(100, 24);
            textBoxPesquisa.TabIndex = 36;
            textBoxPesquisa.Text = "Pesquisar:";
            textBoxPesquisa.TextChanged += this.textBox3_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(558, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(506, 23);
            textBox3.TabIndex = 37;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnPage);
            panel1.Controls.Add(btnNextPage);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 57);
            panel1.TabIndex = 38;
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
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 646);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Controls.Add(textBoxPesquisa);
            Controls.Add(btnLimpar);
            Controls.Add(btnInserir);
            Controls.Add(cb_Tipo);
            Controls.Add(label3);
            Controls.Add(painel_Parentesco);
            Controls.Add(label2);
            Controls.Add(textEmailEE);
            Controls.Add(EmailEE);
            Controls.Add(textNomeEE);
            Controls.Add(NIFEE);
            Controls.Add(textProcesso);
            Controls.Add(Processo);
            Controls.Add(textNome);
            Controls.Add(Nome);
            Controls.Add(maskedTextNIF);
            Controls.Add(NIF);
            Controls.Add(painel_de_EE);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "home";
            Text = "Gestão de avarias - Home";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Panel painel_de_EE;
        private RadioButton rb_Nao;
        private RadioButton rb_Sim;
        private Label label1;
        private Label NIF;
        private MaskedTextBox maskedTextNIF;
        private Label Nome;
        private TextBox textNome;
        private Label Processo;
        private TextBox textProcesso;
        private Label NIFEE;
        private TextBox textNomeEE;
        private Label EmailEE;
        private TextBox textEmailEE;
        private Label label2;
        private Panel painel_Parentesco;
        private RadioButton rb_Parentesco_Nao;
        private RadioButton rb_Parentesco_Sim;
        private Label label3;
        private ComboBox cb_Tipo;
        private Button btnInserir;
        private Button btnLimpar;
        private TextBox textBoxPesquisa;
        private TextBox textBox3;
        private Panel panel1;
        private TextBox textBox1;
        private Button button1;
        private Button btnPage;
        private Button btnNextPage;
    }
}