namespace Pap
{
    partial class QueixaForm
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
            textNome = new TextBox();
            textNIF = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Location = new Point(99, 37);
            textNome.Name = "textNome";
            textNome.ReadOnly = true;
            textNome.Size = new Size(136, 23);
            textNome.TabIndex = 0;
            // 
            // textNIF
            // 
            textNIF.Location = new Point(327, 37);
            textNIF.Name = "textNIF";
            textNIF.ReadOnly = true;
            textNIF.Size = new Size(136, 23);
            textNIF.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 40);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 40);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "NIF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(229, 23);
            label3.TabIndex = 3;
            label3.Text = "Continuar Quiexa do aluno.:";
            // 
            // QueixaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 538);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textNIF);
            Controls.Add(textNome);
            Name = "QueixaForm";
            Text = "Formulário de Queixa";
            Load += QueixaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNome;
        private TextBox textNIF;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}