using DLWMS.WinForms.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forms
{
    public partial class frmNovaKonsultacijaIB170123 : Form
    {
        private Student _student;
        private KonekcijaNaBazu _db = DB.DLWMSdb.Baza;
        private Form _parentForm;

        public frmNovaKonsultacijaIB170123(Student student, Form parentForm)
        {
            InitializeComponent();
            this._student = student;
            this._parentForm = parentForm;
        }

        private void frmNovaKonsultacijaIB170123_Load(object sender, EventArgs e)
        {
            var predmeti = _db.Predmeti.ToList();

            for(int i = 0; i < predmeti.Count; i++)
            {
                comboPredmeti.Items.Insert(i, predmeti[i].Naziv);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var predmet = comboPredmeti.SelectedItem.ToString();

            var odabraniPredmet = _db.Predmeti.Where(x => x.Naziv == predmet).FirstOrDefault();

            var novaKonsultacija = new StudentiKonsultacije()
            {
                Datum = dtPickerKonsultacije.Value.ToString(DLWMSdb.DefaultDateTimeFormat),
                Napomena = txtNapomena.Text,
                PredmetId = odabraniPredmet.Id,
                StudentId = _student.Id
            };

            _db.StudentiKonsultacije.Add(novaKonsultacija);
            _db.SaveChanges();

            var form = _parentForm as frmKonsultacijeIB170123;

            if (form != null)
                form.UcitajPodatke();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
