namespace real_estate.Forms
{
    partial class FormProperty
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
            this.dgvProperty = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.id_prop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_real_estate_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_town_region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperty)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProperty
            // 
            this.dgvProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProperty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_prop,
            this.id_real_estate_type,
            this.id_project,
            this.price,
            this.create_date,
            this.id_town_region,
            this.id_area,
            this.id_district});
            this.dgvProperty.Location = new System.Drawing.Point(30, 39);
            this.dgvProperty.Name = "dgvProperty";
            this.dgvProperty.Size = new System.Drawing.Size(616, 178);
            this.dgvProperty.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(502, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 46);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Transaction";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // id_prop
            // 
            this.id_prop.DataPropertyName = "id_prop";
            this.id_prop.HeaderText = "ID";
            this.id_prop.Name = "id_prop";
            this.id_prop.Width = 70;
            // 
            // id_real_estate_type
            // 
            this.id_real_estate_type.DataPropertyName = "id_real_estate_type";
            this.id_real_estate_type.HeaderText = "ID type";
            this.id_real_estate_type.Name = "id_real_estate_type";
            this.id_real_estate_type.Width = 50;
            // 
            // id_project
            // 
            this.id_project.DataPropertyName = "id_project";
            this.id_project.HeaderText = "ID project";
            this.id_project.Name = "id_project";
            this.id_project.Width = 70;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.Width = 70;
            // 
            // create_date
            // 
            this.create_date.DataPropertyName = "create_date";
            this.create_date.HeaderText = "Create date";
            this.create_date.Name = "create_date";
            // 
            // id_town_region
            // 
            this.id_town_region.DataPropertyName = "id_town_region";
            this.id_town_region.HeaderText = "ID Town";
            this.id_town_region.Name = "id_town_region";
            this.id_town_region.Width = 70;
            // 
            // id_area
            // 
            this.id_area.DataPropertyName = "id_area";
            this.id_area.HeaderText = "ID Area";
            this.id_area.Name = "id_area";
            this.id_area.Width = 70;
            // 
            // id_district
            // 
            this.id_district.DataPropertyName = "id_district";
            this.id_district.HeaderText = "ID District";
            this.id_district.Name = "id_district";
            this.id_district.Width = 70;
            // 
            // FormProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 293);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvProperty);
            this.Name = "FormProperty";
            this.Text = "property";
            this.Load += new System.EventHandler(this.FormProperty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProperty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prop;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_real_estate_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_project;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_town_region;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_district;
    }
}