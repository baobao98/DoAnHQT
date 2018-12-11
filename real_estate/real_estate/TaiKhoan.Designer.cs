namespace real_estate
{
    partial class TaiKhoan
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
            this.components = new System.ComponentModel.Container();
            this.dgvTK = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameAccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bthThoat = new System.Windows.Forms.Button();
            this.nameOfTypeAccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSua = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.cboTypeAcc = new System.Windows.Forms.ComboBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeAccountBindingSource)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTK
            // 
            this.dgvTK.AllowUserToAddRows = false;
            this.dgvTK.AllowUserToDeleteRows = false;
            this.dgvTK.AutoGenerateColumns = false;
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameAccDataGridViewTextBoxColumn,
            this.cbType,
            this.passwordDataGridViewTextBoxColumn});
            this.dgvTK.DataSource = this.accountBindingSource;
            this.dgvTK.Location = new System.Drawing.Point(46, 25);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.ReadOnly = true;
            this.dgvTK.Size = new System.Drawing.Size(447, 150);
            this.dgvTK.TabIndex = 0;
            this.dgvTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTK_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameAccDataGridViewTextBoxColumn
            // 
            this.nameAccDataGridViewTextBoxColumn.DataPropertyName = "nameAcc";
            this.nameAccDataGridViewTextBoxColumn.HeaderText = "nameAcc";
            this.nameAccDataGridViewTextBoxColumn.Name = "nameAccDataGridViewTextBoxColumn";
            this.nameAccDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cbType
            // 
            this.cbType.DataPropertyName = "type_ac";
            this.cbType.HeaderText = "type_ac";
            this.cbType.Name = "cbType";
            this.cbType.ReadOnly = true;
            this.cbType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(DAL.account);
            // 
            // bthThoat
            // 
            this.bthThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthThoat.ForeColor = System.Drawing.Color.Red;
            this.bthThoat.Location = new System.Drawing.Point(587, 41);
            this.bthThoat.Name = "bthThoat";
            this.bthThoat.Size = new System.Drawing.Size(106, 109);
            this.bthThoat.TabIndex = 57;
            this.bthThoat.Text = "TRỞ VỀ";
            this.bthThoat.UseVisualStyleBackColor = true;
            this.bthThoat.Click += new System.EventHandler(this.bthThoat_Click);
            // 
            // nameOfTypeAccDataGridViewTextBoxColumn
            // 
            this.nameOfTypeAccDataGridViewTextBoxColumn.DataPropertyName = "NameOfTypeAcc";
            this.nameOfTypeAccDataGridViewTextBoxColumn.HeaderText = "Loại tài khoản";
            this.nameOfTypeAccDataGridViewTextBoxColumn.Name = "nameOfTypeAccDataGridViewTextBoxColumn";
            this.nameOfTypeAccDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeAccountBindingSource
            // 
            this.typeAccountBindingSource.DataSource = typeof(DAL.typeAccount);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.Location = new System.Drawing.Point(353, 335);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 33);
            this.btnSua.TabIndex = 54;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReload.Location = new System.Drawing.Point(153, 333);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(72, 33);
            this.btnReload.TabIndex = 52;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHuy.Location = new System.Drawing.Point(621, 335);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(72, 33);
            this.btnHuy.TabIndex = 56;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.Location = new System.Drawing.Point(543, 335);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(72, 33);
            this.btnLuu.TabIndex = 55;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(380, 13);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(213, 25);
            this.txtTen.TabIndex = 5;
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(144, 13);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(111, 25);
            this.txtMa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản :";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoa.Location = new System.Drawing.Point(275, 333);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 33);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cboTypeAcc);
            this.panel.Controls.Add(this.txtPass);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.txtTen);
            this.panel.Controls.Add(this.txtMa);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(80, 198);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(626, 88);
            this.panel.TabIndex = 58;
            // 
            // cboTypeAcc
            // 
            this.cboTypeAcc.FormattingEnabled = true;
            this.cboTypeAcc.Location = new System.Drawing.Point(134, 48);
            this.cboTypeAcc.Name = "cboTypeAcc";
            this.cboTypeAcc.Size = new System.Drawing.Size(121, 21);
            this.cboTypeAcc.TabIndex = 10;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(380, 44);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(213, 25);
            this.txtPass.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mật khẩu :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThem.Location = new System.Drawing.Point(431, 335);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 33);
            this.btnThem.TabIndex = 53;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bthThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvTK);
            this.Name = "TaiKhoan";
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeAccountBindingSource)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTK;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.Button bthThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfTypeAccDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource typeAccountBindingSource;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTypeAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameAccDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbType;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}