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
    public partial class frmPretragaIB170123 : Form
    {
        KonekcijaNaBazu db = DB.DLWMSdb.Baza;
        public frmPretragaIB170123()
        {            
            InitializeComponent();
        }

        private void frmPretragaIB170123_Load(object sender, EventArgs e)
        {
            var godineStudija = db.Studenti.Select(x => x.GodinaStudija).Distinct().ToList();
            
            for (int i = 0; i < godineStudija.Count; i++)
            {
                cbGodinaStudija.Items.Insert(i, godineStudija[i]);
            }

            Ucitaj();
        }


        private void Ucitaj()
        {
            var filter = txtPretragaStudenata.Text.ToLower();

            var students = db.Studenti.AsQueryable();

            if (!string.IsNullOrEmpty(filter))
                students = students.Where(student => student.Ime.ToLower().Contains(filter) || student.Prezime.ToLower().Contains(filter));

            if (cbGodinaStudija.SelectedIndex != -1)
            {
                var godina = (int)cbGodinaStudija.Items[cbGodinaStudija.SelectedIndex];
               students = students.Where(student => student.GodinaStudija == godina);
            }

            var studenti = students.ToList();

            DataTable table = new DataTable();

            table.Columns.Add("Id");
            table.Columns.Add("ImePrezime");
            table.Columns.Add("GodinaStudija");
            table.Columns.Add("ProsjecnaOcjena");
            table.Columns.Add("Konsultacije");

            foreach (var student in studenti)
            {
                DataRow row = table.NewRow();
                row["Id"] = student.Id;
                row["ImePrezime"] = student.ToString();
                row["GodinaStudija"] = student.GodinaStudija;

                var prosjecnaOcjena = db.StudentiPredmeti.Where(x => x.Student_Id == student.Id).Select(x => x.Ocjena).Average();                

                row["ProsjecnaOcjena"] = prosjecnaOcjena > 5 ? Math.Round(prosjecnaOcjena, 2) : 5;

                table.Rows.Add(row);
            }

            // Drugi nacin
            //if (string.IsNullOrEmpty(filter))
            //{
            //    studenti = db.Studenti.ToList();
            //}
            //else
            //{
            //    studenti = db.Studenti
            //        .Where(student => student.Ime.ToLower().Contains(filter) || student.Prezime.ToLower().Contains(filter))
            //        .ToList();
            //}

            DGW_Studenti.DataSource = table;
        }

        private void txtPretragaStudenata_KeyUp(object sender, KeyEventArgs e)
        {
            Ucitaj();
        }

        private void cbGodinaStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void DGW_Studenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 4)
            {
                try
                {
                    var studentId = int.Parse(DGW_Studenti.Rows[e.RowIndex].Cells[0].Value.ToString());

                    var student = db.Studenti.Where(x => x.Id == studentId).FirstOrDefault();

                    if (student != null)
                    {
                        var formKonsultacije = new frmKonsultacijeIB170123(student);
                        formKonsultacije.Show();
                    }
                }
                catch (Exception)
                {

                }

            }
        }
    }
}
