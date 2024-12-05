namespace EDDemo.FINAL
{
    partial class intercalar
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnIntercalar = new System.Windows.Forms.Button();
            this.listBoxLista1 = new System.Windows.Forms.ListBox();
            this.listBoxLista2 = new System.Windows.Forms.ListBox();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(253, 151);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnIntercalar
            // 
            this.btnIntercalar.Location = new System.Drawing.Point(150, 151);
            this.btnIntercalar.Name = "btnIntercalar";
            this.btnIntercalar.Size = new System.Drawing.Size(75, 23);
            this.btnIntercalar.TabIndex = 1;
            this.btnIntercalar.Text = "INTERCALAR";
            this.btnIntercalar.UseVisualStyleBackColor = true;
            this.btnIntercalar.Click += new System.EventHandler(this.btnIntercalar_Click);
            // 
            // listBoxLista1
            // 
            this.listBoxLista1.FormattingEnabled = true;
            this.listBoxLista1.Location = new System.Drawing.Point(29, 256);
            this.listBoxLista1.Name = "listBoxLista1";
            this.listBoxLista1.Size = new System.Drawing.Size(120, 160);
            this.listBoxLista1.TabIndex = 2;
            // 
            // listBoxLista2
            // 
            this.listBoxLista2.FormattingEnabled = true;
            this.listBoxLista2.Location = new System.Drawing.Point(176, 256);
            this.listBoxLista2.Name = "listBoxLista2";
            this.listBoxLista2.Size = new System.Drawing.Size(120, 160);
            this.listBoxLista2.TabIndex = 3;
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(363, 256);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(120, 147);
            this.listBoxResultado.TabIndex = 4;
            // 
            // intercalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.listBoxLista2);
            this.Controls.Add(this.listBoxLista1);
            this.Controls.Add(this.btnIntercalar);
            this.Controls.Add(this.btnGenerar);
            this.Name = "intercalar";
            this.Text = "intercalar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnIntercalar;
        private System.Windows.Forms.ListBox listBoxLista1;
        private System.Windows.Forms.ListBox listBoxLista2;
        private System.Windows.Forms.ListBox listBoxResultado;
    }
}