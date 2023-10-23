using MEDSOFT_Task.HelperMethods;
using MEDSOFT_Task.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDSOFT_Task
{
    public partial class AddEditForm : Form
    {
        PatientModel _model = new PatientModel();
        public AddEditForm()
        {

        }

        public AddEditForm(PatientModel model)
        {
            _model = model;
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox() // სქესის არჩევის კომბობოქსის ინიციალიზაცია
        {
            CbFillClass.InitializeCb(genderCb);
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            if (_model != null) // თუ იყო არჩეული რედაქტირება იმ შემთხვევაში ხდება ტექსტბოქსების შევსება პაციენტის მონაცემებით
            {
                nameTb.Text = _model.FullName;
                birthdatePicker.Value = _model.BirthDate;
                phoneTb.Text = _model.Phone;
                addressTb.Text = _model.Address;
                emailTb.Text = _model.Email;
                genderCb.SelectedItem = _model.GenderName;
                personalIdTb.Text = _model.personalId;
            }
        }

        private void addEditBtn_Click(object sender, EventArgs e) // დამატება/რედაქტირების ღილაკი
        {
            if (ValidateData())
            {
                PatientModel model = new PatientModel();

                if(_model != null)
                {
                    model.ID = _model.ID;
                } else
                {
                    model.ID = 0;
                }

                model.FullName = nameTb.Text;
                model.Email = emailTb.Text;
                model.BirthDate = birthdatePicker.Value;
                model.Address = addressTb.Text;
                model.personalId = personalIdTb.Text;
                model.Phone = phoneTb.Text;
                model.GenderId = (int)genderCb.SelectedValue;

                AddEditPatientHandler.PatientSet(model);

                // პაციენტის რედაქტირების ფანჯრის ჩახურვა

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e) // გაუქმების ღილაკი
        {
            this.Close();
        }

        private bool ValidateData() // დასამატებელი პაციენტის შეყვანილი მონაცემების ვალიდაცია
        {
            bool result = true;

            // სახელისა და გვარის ვალიდაცია

            if (!string.IsNullOrWhiteSpace(nameTb.Text))
            { 
                nameErrorLabel.Text = "";
            }
            else // თუ ველი არაა შევსებული
            {
                nameErrorLabel.Text = "შეიყვანეთ სახელი და გვარი !";
                result = false;
            }


            // დაბადების თარიღის ვალიდაცია

            if (birthdatePicker.Value != null && birthdatePicker.Value <= DateTime.Now)
            {
                birthDateErrorLabel.Text = "";
            }
            else if (birthdatePicker.Value != null && birthdatePicker.Value > DateTime.Now) // თუ შეყვანილი დაბადების თარიღი მომავალშია
            {
                birthDateErrorLabel.Text = "შეიყვანეთ ნამდვილი დაბადების თარიღი !";
                result = false;
            }
            else // თუ დაბადების თარიღი არაა შეყვანილი
            {
                birthDateErrorLabel.Text = "შეიყვანეთ დაბადების თარიღი !";
                result = false;
            }


            // სქესის ვალიდაცია

            if (genderCb.SelectedItem != null)
            {
                genderErrorLabel.Text = "";
            }
            else // თუ პაციენტის სქესი არაა არჩეული
            {
                genderErrorLabel.Text = "აირჩიეთ სქესი !";
                result = false;
            }


            // ტელეფონის ნომრის ვალიდაცია (მითითების შემთხვევაში)

            if (!string.IsNullOrWhiteSpace(phoneTb.Text)) // ჯერ ხდება შემოწმება მითითებულია თუ არა ტელეფონის ნომერი (რადგან ტელეფონის ნომრის შეყვანა არასავალდებულოა)
            {
                if (phoneTb.Text.Length == 9 && phoneTb.Text[0] == '5') // შეყვანილი ნომრის შემოწება (იწყება თუ არა 5-ზე და შეიცავს თუ არა 9 ციფრს)
                {
                    phoneErrorLabel.Text = "";
                }
                else // თუ შეყვანილმა ნომერმა ვერ გაიარა შემოწმება
                {
                    phoneErrorLabel.Text = "ნომერი არასწორადაა მითითებული !";
                    result = false;
                }
            }


            // პირადი ნომრის ვალიდაცია

            if (!string.IsNullOrWhiteSpace(personalIdTb.Text) && personalIdTb.Text.Length == 11) // მომწმდება შეყვანილია თუ არა პირადი ნომერი და შეიცავს თუ არა 11 სიმბოლოს
            {
                pIdErrorLabel.Text = "";
            }
            else if (personalIdTb.Text != null && personalIdTb.Text.Length != 11) // თუ შეყვანილია, მაგრამ არ შეიცავს 11 სიმბოლოს
            {
                pIdErrorLabel.Text = "პირადი ნომერი უნდა შეიცავდეს 11 ციფრს !";
                result = false;
            }
            else // თუ არაა შეყვანილი
            {
                pIdErrorLabel.Text = "შეიყვანეთ პირადი ნომერი !";
                result = false;
            }

            return result;
        }
    }
}