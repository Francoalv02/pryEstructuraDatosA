
namespace pryEstructuraDatos
{
    partial class frmEscructuraDinamicaLineal_Cola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEscructuraDinamicaLineal_Cola));
            this.groSecundario = new System.Windows.Forms.GroupBox();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpElementoEliminado = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtTramiteEliminado = new System.Windows.Forms.TextBox();
            this.txtCodigoEliminado = new System.Windows.Forms.TextBox();
            this.lblTramiteEE = new System.Windows.Forms.Label();
            this.lblCodigoEE = new System.Windows.Forms.Label();
            this.txtNombreEliminado = new System.Windows.Forms.TextBox();
            this.lblNombreEE = new System.Windows.Forms.Label();
            this.picRepresentacionCola = new System.Windows.Forms.PictureBox();
            this.groSecundario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.groNuevoElemento.SuspendLayout();
            this.grpElementoEliminado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRepresentacionCola)).BeginInit();
            this.SuspendLayout();
            // 
            // groSecundario
            // 
            this.groSecundario.Controls.Add(this.lstCola);
            this.groSecundario.Controls.Add(this.dgvGrilla);
            this.groSecundario.Location = new System.Drawing.Point(20, 238);
            this.groSecundario.Name = "groSecundario";
            this.groSecundario.Size = new System.Drawing.Size(648, 205);
            this.groSecundario.TabIndex = 1;
            this.groSecundario.TabStop = false;
            this.groSecundario.Text = "Listado en una Lista y una Grilla";
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(6, 19);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(218, 173);
            this.lstCola.TabIndex = 6;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvGrilla.Location = new System.Drawing.Point(235, 19);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(407, 180);
            this.dgvGrilla.TabIndex = 4;
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
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.Name = "Tramite";
            // 
            // groNuevoElemento
            // 
            this.groNuevoElemento.Controls.Add(this.btnAgregar);
            this.groNuevoElemento.Controls.Add(this.txtTramite);
            this.groNuevoElemento.Controls.Add(this.txtCodigo);
            this.groNuevoElemento.Controls.Add(this.lblTramite);
            this.groNuevoElemento.Controls.Add(this.lblCodigo);
            this.groNuevoElemento.Controls.Add(this.txtNombre);
            this.groNuevoElemento.Controls.Add(this.lblNombre);
            this.groNuevoElemento.Location = new System.Drawing.Point(244, 12);
            this.groNuevoElemento.Name = "groNuevoElemento";
            this.groNuevoElemento.Size = new System.Drawing.Size(261, 220);
            this.groNuevoElemento.TabIndex = 2;
            this.groNuevoElemento.TabStop = false;
            this.groNuevoElemento.Text = "Nuevos Elementos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(97, 165);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(158, 49);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(97, 134);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(97, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(21, 141);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 4;
            this.lblTramite.Text = "Tramite:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(21, 39);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 91);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // grpElementoEliminado
            // 
            this.grpElementoEliminado.Controls.Add(this.btnEliminar);
            this.grpElementoEliminado.Controls.Add(this.txtTramiteEliminado);
            this.grpElementoEliminado.Controls.Add(this.txtCodigoEliminado);
            this.grpElementoEliminado.Controls.Add(this.lblTramiteEE);
            this.grpElementoEliminado.Controls.Add(this.lblCodigoEE);
            this.grpElementoEliminado.Controls.Add(this.txtNombreEliminado);
            this.grpElementoEliminado.Controls.Add(this.lblNombreEE);
            this.grpElementoEliminado.Location = new System.Drawing.Point(511, 12);
            this.grpElementoEliminado.Name = "grpElementoEliminado";
            this.grpElementoEliminado.Size = new System.Drawing.Size(261, 220);
            this.grpElementoEliminado.TabIndex = 3;
            this.grpElementoEliminado.TabStop = false;
            this.grpElementoEliminado.Text = " Elementos Eliminados";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(97, 165);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(158, 49);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtTramiteEliminado
            // 
            this.txtTramiteEliminado.Location = new System.Drawing.Point(97, 134);
            this.txtTramiteEliminado.Name = "txtTramiteEliminado";
            this.txtTramiteEliminado.Size = new System.Drawing.Size(100, 20);
            this.txtTramiteEliminado.TabIndex = 5;
            // 
            // txtCodigoEliminado
            // 
            this.txtCodigoEliminado.Location = new System.Drawing.Point(97, 32);
            this.txtCodigoEliminado.Name = "txtCodigoEliminado";
            this.txtCodigoEliminado.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoEliminado.TabIndex = 1;
            // 
            // lblTramiteEE
            // 
            this.lblTramiteEE.AutoSize = true;
            this.lblTramiteEE.Location = new System.Drawing.Point(21, 141);
            this.lblTramiteEE.Name = "lblTramiteEE";
            this.lblTramiteEE.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteEE.TabIndex = 4;
            this.lblTramiteEE.Text = "Tramite:";
            // 
            // lblCodigoEE
            // 
            this.lblCodigoEE.AutoSize = true;
            this.lblCodigoEE.Location = new System.Drawing.Point(21, 39);
            this.lblCodigoEE.Name = "lblCodigoEE";
            this.lblCodigoEE.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoEE.TabIndex = 0;
            this.lblCodigoEE.Text = "Codigo:";
            // 
            // txtNombreEliminado
            // 
            this.txtNombreEliminado.Location = new System.Drawing.Point(97, 84);
            this.txtNombreEliminado.Name = "txtNombreEliminado";
            this.txtNombreEliminado.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEliminado.TabIndex = 3;
            // 
            // lblNombreEE
            // 
            this.lblNombreEE.AutoSize = true;
            this.lblNombreEE.Location = new System.Drawing.Point(21, 91);
            this.lblNombreEE.Name = "lblNombreEE";
            this.lblNombreEE.Size = new System.Drawing.Size(47, 13);
            this.lblNombreEE.TabIndex = 2;
            this.lblNombreEE.Text = "Nombre:";
            // 
            // picRepresentacionCola
            // 
            this.picRepresentacionCola.Image = ((System.Drawing.Image)(resources.GetObject("picRepresentacionCola.Image")));
            this.picRepresentacionCola.Location = new System.Drawing.Point(12, 5);
            this.picRepresentacionCola.Name = "picRepresentacionCola";
            this.picRepresentacionCola.Size = new System.Drawing.Size(226, 227);
            this.picRepresentacionCola.TabIndex = 4;
            this.picRepresentacionCola.TabStop = false;
            // 
            // frmEscructuraDinamicaLineal_Cola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(781, 455);
            this.Controls.Add(this.picRepresentacionCola);
            this.Controls.Add(this.grpElementoEliminado);
            this.Controls.Add(this.groNuevoElemento);
            this.Controls.Add(this.groSecundario);
            this.Name = "frmEscructuraDinamicaLineal_Cola";
            this.Text = "Escructura Dinamica Lineal Cola";
            this.groSecundario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.groNuevoElemento.ResumeLayout(false);
            this.groNuevoElemento.PerformLayout();
            this.grpElementoEliminado.ResumeLayout(false);
            this.grpElementoEliminado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRepresentacionCola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groSecundario;
        private System.Windows.Forms.GroupBox groNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpElementoEliminado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtTramiteEliminado;
        private System.Windows.Forms.TextBox txtCodigoEliminado;
        private System.Windows.Forms.Label lblTramiteEE;
        private System.Windows.Forms.Label lblCodigoEE;
        private System.Windows.Forms.TextBox txtNombreEliminado;
        private System.Windows.Forms.Label lblNombreEE;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.PictureBox picRepresentacionCola;
        private System.Windows.Forms.ListBox lstCola;
    }
}