namespace EDDemo.FINAL
{
    partial class binario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.listBoxNumeros = new System.Windows.Forms.ListBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BINARIA";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(89, 133);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(119, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(46, 177);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 46);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(167, 177);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(93, 46);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(29, 249);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado:";
            // 
            // listBoxNumeros
            // 
            this.listBoxNumeros.FormattingEnabled = true;
            this.listBoxNumeros.Location = new System.Drawing.Point(265, 238);
            this.listBoxNumeros.Name = "listBoxNumeros";
            this.listBoxNumeros.Size = new System.Drawing.Size(175, 160);
            this.listBoxNumeros.TabIndex = 5;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(304, 177);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(111, 46);
            this.btnOrdenar.TabIndex = 6;
            this.btnOrdenar.Text = "ORDENAR";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // binario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.listBoxNumeros);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "binario";
            this.Text = "binario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ListBox listBoxNumeros;
        private System.Windows.Forms.Button btnOrdenar;
    }
}