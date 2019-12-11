namespace Ejercicio2SinSQL
{
    partial class FormTribunales
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
            this.listTribunales = new System.Windows.Forms.ListView();
            this.colNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLugarExamen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumComponentes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTribunales = new System.Windows.Forms.Label();
            this.btnLeerTribunal = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblNumTribunal = new System.Windows.Forms.Label();
            this.txtNumTribunal = new System.Windows.Forms.TextBox();
            this.txtLugarExamen = new System.Windows.Forms.TextBox();
            this.lblLugarExamenTribunal = new System.Windows.Forms.Label();
            this.txtNumComponentes = new System.Windows.Forms.TextBox();
            this.lblNumComponentesTribunal = new System.Windows.Forms.Label();
            this.btnAgregarTribunal = new System.Windows.Forms.Button();
            this.btnActualizarTribunal = new System.Windows.Forms.Button();
            this.btnEliminarTribunal = new System.Windows.Forms.Button();
            this.buscarTribunal = new System.Windows.Forms.Label();
            this.buscarText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listTribunales
            // 
            this.listTribunales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNum,
            this.colLugarExamen,
            this.colNumComponentes});
            this.listTribunales.HideSelection = false;
            this.listTribunales.Location = new System.Drawing.Point(62, 129);
            this.listTribunales.Name = "listTribunales";
            this.listTribunales.Size = new System.Drawing.Size(648, 199);
            this.listTribunales.TabIndex = 0;
            this.listTribunales.UseCompatibleStateImageBehavior = false;
            this.listTribunales.View = System.Windows.Forms.View.Details;
            // 
            // colNum
            // 
            this.colNum.Text = "Num";
            // 
            // colLugarExamen
            // 
            this.colLugarExamen.Text = "Lugar de Examen";
            this.colLugarExamen.Width = 287;
            // 
            // colNumComponentes
            // 
            this.colNumComponentes.Text = "Número de Componentes";
            this.colNumComponentes.Width = 291;
            // 
            // lblTribunales
            // 
            this.lblTribunales.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTribunales.Location = new System.Drawing.Point(295, 22);
            this.lblTribunales.Name = "lblTribunales";
            this.lblTribunales.Size = new System.Drawing.Size(204, 32);
            this.lblTribunales.TabIndex = 1;
            this.lblTribunales.Text = "Tribunales";
            this.lblTribunales.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLeerTribunal
            // 
            this.btnLeerTribunal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerTribunal.Location = new System.Drawing.Point(62, 92);
            this.btnLeerTribunal.Name = "btnLeerTribunal";
            this.btnLeerTribunal.Size = new System.Drawing.Size(75, 31);
            this.btnLeerTribunal.TabIndex = 2;
            this.btnLeerTribunal.Text = "Leer";
            this.btnLeerTribunal.UseVisualStyleBackColor = true;
            this.btnLeerTribunal.Click += new System.EventHandler(this.btnLeerTribunal_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(604, 92);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(106, 31);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Volver Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lblNumTribunal
            // 
            this.lblNumTribunal.AutoSize = true;
            this.lblNumTribunal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTribunal.Location = new System.Drawing.Point(59, 364);
            this.lblNumTribunal.Name = "lblNumTribunal";
            this.lblNumTribunal.Size = new System.Drawing.Size(37, 15);
            this.lblNumTribunal.TabIndex = 4;
            this.lblNumTribunal.Text = "Num";
            // 
            // txtNumTribunal
            // 
            this.txtNumTribunal.Location = new System.Drawing.Point(186, 364);
            this.txtNumTribunal.Name = "txtNumTribunal";
            this.txtNumTribunal.Size = new System.Drawing.Size(212, 20);
            this.txtNumTribunal.TabIndex = 5;
            // 
            // txtLugarExamen
            // 
            this.txtLugarExamen.Location = new System.Drawing.Point(186, 389);
            this.txtLugarExamen.Name = "txtLugarExamen";
            this.txtLugarExamen.Size = new System.Drawing.Size(212, 20);
            this.txtLugarExamen.TabIndex = 7;
            // 
            // lblLugarExamenTribunal
            // 
            this.lblLugarExamenTribunal.AutoSize = true;
            this.lblLugarExamenTribunal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugarExamenTribunal.Location = new System.Drawing.Point(59, 390);
            this.lblLugarExamenTribunal.Name = "lblLugarExamenTribunal";
            this.lblLugarExamenTribunal.Size = new System.Drawing.Size(120, 15);
            this.lblLugarExamenTribunal.TabIndex = 6;
            this.lblLugarExamenTribunal.Text = "Lugar de Examen";
            // 
            // txtNumComponentes
            // 
            this.txtNumComponentes.Location = new System.Drawing.Point(186, 415);
            this.txtNumComponentes.Name = "txtNumComponentes";
            this.txtNumComponentes.Size = new System.Drawing.Size(212, 20);
            this.txtNumComponentes.TabIndex = 9;
            // 
            // lblNumComponentesTribunal
            // 
            this.lblNumComponentesTribunal.AutoSize = true;
            this.lblNumComponentesTribunal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumComponentesTribunal.Location = new System.Drawing.Point(59, 416);
            this.lblNumComponentesTribunal.Name = "lblNumComponentesTribunal";
            this.lblNumComponentesTribunal.Size = new System.Drawing.Size(121, 15);
            this.lblNumComponentesTribunal.TabIndex = 8;
            this.lblNumComponentesTribunal.Text = "No. Componentes";
            // 
            // btnAgregarTribunal
            // 
            this.btnAgregarTribunal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTribunal.Location = new System.Drawing.Point(418, 348);
            this.btnAgregarTribunal.Name = "btnAgregarTribunal";
            this.btnAgregarTribunal.Size = new System.Drawing.Size(81, 31);
            this.btnAgregarTribunal.TabIndex = 10;
            this.btnAgregarTribunal.Text = "Agregar";
            this.btnAgregarTribunal.UseVisualStyleBackColor = true;
            this.btnAgregarTribunal.Click += new System.EventHandler(this.btnAgregarTribunal_Click);
            // 
            // btnActualizarTribunal
            // 
            this.btnActualizarTribunal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTribunal.Location = new System.Drawing.Point(520, 348);
            this.btnActualizarTribunal.Name = "btnActualizarTribunal";
            this.btnActualizarTribunal.Size = new System.Drawing.Size(94, 31);
            this.btnActualizarTribunal.TabIndex = 11;
            this.btnActualizarTribunal.Text = "Actualizar";
            this.btnActualizarTribunal.UseVisualStyleBackColor = true;
            this.btnActualizarTribunal.Click += new System.EventHandler(this.btnActualizarTribunal_Click);
            // 
            // btnEliminarTribunal
            // 
            this.btnEliminarTribunal.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTribunal.Location = new System.Drawing.Point(630, 348);
            this.btnEliminarTribunal.Name = "btnEliminarTribunal";
            this.btnEliminarTribunal.Size = new System.Drawing.Size(80, 31);
            this.btnEliminarTribunal.TabIndex = 12;
            this.btnEliminarTribunal.Text = "Eliminar";
            this.btnEliminarTribunal.UseVisualStyleBackColor = true;
            this.btnEliminarTribunal.Click += new System.EventHandler(this.btnEliminarTribunal_Click);
            // 
            // buscarTribunal
            // 
            this.buscarTribunal.AutoSize = true;
            this.buscarTribunal.Location = new System.Drawing.Point(374, 69);
            this.buscarTribunal.Name = "buscarTribunal";
            this.buscarTribunal.Size = new System.Drawing.Size(40, 13);
            this.buscarTribunal.TabIndex = 13;
            this.buscarTribunal.Text = "Buscar";
            this.buscarTribunal.Click += new System.EventHandler(this.label1_Click);
            // 
            // buscarText
            // 
            this.buscarText.Location = new System.Drawing.Point(437, 66);
            this.buscarText.Name = "buscarText";
            this.buscarText.Size = new System.Drawing.Size(273, 20);
            this.buscarText.TabIndex = 14;
            // 
            // FormTribunales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.buscarText);
            this.Controls.Add(this.buscarTribunal);
            this.Controls.Add(this.btnEliminarTribunal);
            this.Controls.Add(this.btnActualizarTribunal);
            this.Controls.Add(this.btnAgregarTribunal);
            this.Controls.Add(this.txtNumComponentes);
            this.Controls.Add(this.lblNumComponentesTribunal);
            this.Controls.Add(this.txtLugarExamen);
            this.Controls.Add(this.lblLugarExamenTribunal);
            this.Controls.Add(this.txtNumTribunal);
            this.Controls.Add(this.lblNumTribunal);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnLeerTribunal);
            this.Controls.Add(this.lblTribunales);
            this.Controls.Add(this.listTribunales);
            this.Name = "FormTribunales";
            this.Text = "FormTribunales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listTribunales;
        private System.Windows.Forms.ColumnHeader colNum;
        private System.Windows.Forms.ColumnHeader colLugarExamen;
        private System.Windows.Forms.ColumnHeader colNumComponentes;
        private System.Windows.Forms.Label lblTribunales;
        private System.Windows.Forms.Button btnLeerTribunal;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblNumTribunal;
        private System.Windows.Forms.TextBox txtNumTribunal;
        private System.Windows.Forms.TextBox txtLugarExamen;
        private System.Windows.Forms.Label lblLugarExamenTribunal;
        private System.Windows.Forms.TextBox txtNumComponentes;
        private System.Windows.Forms.Label lblNumComponentesTribunal;
        private System.Windows.Forms.Button btnAgregarTribunal;
        private System.Windows.Forms.Button btnActualizarTribunal;
        private System.Windows.Forms.Button btnEliminarTribunal;
        private System.Windows.Forms.Label buscarTribunal;
        private System.Windows.Forms.TextBox buscarText;
    }
}