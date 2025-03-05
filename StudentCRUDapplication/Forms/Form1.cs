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
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        BindingList<Student> studentList = new BindingList<Student>();
        public Form1()
        {
            InitializeComponent();
            GridControlStudents.DataSource = studentList;
        }

        private void BGPanel_Paint(object sender, PaintEventArgs e)
        {

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
            Student newStudent = new Student
            {
                FullName = TeFullName.Text,
                Age = int.TryParse(TeAge.Text, out int age) ? age : 0,
                Course = TeCourse.Text,
                Department = TeDepartment.Text,
                YearLevel = int.TryParse(TeYearLevel.Text, out int year) ? year : 0
            };

            studentList.Add(newStudent);
            ClearTextFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEdit1.Text) ||
               string.IsNullOrWhiteSpace(textEdit2.Text) ||
               string.IsNullOrWhiteSpace(textEdit3.Text) ||
               string.IsNullOrWhiteSpace(textEdit4.Text) ||
               string.IsNullOrWhiteSpace(textEdit5.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student newStudent = new Student
            {
                FullName = textEdit1.Text,
                Age = int.TryParse(TeAge.Text, out int age) ? age : 0,
                Course = textEdit3.Text,
                Department = textEdit4.Text,
                YearLevel = int.TryParse(textEdit5.Text, out int year) ? year : 0
            };

            studentList.Add(newStudent);
            GridControlStudents.RefreshDataSource(); // Update the Grid

            ClearTextFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (GridControlStudents.MainView is GridView gridView)
            {
                int selectedRow = gridView.FocusedRowHandle;
                if (selectedRow >= 0)
                {
                    Student selectedStudent = (Student)gridView.GetRow(selectedRow);
                    studentList.Remove(selectedStudent);
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
    }
}
