namespace StudentCRUDapplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BGPanel = new System.Windows.Forms.Panel();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.GridControlStudents = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GcFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCourse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GcYearLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LabelYearLevel = new DevExpress.XtraEditors.LabelControl();
            this.LabelDepartment = new DevExpress.XtraEditors.LabelControl();
            this.LabelCourse = new DevExpress.XtraEditors.LabelControl();
            this.LabelAge = new DevExpress.XtraEditors.LabelControl();
            this.LabelFullName = new DevExpress.XtraEditors.LabelControl();
            this.TeYearLevel = new DevExpress.XtraEditors.TextEdit();
            this.TeDepartment = new DevExpress.XtraEditors.TextEdit();
            this.TeCourse = new DevExpress.XtraEditors.TextEdit();
            this.TeAge = new DevExpress.XtraEditors.TextEdit();
            this.TeFullName = new DevExpress.XtraEditors.TextEdit();
            this.BGPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeYearLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeCourse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeFullName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BGPanel
            // 
            this.BGPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.BGPanel.Controls.Add(this.btnDelete);
            this.BGPanel.Controls.Add(this.btnEdit);
            this.BGPanel.Controls.Add(this.btnAdd);
            this.BGPanel.Controls.Add(this.GridControlStudents);
            this.BGPanel.Controls.Add(this.LabelYearLevel);
            this.BGPanel.Controls.Add(this.LabelDepartment);
            this.BGPanel.Controls.Add(this.LabelCourse);
            this.BGPanel.Controls.Add(this.LabelAge);
            this.BGPanel.Controls.Add(this.LabelFullName);
            this.BGPanel.Controls.Add(this.TeYearLevel);
            this.BGPanel.Controls.Add(this.TeDepartment);
            this.BGPanel.Controls.Add(this.TeCourse);
            this.BGPanel.Controls.Add(this.TeAge);
            this.BGPanel.Controls.Add(this.TeFullName);
            this.BGPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BGPanel.Location = new System.Drawing.Point(0, 0);
            this.BGPanel.Name = "BGPanel";
            this.BGPanel.Size = new System.Drawing.Size(935, 541);
            this.BGPanel.TabIndex = 0;
            this.BGPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BGPanel_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Location = new System.Drawing.Point(614, 91);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 37);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.Location = new System.Drawing.Point(497, 91);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 37);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(378, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 37);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // GridControlStudents
            // 
            this.GridControlStudents.Location = new System.Drawing.Point(36, 153);
            this.GridControlStudents.MainView = this.gridView1;
            this.GridControlStudents.Name = "GridControlStudents";
            this.GridControlStudents.Size = new System.Drawing.Size(863, 341);
            this.GridControlStudents.TabIndex = 10;
            this.GridControlStudents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GridControlStudents.Click += new System.EventHandler(this.GridControlStudents_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GcFullName,
            this.GcAge,
            this.gcCourse,
            this.GcDepartment,
            this.GcYearLevel});
            this.gridView1.GridControl = this.GridControlStudents;
            this.gridView1.Name = "gridView1";
            // 
            // GcFullName
            // 
            this.GcFullName.Caption = "FullName";
            this.GcFullName.Name = "GcFullName";
            this.GcFullName.Visible = true;
            this.GcFullName.VisibleIndex = 0;
            // 
            // GcAge
            // 
            this.GcAge.Caption = "Age";
            this.GcAge.Name = "GcAge";
            this.GcAge.Visible = true;
            this.GcAge.VisibleIndex = 1;
            // 
            // gcCourse
            // 
            this.gcCourse.Caption = "Course";
            this.gcCourse.Name = "gcCourse";
            this.gcCourse.Visible = true;
            this.gcCourse.VisibleIndex = 2;
            // 
            // GcDepartment
            // 
            this.GcDepartment.Caption = "Department";
            this.GcDepartment.Name = "GcDepartment";
            this.GcDepartment.Visible = true;
            this.GcDepartment.VisibleIndex = 3;
            // 
            // GcYearLevel
            // 
            this.GcYearLevel.Caption = "YearLevel";
            this.GcYearLevel.Name = "GcYearLevel";
            this.GcYearLevel.Visible = true;
            this.GcYearLevel.VisibleIndex = 4;
            // 
            // LabelYearLevel
            // 
            this.LabelYearLevel.Location = new System.Drawing.Point(704, 22);
            this.LabelYearLevel.Name = "LabelYearLevel";
            this.LabelYearLevel.Size = new System.Drawing.Size(49, 13);
            this.LabelYearLevel.TabIndex = 9;
            this.LabelYearLevel.Text = "YearLevel:";
            // 
            // LabelDepartment
            // 
            this.LabelDepartment.Location = new System.Drawing.Point(497, 22);
            this.LabelDepartment.Name = "LabelDepartment";
            this.LabelDepartment.Size = new System.Drawing.Size(64, 13);
            this.LabelDepartment.TabIndex = 8;
            this.LabelDepartment.Text = "Department:";
            // 
            // LabelCourse
            // 
            this.LabelCourse.Location = new System.Drawing.Point(318, 22);
            this.LabelCourse.Name = "LabelCourse";
            this.LabelCourse.Size = new System.Drawing.Size(39, 13);
            this.LabelCourse.TabIndex = 7;
            this.LabelCourse.Text = "Course:";
            // 
            // LabelAge
            // 
            this.LabelAge.Location = new System.Drawing.Point(228, 22);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(23, 13);
            this.LabelAge.TabIndex = 6;
            this.LabelAge.Text = "Age:";
            // 
            // LabelFullName
            // 
            this.LabelFullName.Location = new System.Drawing.Point(36, 19);
            this.LabelFullName.Name = "LabelFullName";
            this.LabelFullName.Size = new System.Drawing.Size(51, 13);
            this.LabelFullName.TabIndex = 5;
            this.LabelFullName.Text = "FullName:";
            // 
            // TeYearLevel
            // 
            this.TeYearLevel.Location = new System.Drawing.Point(704, 41);
            this.TeYearLevel.Name = "TeYearLevel";
            this.TeYearLevel.Properties.AutoHeight = false;
            this.TeYearLevel.Size = new System.Drawing.Size(195, 28);
            this.TeYearLevel.TabIndex = 4;
            // 
            // TeDepartment
            // 
            this.TeDepartment.Location = new System.Drawing.Point(497, 41);
            this.TeDepartment.Name = "TeDepartment";
            this.TeDepartment.Properties.AutoHeight = false;
            this.TeDepartment.Size = new System.Drawing.Size(201, 28);
            this.TeDepartment.TabIndex = 3;
            // 
            // TeCourse
            // 
            this.TeCourse.Location = new System.Drawing.Point(318, 41);
            this.TeCourse.Name = "TeCourse";
            this.TeCourse.Properties.AutoHeight = false;
            this.TeCourse.Size = new System.Drawing.Size(173, 28);
            this.TeCourse.TabIndex = 2;
            // 
            // TeAge
            // 
            this.TeAge.Location = new System.Drawing.Point(228, 41);
            this.TeAge.Name = "TeAge";
            this.TeAge.Properties.AutoHeight = false;
            this.TeAge.Size = new System.Drawing.Size(84, 28);
            this.TeAge.TabIndex = 1;
            // 
            // TeFullName
            // 
            this.TeFullName.Location = new System.Drawing.Point(36, 41);
            this.TeFullName.Name = "TeFullName";
            this.TeFullName.Properties.AutoHeight = false;
            this.TeFullName.Size = new System.Drawing.Size(186, 28);
            this.TeFullName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 541);
            this.Controls.Add(this.BGPanel);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Form1.IconOptions.SvgImage")));
            this.Name = "Form1";
            this.Text = "Student";
            this.BGPanel.ResumeLayout(false);
            this.BGPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeYearLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeCourse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeFullName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BGPanel;
        private DevExpress.XtraEditors.TextEdit TeFullName;
        private DevExpress.XtraEditors.TextEdit TeYearLevel;
        private DevExpress.XtraEditors.TextEdit TeDepartment;
        private DevExpress.XtraEditors.TextEdit TeCourse;
        private DevExpress.XtraEditors.TextEdit TeAge;
        private DevExpress.XtraEditors.LabelControl LabelCourse;
        private DevExpress.XtraEditors.LabelControl LabelAge;
        private DevExpress.XtraEditors.LabelControl LabelFullName;
        private DevExpress.XtraEditors.LabelControl LabelYearLevel;
        private DevExpress.XtraEditors.LabelControl LabelDepartment;
        private DevExpress.XtraGrid.GridControl GridControlStudents;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn GcFullName;
        private DevExpress.XtraGrid.Columns.GridColumn GcAge;
        private DevExpress.XtraGrid.Columns.GridColumn gcCourse;
        private DevExpress.XtraGrid.Columns.GridColumn GcDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn GcYearLevel;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}

