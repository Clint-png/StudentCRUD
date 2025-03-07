using DevExpress.XtraGrid.Views.Grid;
using StudentCRUDapplication.Models;
using System;
using System.Collections.Generic;
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

            TeAge.KeyPress += TeAge_KeyPress;
            TeYearLevel.KeyPress += TeYearLevel_KeyPress;
        }

        //para numbers ray dawaton
        private void TeAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed for Age!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //para numbers ray dawaton
        private void TeYearLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed for Year Level!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Populates the text fields with the selected student's information.
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
        //adds temporary data to temporary Grid
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

            if (!int.TryParse(TeAge.Text, out int age))
            {
                MessageBox.Show("Age must be a valid number!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student newStudent = new Student
            {
                FullName = TeFullName.Text,
                Age = age,
                Course = TeCourse.Text,
                Department = TeDepartment.Text,
                YearLevel = int.TryParse(TeYearLevel.Text, out int year) ? year : 0
            };

            tempStudentList.Add(newStudent);
            GridControlListView.RefreshDataSource();
            ClearTextFields();
        }
        //edit selected data
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (GridControlStudents.MainView is GridView gridView)
            {
                int selectedRow = gridView.FocusedRowHandle;
                if (selectedRow >= 0)
                {
                    if (!int.TryParse(TeAge.Text, out int age))
                    {
                        MessageBox.Show("Age must be a valid number!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Student selectedStudent = (Student)gridView.GetRow(selectedRow);
                    selectedStudent.FullName = TeFullName.Text;
                    selectedStudent.Age = age;
                    selectedStudent.Course = TeCourse.Text;
                    selectedStudent.Department = TeDepartment.Text;
                    selectedStudent.YearLevel = int.TryParse(TeYearLevel.Text, out int year) ? year : 0;

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
        //delete function
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (GridControlStudents.MainView is GridView gridView)
            {
                int selectedRow = gridView.FocusedRowHandle;
                if (selectedRow >= 0)
                {
                    Student selectedStudent = (Student)gridView.GetRow(selectedRow);
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        studentList.Remove(selectedStudent);
                        GridControlStudents.RefreshDataSource();
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
            studentList.AddRange(tempStudentList);
            tempStudentList.Clear();
            GridControlStudents.RefreshDataSource();
            GridControlListView.RefreshDataSource();
        }
    }
}
