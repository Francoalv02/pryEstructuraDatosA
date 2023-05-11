namespace pryEstructuraDatos
{
    partial class frmListaDoblementeEnlazada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaDoblementeEnlazada));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDescendente = new System.Windows.Forms.RadioButton();
            this.rbAscendente = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picRepresentacionEnlazada)).BeginInit();
            this.grpElementoEliminado.SuspendLayout();
            this.groNuevoElemento.SuspendLayout();
            this.groSecundario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picRepresentacionEnlazada
            // 
            this.picRepresentacionEnlazada.Image = ((System.Drawing.Image)(resources.GetObject("picRepresentacionEnlazada.Image")));
            this.picRepresentacionEnlazada.Location = new System.Drawing.Point(7, 44);
            this.picRepresentacionEnlazada.Name = "picRepresentacionEnlazada";
            this.picRepresentacionEnlazada.Size = new System.Drawing.Size(337, 150);
            this.picRepresentacionEnlazada.TabIndex = 12;
            this.picRepresentacionEnlazada.TabStop = false;
            this.picRepresentacionEnlazada.Click += new System.EventHandler(this.picRepresentacionEnlazada_Click);
            // 
            // grpElementoEliminado
            // 
            this.grpElementoEliminado.Controls.Add(this.lblCodigoEE);
            this.grpElementoEliminado.Controls.Add(this.cbCodigoEE);
            this.grpElementoEliminado.Controls.Add(this.btnEliminar);
            this.grpElementoEliminado.Location = new System.Drawing.Point(620, 12);
            this.grpElementoEliminado.Name = "grpElementoEliminado";
            this.grpElementoEliminado.Size = new System.Drawing.Size(261, 115);
            this.grpElementoEliminado.TabIndex = 11;
            this.grpElementoEliminado.TabStop = false;
            this.grpElementoEliminado.Text = " Elementos Eliminados";
            this.grpElementoEliminado.Enter += new System.EventHandler(this.grpElementoEliminado_Enter);
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
            this.cbCodigoEE.Location = new System.Drawing.Point(81, 19);
            this.cbCodigoEE.Name = "cbCodigoEE";
            this.cbCodigoEE.Size = new System.Drawing.Size(121, 21);
            this.cbCodigoEE.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(24, 55);
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
            this.groNuevoElemento.Location = new System.Drawing.Point(353, 12);
            this.groNuevoElemento.Name = "groNuevoElemento";
            this.groNuevoElemento.Size = new System.Drawing.Size(261, 220);
            this.groNuevoElemento.TabIndex = 10;
            this.groNuevoElemento.TabStop = false;
            this.groNuevoElemento.Text = "Nuevos Elementos";
            this.groNuevoElemento.Enter += new System.EventHandler(this.groNuevoElemento_Enter);
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
            // groSecundario
            // 
            this.groSecundario.Controls.Add(this.lstEnlazada);
            this.groSecundario.Controls.Add(this.dgvGrilla);
            this.groSecundario.Location = new System.Drawing.Point(7, 239);
            this.groSecundario.Name = "groSecundario";
            this.groSecundario.Size = new System.Drawing.Size(648, 205);
            this.groSecundario.TabIndex = 9;
            this.groSecundario.TabStop = false;
            this.groSecundario.Text = "Listado en una Lista y una Grilla";
            this.groSecundario.Enter += new System.EventHandler(this.groSecundario_Enter);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDescendente);
            this.groupBox1.Controls.Add(this.rbAscendente);
            this.groupBox1.Location = new System.Drawing.Point(620, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Datos";
            // 
            // rbDescendente
            // 
            this.rbDescendente.AutoSize = true;
            this.rbDescendente.Location = new System.Drawing.Point(6, 44);
            this.rbDescendente.Name = "rbDescendente";
            this.rbDescendente.Size = new System.Drawing.Size(89, 17);
            this.rbDescendente.TabIndex = 1;
            this.rbDescendente.TabStop = true;
            this.rbDescendente.Text = "Descendente";
            this.rbDescendente.UseVisualStyleBackColor = true;
            // 
            // rbAscendente
            // 
            this.rbAscendente.AutoSize = true;
            this.rbAscendente.Location = new System.Drawing.Point(6, 18);
            this.rbAscendente.Name = "rbAscendente";
            this.rbAscendente.Size = new System.Drawing.Size(82, 17);
            this.rbAscendente.TabIndex = 0;
            this.rbAscendente.TabStop = true;
            this.rbAscendente.Text = "Ascendente";
            this.rbAscendente.UseVisualStyleBackColor = true;
            // 
            // frmListaDoblementeEnlazada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(889, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picRepresentacionEnlazada);
            this.Controls.Add(this.grpElementoEliminado);
            this.Controls.Add(this.groNuevoElemento);
            this.Controls.Add(this.groSecundario);
            this.Name = "frmListaDoblementeEnlazada";
            this.Text = "Lista Doblemente Enlazada";
            this.Load += new System.EventHandler(this.frmListaDoblementeEnlazada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRepresentacionEnlazada)).EndInit();
            this.grpElementoEliminado.ResumeLayout(false);
            this.grpElementoEliminado.PerformLayout();
            this.groNuevoElemento.ResumeLayout(false);
            this.groNuevoElemento.PerformLayout();
            this.groSecundario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDescendente;
        private System.Windows.Forms.RadioButton rbAscendente;
    }
}