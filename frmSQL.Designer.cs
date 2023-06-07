namespace pryBonaderoED
{
    partial class frmSQL
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
            this.gbProyeccion = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnPrMult = new System.Windows.Forms.Button();
            this.btnPrSimple = new System.Windows.Forms.Button();
            this.dgvSQL = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeleccConvolucion = new System.Windows.Forms.Button();
            this.btnSeleccionMultiatributo = new System.Windows.Forms.Button();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.gbProyeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProyeccion
            // 
            this.gbProyeccion.Controls.Add(this.btnJuntar);
            this.gbProyeccion.Controls.Add(this.btnPrMult);
            this.gbProyeccion.Controls.Add(this.btnPrSimple);
            this.gbProyeccion.Location = new System.Drawing.Point(12, 403);
            this.gbProyeccion.Name = "gbProyeccion";
            this.gbProyeccion.Size = new System.Drawing.Size(225, 115);
            this.gbProyeccion.TabIndex = 5;
            this.gbProyeccion.TabStop = false;
            this.gbProyeccion.Text = "Operaciones de Proyeccion";
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(6, 80);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(202, 21);
            this.btnJuntar.TabIndex = 3;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // btnPrMult
            // 
            this.btnPrMult.Location = new System.Drawing.Point(6, 53);
            this.btnPrMult.Name = "btnPrMult";
            this.btnPrMult.Size = new System.Drawing.Size(202, 21);
            this.btnPrMult.TabIndex = 2;
            this.btnPrMult.Text = "Proyeccion multiatributo";
            this.btnPrMult.UseVisualStyleBackColor = true;
            this.btnPrMult.Click += new System.EventHandler(this.btnPrMult_Click);
            // 
            // btnPrSimple
            // 
            this.btnPrSimple.Location = new System.Drawing.Point(6, 26);
            this.btnPrSimple.Name = "btnPrSimple";
            this.btnPrSimple.Size = new System.Drawing.Size(202, 21);
            this.btnPrSimple.TabIndex = 1;
            this.btnPrSimple.Text = "Proyeccion simple";
            this.btnPrSimple.UseVisualStyleBackColor = true;
            this.btnPrSimple.Click += new System.EventHandler(this.btnPrSimple_Click);
            // 
            // dgvSQL
            // 
            this.dgvSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSQL.Location = new System.Drawing.Point(12, 12);
            this.dgvSQL.Name = "dgvSQL";
            this.dgvSQL.Size = new System.Drawing.Size(687, 385);
            this.dgvSQL.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeleccConvolucion);
            this.groupBox1.Controls.Add(this.btnSeleccionMultiatributo);
            this.groupBox1.Controls.Add(this.btnSeleccionSimple);
            this.groupBox1.Location = new System.Drawing.Point(243, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 115);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones de Seleccion";
            // 
            // btnSeleccConvolucion
            // 
            this.btnSeleccConvolucion.Location = new System.Drawing.Point(6, 80);
            this.btnSeleccConvolucion.Name = "btnSeleccConvolucion";
            this.btnSeleccConvolucion.Size = new System.Drawing.Size(202, 21);
            this.btnSeleccConvolucion.TabIndex = 3;
            this.btnSeleccConvolucion.Text = "Seleccion por convolucion";
            this.btnSeleccConvolucion.UseVisualStyleBackColor = true;
            this.btnSeleccConvolucion.Click += new System.EventHandler(this.btnSeleccConvolucion_Click);
            // 
            // btnSeleccionMultiatributo
            // 
            this.btnSeleccionMultiatributo.Location = new System.Drawing.Point(6, 53);
            this.btnSeleccionMultiatributo.Name = "btnSeleccionMultiatributo";
            this.btnSeleccionMultiatributo.Size = new System.Drawing.Size(202, 21);
            this.btnSeleccionMultiatributo.TabIndex = 2;
            this.btnSeleccionMultiatributo.Text = "Seleccion multiatributo";
            this.btnSeleccionMultiatributo.UseVisualStyleBackColor = true;
            this.btnSeleccionMultiatributo.Click += new System.EventHandler(this.btnSeleccionMultiatributo_Click);
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.Location = new System.Drawing.Point(6, 26);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(202, 21);
            this.btnSeleccionSimple.TabIndex = 1;
            this.btnSeleccionSimple.Text = "Seleccion simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            this.btnSeleccionSimple.Click += new System.EventHandler(this.btnSeleccionSimple_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDiferencia);
            this.groupBox2.Controls.Add(this.btnInterseccion);
            this.groupBox2.Controls.Add(this.btnUnion);
            this.groupBox2.Location = new System.Drawing.Point(474, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 115);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones Algebraicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(6, 80);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(202, 21);
            this.btnDiferencia.TabIndex = 3;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(6, 53);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(202, 21);
            this.btnInterseccion.TabIndex = 2;
            this.btnInterseccion.Text = "Interseccion";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(6, 26);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(202, 21);
            this.btnUnion.TabIndex = 1;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // frmSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSQL);
            this.Controls.Add(this.gbProyeccion);
            this.Name = "frmSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSQL";
            this.Load += new System.EventHandler(this.frmSQL_Load);
            this.gbProyeccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProyeccion;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnPrMult;
        private System.Windows.Forms.Button btnPrSimple;
        private System.Windows.Forms.DataGridView dgvSQL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeleccConvolucion;
        private System.Windows.Forms.Button btnSeleccionMultiatributo;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
    }
}