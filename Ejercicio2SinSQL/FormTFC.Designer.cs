namespace Ejercicio2SinSQL
{
    partial class FormTFC
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
            this.listTFC = new System.Windows.Forms.ListView();
            this.colNum_orden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTema = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTFC = new System.Windows.Forms.Label();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNum_orden = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtNum_orden = new System.Windows.Forms.TextBox();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.buscarText = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listTFC
            // 
            this.listTFC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNum_orden,
            this.colTema,
            this.colFecha});
            this.listTFC.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTFC.HideSelection = false;
            this.listTFC.Location = new System.Drawing.Point(66, 80);
            this.listTFC.Name = "listTFC";
            this.listTFC.Size = new System.Drawing.Size(509, 230);
            this.listTFC.TabIndex = 0;
            this.listTFC.UseCompatibleStateImageBehavior = false;
            this.listTFC.View = System.Windows.Forms.View.Details;
            // 
            // colNum_orden
            // 
            this.colNum_orden.Text = "Numero orden";
            this.colNum_orden.Width = 132;
            // 
            // colTema
            // 
            this.colTema.Text = "Tema";
            this.colTema.Width = 196;
            // 
            // colFecha
            // 
            this.colFecha.Text = "Fecha";
            this.colFecha.Width = 151;
            // 
            // lblTFC
            // 
            this.lblTFC.AutoSize = true;
            this.lblTFC.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTFC.Location = new System.Drawing.Point(290, 9);
            this.lblTFC.Name = "lblTFC";
            this.lblTFC.Size = new System.Drawing.Size(65, 28);
            this.lblTFC.TabIndex = 1;
            this.lblTFC.Text = "TFC";
            // 
            // btnLeer
            // 
            this.btnLeer.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeer.Location = new System.Drawing.Point(66, 36);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 2;
            this.btnLeer.Text = "LEER";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(500, 36);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(433, 328);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 28);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(433, 368);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(117, 26);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(433, 406);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 26);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblNum_orden
            // 
            this.lblNum_orden.AutoSize = true;
            this.lblNum_orden.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum_orden.Location = new System.Drawing.Point(66, 326);
            this.lblNum_orden.Name = "lblNum_orden";
            this.lblNum_orden.Size = new System.Drawing.Size(88, 15);
            this.lblNum_orden.TabIndex = 7;
            this.lblNum_orden.Text = "Numero orden";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.Location = new System.Drawing.Point(66, 369);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(39, 15);
            this.lblTema.TabIndex = 8;
            this.lblTema.Text = "Tema";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(69, 413);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 15);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha";
            // 
            // txtNum_orden
            // 
            this.txtNum_orden.Location = new System.Drawing.Point(172, 326);
            this.txtNum_orden.Name = "txtNum_orden";
            this.txtNum_orden.Size = new System.Drawing.Size(192, 20);
            this.txtNum_orden.TabIndex = 10;
            // 
            // txtTema
            // 
            this.txtTema.Location = new System.Drawing.Point(172, 369);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(192, 20);
            this.txtTema.TabIndex = 11;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(172, 413);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(192, 20);
            this.txtFecha.TabIndex = 12;
            // 
            // buscarText
            // 
            this.buscarText.Location = new System.Drawing.Point(336, 38);
            this.buscarText.Name = "buscarText";
            this.buscarText.Size = new System.Drawing.Size(158, 20);
            this.buscarText.TabIndex = 13;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(292, 41);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 14;
            this.lblBuscar.Text = "Buscar";
            // 
            // FormTFC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 466);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.buscarText);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtTema);
            this.Controls.Add(this.txtNum_orden);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblNum_orden);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.lblTFC);
            this.Controls.Add(this.listTFC);
            this.Name = "FormTFC";
            this.Text = "FormTfc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listTFC;
        private System.Windows.Forms.ColumnHeader colNum_orden;
        private System.Windows.Forms.ColumnHeader colTema;
        private System.Windows.Forms.ColumnHeader colFecha;
        private System.Windows.Forms.Label lblTFC;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNum_orden;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtNum_orden;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox buscarText;
        private System.Windows.Forms.Label lblBuscar;
    }
}