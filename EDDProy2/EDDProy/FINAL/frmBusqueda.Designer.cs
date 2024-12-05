namespace EDDemo.FINAL
{
    partial class frmBusqueda
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
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCrearLista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxDatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(111, 147);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 201);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(130, 36);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 272);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado:";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // btnCrearLista
            // 
            this.btnCrearLista.Location = new System.Drawing.Point(167, 201);
            this.btnCrearLista.Name = "btnCrearLista";
            this.btnCrearLista.Size = new System.Drawing.Size(130, 36);
            this.btnCrearLista.TabIndex = 3;
            this.btnCrearLista.Text = "CARGAR ARCHIVO";
            this.btnCrearLista.UseVisualStyleBackColor = true;
            this.btnCrearLista.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "BUSQUEDA HASH";
            // 
            // listBoxDatos
            // 
            this.listBoxDatos.FormattingEnabled = true;
            this.listBoxDatos.Location = new System.Drawing.Point(198, 272);
            this.listBoxDatos.Name = "listBoxDatos";
            this.listBoxDatos.Size = new System.Drawing.Size(187, 160);
            this.listBoxDatos.TabIndex = 5;
            // 
            // frmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(449, 502);
            this.Controls.Add(this.listBoxDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrearLista);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtClave);
            this.Name = "frmBusqueda";
            this.Text = "frmBusqueda";
            this.Load += new System.EventHandler(this.frmBusqueda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCrearLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxDatos;
    }
}