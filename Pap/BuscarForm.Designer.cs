namespace Pap
{
    partial class BuscarForm
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
            lstDados = new ListView();
            btnBuscar_NIF = new Button();
            txtBuscaNIF = new TextBox();
            NIFF_NIFEE_Processo = new Label();
            Nome_Email = new Label();
            txtBuscaNome = new TextBox();
            btnBuscar_Nome = new Button();
            btnPage = new Button();
            btnLimpar = new Button();
            panel1 = new Panel();
            btn_Devolucao = new Button();
            btn_Orcamento = new Button();
            btn_Envio = new Button();
            btn_Contato = new Button();
            btnPageEquipamentos = new Button();
            textBox1 = new TextBox();
            btnPageHome = new Button();
            btnPageQueixa = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lstDados
            // 
            lstDados.Location = new Point(12, 127);
            lstDados.Name = "lstDados";
            lstDados.Size = new Size(1346, 610);
            lstDados.TabIndex = 7;
            lstDados.UseCompatibleStateImageBehavior = false;
            // 
            // btnBuscar_NIF
            // 
            btnBuscar_NIF.BackColor = Color.RoyalBlue;
            btnBuscar_NIF.FlatStyle = FlatStyle.Flat;
            btnBuscar_NIF.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar_NIF.ForeColor = Color.White;
            btnBuscar_NIF.Location = new Point(197, 98);
            btnBuscar_NIF.Name = "btnBuscar_NIF";
            btnBuscar_NIF.Size = new Size(108, 23);
            btnBuscar_NIF.TabIndex = 2;
            btnBuscar_NIF.Text = "Buscar";
            btnBuscar_NIF.UseVisualStyleBackColor = false;
            btnBuscar_NIF.Click += btnBuscar_NIF_Click;
            // 
            // txtBuscaNIF
            // 
            txtBuscaNIF.Location = new Point(12, 98);
            txtBuscaNIF.MaxLength = 9;
            txtBuscaNIF.Name = "txtBuscaNIF";
            txtBuscaNIF.Size = new Size(179, 23);
            txtBuscaNIF.TabIndex = 1;
            // 
            // NIFF_NIFEE_Processo
            // 
            NIFF_NIFEE_Processo.AutoSize = true;
            NIFF_NIFEE_Processo.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NIFF_NIFEE_Processo.Location = new Point(12, 78);
            NIFF_NIFEE_Processo.Name = "NIFF_NIFEE_Processo";
            NIFF_NIFEE_Processo.Size = new Size(217, 15);
            NIFF_NIFEE_Processo.TabIndex = 0;
            NIFF_NIFEE_Processo.Text = "Buscar por NIF/NIFEE/Processo:";
            // 
            // Nome_Email
            // 
            Nome_Email.AutoSize = true;
            Nome_Email.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nome_Email.Location = new Point(324, 78);
            Nome_Email.Name = "Nome_Email";
            Nome_Email.Size = new Size(224, 15);
            Nome_Email.TabIndex = 0;
            Nome_Email.Text = "Buscar por Nome/NomeEE/EmailEE:";
            // 
            // txtBuscaNome
            // 
            txtBuscaNome.Location = new Point(324, 97);
            txtBuscaNome.MaxLength = 255;
            txtBuscaNome.Name = "txtBuscaNome";
            txtBuscaNome.Size = new Size(179, 23);
            txtBuscaNome.TabIndex = 3;
            // 
            // btnBuscar_Nome
            // 
            btnBuscar_Nome.BackColor = Color.RoyalBlue;
            btnBuscar_Nome.FlatStyle = FlatStyle.Flat;
            btnBuscar_Nome.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar_Nome.ForeColor = SystemColors.Control;
            btnBuscar_Nome.Location = new Point(509, 96);
            btnBuscar_Nome.Name = "btnBuscar_Nome";
            btnBuscar_Nome.Size = new Size(108, 25);
            btnBuscar_Nome.TabIndex = 4;
            btnBuscar_Nome.Text = "Buscar";
            btnBuscar_Nome.UseVisualStyleBackColor = false;
            btnBuscar_Nome.Click += btnBuscar_Nome_Click;
            // 
            // btnPage
            // 
            btnPage.FlatStyle = FlatStyle.Flat;
            btnPage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPage.Location = new Point(1049, 16);
            btnPage.Name = "btnPage";
            btnPage.Size = new Size(176, 32);
            btnPage.TabIndex = 6;
            btnPage.Text = "Página de inserção";
            btnPage.UseVisualStyleBackColor = true;
            btnPage.Click += btnPage_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.RoyalBlue;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = SystemColors.Control;
            btnLimpar.Location = new Point(623, 96);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(93, 25);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btn_Devolucao);
            panel1.Controls.Add(btn_Orcamento);
            panel1.Controls.Add(btn_Envio);
            panel1.Controls.Add(btn_Contato);
            panel1.Controls.Add(btnPageEquipamentos);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnPageHome);
            panel1.Controls.Add(btnPage);
            panel1.Controls.Add(btnPageQueixa);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1374, 57);
            panel1.TabIndex = 19;
            // 
            // btn_Devolucao
            // 
            btn_Devolucao.FlatStyle = FlatStyle.Flat;
            btn_Devolucao.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Devolucao.Location = new Point(404, 16);
            btn_Devolucao.Name = "btn_Devolucao";
            btn_Devolucao.Size = new Size(103, 32);
            btn_Devolucao.TabIndex = 20;
            btn_Devolucao.Text = "Devolução";
            btn_Devolucao.UseVisualStyleBackColor = true;
            btn_Devolucao.Click += btn_Devolucao_Click;
            // 
            // btn_Orcamento
            // 
            btn_Orcamento.FlatStyle = FlatStyle.Flat;
            btn_Orcamento.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Orcamento.Location = new Point(513, 16);
            btn_Orcamento.Name = "btn_Orcamento";
            btn_Orcamento.Size = new Size(108, 32);
            btn_Orcamento.TabIndex = 22;
            btn_Orcamento.Text = "Orçamento";
            btn_Orcamento.UseVisualStyleBackColor = true;
            btn_Orcamento.Click += btn_Orcamento_Click;
            // 
            // btn_Envio
            // 
            btn_Envio.FlatStyle = FlatStyle.Flat;
            btn_Envio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Envio.Location = new Point(627, 16);
            btn_Envio.Name = "btn_Envio";
            btn_Envio.Size = new Size(92, 32);
            btn_Envio.TabIndex = 21;
            btn_Envio.Text = "Envio";
            btn_Envio.UseVisualStyleBackColor = true;
            btn_Envio.Click += btn_Envio_Click;
            // 
            // btn_Contato
            // 
            btn_Contato.FlatStyle = FlatStyle.Flat;
            btn_Contato.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Contato.Location = new Point(725, 16);
            btn_Contato.Name = "btn_Contato";
            btn_Contato.Size = new Size(92, 32);
            btn_Contato.TabIndex = 20;
            btn_Contato.Text = "Contacto";
            btn_Contato.UseVisualStyleBackColor = true;
            btn_Contato.Click += btn_Contato_Click;
            // 
            // btnPageEquipamentos
            // 
            btnPageEquipamentos.FlatStyle = FlatStyle.Flat;
            btnPageEquipamentos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageEquipamentos.Location = new Point(823, 16);
            btnPageEquipamentos.Name = "btnPageEquipamentos";
            btnPageEquipamentos.Size = new Size(134, 32);
            btnPageEquipamentos.TabIndex = 20;
            btnPageEquipamentos.Text = "Equipamentos";
            btnPageEquipamentos.UseVisualStyleBackColor = true;
            btnPageEquipamentos.Click += btnPageEquipamentos_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.RoyalBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 33);
            textBox1.TabIndex = 15;
            textBox1.Text = "Gestão de avarias";
            // 
            // btnPageHome
            // 
            btnPageHome.BackColor = Color.RoyalBlue;
            btnPageHome.BackgroundImageLayout = ImageLayout.Center;
            btnPageHome.FlatStyle = FlatStyle.Flat;
            btnPageHome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageHome.Location = new Point(1231, 17);
            btnPageHome.Name = "btnPageHome";
            btnPageHome.Size = new Size(127, 32);
            btnPageHome.TabIndex = 14;
            btnPageHome.Text = "Página Inicial";
            btnPageHome.UseVisualStyleBackColor = false;
            btnPageHome.Click += btnPageHome_Click;
            // 
            // btnPageQueixa
            // 
            btnPageQueixa.BackColor = Color.RoyalBlue;
            btnPageQueixa.BackgroundImageLayout = ImageLayout.Center;
            btnPageQueixa.FlatStyle = FlatStyle.Flat;
            btnPageQueixa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageQueixa.Location = new Point(963, 16);
            btnPageQueixa.Name = "btnPageQueixa";
            btnPageQueixa.Size = new Size(80, 32);
            btnPageQueixa.TabIndex = 12;
            btnPageQueixa.Text = "Queixa";
            btnPageQueixa.UseVisualStyleBackColor = false;
            btnPageQueixa.Click += btnPageQueixa_Click;
            // 
            // BuscarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel1);
            Controls.Add(btnLimpar);
            Controls.Add(Nome_Email);
            Controls.Add(txtBuscaNome);
            Controls.Add(btnBuscar_Nome);
            Controls.Add(NIFF_NIFEE_Processo);
            Controls.Add(txtBuscaNIF);
            Controls.Add(btnBuscar_NIF);
            Controls.Add(lstDados);
            Name = "BuscarForm";
            Text = "Gestão de avarias - Procurar avarias";
            WindowState = FormWindowState.Maximized;
            Load += BuscarForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstDados;
        private Button btnBuscar_NIF;
        private TextBox txtBuscaNIF;
        private Label NIFF_NIFEE_Processo;
        private Label Nome_Email;
        private TextBox txtBuscaNome;
        private Button btnBuscar_Nome;
        private Button btnPage;
        private Button btnLimpar;
        private Panel panel1;
        private TextBox textBox1;
        private Button btnPageHome;
        private Button btnPageQueixa;
        private Button btnPageEquipamentos;
        private Button btn_Contato;
        private Button btn_Envio;
        private Button btn_Orcamento;
        private Button btn_Devolucao;
    }
}