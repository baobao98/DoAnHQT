namespace real_estate.user_control
{
    partial class Products
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.dgvRealEstate = new System.Windows.Forms.DataGridView();
            this.id_prop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbProject = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbTypeProp = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbTown = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.propertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbArea = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbDistrict = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.avatar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pcImage = new System.Windows.Forms.PictureBox();
            this.cbProjectBind = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCreate_date = new System.Windows.Forms.TextBox();
            this.cbRealEstateBind = new System.Windows.Forms.ComboBox();
            this.cbTownRegionBind = new System.Windows.Forms.ComboBox();
            this.cbAreaBind = new System.Windows.Forms.ComboBox();
            this.cbDisTrictBind = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSearchDistrict = new System.Windows.Forms.ComboBox();
            this.cbSearchArea = new System.Windows.Forms.ComboBox();
            this.cbSearchTown = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealEstate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRealEstate
            // 
            this.dgvRealEstate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRealEstate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_prop,
            this.name,
            this.floor,
            this.room,
            this.price,
            this.create_date,
            this.cbProject,
            this.cbTypeProp,
            this.cbTown,
            this.cbArea,
            this.cbDistrict,
            this.avatar,
            this.status,
            this.Selected});
            this.dgvRealEstate.Location = new System.Drawing.Point(0, 0);
            this.dgvRealEstate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRealEstate.Name = "dgvRealEstate";
            this.dgvRealEstate.RowTemplate.Height = 28;
            this.dgvRealEstate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRealEstate.Size = new System.Drawing.Size(1283, 253);
            this.dgvRealEstate.TabIndex = 0;
            this.dgvRealEstate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRealEstate_CellClick);
            this.dgvRealEstate.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRealEstate_CellEnter);
            this.dgvRealEstate.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRealEstate_CellValueChanged);
            this.dgvRealEstate.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvRealEstate_CurrentCellDirtyStateChanged);
            // 
            // id_prop
            // 
            this.id_prop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_prop.DataPropertyName = "id_prop";
            this.id_prop.HeaderText = "ID";
            this.id_prop.Name = "id_prop";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // floor
            // 
            this.floor.DataPropertyName = "floor";
            this.floor.HeaderText = "Floor";
            this.floor.Name = "floor";
            this.floor.Width = 50;
            // 
            // room
            // 
            this.room.DataPropertyName = "room";
            this.room.HeaderText = "Room";
            this.room.Name = "room";
            this.room.Width = 50;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // create_date
            // 
            this.create_date.DataPropertyName = "create_date";
            this.create_date.HeaderText = "Create_date";
            this.create_date.Name = "create_date";
            // 
            // cbProject
            // 
            this.cbProject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cbProject.DataPropertyName = "id_project";
            this.cbProject.HeaderText = "Project";
            this.cbProject.Name = "cbProject";
            this.cbProject.Width = 58;
            // 
            // cbTypeProp
            // 
            this.cbTypeProp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cbTypeProp.DataPropertyName = "id_real_estate_type";
            this.cbTypeProp.HeaderText = "RealEstateType";
            this.cbTypeProp.Name = "cbTypeProp";
            this.cbTypeProp.Width = 115;
            // 
            // cbTown
            // 
            this.cbTown.DataPropertyName = "id_town_region";
            this.cbTown.DataSource = this.propertyBindingSource;
            this.cbTown.HeaderText = "TownRegion";
            this.cbTown.Name = "cbTown";
            this.cbTown.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbTown.Visible = false;
            this.cbTown.Width = 150;
            // 
            // propertyBindingSource
            // 
            this.propertyBindingSource.DataSource = typeof(DAL.property);
            // 
            // cbArea
            // 
            this.cbArea.DataPropertyName = "id_area";
            this.cbArea.DataSource = this.propertyBindingSource;
            this.cbArea.HeaderText = "Area";
            this.cbArea.Name = "cbArea";
            this.cbArea.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbArea.Visible = false;
            this.cbArea.Width = 150;
            // 
            // cbDistrict
            // 
            this.cbDistrict.DataPropertyName = "id_district";
            this.cbDistrict.DataSource = this.propertyBindingSource;
            this.cbDistrict.HeaderText = "District";
            this.cbDistrict.Name = "cbDistrict";
            this.cbDistrict.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbDistrict.Visible = false;
            this.cbDistrict.Width = 130;
            // 
            // avatar
            // 
            this.avatar.DataPropertyName = "avatar";
            this.avatar.HeaderText = "Image";
            this.avatar.Name = "avatar";
            this.avatar.Visible = false;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // Selected
            // 
            this.Selected.HeaderText = "Selected";
            this.Selected.Name = "Selected";
            this.Selected.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(173)))), ((int)(((byte)(127)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(9, 286);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 47);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(173)))), ((int)(((byte)(127)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(356, 286);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 47);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(173)))), ((int)(((byte)(127)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(189, 286);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 47);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pcImage
            // 
            this.pcImage.Image = ((System.Drawing.Image)(resources.GetObject("pcImage.Image")));
            this.pcImage.Location = new System.Drawing.Point(588, 20);
            this.pcImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcImage.Name = "pcImage";
            this.pcImage.Size = new System.Drawing.Size(349, 261);
            this.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcImage.TabIndex = 2;
            this.pcImage.TabStop = false;
            // 
            // cbProjectBind
            // 
            this.cbProjectBind.Enabled = false;
            this.cbProjectBind.FormattingEnabled = true;
            this.cbProjectBind.Location = new System.Drawing.Point(375, 30);
            this.cbProjectBind.Name = "cbProjectBind";
            this.cbProjectBind.Size = new System.Drawing.Size(176, 24);
            this.cbProjectBind.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(61, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtFloor
            // 
            this.txtFloor.Enabled = false;
            this.txtFloor.Location = new System.Drawing.Point(61, 129);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(158, 22);
            this.txtFloor.TabIndex = 3;
            // 
            // txtRoom
            // 
            this.txtRoom.Enabled = false;
            this.txtRoom.Location = new System.Drawing.Point(61, 93);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(158, 22);
            this.txtRoom.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(61, 164);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(158, 22);
            this.txtPrice.TabIndex = 4;
            // 
            // txtCreate_date
            // 
            this.txtCreate_date.Enabled = false;
            this.txtCreate_date.Location = new System.Drawing.Point(106, 199);
            this.txtCreate_date.Name = "txtCreate_date";
            this.txtCreate_date.Size = new System.Drawing.Size(113, 22);
            this.txtCreate_date.TabIndex = 5;
            // 
            // cbRealEstateBind
            // 
            this.cbRealEstateBind.Enabled = false;
            this.cbRealEstateBind.FormattingEnabled = true;
            this.cbRealEstateBind.Location = new System.Drawing.Point(375, 67);
            this.cbRealEstateBind.Name = "cbRealEstateBind";
            this.cbRealEstateBind.Size = new System.Drawing.Size(176, 24);
            this.cbRealEstateBind.TabIndex = 8;
            // 
            // cbTownRegionBind
            // 
            this.cbTownRegionBind.Enabled = false;
            this.cbTownRegionBind.FormattingEnabled = true;
            this.cbTownRegionBind.Location = new System.Drawing.Point(375, 103);
            this.cbTownRegionBind.Name = "cbTownRegionBind";
            this.cbTownRegionBind.Size = new System.Drawing.Size(176, 24);
            this.cbTownRegionBind.TabIndex = 9;
            this.cbTownRegionBind.SelectedIndexChanged += new System.EventHandler(this.cbTownRegionBind_SelectedIndexChanged);
            // 
            // cbAreaBind
            // 
            this.cbAreaBind.Enabled = false;
            this.cbAreaBind.FormattingEnabled = true;
            this.cbAreaBind.Location = new System.Drawing.Point(375, 136);
            this.cbAreaBind.Name = "cbAreaBind";
            this.cbAreaBind.Size = new System.Drawing.Size(176, 24);
            this.cbAreaBind.TabIndex = 10;
            this.cbAreaBind.SelectedIndexChanged += new System.EventHandler(this.cbAreaBind_SelectedIndexChanged);
            // 
            // cbDisTrictBind
            // 
            this.cbDisTrictBind.Enabled = false;
            this.cbDisTrictBind.FormattingEnabled = true;
            this.cbDisTrictBind.Location = new System.Drawing.Point(375, 167);
            this.cbDisTrictBind.Name = "cbDisTrictBind";
            this.cbDisTrictBind.Size = new System.Drawing.Size(176, 24);
            this.cbDisTrictBind.TabIndex = 11;
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(61, 240);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(158, 22);
            this.txtStatus.TabIndex = 6;
            // 
            // btnBrowser
            // 
            this.btnBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(173)))), ((int)(((byte)(127)))));
            this.btnBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowser.ForeColor = System.Drawing.Color.White;
            this.btnBrowser.Location = new System.Drawing.Point(697, 286);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(124, 47);
            this.btnBrowser.TabIndex = 19;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.UseVisualStyleBackColor = false;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(61, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(158, 22);
            this.txtId.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(173)))), ((int)(((byte)(127)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(356, 343);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 47);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.txtEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(173)))), ((int)(((byte)(127)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(189, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 47);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnBrowser);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pcImage);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.cbDisTrictBind);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cbAreaBind);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbTownRegionBind);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbRealEstateBind);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbProjectBind);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCreate_date);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFloor);
            this.groupBox1.Controls.Add(this.txtRoom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(3, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1279, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Row";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(173)))), ((int)(((byte)(127)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(697, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 47);
            this.button1.TabIndex = 31;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(173)))), ((int)(((byte)(127)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1057, 286);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 47);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSearchDistrict);
            this.groupBox2.Controls.Add(this.cbSearchArea);
            this.groupBox2.Controls.Add(this.cbSearchTown);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(964, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 260);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // cbSearchDistrict
            // 
            this.cbSearchDistrict.FormattingEnabled = true;
            this.cbSearchDistrict.Location = new System.Drawing.Point(131, 129);
            this.cbSearchDistrict.Name = "cbSearchDistrict";
            this.cbSearchDistrict.Size = new System.Drawing.Size(167, 24);
            this.cbSearchDistrict.TabIndex = 5;
            // 
            // cbSearchArea
            // 
            this.cbSearchArea.FormattingEnabled = true;
            this.cbSearchArea.Location = new System.Drawing.Point(131, 83);
            this.cbSearchArea.Name = "cbSearchArea";
            this.cbSearchArea.Size = new System.Drawing.Size(167, 24);
            this.cbSearchArea.TabIndex = 4;
            this.cbSearchArea.SelectedIndexChanged += new System.EventHandler(this.cbSearchArea_SelectedIndexChanged);
            // 
            // cbSearchTown
            // 
            this.cbSearchTown.FormattingEnabled = true;
            this.cbSearchTown.Location = new System.Drawing.Point(131, 37);
            this.cbSearchTown.Name = "cbSearchTown";
            this.cbSearchTown.Size = new System.Drawing.Size(167, 24);
            this.cbSearchTown.TabIndex = 3;
            this.cbSearchTown.SelectedIndexChanged += new System.EventHandler(this.cbSearchTown_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 17);
            this.label15.TabIndex = 2;
            this.label15.Text = "District :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Area :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "TownRegion:";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(9, 342);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(124, 47);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(309, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "District :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(323, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Area :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Town_Region :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Type_Property :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Project :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Status :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Create_date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Floor :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Room:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRealEstate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(1285, 686);
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRealEstate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRealEstate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource propertyBindingSource;
        private System.Windows.Forms.PictureBox pcImage;
        private System.Windows.Forms.ComboBox cbProjectBind;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCreate_date;
        private System.Windows.Forms.ComboBox cbRealEstateBind;
        private System.Windows.Forms.ComboBox cbTownRegionBind;
        private System.Windows.Forms.ComboBox cbAreaBind;
        private System.Windows.Forms.ComboBox cbDisTrictBind;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prop;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_date;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbProject;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbTypeProp;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbTown;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbArea;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbDistrict;
        private System.Windows.Forms.DataGridViewTextBoxColumn avatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbSearchDistrict;
        private System.Windows.Forms.ComboBox cbSearchArea;
        private System.Windows.Forms.ComboBox cbSearchTown;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
    }
}
