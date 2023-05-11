namespace pryEstructuraDatos
{
    partial class frmCola
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
            this.gpbNuevoelemento = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gpbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblTraEliminar = new System.Windows.Forms.Label();
            this.lblNombreEliminar = new System.Windows.Forms.Label();
            this.lblCodEliminar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.lblListado = new System.Windows.Forms.Label();
            this.gpbNuevoelemento.SuspendLayout();
            this.gpbElementoEliminado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbNuevoelemento
            // 
            this.gpbNuevoelemento.Controls.Add(this.txtTramite);
            this.gpbNuevoelemento.Controls.Add(this.txtNombre);
            this.gpbNuevoelemento.Controls.Add(this.txtCodigo);
            this.gpbNuevoelemento.Controls.Add(this.btnAgregar);
            this.gpbNuevoelemento.Controls.Add(this.lblTramite);
            this.gpbNuevoelemento.Controls.Add(this.lblNombre);
            this.gpbNuevoelemento.Controls.Add(this.lblCodigo);
            this.gpbNuevoelemento.Location = new System.Drawing.Point(246, 12);
            this.gpbNuevoelemento.Name = "gpbNuevoelemento";
            this.gpbNuevoelemento.Size = new System.Drawing.Size(178, 214);
            this.gpbNuevoelemento.TabIndex = 0;
            this.gpbNuevoelemento.TabStop = false;
            this.gpbNuevoelemento.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(56, 113);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(56, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(56, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(30, 158);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 50);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(6, 116);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(42, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // gpbElementoEliminado
            // 
            this.gpbElementoEliminado.Controls.Add(this.lblTraEliminar);
            this.gpbElementoEliminado.Controls.Add(this.lblNombreEliminar);
            this.gpbElementoEliminado.Controls.Add(this.lblCodEliminar);
            this.gpbElementoEliminado.Controls.Add(this.btnEliminar);
            this.gpbElementoEliminado.Controls.Add(this.lblTramite2);
            this.gpbElementoEliminado.Controls.Add(this.lblNombre2);
            this.gpbElementoEliminado.Controls.Add(this.lblCodigo2);
            this.gpbElementoEliminado.Location = new System.Drawing.Point(441, 12);
            this.gpbElementoEliminado.Name = "gpbElementoEliminado";
            this.gpbElementoEliminado.Size = new System.Drawing.Size(178, 214);
            this.gpbElementoEliminado.TabIndex = 1;
            this.gpbElementoEliminado.TabStop = false;
            this.gpbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // lblTraEliminar
            // 
            this.lblTraEliminar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTraEliminar.Location = new System.Drawing.Point(63, 107);
            this.lblTraEliminar.Name = "lblTraEliminar";
            this.lblTraEliminar.Size = new System.Drawing.Size(98, 22);
            this.lblTraEliminar.TabIndex = 8;
            // 
            // lblNombreEliminar
            // 
            this.lblNombreEliminar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreEliminar.Location = new System.Drawing.Point(63, 69);
            this.lblNombreEliminar.Name = "lblNombreEliminar";
            this.lblNombreEliminar.Size = new System.Drawing.Size(98, 22);
            this.lblNombreEliminar.TabIndex = 7;
            // 
            // lblCodEliminar
            // 
            this.lblCodEliminar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodEliminar.Location = new System.Drawing.Point(63, 29);
            this.lblCodEliminar.Name = "lblCodEliminar";
            this.lblCodEliminar.Size = new System.Drawing.Size(98, 22);
            this.lblCodEliminar.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(36, 158);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 50);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTramite2
            // 
            this.lblTramite2.AutoSize = true;
            this.lblTramite2.Location = new System.Drawing.Point(6, 116);
            this.lblTramite2.Name = "lblTramite2";
            this.lblTramite2.Size = new System.Drawing.Size(42, 13);
            this.lblTramite2.TabIndex = 5;
            this.lblTramite2.Text = "Tramite";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(6, 78);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(44, 13);
            this.lblNombre2.TabIndex = 4;
            this.lblNombre2.Text = "Nombre";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(6, 38);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo2.TabIndex = 3;
            this.lblCodigo2.Text = "Codigo";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvDatos.Location = new System.Drawing.Point(246, 266);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(372, 173);
            this.dgvDatos.TabIndex = 2;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.Name = "Tramite";
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(15, 266);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(215, 173);
            this.lstCola.TabIndex = 3;
            // 
            // picFoto
            // 
            this.picFoto.Image = global::pryEstructuraDatos.Properties.Resources.cola;
            this.picFoto.Location = new System.Drawing.Point(12, 12);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(218, 214);
            this.picFoto.TabIndex = 4;
            this.picFoto.TabStop = false;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Location = new System.Drawing.Point(12, 240);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(157, 13);
            this.lblListado.TabIndex = 5;
            this.lblListado.Text = "Listado en una Lista y una Grilla";
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 513);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.lstCola);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.gpbElementoEliminado);
            this.Controls.Add(this.gpbNuevoelemento);
            this.Name = "frmCola";
            this.Text = "Cola";
            this.gpbNuevoelemento.ResumeLayout(false);
            this.gpbNuevoelemento.PerformLayout();
            this.gpbElementoEliminado.ResumeLayout(false);
            this.gpbElementoEliminado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbNuevoelemento;
        private System.Windows.Forms.GroupBox gpbElementoEliminado;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodEliminar;
        private System.Windows.Forms.Label lblTraEliminar;
        private System.Windows.Forms.Label lblNombreEliminar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}