using Model.BLL;
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
        public PatientRecords(MainForm formParent)
        {
            InitializeComponent();
            FormParent = formParent;
        }

        private void PatientRecords_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            var doctor = DoctorBLL.GetDoctorByUserId(FormParent.UserId);

            var patientRecords = PatientRecordBLL.GetPatientRecordsByDoctorId(doctor.Id)
                                                     .Select(pr => new
                                                     {
                                                         CreatedAt = pr.CreatedAt,
                                                         Doctor = pr.Doctor.FirstName + " " + pr.Doctor.LastName,
                                                         Patient = pr.Patient.FirstName + " " + pr.Patient.LastName,
                                                         OptName = pr.OperationalsTemplate.Name
                                                     }).ToList();

            /*dataGridPatientRecord.Columns.Add("CreatedAt", "Data");
            dataGridPatientRecord.Columns.Add("Doctor", "Médico");
            dataGridPatientRecord.Columns.Add("Patient", "Paciente");
            dataGridPatientRecord.Columns.Add("OptName", "Consulta/procedimento");*/

            dataGridPatientRecord.DataSource = null;
            dataGridPatientRecord.DataSource = patientRecords;
            dataGridPatientRecord.Refresh();
        }
    }
}
