using DevExpress.XtraGrid.Views.Grid;
using StudentCRUDapplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentCRUDapplication
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        List<Student> studentList = new List<Student>();
        List<Student> tempStudentList = new List<Student>();

        public MainForm()
        {
            InitializeComponent();
            GridControlStudents.DataSource = studentList;
            GridControlListView.DataSource = tempStudentList;
        }
        private void GridControlStudents_Click(object sender, EventArgs e)
        {
            if (GridControlStudents.MainView is GridView gridView)
            {
                int selectedRow = gridView.FocusedRowHandle;
                if (selectedRow >= 0)
                {
                    Student selectedStudent = (Student)gridView.GetRow(selectedRow);

                    TeFullName.Text = selectedStudent.FullName;
                    TeAge.Text = selectedStudent.Age.ToString();
                    TeCourse.Text = selectedStudent.Course;
                    TeDepartment.Text = selectedStudent.Department;
                    TeYearLevel.Text = selectedStudent.YearLevel.ToString();
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TeFullName.Text) ||
               string.IsNullOrWhiteSpace(TeAge.Text) ||
               string.IsNullOrWhiteSpace(TeCourse.Text) ||
               string.IsNullOrWhiteSpace(TeDepartment.Text) ||
               string.IsNullOrWhiteSpace(TeYearLevel.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            Student newStudent = new Student //Pag naay value ang textedit kay ma add dayun mo refresh
            {
                FullName = TeFullName.Text,
                Age = int.TryParse(TeAge.Text, out int age) ? age : 0,
                Course = TeCourse.Text,
                Department = TeDepartment.Text,
                YearLevel = int.TryParse(TeYearLevel.Text, out int year) ? year : 0
            };

            tempStudentList.Add(newStudent);
            GridControlListView.RefreshDataSource();

            ClearTextFields();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (GridControlStudents.MainView is GridView gridView)
            {
                int selectedRow = gridView.FocusedRowHandle;
                if (selectedRow >= 0)
                {
                    Student selectedStudent = (Student)gridView.GetRow(selectedRow);

                    // Update student details with values from textedit
                    selectedStudent.FullName = TeFullName.Text;
                    selectedStudent.Age = int.TryParse(TeAge.Text, out int age) ? age : 0;
                    selectedStudent.Course = TeCourse.Text;
                    selectedStudent.Department = TeDepartment.Text;
                    selectedStudent.YearLevel = int.TryParse(TeYearLevel.Text, out int year) ? year : 0;

                    // Refresh GridControl to para makita ang data
                    GridControlStudents.RefreshDataSource();

                    MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextFields();
                }
                else
                {
                    MessageBox.Show("Please select a record to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (GridControlStudents.MainView is GridView gridView)
            {
                int selectedRow = gridView.FocusedRowHandle;
                if (selectedRow >= 0)
                {
                    Student selectedStudent = (Student)gridView.GetRow(selectedRow);

                    // Confirmation before delete
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?",
                        "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        studentList.Remove(selectedStudent);
                        GridControlStudents.RefreshDataSource(); // Refresh GridControl

                        MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextFields();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void ClearTextFields()
        {
            TeFullName.Text = "";
            TeAge.Text = "";
            TeCourse.Text = "";
            TeDepartment.Text = "";
            TeYearLevel.Text = "";
        }
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            foreach (var student in tempStudentList)
            {
                studentList.Add(student);
            }
            
            tempStudentList.Clear(); // Clear the temporary storage and refresh the UI
            GridControlStudents.RefreshDataSource(); // Refresh main GridControl
            GridControlListView.RefreshDataSource(); // Refresh temporary GridControl
        }
    }
}
