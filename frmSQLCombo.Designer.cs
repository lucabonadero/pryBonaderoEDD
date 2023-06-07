namespace pryBonaderoED
{
    partial class frmSQLCombo
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
            this.dgvSQL = new System.Windows.Forms.DataGridView();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.cboOperaciones = new System.Windows.Forms.ComboBox();
            this.lblOp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSQL
            // 
            this.dgvSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSQL.Location = new System.Drawing.Point(12, 158);
            this.dgvSQL.Name = "dgvSQL";
            this.dgvSQL.Size = new System.Drawing.Size(775, 234);
            this.dgvSQL.TabIndex = 5;
            // 
            // txtSQL
            // 
            this.txtSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQL.Location = new System.Drawing.Point(12, 49);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.ReadOnly = true;
            this.txtSQL.Size = new System.Drawing.Size(775, 103);
            this.txtSQL.TabIndex = 4;
            // 
            // cboOperaciones
            // 
            this.cboOperaciones.FormattingEnabled = true;
            this.cboOperaciones.Location = new System.Drawing.Point(362, 19);
            this.cboOperaciones.Name = "cboOperaciones";
            this.cboOperaciones.Size = new System.Drawing.Size(420, 21);
            this.cboOperaciones.TabIndex = 7;
            this.cboOperaciones.SelectedIndexChanged += new System.EventHandler(this.cboOperaciones_SelectedIndexChanged);
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(8, 16);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(353, 24);
            this.lblOp.TabIndex = 8;
            this.lblOp.Text = "Operacion a realizar en la base de datos:";
            // 
            // frmSQLCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 404);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.cboOperaciones);
            this.Controls.Add(this.dgvSQL);
            this.Controls.Add(this.txtSQL);
            this.Name = "frmSQLCombo";
            this.Text = "frmSQLCombo";
            this.Load += new System.EventHandler(this.frmSQLCombo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSQL;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.ComboBox cboOperaciones;
        private System.Windows.Forms.Label lblOp;
    }
}