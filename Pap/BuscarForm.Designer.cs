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
            textBox1 = new TextBox();
            btnPageHome = new Button();
            btnPageQueixa = new Button();
            btnPageEquipamentos = new Button();
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
            btnPage.Location = new Point(1033, 17);
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
            btnPageHome.Location = new Point(1215, 17);
            btnPageHome.Name = "btnPageHome";
            btnPageHome.Size = new Size(156, 32);
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
            btnPageQueixa.Location = new Point(932, 17);
            btnPageQueixa.Name = "btnPageQueixa";
            btnPageQueixa.Size = new Size(95, 32);
            btnPageQueixa.TabIndex = 12;
            btnPageQueixa.Text = "Queixa";
            btnPageQueixa.UseVisualStyleBackColor = false;
            btnPageQueixa.Click += btnPageQueixa_Click;
            // 
            // btnPageEquipamentos
            // 
            btnPageEquipamentos.FlatStyle = FlatStyle.Flat;
            btnPageEquipamentos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPageEquipamentos.Location = new Point(750, 17);
            btnPageEquipamentos.Name = "btnPageEquipamentos";
            btnPageEquipamentos.Size = new Size(176, 32);
            btnPageEquipamentos.TabIndex = 20;
            btnPageEquipamentos.Text = "Equipamentos";
            btnPageEquipamentos.UseVisualStyleBackColor = true;
            btnPageEquipamentos.Click += btnPageEquipamentos_Click;
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
    }
}