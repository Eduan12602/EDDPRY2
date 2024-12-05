
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArbo
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbtnVertical = new System.Windows.Forms.RadioButton();
            this.rdbtnHorizontal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNiveles = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(118, 57);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(60, 24);
            this.txtDato.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(12, 97);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 33);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArbol.Location = new System.Drawing.Point(2, 277);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArbol.Size = new System.Drawing.Size(755, 190);
            this.txtArbol.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(604, 84);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 33);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrafica.BackColor = System.Drawing.Color.White;
            this.btnGrafica.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafica.Location = new System.Drawing.Point(501, 84);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(86, 33);
            this.btnGrafica.TabIndex = 3;
            this.btnGrafica.Text = "Graficar";
            this.btnGrafica.UseVisualStyleBackColor = false;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.BackColor = System.Drawing.Color.White;
            this.btnRecorrer.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorrer.Location = new System.Drawing.Point(501, 184);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(86, 33);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = false;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(8, 58);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(106, 16);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Ingresa un valor :";
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.BackColor = System.Drawing.Color.White;
            this.btnCrearArbol.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearArbol.Location = new System.Drawing.Point(400, 113);
            this.btnCrearArbol.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(74, 28);
            this.btnCrearArbol.TabIndex = 6;
            this.btnCrearArbol.Text = "Crear";
            this.btnCrearArbol.UseVisualStyleBackColor = false;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(118, 103);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(58, 24);
            this.txtNodos.TabIndex = 8;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostOrden.Location = new System.Drawing.Point(8, 217);
            this.lblPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(78, 17);
            this.lblPostOrden.TabIndex = 9;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(86, 219);
            this.lblRecorridoPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(0, 13);
            this.lblRecorridoPostOrden.TabIndex = 10;
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInOrden.Location = new System.Drawing.Point(8, 182);
            this.lblInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(52, 17);
            this.lblInOrden.TabIndex = 11;
            this.lblInOrden.Text = "Orden:";
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreOrden.Location = new System.Drawing.Point(8, 151);
            this.lblPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(73, 17);
            this.lblPreOrden.TabIndex = 12;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(86, 184);
            this.lblRecorridoInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(0, 13);
            this.lblRecorridoInOrden.TabIndex = 13;
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(86, 153);
            this.lblRecorridoPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(0, 13);
            this.lblRecorridoPreOrden.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(501, 135);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 33);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Arbol Binario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdbtnVertical
            // 
            this.rdbtnVertical.AutoSize = true;
            this.rdbtnVertical.Location = new System.Drawing.Point(312, 113);
            this.rdbtnVertical.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtnVertical.Name = "rdbtnVertical";
            this.rdbtnVertical.Size = new System.Drawing.Size(60, 17);
            this.rdbtnVertical.TabIndex = 17;
            this.rdbtnVertical.TabStop = true;
            this.rdbtnVertical.Text = "Vertical";
            this.rdbtnVertical.UseVisualStyleBackColor = true;
            // 
            // rdbtnHorizontal
            // 
            this.rdbtnHorizontal.AutoSize = true;
            this.rdbtnHorizontal.Location = new System.Drawing.Point(207, 110);
            this.rdbtnHorizontal.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtnHorizontal.Name = "rdbtnHorizontal";
            this.rdbtnHorizontal.Size = new System.Drawing.Size(72, 17);
            this.rdbtnHorizontal.TabIndex = 18;
            this.rdbtnHorizontal.TabStop = true;
            this.rdbtnHorizontal.Text = "Horizontal";
            this.rdbtnHorizontal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Niveles:";
            // 
            // lblNiveles
            // 
            this.lblNiveles.AutoSize = true;
            this.lblNiveles.Location = new System.Drawing.Point(86, 248);
            this.lblNiveles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNiveles.Name = "lblNiveles";
            this.lblNiveles.Size = new System.Drawing.Size(0, 13);
            this.lblNiveles.TabIndex = 20;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(604, 182);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 33);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.White;
            this.btnInfo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(604, 135);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(93, 33);
            this.btnInfo.TabIndex = 22;
            this.btnInfo.Text = "Informacion";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // frmArbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(765, 504);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblNiveles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbtnHorizontal);
            this.Controls.Add(this.rdbtnVertical);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblRecorridoPreOrden);
            this.Controls.Add(this.lblRecorridoInOrden);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.lblRecorridoPostOrden);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArbo";
            this.Text = "ARBOLES";
            this.Load += new System.EventHandler(this.frmArbo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbtnVertical;
        private System.Windows.Forms.RadioButton rdbtnHorizontal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNiveles;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInfo;
    }
}