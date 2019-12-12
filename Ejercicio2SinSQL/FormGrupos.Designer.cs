namespace Ejercicio2SinSQL
{
    partial class FormGrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrupos));
            this.listGrupos = new System.Windows.Forms.ListView();
            this.colNumgrupo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombreGrupo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumComponente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLeerGrupo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            this.txtNumGrupo = new System.Windows.Forms.TextBox();
            this.lblNumGrupo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.lblComponente = new System.Windows.Forms.Label();
            this.txtNumeroComponente = new System.Windows.Forms.TextBox();
            this.btnAgregarGrupo = new System.Windows.Forms.Button();
            this.btnActualizarGrupo = new System.Windows.Forms.Button();
            this.btnEliminarGrupo = new System.Windows.Forms.Button();
            this.buscarText = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listGrupos
            // 
            this.listGrupos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNumgrupo,
            this.colNombreGrupo,
            this.colNumComponente});
            this.listGrupos.HideSelection = false;
            this.listGrupos.Location = new System.Drawing.Point(116, 105);
            this.listGrupos.Name = "listGrupos";
            this.listGrupos.Size = new System.Drawing.Size(553, 160);
            this.listGrupos.TabIndex = 0;
            this.listGrupos.UseCompatibleStateImageBehavior = false;
            this.listGrupos.View = System.Windows.Forms.View.Details;
            // 
            // colNumgrupo
            // 
            this.colNumgrupo.Text = "Numero grupo";
            this.colNumgrupo.Width = 132;
            // 
            // colNombreGrupo
            // 
            this.colNombreGrupo.Text = "Nombe grupo";
            this.colNombreGrupo.Width = 143;
            // 
            // colNumComponente
            // 
            this.colNumComponente.Text = "Numero componente";
            this.colNumComponente.Width = 130;
            // 
            // btnLeerGrupo
            // 
            this.btnLeerGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnLeerGrupo.Image")));
            this.btnLeerGrupo.Location = new System.Drawing.Point(116, 50);
            this.btnLeerGrupo.Name = "btnLeerGrupo";
            this.btnLeerGrupo.Size = new System.Drawing.Size(71, 49);
            this.btnLeerGrupo.TabIndex = 1;
            this.btnLeerGrupo.UseVisualStyleBackColor = true;
            this.btnLeerGrupo.Click += new System.EventHandler(this.btnLeerGrupo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(340, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(132, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Lista grupos";
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.Location = new System.Drawing.Point(594, 76);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(75, 23);
            this.btnVolverInicio.TabIndex = 3;
            this.btnVolverInicio.Text = "Volver inicio";
            this.btnVolverInicio.UseVisualStyleBackColor = true;
            this.btnVolverInicio.Click += new System.EventHandler(this.btnVolverInicio_Click);
            // 
            // txtNumGrupo
            // 
            this.txtNumGrupo.Location = new System.Drawing.Point(243, 293);
            this.txtNumGrupo.Name = "txtNumGrupo";
            this.txtNumGrupo.Size = new System.Drawing.Size(158, 20);
            this.txtNumGrupo.TabIndex = 4;
            // 
            // lblNumGrupo
            // 
            this.lblNumGrupo.AutoSize = true;
            this.lblNumGrupo.Location = new System.Drawing.Point(113, 296);
            this.lblNumGrupo.Name = "lblNumGrupo";
            this.lblNumGrupo.Size = new System.Drawing.Size(76, 13);
            this.lblNumGrupo.TabIndex = 5;
            this.lblNumGrupo.Text = "Numero Grupo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(113, 335);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(74, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre grupo";
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.Location = new System.Drawing.Point(243, 332);
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.Size = new System.Drawing.Size(158, 20);
            this.txtNombreGrupo.TabIndex = 6;
            // 
            // lblComponente
            // 
            this.lblComponente.AutoSize = true;
            this.lblComponente.Location = new System.Drawing.Point(113, 378);
            this.lblComponente.Name = "lblComponente";
            this.lblComponente.Size = new System.Drawing.Size(106, 13);
            this.lblComponente.TabIndex = 9;
            this.lblComponente.Text = "Numero componente";
            // 
            // txtNumeroComponente
            // 
            this.txtNumeroComponente.Location = new System.Drawing.Point(243, 375);
            this.txtNumeroComponente.Name = "txtNumeroComponente";
            this.txtNumeroComponente.Size = new System.Drawing.Size(158, 20);
            this.txtNumeroComponente.TabIndex = 8;
            // 
            // btnAgregarGrupo
            // 
            this.btnAgregarGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarGrupo.Image")));
            this.btnAgregarGrupo.Location = new System.Drawing.Point(407, 293);
            this.btnAgregarGrupo.Name = "btnAgregarGrupo";
            this.btnAgregarGrupo.Size = new System.Drawing.Size(83, 79);
            this.btnAgregarGrupo.TabIndex = 10;
            this.btnAgregarGrupo.UseVisualStyleBackColor = true;
            this.btnAgregarGrupo.Click += new System.EventHandler(this.btnAgregarGrupo_Click);
            // 
            // btnActualizarGrupo
            // 
            this.btnActualizarGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarGrupo.Image")));
            this.btnActualizarGrupo.Location = new System.Drawing.Point(496, 293);
            this.btnActualizarGrupo.Name = "btnActualizarGrupo";
            this.btnActualizarGrupo.Size = new System.Drawing.Size(79, 79);
            this.btnActualizarGrupo.TabIndex = 11;
            this.btnActualizarGrupo.UseVisualStyleBackColor = true;
            this.btnActualizarGrupo.Click += new System.EventHandler(this.btnActualizarGrupo_Click);
            // 
            // btnEliminarGrupo
            // 
            this.btnEliminarGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarGrupo.Image")));
            this.btnEliminarGrupo.Location = new System.Drawing.Point(581, 293);
            this.btnEliminarGrupo.Name = "btnEliminarGrupo";
            this.btnEliminarGrupo.Size = new System.Drawing.Size(88, 79);
            this.btnEliminarGrupo.TabIndex = 12;
            this.btnEliminarGrupo.UseVisualStyleBackColor = true;
            this.btnEliminarGrupo.Click += new System.EventHandler(this.btnEliminarGrupo_Click);
            // 
            // buscarText
            // 
            this.buscarText.Location = new System.Drawing.Point(478, 50);
            this.buscarText.Name = "buscarText";
            this.buscarText.Size = new System.Drawing.Size(191, 20);
            this.buscarText.TabIndex = 13;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(432, 53);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 14;
            this.lblBuscar.Text = "Buscar";
            // 
            // FormGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.buscarText);
            this.Controls.Add(this.btnEliminarGrupo);
            this.Controls.Add(this.btnActualizarGrupo);
            this.Controls.Add(this.btnAgregarGrupo);
            this.Controls.Add(this.lblComponente);
            this.Controls.Add(this.txtNumeroComponente);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombreGrupo);
            this.Controls.Add(this.lblNumGrupo);
            this.Controls.Add(this.txtNumGrupo);
            this.Controls.Add(this.btnVolverInicio);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnLeerGrupo);
            this.Controls.Add(this.listGrupos);
            this.Name = "FormGrupos";
            this.Text = "FormGrupos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listGrupos;
        private System.Windows.Forms.ColumnHeader colNumgrupo;
        private System.Windows.Forms.ColumnHeader colNombreGrupo;
        private System.Windows.Forms.ColumnHeader colNumComponente;
        private System.Windows.Forms.Button btnLeerGrupo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVolverInicio;
        private System.Windows.Forms.TextBox txtNumGrupo;
        private System.Windows.Forms.Label lblNumGrupo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreGrupo;
        private System.Windows.Forms.Label lblComponente;
        private System.Windows.Forms.TextBox txtNumeroComponente;
        private System.Windows.Forms.Button btnAgregarGrupo;
        private System.Windows.Forms.Button btnActualizarGrupo;
        private System.Windows.Forms.Button btnEliminarGrupo;
        private System.Windows.Forms.TextBox buscarText;
        private System.Windows.Forms.Label lblBuscar;
    }
}