
namespace pryEstructuraDatos
{
    partial class Operaciones_De_Base_De_Datos
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
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.grbOperacionesDeProyeccion = new System.Windows.Forms.GroupBox();
            this.btnProyeccionMultiatributos = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.grbSeleccion = new System.Windows.Forms.GroupBox();
            this.btnSeleccionMultiatributos = new System.Windows.Forms.Button();
            this.btnSeleccionporConvulcion = new System.Windows.Forms.Button();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.grbAlgebraicas = new System.Windows.Forms.GroupBox();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbOperacionesDeProyeccion.SuspendLayout();
            this.grbSeleccion.SuspendLayout();
            this.grbAlgebraicas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.Location = new System.Drawing.Point(27, 19);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(143, 46);
            this.btnProyeccionSimple.TabIndex = 0;
            this.btnProyeccionSimple.Text = "Proyeccion Simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            this.btnProyeccionSimple.Click += new System.EventHandler(this.button1_Click);
            // 
            // grbOperacionesDeProyeccion
            // 
            this.grbOperacionesDeProyeccion.Controls.Add(this.btnProyeccionMultiatributos);
            this.grbOperacionesDeProyeccion.Controls.Add(this.btnJuntar);
            this.grbOperacionesDeProyeccion.Controls.Add(this.btnProyeccionSimple);
            this.grbOperacionesDeProyeccion.Location = new System.Drawing.Point(41, 296);
            this.grbOperacionesDeProyeccion.Name = "grbOperacionesDeProyeccion";
            this.grbOperacionesDeProyeccion.Size = new System.Drawing.Size(200, 168);
            this.grbOperacionesDeProyeccion.TabIndex = 0;
            this.grbOperacionesDeProyeccion.TabStop = false;
            this.grbOperacionesDeProyeccion.Text = "Operaciones de Proyeccion";
            this.grbOperacionesDeProyeccion.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnProyeccionMultiatributos
            // 
            this.btnProyeccionMultiatributos.Location = new System.Drawing.Point(27, 77);
            this.btnProyeccionMultiatributos.Name = "btnProyeccionMultiatributos";
            this.btnProyeccionMultiatributos.Size = new System.Drawing.Size(143, 36);
            this.btnProyeccionMultiatributos.TabIndex = 2;
            this.btnProyeccionMultiatributos.Text = "Proyeccion Multiatributos";
            this.btnProyeccionMultiatributos.UseVisualStyleBackColor = true;
            this.btnProyeccionMultiatributos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(27, 124);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(143, 38);
            this.btnJuntar.TabIndex = 3;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.button3_Click);
            // 
            // grbSeleccion
            // 
            this.grbSeleccion.Controls.Add(this.btnSeleccionMultiatributos);
            this.grbSeleccion.Controls.Add(this.btnSeleccionporConvulcion);
            this.grbSeleccion.Controls.Add(this.btnSeleccionSimple);
            this.grbSeleccion.Location = new System.Drawing.Point(258, 296);
            this.grbSeleccion.Name = "grbSeleccion";
            this.grbSeleccion.Size = new System.Drawing.Size(200, 168);
            this.grbSeleccion.TabIndex = 2;
            this.grbSeleccion.TabStop = false;
            this.grbSeleccion.Text = "Operacion de Seleccion";
            this.grbSeleccion.Enter += new System.EventHandler(this.grbSeleccion_Enter);
            // 
            // btnSeleccionMultiatributos
            // 
            this.btnSeleccionMultiatributos.Location = new System.Drawing.Point(51, 62);
            this.btnSeleccionMultiatributos.Name = "btnSeleccionMultiatributos";
            this.btnSeleccionMultiatributos.Size = new System.Drawing.Size(124, 42);
            this.btnSeleccionMultiatributos.TabIndex = 2;
            this.btnSeleccionMultiatributos.Text = "Seleccion Multiatributos";
            this.btnSeleccionMultiatributos.UseVisualStyleBackColor = true;
            this.btnSeleccionMultiatributos.Click += new System.EventHandler(this.btnSeleccionMultiatributos_Click);
            // 
            // btnSeleccionporConvulcion
            // 
            this.btnSeleccionporConvulcion.Location = new System.Drawing.Point(50, 115);
            this.btnSeleccionporConvulcion.Name = "btnSeleccionporConvulcion";
            this.btnSeleccionporConvulcion.Size = new System.Drawing.Size(125, 38);
            this.btnSeleccionporConvulcion.TabIndex = 3;
            this.btnSeleccionporConvulcion.Text = "Seleccion por convulcion";
            this.btnSeleccionporConvulcion.UseVisualStyleBackColor = true;
            this.btnSeleccionporConvulcion.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.Location = new System.Drawing.Point(51, 19);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(124, 37);
            this.btnSeleccionSimple.TabIndex = 0;
            this.btnSeleccionSimple.Text = "Seleccion Simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            this.btnSeleccionSimple.Click += new System.EventHandler(this.button6_Click);
            // 
            // grbAlgebraicas
            // 
            this.grbAlgebraicas.Controls.Add(this.btnInterseccion);
            this.grbAlgebraicas.Controls.Add(this.btnDiferencia);
            this.grbAlgebraicas.Controls.Add(this.btnUnion);
            this.grbAlgebraicas.Location = new System.Drawing.Point(515, 296);
            this.grbAlgebraicas.Name = "grbAlgebraicas";
            this.grbAlgebraicas.Size = new System.Drawing.Size(200, 168);
            this.grbAlgebraicas.TabIndex = 3;
            this.grbAlgebraicas.TabStop = false;
            this.grbAlgebraicas.Text = "Operaciones Algebraicas";
            this.grbAlgebraicas.Enter += new System.EventHandler(this.grbAlgebraicas_Enter);
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(40, 65);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(123, 39);
            this.btnInterseccion.TabIndex = 2;
            this.btnInterseccion.Text = "Interseccion";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(40, 115);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(123, 38);
            this.btnDiferencia.TabIndex = 3;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(40, 19);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(123, 37);
            this.btnUnion.TabIndex = 0;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 284);
            this.dataGridView1.TabIndex = 4;
            // 
            // Operaciones_De_Base_De_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 487);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbAlgebraicas);
            this.Controls.Add(this.grbSeleccion);
            this.Controls.Add(this.grbOperacionesDeProyeccion);
            this.Name = "Operaciones_De_Base_De_Datos";
            this.Text = "Operaciones_De_Base_De_Datos";
            this.Load += new System.EventHandler(this.Operaciones_De_Base_De_Datos_Load);
            this.grbOperacionesDeProyeccion.ResumeLayout(false);
            this.grbSeleccion.ResumeLayout(false);
            this.grbAlgebraicas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProyeccionSimple;
        private System.Windows.Forms.GroupBox grbOperacionesDeProyeccion;
        private System.Windows.Forms.Button btnProyeccionMultiatributos;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.GroupBox grbSeleccion;
        private System.Windows.Forms.Button btnSeleccionMultiatributos;
        private System.Windows.Forms.Button btnSeleccionporConvulcion;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.GroupBox grbAlgebraicas;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}