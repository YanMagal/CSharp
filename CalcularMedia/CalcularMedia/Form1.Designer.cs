namespace CalcularMedia
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
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblMed = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblSit = new System.Windows.Forms.Label();
            this.lblSitaçao = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(54, 24);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(39, 15);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "Nota1";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(54, 52);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(39, 15);
            this.lblNota2.TabIndex = 1;
            this.lblNota2.Text = "Nota2";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(54, 81);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(39, 15);
            this.lblNota3.TabIndex = 2;
            this.lblNota3.Text = "Nota3";
            this.lblNota3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Location = new System.Drawing.Point(68, 135);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(40, 15);
            this.lblMed.TabIndex = 3;
            this.lblMed.Text = "Média";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(133, 135);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(38, 15);
            this.lblMedia.TabIndex = 4;
            this.lblMedia.Text = "label5";
            // 
            // lblSit
            // 
            this.lblSit.AutoSize = true;
            this.lblSit.Location = new System.Drawing.Point(68, 171);
            this.lblSit.Name = "lblSit";
            this.lblSit.Size = new System.Drawing.Size(52, 15);
            this.lblSit.TabIndex = 5;
            this.lblSit.Text = "Situação";
            // 
            // lblSitaçao
            // 
            this.lblSitaçao.AutoSize = true;
            this.lblSitaçao.Location = new System.Drawing.Point(133, 171);
            this.lblSitaçao.Name = "lblSitaçao";
            this.lblSitaçao.Size = new System.Drawing.Size(38, 15);
            this.lblSitaçao.TabIndex = 6;
            this.lblSitaçao.Text = "label7";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(81, 199);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(98, 21);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 23);
            this.txtNota1.TabIndex = 8;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(98, 50);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 23);
            this.txtNota2.TabIndex = 9;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(98, 81);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 23);
            this.txtNota3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 266);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSitaçao);
            this.Controls.Add(this.lblSit);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblMed);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Name = "Form1";
            this.Text = "Calcular Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNota1;
        private Label lblNota2;
        private Label lblNota3;
        private Label lblMed;
        private Label lblMedia;
        private Label lblSit;
        private Label lblSitaçao;
        private Button btnCalcular;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
    }
}