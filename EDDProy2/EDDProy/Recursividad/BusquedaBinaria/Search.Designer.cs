namespace Algoritmos_recursividad
{
    partial class Binaria
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
            this.label2 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.SearchElement = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Busqueda Binaria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(44, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Qué número desea buscar?";
            // 
            // number
            // 
            this.number.BackColor = System.Drawing.SystemColors.ControlLight;
            this.number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.number.Location = new System.Drawing.Point(221, 115);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(46, 20);
            this.number.TabIndex = 15;
            // 
            // SearchElement
            // 
            this.SearchElement.BackColor = System.Drawing.Color.White;
            this.SearchElement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchElement.Location = new System.Drawing.Point(60, 150);
            this.SearchElement.Name = "SearchElement";
            this.SearchElement.Size = new System.Drawing.Size(56, 27);
            this.SearchElement.TabIndex = 16;
            this.SearchElement.Text = "Buscar";
            this.SearchElement.UseVisualStyleBackColor = false;
            this.SearchElement.Click += new System.EventHandler(this.SearchElement_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Location = new System.Drawing.Point(192, 154);
            this.back.Margin = new System.Windows.Forms.Padding(0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 17;
            this.back.Text = "Cancelar";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Binaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(330, 279);
            this.Controls.Add(this.back);
            this.Controls.Add(this.SearchElement);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Binaria";
            this.Text = "BINARIA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button SearchElement;
        private System.Windows.Forms.Button back;
    }
}