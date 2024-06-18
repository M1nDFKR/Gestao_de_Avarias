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
            btnInserir = new Button();
            btnLimpar = new Button();
            textBoxPesquisa = new TextBox();
            textBox3 = new TextBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            btnPage = new Button();
            btnNextPage = new Button();
            Clientes = new Label();
            cb_listaClientes = new ComboBox();
            TipoEquip = new Label();
            textTipoEquip = new TextBox();
            N_S = new Label();
            textN_S = new TextBox();
            DtQueixa = new Label();
            dateQueixa = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            textBox2.Location = new Point(12, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 26);
            textBox2.TabIndex = 18;
            textBox2.Text = "Inserir queixa";
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.RoyalBlue;
            btnInserir.BackgroundImageLayout = ImageLayout.Center;
            btnInserir.FlatStyle = FlatStyle.Popup;
            btnInserir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserir.ForeColor = Color.White;
            btnInserir.Location = new Point(12, 544);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(218, 32);
            btnInserir.TabIndex = 34;
            btnInserir.Text = "Continuar queixa";
            btnInserir.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.RoyalBlue;
            btnLimpar.BackgroundImageLayout = ImageLayout.Center;
            btnLimpar.FlatStyle = FlatStyle.Popup;
            btnLimpar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(236, 544);
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
            textBoxPesquisa.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPesquisa.Location = new Point(463, 230);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(100, 23);
            textBoxPesquisa.TabIndex = 36;
            textBoxPesquisa.Text = "Pesquisar:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(565, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(499, 23);
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
            btnNextPage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextPage.Location = new Point(632, 13);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(95, 32);
            btnNextPage.TabIndex = 12;
            btnNextPage.Text = " Queixa";
            btnNextPage.UseVisualStyleBackColor = false;
            // 
            // Clientes
            // 
            Clientes.AutoSize = true;
            Clientes.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clientes.Location = new Point(12, 237);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(70, 15);
            Clientes.TabIndex = 39;
            Clientes.Text = "Clientes:";
            // 
            // cb_listaClientes
            // 
            cb_listaClientes.FormattingEnabled = true;
            cb_listaClientes.Items.AddRange(new object[] { "Selecione um Cliente" });
            cb_listaClientes.Location = new Point(88, 233);
            cb_listaClientes.Name = "cb_listaClientes";
            cb_listaClientes.Size = new Size(301, 23);
            cb_listaClientes.TabIndex = 40;
            // 
            // TipoEquip
            // 
            TipoEquip.AutoSize = true;
            TipoEquip.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TipoEquip.Location = new Point(12, 280);
            TipoEquip.Name = "TipoEquip";
            TipoEquip.Size = new Size(147, 15);
            TipoEquip.TabIndex = 41;
            TipoEquip.Text = "Tipo de Equipamento:";
            // 
            // textTipoEquip
            // 
            textTipoEquip.Location = new Point(156, 277);
            textTipoEquip.MaxLength = 255;
            textTipoEquip.Name = "textTipoEquip";
            textTipoEquip.Size = new Size(217, 23);
            textTipoEquip.TabIndex = 42;
            // 
            // N_S
            // 
            N_S.AutoSize = true;
            N_S.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            N_S.Location = new Point(12, 317);
            N_S.Name = "N_S";
            N_S.Size = new Size(35, 15);
            N_S.TabIndex = 43;
            N_S.Text = "N-S:";
            // 
            // textN_S
            // 
            textN_S.Location = new Point(52, 316);
            textN_S.MaxLength = 255;
            textN_S.Name = "textN_S";
            textN_S.Size = new Size(321, 23);
            textN_S.TabIndex = 44;
            // 
            // DtQueixa
            // 
            DtQueixa.AutoSize = true;
            DtQueixa.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DtQueixa.Location = new Point(12, 362);
            DtQueixa.Name = "DtQueixa";
            DtQueixa.Size = new Size(112, 15);
            DtQueixa.TabIndex = 45;
            DtQueixa.Text = "Data da Queixa:";
            // 
            // dateQueixa
            // 
            dateQueixa.Location = new Point(123, 358);
            dateQueixa.Name = "dateQueixa";
            dateQueixa.Size = new Size(176, 23);
            dateQueixa.TabIndex = 46;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 646);
            Controls.Add(dateQueixa);
            Controls.Add(DtQueixa);
            Controls.Add(textN_S);
            Controls.Add(N_S);
            Controls.Add(textTipoEquip);
            Controls.Add(TipoEquip);
            Controls.Add(cb_listaClientes);
            Controls.Add(Clientes);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Controls.Add(textBoxPesquisa);
            Controls.Add(btnLimpar);
            Controls.Add(btnInserir);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "home";
            Text = "Gestão de avarias - Home";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Button btnInserir;
        private Button btnLimpar;
        private TextBox textBoxPesquisa;
        private TextBox textBox3;
        private Panel panel1;
        private TextBox textBox1;
        private Button button1;
        private Button btnPage;
        private Button btnNextPage;
        private Label Clientes;
        private ComboBox cb_listaClientes;
        private Label TipoEquip;
        private TextBox textTipoEquip;
        private Label N_S;
        private TextBox textN_S;
        private Label DtQueixa;
        private DateTimePicker dateQueixa;
    }
}