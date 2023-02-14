namespace Operadores
{
    partial class Form
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
            this.lblX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(12, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 15);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(56, 9);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 23);
            this.txtX.TabIndex = 1;
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(12, 38);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(135, 23);
            this.btnPre.TabIndex = 2;
            this.btnPre.Text = "Incremento Pré-fixado";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(153, 38);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(143, 23);
            this.btnPos.TabIndex = 3;
            this.btnPos.Text = "Incremento Pós-fixado";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPos);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblX);
            this.Name = "Form";
            this.Text = "Operador de Incremento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblX;
        private TextBox txtX;
        private Button btnPre;
        private Button btnPos;
    }
}