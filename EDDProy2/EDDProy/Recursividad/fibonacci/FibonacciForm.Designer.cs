namespace Algoritmos_recursividad
{
    partial class FormFab
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
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Location = new System.Drawing.Point(531, 193);
            this.back.Margin = new System.Windows.Forms.Padding(0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(93, 42);
            this.back.TabIndex = 11;
            this.back.Text = "Regresar";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(333, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fibonacci";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(64, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ingrese la posición que desea calcular";
            // 
            // number
            // 
            this.number.BackColor = System.Drawing.SystemColors.ControlLight;
            this.number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.number.Location = new System.Drawing.Point(328, 153);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(192, 20);
            this.number.TabIndex = 14;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.White;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start.Location = new System.Drawing.Point(357, 193);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(139, 42);
            this.start.TabIndex = 15;
            this.start.Text = "Aceptar";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // FormFab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Name = "FormFab";
            this.Text = "Fibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button start;
    }
}