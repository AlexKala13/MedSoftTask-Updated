using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MEDSOFT_Task.Model;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraExport.Helpers;
using System.Data.Linq.Mapping;

namespace MEDSOFT_Task
{
    public partial class Main : Form
    {
       

        public Main()
        {
            // მეთოდების გამოძახება
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGrid.DataSource = MainHandler.GetPatients();
            gvPatients.BestFitColumns();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddEditForm addEditForm = new AddEditForm(null);
            if (addEditForm.ShowDialog() == DialogResult.OK) // არჩეული პაციენტის რედაქტირების ფანჯრის გახსნა
            {
                LoadData();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (gvPatients.SelectedRowsCount == 1)
            {
                PatientModel model = new PatientModel();
                model.ID = Convert.ToInt32(gvPatients.GetFocusedRowCellValue(colId).ToString());
                model.FullName = gvPatients.GetFocusedRowCellValue(colFullName).ToString();
                model.Phone = gvPatients.GetFocusedRowCellValue(colPhone).ToString();
                model.personalId = gvPatients.GetFocusedRowCellValue(colPersonalId).ToString();
                model.Email = gvPatients.GetFocusedRowCellValue(colEmail).ToString();
                model.GenderName = gvPatients.GetFocusedRowCellValue(colGenderName).ToString();
                model.BirthDate = Convert.ToDateTime(gvPatients.GetFocusedRowCellValue(colBirthDate).ToString());
                model.Address = gvPatients.GetFocusedRowCellValue(colAddress).ToString();

                AddEditForm addEditForm = new AddEditForm(model);
                if (addEditForm.ShowDialog() == DialogResult.OK) // არჩეული პაციენტის რედაქტირების ფანჯრის გახსნა
                {
                    LoadData();
                }
            } else
            {
                MessageBox.Show("აირჩიეთ მხოლოდ ერთი პაციენტი!");
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            // Получаем выбранные строки
            int[] selectedRowHandles = gvPatients.GetSelectedRows();

            // Создаем список для хранения айди выбранных пациентов
            List<int> selectedPatientIDs = new List<int>();

            // Перебираем выбранные строки и извлекаем айди
            foreach (int rowHandle in selectedRowHandles)
            {
                int patientID = (int)gvPatients.GetRowCellValue(rowHandle, colId);
                selectedPatientIDs.Add(patientID);
            }

            if (selectedPatientIDs.Count > 0)
            {
                DialogResult result = MessageBox.Show($"გსურთ მონიშნული ჩანაწერის წაშლა?", "წაშლის დადასტურება",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MainHandler.DeletePatients(selectedPatientIDs);
                    LoadData();
                } 
            }
            else
            {
                MessageBox.Show("აირჩიეთ პაციენტი!");
            }
        }
    }
}