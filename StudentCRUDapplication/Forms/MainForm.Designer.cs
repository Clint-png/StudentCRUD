namespace StudentCRUDapplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BGPanel = new System.Windows.Forms.Panel();
            this.GridControlListView = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLoadData = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.GridControlStudents = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Age = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Course = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Department = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YearLevel = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.GridControlListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.BGPanel.Controls.Add(this.GridControlListView);
            this.BGPanel.Controls.Add(this.btnLoadData);
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
            this.BGPanel.Margin = new System.Windows.Forms.Padding(4);
            this.BGPanel.Name = "BGPanel";
            this.BGPanel.Size = new System.Drawing.Size(1091, 861);
            this.BGPanel.TabIndex = 0;
            // 
            // GridControlListView
            // 
            this.GridControlListView.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GridControlListView.Location = new System.Drawing.Point(40, 175);
            this.GridControlListView.MainView = this.gridView2;
            this.GridControlListView.Margin = new System.Windows.Forms.Padding(4);
            this.GridControlListView.Name = "GridControlListView";
            this.GridControlListView.Size = new System.Drawing.Size(1007, 191);
            this.GridControlListView.TabIndex = 15;
            this.GridControlListView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView2.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView2.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView2.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView2.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView2.Appearance.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView2.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView2.DetailHeight = 458;
            this.gridView2.GridControl = this.GridControlListView;
            this.gridView2.GroupPanelText = "Temporary Data";
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsEditForm.PopupEditFormWidth = 933;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "FullName";
            this.gridColumn1.FieldName = "FullName";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 186;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "Age";
            this.gridColumn2.FieldName = "Age";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 99;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Course";
            this.gridColumn3.FieldName = "Course";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 192;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Department";
            this.gridColumn4.FieldName = "Department";
            this.gridColumn4.MinWidth = 23;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 226;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "YearLevel";
            this.gridColumn5.FieldName = "YearLevel";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 157;
            // 
            // btnLoadData
            // 
            this.btnLoadData.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoadData.ImageOptions.SvgImage")));
            this.btnLoadData.Location = new System.Drawing.Point(438, 119);
            this.btnLoadData.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(92, 48);
            this.btnLoadData.TabIndex = 14;
            this.btnLoadData.Text = "LOAD";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Location = new System.Drawing.Point(716, 119);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 48);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.Location = new System.Drawing.Point(580, 119);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 48);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(302, 119);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 48);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // GridControlStudents
            // 
            this.GridControlStudents.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GridControlStudents.Location = new System.Drawing.Point(42, 391);
            this.GridControlStudents.MainView = this.gridView1;
            this.GridControlStudents.Margin = new System.Windows.Forms.Padding(4);
            this.GridControlStudents.Name = "GridControlStudents";
            this.GridControlStudents.Size = new System.Drawing.Size(1007, 446);
            this.GridControlStudents.TabIndex = 10;
            this.GridControlStudents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GridControlStudents.Click += new System.EventHandler(this.GridControlStudents_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView1.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView1.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView1.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView1.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView1.Appearance.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView1.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView1.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FullName,
            this.Age,
            this.Course,
            this.Department,
            this.YearLevel});
            this.gridView1.DetailHeight = 458;
            this.gridView1.GridControl = this.GridControlStudents;
            this.gridView1.GroupPanelText = "Permanent Data stored in Database";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 933;
            // 
            // FullName
            // 
            this.FullName.AppearanceHeader.Options.UseTextOptions = true;
            this.FullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FullName.Caption = "FullName";
            this.FullName.FieldName = "FullName";
            this.FullName.MinWidth = 23;
            this.FullName.Name = "FullName";
            this.FullName.OptionsColumn.AllowEdit = false;
            this.FullName.OptionsColumn.AllowFocus = false;
            this.FullName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 0;
            this.FullName.Width = 186;
            // 
            // Age
            // 
            this.Age.AppearanceHeader.Options.UseTextOptions = true;
            this.Age.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Age.Caption = "Age";
            this.Age.FieldName = "Age";
            this.Age.MinWidth = 23;
            this.Age.Name = "Age";
            this.Age.OptionsColumn.AllowEdit = false;
            this.Age.OptionsColumn.AllowFocus = false;
            this.Age.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Age.Visible = true;
            this.Age.VisibleIndex = 1;
            this.Age.Width = 99;
            // 
            // Course
            // 
            this.Course.AppearanceHeader.Options.UseTextOptions = true;
            this.Course.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Course.Caption = "Course";
            this.Course.FieldName = "Course";
            this.Course.MinWidth = 23;
            this.Course.Name = "Course";
            this.Course.OptionsColumn.AllowEdit = false;
            this.Course.OptionsColumn.AllowFocus = false;
            this.Course.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Course.Visible = true;
            this.Course.VisibleIndex = 2;
            this.Course.Width = 192;
            // 
            // Department
            // 
            this.Department.AppearanceHeader.Options.UseTextOptions = true;
            this.Department.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Department.Caption = "Department";
            this.Department.FieldName = "Department";
            this.Department.MinWidth = 23;
            this.Department.Name = "Department";
            this.Department.OptionsColumn.AllowEdit = false;
            this.Department.OptionsColumn.AllowFocus = false;
            this.Department.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Department.Visible = true;
            this.Department.VisibleIndex = 3;
            this.Department.Width = 226;
            // 
            // YearLevel
            // 
            this.YearLevel.AppearanceHeader.Options.UseTextOptions = true;
            this.YearLevel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.YearLevel.Caption = "YearLevel";
            this.YearLevel.FieldName = "YearLevel";
            this.YearLevel.MinWidth = 23;
            this.YearLevel.Name = "YearLevel";
            this.YearLevel.OptionsColumn.AllowEdit = false;
            this.YearLevel.OptionsColumn.AllowFocus = false;
            this.YearLevel.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.YearLevel.Visible = true;
            this.YearLevel.VisibleIndex = 4;
            this.YearLevel.Width = 157;
            // 
            // LabelYearLevel
            // 
            this.LabelYearLevel.Location = new System.Drawing.Point(821, 29);
            this.LabelYearLevel.Margin = new System.Windows.Forms.Padding(4);
            this.LabelYearLevel.Name = "LabelYearLevel";
            this.LabelYearLevel.Size = new System.Drawing.Size(58, 17);
            this.LabelYearLevel.TabIndex = 9;
            this.LabelYearLevel.Text = "YearLevel:";
            // 
            // LabelDepartment
            // 
            this.LabelDepartment.Location = new System.Drawing.Point(580, 29);
            this.LabelDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.LabelDepartment.Name = "LabelDepartment";
            this.LabelDepartment.Size = new System.Drawing.Size(72, 17);
            this.LabelDepartment.TabIndex = 8;
            this.LabelDepartment.Text = "Department:";
            // 
            // LabelCourse
            // 
            this.LabelCourse.Location = new System.Drawing.Point(371, 29);
            this.LabelCourse.Margin = new System.Windows.Forms.Padding(4);
            this.LabelCourse.Name = "LabelCourse";
            this.LabelCourse.Size = new System.Drawing.Size(44, 17);
            this.LabelCourse.TabIndex = 7;
            this.LabelCourse.Text = "Course:";
            // 
            // LabelAge
            // 
            this.LabelAge.Location = new System.Drawing.Point(266, 29);
            this.LabelAge.Margin = new System.Windows.Forms.Padding(4);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(26, 17);
            this.LabelAge.TabIndex = 6;
            this.LabelAge.Text = "Age:";
            // 
            // LabelFullName
            // 
            this.LabelFullName.Location = new System.Drawing.Point(42, 25);
            this.LabelFullName.Margin = new System.Windows.Forms.Padding(4);
            this.LabelFullName.Name = "LabelFullName";
            this.LabelFullName.Size = new System.Drawing.Size(57, 17);
            this.LabelFullName.TabIndex = 5;
            this.LabelFullName.Text = "FullName:";
            // 
            // TeYearLevel
            // 
            this.TeYearLevel.Location = new System.Drawing.Point(821, 54);
            this.TeYearLevel.Margin = new System.Windows.Forms.Padding(4);
            this.TeYearLevel.Name = "TeYearLevel";
            this.TeYearLevel.Properties.AutoHeight = false;
            this.TeYearLevel.Size = new System.Drawing.Size(227, 37);
            this.TeYearLevel.TabIndex = 4;
            // 
            // TeDepartment
            // 
            this.TeDepartment.Location = new System.Drawing.Point(580, 54);
            this.TeDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.TeDepartment.Name = "TeDepartment";
            this.TeDepartment.Properties.AutoHeight = false;
            this.TeDepartment.Size = new System.Drawing.Size(234, 37);
            this.TeDepartment.TabIndex = 3;
            // 
            // TeCourse
            // 
            this.TeCourse.Location = new System.Drawing.Point(371, 54);
            this.TeCourse.Margin = new System.Windows.Forms.Padding(4);
            this.TeCourse.Name = "TeCourse";
            this.TeCourse.Properties.AutoHeight = false;
            this.TeCourse.Size = new System.Drawing.Size(202, 37);
            this.TeCourse.TabIndex = 2;
            // 
            // TeAge
            // 
            this.TeAge.Location = new System.Drawing.Point(266, 54);
            this.TeAge.Margin = new System.Windows.Forms.Padding(4);
            this.TeAge.Name = "TeAge";
            this.TeAge.Properties.AutoHeight = false;
            this.TeAge.Size = new System.Drawing.Size(98, 37);
            this.TeAge.TabIndex = 1;
            // 
            // TeFullName
            // 
            this.TeFullName.Location = new System.Drawing.Point(42, 54);
            this.TeFullName.Margin = new System.Windows.Forms.Padding(4);
            this.TeFullName.Name = "TeFullName";
            this.TeFullName.Properties.AutoHeight = false;
            this.TeFullName.Size = new System.Drawing.Size(217, 37);
            this.TeFullName.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 861);
            this.Controls.Add(this.BGPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MainForm.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.BGPanel.ResumeLayout(false);
            this.BGPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraGrid.Columns.GridColumn Age;
        private DevExpress.XtraGrid.Columns.GridColumn Course;
        private DevExpress.XtraGrid.Columns.GridColumn Department;
        private DevExpress.XtraGrid.Columns.GridColumn YearLevel;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnLoadData;
        private DevExpress.XtraGrid.GridControl GridControlListView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}

