namespace CondiconalAninhada
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
            this.txtAluno1 = new System.Windows.Forms.TextBox();
            this.txtAluno2 = new System.Windows.Forms.TextBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.lblAluno1 = new System.Windows.Forms.Label();
            this.lblAluno2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAluno1
            // 
            this.txtAluno1.Location = new System.Drawing.Point(83, 18);
            this.txtAluno1.Name = "txtAluno1";
            this.txtAluno1.Size = new System.Drawing.Size(100, 23);
            this.txtAluno1.TabIndex = 0;
            // 
            // txtAluno2
            // 
            this.txtAluno2.Location = new System.Drawing.Point(83, 52);
            this.txtAluno2.Name = "txtAluno2";
            this.txtAluno2.Size = new System.Drawing.Size(100, 23);
            this.txtAluno2.TabIndex = 1;
            this.txtAluno2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(50, 97);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(120, 23);
            this.btnComparar.TabIndex = 2;
            this.btnComparar.Text = "Comparar Notas";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // lblAluno1
            // 
            this.lblAluno1.AutoSize = true;
            this.lblAluno1.Location = new System.Drawing.Point(32, 21);
            this.lblAluno1.Name = "lblAluno1";
            this.lblAluno1.Size = new System.Drawing.Size(45, 15);
            this.lblAluno1.TabIndex = 3;
            this.lblAluno1.Text = "Aluno1";
            // 
            // lblAluno2
            // 
            this.lblAluno2.AutoSize = true;
            this.lblAluno2.Location = new System.Drawing.Point(32, 55);
            this.lblAluno2.Name = "lblAluno2";
            this.lblAluno2.Size = new System.Drawing.Size(45, 15);
            this.lblAluno2.TabIndex = 4;
            this.lblAluno2.Text = "Aluno2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 155);
            this.Controls.Add(this.lblAluno2);
            this.Controls.Add(this.lblAluno1);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.txtAluno2);
            this.Controls.Add(this.txtAluno1);
            this.Name = "Form1";
            this.Text = "Comparação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAluno1;
        private TextBox txtAluno2;
        private Button btnComparar;
        private Label lblAluno1;
        private Label lblAluno2;
    }
}