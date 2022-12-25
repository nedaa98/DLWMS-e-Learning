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
    public partial class frmKonsultacijeIB170123 : Form
    {
        private Student _student;
        private KonekcijaNaBazu _db = DB.DLWMSdb.Baza;

        public frmKonsultacijeIB170123(Student student)
        {
            InitializeComponent();

            _student = student;
        }

        private void frmKonsultacijeIB170123_Load(object sender, EventArgs e)
        {
            txtNaslov.Text = $"Konsultacije za studenta {_student.ToString()}";

            UcitajPodatke();
        }

        public void UcitajPodatke()
        {
            var konsultacije = _db.StudentiKonsultacije.Where(x => x.StudentId == _student.Id).ToList();

            DataTable table = new DataTable();

            table.Columns.Add("Id");
            table.Columns.Add("Predmet");
            table.Columns.Add("Napomena");
            table.Columns.Add("DatumVrijeme");
            table.Columns.Add("Obrisi");

            foreach (var konsultacija in konsultacije)
            {
                DataRow row = table.NewRow();
                row["Id"] = konsultacija.Id;
                row["Predmet"] = konsultacija.Predmet.Naziv;
                row["Napomena"] = konsultacija.Napomena;
                row["DatumVrijeme"] = konsultacija.Datum;

                table.Rows.Add(row);
            }

            dgvKonsultacije.DataSource = table;
            this.Text = $"Broj konsultacija: {konsultacije.Count}";
        }

        private void dgvKonsultacije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var dialogResult = MessageBox.Show("Jeste li sigurni da zelite obrisati konsultaciju?", "Upozorenje", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    var konsultacijaId = int.Parse(dgvKonsultacije.Rows[e.RowIndex].Cells[0].Value.ToString());

                    var konsultacijaZaBrisanje = _db.StudentiKonsultacije.Where(x => x.Id == konsultacijaId).FirstOrDefault();

                    if (konsultacijaZaBrisanje != null)
                    {
                        // Prije brisanja ili update-a mora attach
                        _db.StudentiKonsultacije.Attach(konsultacijaZaBrisanje);
                        _db.StudentiKonsultacije.Remove(konsultacijaZaBrisanje);

                        _db.SaveChanges();

                        UcitajPodatke();
                    }
                }
            }
        }

        private void btnDodajZahtjev_Click(object sender, EventArgs e)
        {
            var formaDodaj = new frmNovaKonsultacijaIB170123(_student, this);
            formaDodaj.Show();


        }
    }
}
