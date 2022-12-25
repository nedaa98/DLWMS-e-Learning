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

namespace DLWMS.WinForms
{
    public partial class frmGlavna : Form
    {

        KonekcijaNaBazu baza = DB.DLWMSdb.Baza;

        public frmGlavna()
        {
            InitializeComponent();
        }        

        private void frmGlavna_Load(object sender, EventArgs e)
        {
            try
            {
                lblInfo.Text = $"Broj studenata u bazi: {DB.DLWMSdb.Baza.Studenti.FirstOrDefault().Spol.Naziv}";

                var studenti = baza.StudentiPredmeti.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.InnerException?.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Reports.frmIzvjestaj().Show();
        }
    }
}
