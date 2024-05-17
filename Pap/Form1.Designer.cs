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
            btnNextPage = new Button();
            maskedTextNIF = new MaskedTextBox();
            maskedTextNIFEE = new MaskedTextBox();
            SuspendLayout();
            // 
            // NIF
            // 
            NIF.AutoSize = true;
            NIF.Font = new Font("Consolas", 9F, FontStyle.Bold);
            NIF.Location = new Point(70, 89);
            NIF.Name = "NIF";
            NIF.Size = new Size(35, 14);
            NIF.TabIndex = 0;
            NIF.Text = "NIF:";
            // 
            // textNome
            // 
            textNome.Location = new Point(142, 136);
            textNome.MaxLength = 255;
            textNome.Name = "textNome";
            textNome.Size = new Size(331, 23);
            textNome.TabIndex = 2;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Font = new Font("Consolas", 9F, FontStyle.Bold);
            Nome.Location = new Point(70, 139);
            Nome.Name = "Nome";
            Nome.Size = new Size(42, 14);
            Nome.TabIndex = 0;
            Nome.Text = "Nome:";
            // 
            // Processo
            // 
            Processo.AutoSize = true;
            Processo.Font = new Font("Consolas", 9F, FontStyle.Bold);
            Processo.Location = new Point(70, 199);
            Processo.Name = "Processo";
            Processo.Size = new Size(70, 14);
            Processo.TabIndex = 0;
            Processo.Text = "Processo:";
            // 
            // textProcesso
            // 
            textProcesso.Location = new Point(142, 196);
            textProcesso.MaxLength = 5;
            textProcesso.Name = "textProcesso";
            textProcesso.Size = new Size(76, 23);
            textProcesso.TabIndex = 3;
            // 
            // NIFEE
            // 
            NIFEE.AutoSize = true;
            NIFEE.Font = new Font("Consolas", 9F, FontStyle.Bold);
            NIFEE.Location = new Point(70, 254);
            NIFEE.Name = "NIFEE";
            NIFEE.Size = new Size(49, 14);
            NIFEE.TabIndex = 0;
            NIFEE.Text = "NIFEE:";
            // 
            // NomeEE
            // 
            NomeEE.AutoSize = true;
            NomeEE.Font = new Font("Consolas", 9F, FontStyle.Bold);
            NomeEE.Location = new Point(70, 315);
            NomeEE.Name = "NomeEE";
            NomeEE.Size = new Size(56, 14);
            NomeEE.TabIndex = 0;
            NomeEE.Text = "NomeEE:";
            // 
            // textNomeEE
            // 
            textNomeEE.Location = new Point(142, 312);
            textNomeEE.MaxLength = 255;
            textNomeEE.Name = "textNomeEE";
            textNomeEE.Size = new Size(331, 23);
            textNomeEE.TabIndex = 5;
            // 
            // EmailEE
            // 
            EmailEE.AutoSize = true;
            EmailEE.Font = new Font("Consolas", 9F, FontStyle.Bold);
            EmailEE.Location = new Point(70, 370);
            EmailEE.Name = "EmailEE";
            EmailEE.Size = new Size(63, 14);
            EmailEE.TabIndex = 0;
            EmailEE.Text = "EmailEE:";
            // 
            // textEmailEE
            // 
            textEmailEE.Location = new Point(142, 367);
            textEmailEE.MaxLength = 255;
            textEmailEE.Name = "textEmailEE";
            textEmailEE.Size = new Size(331, 23);
            textEmailEE.TabIndex = 6;
            // 
            // btnInserir
            // 
            btnInserir.BackgroundImageLayout = ImageLayout.Center;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Arial Nova", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserir.Location = new Point(124, 435);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(122, 32);
            btnInserir.TabIndex = 7;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackgroundImageLayout = ImageLayout.Center;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Arial Nova", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(252, 435);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(122, 32);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.BackgroundImageLayout = ImageLayout.Center;
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.Font = new Font("Arial Nova", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextPage.Location = new Point(380, 435);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(153, 32);
            btnNextPage.TabIndex = 9;
            btnNextPage.Text = "Próxima página";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // maskedTextNIF
            // 
            maskedTextNIF.Location = new Point(142, 85);
            maskedTextNIF.Mask = "000000000";
            maskedTextNIF.Name = "maskedTextNIF";
            maskedTextNIF.Size = new Size(76, 23);
            maskedTextNIF.TabIndex = 1;
            // 
            // maskedTextNIFEE
            // 
            maskedTextNIFEE.Location = new Point(142, 250);
            maskedTextNIFEE.Mask = "000000000";
            maskedTextNIFEE.Name = "maskedTextNIFEE";
            maskedTextNIFEE.Size = new Size(76, 23);
            maskedTextNIFEE.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 544);
            Controls.Add(maskedTextNIFEE);
            Controls.Add(maskedTextNIF);
            Controls.Add(btnNextPage);
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
            Text = "Utilizador";
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
        private Button btnNextPage;
        private MaskedTextBox maskedTextNIF;
        private MaskedTextBox maskedTextNIFEE;
    }
}
