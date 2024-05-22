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
            SuspendLayout();
            // 
            // lstDados
            // 
            lstDados.Location = new Point(12, 66);
            lstDados.Name = "lstDados";
            lstDados.Size = new Size(1346, 671);
            lstDados.TabIndex = 7;
            lstDados.UseCompatibleStateImageBehavior = false;
            // 
            // btnBuscar_NIF
            // 
            btnBuscar_NIF.Location = new Point(197, 37);
            btnBuscar_NIF.Name = "btnBuscar_NIF";
            btnBuscar_NIF.Size = new Size(108, 23);
            btnBuscar_NIF.TabIndex = 2;
            btnBuscar_NIF.Text = "Buscar";
            btnBuscar_NIF.UseVisualStyleBackColor = true;
            btnBuscar_NIF.Click += btnBuscar_NIF_Click;
            // 
            // txtBuscaNIF
            // 
            txtBuscaNIF.Location = new Point(12, 37);
            txtBuscaNIF.MaxLength = 9;
            txtBuscaNIF.Name = "txtBuscaNIF";
            txtBuscaNIF.Size = new Size(179, 23);
            txtBuscaNIF.TabIndex = 1;
            // 
            // NIFF_NIFEE_Processo
            // 
            NIFF_NIFEE_Processo.AutoSize = true;
            NIFF_NIFEE_Processo.Location = new Point(12, 9);
            NIFF_NIFEE_Processo.Name = "NIFF_NIFEE_Processo";
            NIFF_NIFEE_Processo.Size = new Size(171, 15);
            NIFF_NIFEE_Processo.TabIndex = 0;
            NIFF_NIFEE_Processo.Text = "Buscar por NIF/NIFEE/Processo";
            // 
            // Nome_Email
            // 
            Nome_Email.AutoSize = true;
            Nome_Email.Location = new Point(324, 9);
            Nome_Email.Name = "Nome_Email";
            Nome_Email.Size = new Size(195, 15);
            Nome_Email.TabIndex = 0;
            Nome_Email.Text = "Buscar por Nome/NomeEE/EmailEE";
            // 
            // txtBuscaNome
            // 
            txtBuscaNome.Location = new Point(324, 37);
            txtBuscaNome.MaxLength = 255;
            txtBuscaNome.Name = "txtBuscaNome";
            txtBuscaNome.Size = new Size(179, 23);
            txtBuscaNome.TabIndex = 3;
            // 
            // btnBuscar_Nome
            // 
            btnBuscar_Nome.Location = new Point(509, 37);
            btnBuscar_Nome.Name = "btnBuscar_Nome";
            btnBuscar_Nome.Size = new Size(108, 23);
            btnBuscar_Nome.TabIndex = 4;
            btnBuscar_Nome.Text = "Buscar";
            btnBuscar_Nome.UseVisualStyleBackColor = true;
            btnBuscar_Nome.Click += btnBuscar_Nome_Click;
            // 
            // btnPage
            // 
            btnPage.Location = new Point(1223, 36);
            btnPage.Name = "btnPage";
            btnPage.Size = new Size(135, 23);
            btnPage.TabIndex = 6;
            btnPage.Text = "Página de inserção";
            btnPage.UseVisualStyleBackColor = true;
            btnPage.Click += btnPage_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(632, 38);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(84, 22);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // BuscarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(btnLimpar);
            Controls.Add(btnPage);
            Controls.Add(Nome_Email);
            Controls.Add(txtBuscaNome);
            Controls.Add(btnBuscar_Nome);
            Controls.Add(NIFF_NIFEE_Processo);
            Controls.Add(txtBuscaNIF);
            Controls.Add(btnBuscar_NIF);
            Controls.Add(lstDados);
            Name = "BuscarForm";
            Text = "Formulário de busca";
            Load += BuscarForm_Load;
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
    }
}