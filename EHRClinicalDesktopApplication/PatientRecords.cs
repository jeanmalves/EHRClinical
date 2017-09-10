using Model.BLL;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHRClinicalDesktopApplication
{
    public partial class PatientRecords : Form
    {
        public MainForm FormParent { get; private set; }
        public Doctor doctor { get; private set; }
        public PatientRecords(MainForm formParent)
        {
            InitializeComponent();
            FormParent = formParent;
        }

        private void PatientRecords_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dataGridPatientRecord.AutoGenerateColumns = false;

            doctor = DoctorBLL.GetDoctorByUserId(FormParent.UserId);

            try
            {
                var patientRecords = PatientRecordBLL.GetPatientRecordsByDoctorId(doctor.Id)
                                                         .Select(pr => new
                                                         {
                                                             Id = pr.Id,
                                                             CreatedAt = pr.CreatedAt,
                                                             Doctor = pr.Doctor.FirstName + " " + pr.Doctor.LastName,
                                                             Patient = pr.Patient.FirstName + " " + pr.Patient.LastName,
                                                             OptName = pr.OperationalsTemplate.Name
                                                         }).ToList();

                dataGridPatientRecord.DataSource = null;
                dataGridPatientRecord.DataSource = patientRecords;
                dataGridPatientRecord.Refresh();

                btnVisualizar.Visible = (dataGridPatientRecord.Rows.Count) > 0;
            }
            catch (Exception)
            {

                MessageBox.Show("Não há dados para exibir.");
            }


        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            var cells = dataGridPatientRecord.SelectedCells;

            var patientRecordId = Convert.ToInt32(cells[0].Value);

            var patientRecord = PatientRecordBLL.GetPatientRecord(patientRecordId);

            var dataDetails = new PatientRecordDetails(patientRecord);
            dataDetails.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchPatient();
        }

        private void searchPatient()
        {
            try
            {
                var patientRecords = PatientRecordBLL.GetPatientRecordsByTerm(doctor.Id, textSearch.Text)
                                                         .Select(pr => new
                                                         {
                                                             Id = pr.Id,
                                                             CreatedAt = pr.CreatedAt,
                                                             Doctor = pr.Doctor.FirstName + " " + pr.Doctor.LastName,
                                                             Patient = pr.Patient.FirstName + " " + pr.Patient.LastName,
                                                             OptName = pr.OperationalsTemplate.Name
                                                         }).ToList();


                dataGridPatientRecord.DataSource = null;
                dataGridPatientRecord.DataSource = patientRecords;
                dataGridPatientRecord.Refresh();

                if (patientRecords.Count == 0)
                {
                    MessageBox.Show("Não há dados para exibir.");
                }

                btnVisualizar.Visible = (dataGridPatientRecord.Rows.Count) > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                searchPatient();
            }
        }
    }
}
