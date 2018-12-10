namespace real_estate
{
    partial class LoaiTK
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
            this.dgvLoaiTK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTK)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoaiTK
            // 
            this.dgvLoaiTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTK.Location = new System.Drawing.Point(23, 59);
            this.dgvLoaiTK.Name = "dgvLoaiTK";
            this.dgvLoaiTK.Size = new System.Drawing.Size(424, 163);
            this.dgvLoaiTK.TabIndex = 0;
            this.dgvLoaiTK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiTK_CellContentClick);
            // 
            // LoaiTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 249);
            this.Controls.Add(this.dgvLoaiTK);
            this.Name = "LoaiTK";
            this.Text = "LoaiTK";
            this.Load += new System.EventHandler(this.LoaiTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiTK;
    }
}