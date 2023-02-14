namespace Pizzaria
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
            this.lblSabores = new System.Windows.Forms.Label();
            this.cboSabores = new System.Windows.Forms.ComboBox();
            this.grpIngredientes = new System.Windows.Forms.GroupBox();
            this.grpBorda = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.chkCebola = new System.Windows.Forms.CheckBox();
            this.chkAzeitona = new System.Windows.Forms.CheckBox();
            this.rdbSemBorda = new System.Windows.Forms.RadioButton();
            this.rdbComBorda = new System.Windows.Forms.RadioButton();
            this.grpIngredientes.SuspendLayout();
            this.grpBorda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSabores
            // 
            this.lblSabores.AutoSize = true;
            this.lblSabores.Location = new System.Drawing.Point(10, 28);
            this.lblSabores.Name = "lblSabores";
            this.lblSabores.Size = new System.Drawing.Size(103, 15);
            this.lblSabores.TabIndex = 0;
            this.lblSabores.Text = "Sabores das Pizzas";
            // 
            // cboSabores
            // 
            this.cboSabores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSabores.FormattingEnabled = true;
            this.cboSabores.Location = new System.Drawing.Point(119, 25);
            this.cboSabores.Name = "cboSabores";
            this.cboSabores.Size = new System.Drawing.Size(121, 23);
            this.cboSabores.Sorted = true;
            this.cboSabores.TabIndex = 1;
            // 
            // grpIngredientes
            // 
            this.grpIngredientes.Controls.Add(this.chkAzeitona);
            this.grpIngredientes.Controls.Add(this.chkCebola);
            this.grpIngredientes.Location = new System.Drawing.Point(12, 84);
            this.grpIngredientes.Name = "grpIngredientes";
            this.grpIngredientes.Size = new System.Drawing.Size(154, 100);
            this.grpIngredientes.TabIndex = 2;
            this.grpIngredientes.TabStop = false;
            this.grpIngredientes.Text = "Ingredientes Adicionais";
            // 
            // grpBorda
            // 
            this.grpBorda.Controls.Add(this.rdbComBorda);
            this.grpBorda.Controls.Add(this.rdbSemBorda);
            this.grpBorda.Location = new System.Drawing.Point(172, 84);
            this.grpBorda.Name = "grpBorda";
            this.grpBorda.Size = new System.Drawing.Size(200, 100);
            this.grpBorda.TabIndex = 3;
            this.grpBorda.TabStop = false;
            this.grpBorda.Text = "Borda";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(224, 190);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(109, 23);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir Pedido";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(30, 190);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar Pedido";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // chkCebola
            // 
            this.chkCebola.AutoSize = true;
            this.chkCebola.Location = new System.Drawing.Point(18, 27);
            this.chkCebola.Name = "chkCebola";
            this.chkCebola.Size = new System.Drawing.Size(63, 19);
            this.chkCebola.TabIndex = 0;
            this.chkCebola.Text = "Cebola";
            this.chkCebola.UseVisualStyleBackColor = true;
            // 
            // chkAzeitona
            // 
            this.chkAzeitona.AutoSize = true;
            this.chkAzeitona.Location = new System.Drawing.Point(21, 64);
            this.chkAzeitona.Name = "chkAzeitona";
            this.chkAzeitona.Size = new System.Drawing.Size(72, 19);
            this.chkAzeitona.TabIndex = 1;
            this.chkAzeitona.Text = "Azeitona";
            this.chkAzeitona.UseVisualStyleBackColor = true;
            // 
            // rdbSemBorda
            // 
            this.rdbSemBorda.AutoSize = true;
            this.rdbSemBorda.Checked = true;
            this.rdbSemBorda.Location = new System.Drawing.Point(17, 23);
            this.rdbSemBorda.Name = "rdbSemBorda";
            this.rdbSemBorda.Size = new System.Drawing.Size(82, 19);
            this.rdbSemBorda.TabIndex = 0;
            this.rdbSemBorda.TabStop = true;
            this.rdbSemBorda.Text = "Sem Borda";
            this.rdbSemBorda.UseVisualStyleBackColor = true;
            // 
            // rdbComBorda
            // 
            this.rdbComBorda.AutoSize = true;
            this.rdbComBorda.Location = new System.Drawing.Point(22, 58);
            this.rdbComBorda.Name = "rdbComBorda";
            this.rdbComBorda.Size = new System.Drawing.Size(139, 19);
            this.rdbComBorda.TabIndex = 1;
            this.rdbComBorda.Text = "Com Borda Recheada";
            this.rdbComBorda.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 280);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.grpBorda);
            this.Controls.Add(this.grpIngredientes);
            this.Controls.Add(this.cboSabores);
            this.Controls.Add(this.lblSabores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Pizzaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpIngredientes.ResumeLayout(false);
            this.grpIngredientes.PerformLayout();
            this.grpBorda.ResumeLayout(false);
            this.grpBorda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSabores;
        private ComboBox cboSabores;
        private GroupBox grpIngredientes;
        private CheckBox chkAzeitona;
        private CheckBox chkCebola;
        private GroupBox grpBorda;
        private RadioButton rdbComBorda;
        private RadioButton rdbSemBorda;
        private Button btnImprimir;
        private Button btnLimpar;
    }
}