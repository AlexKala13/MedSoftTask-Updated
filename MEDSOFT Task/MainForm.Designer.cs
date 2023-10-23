namespace MEDSOFT_Task
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addBtn = new System.Windows.Forms.ToolStripButton();
            this.editBtn = new System.Windows.Forms.ToolStripButton();
            this.removeBtn = new System.Windows.Forms.ToolStripButton();
            this.dataGrid = new DevExpress.XtraGrid.GridControl();
            this.gvPatients = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenderName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonalId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(744, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "MedSoft Test Task\r\nBy Alex Kalandadze\r\n";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBtn,
            this.editBtn,
            this.removeBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(923, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addBtn
            // 
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(69, 22);
            this.addBtn.Tag = "";
            this.addBtn.Text = "დამატება";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(92, 22);
            this.editBtn.Tag = "";
            this.editBtn.Text = "რედაქტირება";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.removeBtn.Image = ((System.Drawing.Image)(resources.GetObject("removeBtn.Image")));
            this.removeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(55, 22);
            this.removeBtn.Tag = "";
            this.removeBtn.Text = "წაშლა";
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 25);
            this.dataGrid.MainView = this.gvPatients;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(923, 516);
            this.dataGrid.TabIndex = 6;
            this.dataGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPatients});
            // 
            // gvPatients
            // 
            this.gvPatients.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFullName,
            this.colBirthDate,
            this.colGenderName,
            this.colPhone,
            this.colAddress,
            this.colEmail,
            this.colPersonalId});
            this.gvPatients.GridControl = this.dataGrid;
            this.gvPatients.Name = "gvPatients";
            this.gvPatients.OptionsSelection.MultiSelect = true;
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "ID";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "სახელი გვარი";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.AllowEdit = false;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            // 
            // colBirthDate
            // 
            this.colBirthDate.Caption = "დაბ. თარიღი";
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.OptionsColumn.AllowEdit = false;
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 2;
            // 
            // colGenderName
            // 
            this.colGenderName.Caption = "სქესი";
            this.colGenderName.FieldName = "PatientGender";
            this.colGenderName.Name = "colGenderName";
            this.colGenderName.OptionsColumn.AllowEdit = false;
            this.colGenderName.Visible = true;
            this.colGenderName.VisibleIndex = 3;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "ტელეფონი";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.AllowEdit = false;
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 4;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "მისამართი";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowEdit = false;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 5;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "ელ. ფოსტა";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 6;
            // 
            // colPersonalId
            // 
            this.colPersonalId.Caption = "პირადი ნომერი";
            this.colPersonalId.FieldName = "PersonalID";
            this.colPersonalId.Name = "colPersonalId";
            this.colPersonalId.OptionsColumn.AllowEdit = false;
            this.colPersonalId.Visible = true;
            this.colPersonalId.VisibleIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(923, 541);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedSoft Task";
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraGrid.GridControl dataGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPatients;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colGenderName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonalId;
        private System.Windows.Forms.ToolStripButton addBtn;
        private System.Windows.Forms.ToolStripButton editBtn;
        private System.Windows.Forms.ToolStripButton removeBtn;
    }
}

