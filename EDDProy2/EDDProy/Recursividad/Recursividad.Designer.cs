namespace Algoritmos_recursividad
{
    partial class FormRecu
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
            this.factorial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exponent = new System.Windows.Forms.Button();
            this.sumArray = new System.Windows.Forms.Button();
            this.hanoiTower = new System.Windows.Forms.Button();
            this.binary = new System.Windows.Forms.Button();
            this.fibonacci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // factorial
            // 
            this.factorial.BackColor = System.Drawing.Color.White;
            this.factorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.factorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.factorial.Location = new System.Drawing.Point(52, 151);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(111, 28);
            this.factorial.TabIndex = 0;
            this.factorial.Text = "Factorial";
            this.factorial.UseVisualStyleBackColor = false;
            this.factorial.Click += new System.EventHandler(this.Factorial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(154, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recursividad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(48, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Algoritmos";
            // 
            // exponent
            // 
            this.exponent.BackColor = System.Drawing.Color.White;
            this.exponent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exponent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exponent.Location = new System.Drawing.Point(353, 151);
            this.exponent.Name = "exponent";
            this.exponent.Size = new System.Drawing.Size(111, 28);
            this.exponent.TabIndex = 3;
            this.exponent.Text = "Exponente";
            this.exponent.UseVisualStyleBackColor = false;
            this.exponent.Click += new System.EventHandler(this.Exponent_Click);
            // 
            // sumArray
            // 
            this.sumArray.BackColor = System.Drawing.Color.White;
            this.sumArray.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sumArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumArray.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sumArray.Location = new System.Drawing.Point(183, 312);
            this.sumArray.Name = "sumArray";
            this.sumArray.Size = new System.Drawing.Size(152, 28);
            this.sumArray.TabIndex = 4;
            this.sumArray.Text = "Suma de arreglo";
            this.sumArray.UseVisualStyleBackColor = false;
            this.sumArray.Click += new System.EventHandler(this.SumArray_Click);
            // 
            // hanoiTower
            // 
            this.hanoiTower.BackColor = System.Drawing.Color.White;
            this.hanoiTower.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hanoiTower.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hanoiTower.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hanoiTower.Location = new System.Drawing.Point(280, 234);
            this.hanoiTower.Name = "hanoiTower";
            this.hanoiTower.Size = new System.Drawing.Size(152, 28);
            this.hanoiTower.TabIndex = 5;
            this.hanoiTower.Text = "Torre de Hanoi";
            this.hanoiTower.UseVisualStyleBackColor = false;
            this.hanoiTower.Click += new System.EventHandler(this.HanoiTower_Click);
            // 
            // binary
            // 
            this.binary.BackColor = System.Drawing.Color.White;
            this.binary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.binary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.binary.Location = new System.Drawing.Point(85, 234);
            this.binary.Name = "binary";
            this.binary.Size = new System.Drawing.Size(152, 28);
            this.binary.TabIndex = 6;
            this.binary.Text = "Busqueda binaria";
            this.binary.UseVisualStyleBackColor = false;
            this.binary.Click += new System.EventHandler(this.Binary_Click);
            // 
            // fibonacci
            // 
            this.fibonacci.BackColor = System.Drawing.Color.White;
            this.fibonacci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fibonacci.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fibonacci.Location = new System.Drawing.Point(201, 151);
            this.fibonacci.Name = "fibonacci";
            this.fibonacci.Size = new System.Drawing.Size(111, 28);
            this.fibonacci.TabIndex = 7;
            this.fibonacci.Text = "Fibonacci";
            this.fibonacci.UseVisualStyleBackColor = false;
            this.fibonacci.Click += new System.EventHandler(this.Fibonacci_Click);
            // 
            // FormRecu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(498, 375);
            this.Controls.Add(this.fibonacci);
            this.Controls.Add(this.binary);
            this.Controls.Add(this.hanoiTower);
            this.Controls.Add(this.sumArray);
            this.Controls.Add(this.exponent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.factorial);
            this.Name = "FormRecu";
            this.Text = "Recursividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exponent;
        private System.Windows.Forms.Button sumArray;
        private System.Windows.Forms.Button hanoiTower;
        private System.Windows.Forms.Button binary;
        private System.Windows.Forms.Button fibonacci;
    }
}

