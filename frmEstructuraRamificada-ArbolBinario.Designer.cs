namespace pryEstructuraDatos
{
    partial class frmEstructuraRamificada_ArbolBinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstructuraRamificada_ArbolBinario));
            this.picRepresentacionEnlazada = new System.Windows.Forms.PictureBox();
            this.grpElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblCodigoEE = new System.Windows.Forms.Label();
            this.cbCodigoEE = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groSecundario = new System.Windows.Forms.GroupBox();
            this.lstEnlazada = new System.Windows.Forms.ListBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp = new System.Windows.Forms.GroupBox();
            this.rbInOrdenAsc = new System.Windows.Forms.RadioButton();
            this.btnOrdenarArbol = new System.Windows.Forms.Button();
            this.rbInOrdenDesc = new System.Windows.Forms.RadioButton();
            this.rbPostOrden = new System.Windows.Forms.RadioButton();
            this.rbPreOrden = new System.Windows.Forms.RadioButton();
            this.tvArbol = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.picRepresentacionEnlazada)).BeginInit();
            this.grpElementoEliminado.SuspendLayout();
            this.groNuevoElemento.SuspendLayout();
            this.groSecundario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // picRepresentacionEnlazada
            // 
            this.picRepresentacionEnlazada.Image = ((System.Drawing.Image)(resources.GetObject("picRepresentacionEnlazada.Image")));
            this.picRepresentacionEnlazada.Location = new System.Drawing.Point(12, 12);
            this.picRepresentacionEnlazada.Name = "picRepresentacionEnlazada";
            this.picRepresentacionEnlazada.Size = new System.Drawing.Size(288, 229);
            this.picRepresentacionEnlazada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRepresentacionEnlazada.TabIndex = 17;
            this.picRepresentacionEnlazada.TabStop = false;
            // 
            // grpElementoEliminado
            // 
            this.grpElementoEliminado.Controls.Add(this.lblCodigoEE);
            this.grpElementoEliminado.Controls.Add(this.cbCodigoEE);
            this.grpElementoEliminado.Controls.Add(this.btnEliminar);
            this.grpElementoEliminado.Location = new System.Drawing.Point(511, 79);
            this.grpElementoEliminado.Name = "grpElementoEliminado";
            this.grpElementoEliminado.Size = new System.Drawing.Size(209, 115);
            this.grpElementoEliminado.TabIndex = 16;
            this.grpElementoEliminado.TabStop = false;
            this.grpElementoEliminado.Text = " Elementos Eliminados";
            // 
            // lblCodigoEE
            // 
            this.lblCodigoEE.AutoSize = true;
            this.lblCodigoEE.Location = new System.Drawing.Point(21, 27);
            this.lblCodigoEE.Name = "lblCodigoEE";
            this.lblCodigoEE.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoEE.TabIndex = 7;
            this.lblCodigoEE.Text = "Codigo:";
            // 
            // cbCodigoEE
            // 
            this.cbCodigoEE.FormattingEnabled = true;
            this.cbCodigoEE.Location = new System.Drawing.Point(70, 28);
            this.cbCodigoEE.Name = "cbCodigoEE";
            this.cbCodigoEE.Size = new System.Drawing.Size(121, 21);
            this.cbCodigoEE.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(24, 60);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(158, 49);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.groNuevoElemento.Location = new System.Drawing.Point(306, 12);
            this.groNuevoElemento.Name = "groNuevoElemento";
            this.groNuevoElemento.Size = new System.Drawing.Size(190, 229);
            this.groNuevoElemento.TabIndex = 15;
            this.groNuevoElemento.TabStop = false;
            this.groNuevoElemento.Text = "Nuevos Elementos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(14, 164);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(158, 49);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(72, 138);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(72, 36);
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
            this.txtNombre.Location = new System.Drawing.Point(72, 88);
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
            // groSecundario
            // 
            this.groSecundario.Controls.Add(this.lstEnlazada);
            this.groSecundario.Controls.Add(this.dgvGrilla);
            this.groSecundario.Location = new System.Drawing.Point(12, 318);
            this.groSecundario.Name = "groSecundario";
            this.groSecundario.Size = new System.Drawing.Size(699, 205);
            this.groSecundario.TabIndex = 14;
            this.groSecundario.TabStop = false;
            this.groSecundario.Text = "Listado en una Lista y una Grilla";
            // 
            // lstEnlazada
            // 
            this.lstEnlazada.FormattingEnabled = true;
            this.lstEnlazada.Location = new System.Drawing.Point(6, 19);
            this.lstEnlazada.Name = "lstEnlazada";
            this.lstEnlazada.Size = new System.Drawing.Size(218, 173);
            this.lstEnlazada.TabIndex = 6;
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
            this.dgvGrilla.Size = new System.Drawing.Size(439, 180);
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
            // grp
            // 
            this.grp.Controls.Add(this.rbInOrdenAsc);
            this.grp.Controls.Add(this.btnOrdenarArbol);
            this.grp.Controls.Add(this.rbInOrdenDesc);
            this.grp.Controls.Add(this.rbPostOrden);
            this.grp.Controls.Add(this.rbPreOrden);
            this.grp.Location = new System.Drawing.Point(18, 247);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(693, 65);
            this.grp.TabIndex = 7;
            this.grp.TabStop = false;
            this.grp.Text = "Seleccione un Sistema de Ordenamiento";
            // 
            // rbInOrdenAsc
            // 
            this.rbInOrdenAsc.AutoSize = true;
            this.rbInOrdenAsc.Location = new System.Drawing.Point(36, 30);
            this.rbInOrdenAsc.Name = "rbInOrdenAsc";
            this.rbInOrdenAsc.Size = new System.Drawing.Size(81, 17);
            this.rbInOrdenAsc.TabIndex = 22;
            this.rbInOrdenAsc.TabStop = true;
            this.rbInOrdenAsc.Text = "InOrdenAsc";
            this.rbInOrdenAsc.UseVisualStyleBackColor = true;
            this.rbInOrdenAsc.CheckedChanged += new System.EventHandler(this.rbInOrdenAsc_CheckedChanged);
            // 
            // btnOrdenarArbol
            // 
            this.btnOrdenarArbol.Location = new System.Drawing.Point(510, 10);
            this.btnOrdenarArbol.Name = "btnOrdenarArbol";
            this.btnOrdenarArbol.Size = new System.Drawing.Size(158, 49);
            this.btnOrdenarArbol.TabIndex = 18;
            this.btnOrdenarArbol.Text = "Ordenar Arbol";
            this.btnOrdenarArbol.UseVisualStyleBackColor = true;
            this.btnOrdenarArbol.Click += new System.EventHandler(this.btnOrdenarArbol_Click);
            // 
            // rbInOrdenDesc
            // 
            this.rbInOrdenDesc.AutoSize = true;
            this.rbInOrdenDesc.Location = new System.Drawing.Point(153, 30);
            this.rbInOrdenDesc.Name = "rbInOrdenDesc";
            this.rbInOrdenDesc.Size = new System.Drawing.Size(88, 17);
            this.rbInOrdenDesc.TabIndex = 21;
            this.rbInOrdenDesc.TabStop = true;
            this.rbInOrdenDesc.Text = "InOrdenDesc";
            this.rbInOrdenDesc.UseVisualStyleBackColor = true;
            this.rbInOrdenDesc.CheckedChanged += new System.EventHandler(this.rbInOrdenDesc_CheckedChanged);
            // 
            // rbPostOrden
            // 
            this.rbPostOrden.AutoSize = true;
            this.rbPostOrden.Location = new System.Drawing.Point(385, 30);
            this.rbPostOrden.Name = "rbPostOrden";
            this.rbPostOrden.Size = new System.Drawing.Size(75, 17);
            this.rbPostOrden.TabIndex = 20;
            this.rbPostOrden.TabStop = true;
            this.rbPostOrden.Text = "PostOrden";
            this.rbPostOrden.UseVisualStyleBackColor = true;
            this.rbPostOrden.CheckedChanged += new System.EventHandler(this.rbPostOrden_CheckedChanged);
            // 
            // rbPreOrden
            // 
            this.rbPreOrden.AutoSize = true;
            this.rbPreOrden.Location = new System.Drawing.Point(271, 30);
            this.rbPreOrden.Name = "rbPreOrden";
            this.rbPreOrden.Size = new System.Drawing.Size(70, 17);
            this.rbPreOrden.TabIndex = 19;
            this.rbPreOrden.TabStop = true;
            this.rbPreOrden.Text = "PreOrden";
            this.rbPreOrden.UseVisualStyleBackColor = true;
            this.rbPreOrden.CheckedChanged += new System.EventHandler(this.rbPreOrden_CheckedChanged);
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(726, 12);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(244, 498);
            this.tvArbol.TabIndex = 20;
            // 
            // frmEstructuraRamificada_ArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(983, 535);
            this.Controls.Add(this.tvArbol);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.picRepresentacionEnlazada);
            this.Controls.Add(this.grpElementoEliminado);
            this.Controls.Add(this.groNuevoElemento);
            this.Controls.Add(this.groSecundario);
            this.Name = "frmEstructuraRamificada_ArbolBinario";
            this.Text = "Estructura Ramificada-Arbol Binario";
            this.Load += new System.EventHandler(this.frmEstructuraRamificada_ArbolBinario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRepresentacionEnlazada)).EndInit();
            this.grpElementoEliminado.ResumeLayout(false);
            this.grpElementoEliminado.PerformLayout();
            this.groNuevoElemento.ResumeLayout(false);
            this.groNuevoElemento.PerformLayout();
            this.groSecundario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picRepresentacionEnlazada;
        private System.Windows.Forms.GroupBox grpElementoEliminado;
        private System.Windows.Forms.Label lblCodigoEE;
        private System.Windows.Forms.ComboBox cbCodigoEE;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groSecundario;
        private System.Windows.Forms.ListBox lstEnlazada;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.RadioButton rbPostOrden;
        private System.Windows.Forms.RadioButton rbPreOrden;
        private System.Windows.Forms.RadioButton rbInOrdenDesc;
        private System.Windows.Forms.Button btnOrdenarArbol;
        private System.Windows.Forms.RadioButton rbInOrdenAsc;
        private System.Windows.Forms.TreeView tvArbol;
    }
}