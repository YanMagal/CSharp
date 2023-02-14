namespace DiaDaSemana
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
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(37, 102);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(118, 102);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(37, 26);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(24, 15);
            this.lblDia.TabIndex = 2;
            this.lblDia.Text = "Dia";
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiaSemana.ForeColor = System.Drawing.Color.Red;
            this.lblDiaSemana.Location = new System.Drawing.Point(81, 63);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(57, 20);
            this.lblDiaSemana.TabIndex = 3;
            this.lblDiaSemana.Text = "label2";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(81, 23);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 23);
            this.txtDia.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 181);
            this.ControlBox = false;
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblDiaSemana);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnVerificar);
            this.Name = "Form1";
            this.Text = "Seleciona Dia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVerificar;
        private Button btnFechar;
        private Label lblDia;
        private Label lblDiaSemana;
        private TextBox txtDia;
    }
}