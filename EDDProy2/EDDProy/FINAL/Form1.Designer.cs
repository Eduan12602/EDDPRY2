namespace EDDemo.FINAL
{
    partial class Formfinal
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
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.btnOrdenarQuickSort = new System.Windows.Forms.Button();
            this.btnOrdenarShellSort = new System.Windows.Forms.Button();
            this.btnOrdenarRadixSort = new System.Windows.Forms.Button();
            this.btnIntercalar = new System.Windows.Forms.Button();
            this.btnOrdenarMezclaDirecta = new System.Windows.Forms.Button();
            this.btnOrdenarMezclaNatural = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(312, 107);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(95, 35);
            this.btnOrdenar.TabIndex = 0;
            this.btnOrdenar.Text = "Burbuja";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(154, 122);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(100, 20);
            this.txtNumeros.TabIndex = 3;
            // 
            // btnOrdenarQuickSort
            // 
            this.btnOrdenarQuickSort.Location = new System.Drawing.Point(312, 165);
            this.btnOrdenarQuickSort.Name = "btnOrdenarQuickSort";
            this.btnOrdenarQuickSort.Size = new System.Drawing.Size(95, 39);
            this.btnOrdenarQuickSort.TabIndex = 4;
            this.btnOrdenarQuickSort.Text = "QuickSort";
            this.btnOrdenarQuickSort.UseVisualStyleBackColor = true;
            this.btnOrdenarQuickSort.Click += new System.EventHandler(this.btnOrdenarQuickSort_Click);
            // 
            // btnOrdenarShellSort
            // 
            this.btnOrdenarShellSort.Location = new System.Drawing.Point(436, 107);
            this.btnOrdenarShellSort.Name = "btnOrdenarShellSort";
            this.btnOrdenarShellSort.Size = new System.Drawing.Size(100, 35);
            this.btnOrdenarShellSort.TabIndex = 5;
            this.btnOrdenarShellSort.Text = "ShellSort";
            this.btnOrdenarShellSort.UseVisualStyleBackColor = true;
            this.btnOrdenarShellSort.Click += new System.EventHandler(this.btnOrdenarShellSort_Click);
            // 
            // btnOrdenarRadixSort
            // 
            this.btnOrdenarRadixSort.Location = new System.Drawing.Point(436, 165);
            this.btnOrdenarRadixSort.Name = "btnOrdenarRadixSort";
            this.btnOrdenarRadixSort.Size = new System.Drawing.Size(100, 39);
            this.btnOrdenarRadixSort.TabIndex = 6;
            this.btnOrdenarRadixSort.Text = "Radix";
            this.btnOrdenarRadixSort.UseVisualStyleBackColor = true;
            this.btnOrdenarRadixSort.Click += new System.EventHandler(this.btnOrdenarRadixSort_Click);
            // 
            // btnIntercalar
            // 
            this.btnIntercalar.Location = new System.Drawing.Point(312, 226);
            this.btnIntercalar.Name = "btnIntercalar";
            this.btnIntercalar.Size = new System.Drawing.Size(95, 35);
            this.btnIntercalar.TabIndex = 7;
            this.btnIntercalar.Text = "Intercalar";
            this.btnIntercalar.UseVisualStyleBackColor = true;
            this.btnIntercalar.Click += new System.EventHandler(this.btnIntercalar_Click);
            // 
            // btnOrdenarMezclaDirecta
            // 
            this.btnOrdenarMezclaDirecta.Location = new System.Drawing.Point(436, 226);
            this.btnOrdenarMezclaDirecta.Name = "btnOrdenarMezclaDirecta";
            this.btnOrdenarMezclaDirecta.Size = new System.Drawing.Size(100, 35);
            this.btnOrdenarMezclaDirecta.TabIndex = 8;
            this.btnOrdenarMezclaDirecta.Text = "Mezcla Directa";
            this.btnOrdenarMezclaDirecta.UseVisualStyleBackColor = true;
            this.btnOrdenarMezclaDirecta.Click += new System.EventHandler(this.btnOrdenarMezclaDirecta_Click);
            // 
            // btnOrdenarMezclaNatural
            // 
            this.btnOrdenarMezclaNatural.Location = new System.Drawing.Point(364, 278);
            this.btnOrdenarMezclaNatural.Name = "btnOrdenarMezclaNatural";
            this.btnOrdenarMezclaNatural.Size = new System.Drawing.Size(103, 37);
            this.btnOrdenarMezclaNatural.TabIndex = 9;
            this.btnOrdenarMezclaNatural.Text = "Mezcla Natural";
            this.btnOrdenarMezclaNatural.UseVisualStyleBackColor = true;
            this.btnOrdenarMezclaNatural.Click += new System.EventHandler(this.btnOrdenarMezclaNatural_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "ORDENACION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "INGRESE:";
            // 
            // Formfinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(585, 437);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrdenarMezclaNatural);
            this.Controls.Add(this.btnOrdenarMezclaDirecta);
            this.Controls.Add(this.btnIntercalar);
            this.Controls.Add(this.btnOrdenarRadixSort);
            this.Controls.Add(this.btnOrdenarShellSort);
            this.Controls.Add(this.btnOrdenarQuickSort);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.btnOrdenar);
            this.Name = "Formfinal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Formfinal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Button btnOrdenarQuickSort;
        private System.Windows.Forms.Button btnOrdenarShellSort;
        private System.Windows.Forms.Button btnOrdenarRadixSort;
        private System.Windows.Forms.Button btnIntercalar;
        private System.Windows.Forms.Button btnOrdenarMezclaDirecta;
        private System.Windows.Forms.Button btnOrdenarMezclaNatural;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}