namespace Pila1
{
    partial class FormLifo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnApilar = new System.Windows.Forms.Button();
            this.btnDesapilar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.listPila = new System.Windows.Forms.ListBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApilar
            // 
            this.btnApilar.BackColor = System.Drawing.SystemColors.Control;
            this.btnApilar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApilar.Location = new System.Drawing.Point(11, 136);
            this.btnApilar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApilar.Name = "btnApilar";
            this.btnApilar.Size = new System.Drawing.Size(75, 30);
            this.btnApilar.TabIndex = 0;
            this.btnApilar.Text = "Apilar";
            this.btnApilar.UseVisualStyleBackColor = false;
            this.btnApilar.Click += new System.EventHandler(this.btnApilar_Click);
            // 
            // btnDesapilar
            // 
            this.btnDesapilar.BackColor = System.Drawing.SystemColors.Control;
            this.btnDesapilar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesapilar.Location = new System.Drawing.Point(106, 137);
            this.btnDesapilar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDesapilar.Name = "btnDesapilar";
            this.btnDesapilar.Size = new System.Drawing.Size(75, 29);
            this.btnDesapilar.TabIndex = 1;
            this.btnDesapilar.Text = "Desapilar";
            this.btnDesapilar.UseVisualStyleBackColor = false;
            this.btnDesapilar.Click += new System.EventHandler(this.btnDesapilar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.SystemColors.Control;
            this.btnVaciar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciar.Location = new System.Drawing.Point(11, 193);
            this.btnVaciar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(75, 31);
            this.btnVaciar.TabIndex = 2;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // listPila
            // 
            this.listPila.FormattingEnabled = true;
            this.listPila.Location = new System.Drawing.Point(263, 96);
            this.listPila.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listPila.Name = "listPila";
            this.listPila.Size = new System.Drawing.Size(91, 147);
            this.listPila.TabIndex = 3;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(106, 96);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(76, 20);
            this.txtDato.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingresa un valor ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pila(LIFO)";
            // 
            // btnGrafica
            // 
            this.btnGrafica.BackColor = System.Drawing.SystemColors.Control;
            this.btnGrafica.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafica.Location = new System.Drawing.Point(106, 193);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(75, 30);
            this.btnGrafica.TabIndex = 7;
            this.btnGrafica.Text = "Graficar";
            this.btnGrafica.UseVisualStyleBackColor = false;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // FormLifo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(381, 268);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.listPila);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnDesapilar);
            this.Controls.Add(this.btnApilar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLifo";
            this.Text = "LIFO";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApilar;
        private System.Windows.Forms.Button btnDesapilar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.ListBox listPila;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGrafica;
    }
}

