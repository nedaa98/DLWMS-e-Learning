
namespace DLWMS.WinForms.Forms
{
    partial class frmPretragaIB170123
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretragaStudenata = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbGodinaStudija = new System.Windows.Forms.ComboBox();
            this.Konsultacije = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProsjecnaOcjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaStudija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGW_Studenti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Studenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Spol";
            this.dataGridViewTextBoxColumn1.HeaderText = "Spol";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pretraži studente";
            // 
            // txtPretragaStudenata
            // 
            this.txtPretragaStudenata.Location = new System.Drawing.Point(134, 18);
            this.txtPretragaStudenata.Name = "txtPretragaStudenata";
            this.txtPretragaStudenata.Size = new System.Drawing.Size(239, 20);
            this.txtPretragaStudenata.TabIndex = 2;
            this.txtPretragaStudenata.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPretragaStudenata_KeyUp);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Spol";
            this.dataGridViewTextBoxColumn2.HeaderText = "Spol";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // cbGodinaStudija
            // 
            this.cbGodinaStudija.FormattingEnabled = true;
            this.cbGodinaStudija.Location = new System.Drawing.Point(454, 18);
            this.cbGodinaStudija.Name = "cbGodinaStudija";
            this.cbGodinaStudija.Size = new System.Drawing.Size(121, 21);
            this.cbGodinaStudija.TabIndex = 4;
            this.cbGodinaStudija.SelectedIndexChanged += new System.EventHandler(this.cbGodinaStudija_SelectedIndexChanged);
            // 
            // Konsultacije
            // 
            this.Konsultacije.DataPropertyName = "Konsultacije";
            this.Konsultacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Konsultacije.HeaderText = "Konsultacije";
            this.Konsultacije.Name = "Konsultacije";
            this.Konsultacije.ReadOnly = true;
            this.Konsultacije.Text = "Konsultacije";
            this.Konsultacije.ToolTipText = "Konsultacije";
            this.Konsultacije.UseColumnTextForButtonValue = true;
            // 
            // ProsjecnaOcjena
            // 
            this.ProsjecnaOcjena.DataPropertyName = "ProsjecnaOcjena";
            this.ProsjecnaOcjena.HeaderText = "Prosjecna ocjena";
            this.ProsjecnaOcjena.Name = "ProsjecnaOcjena";
            this.ProsjecnaOcjena.ReadOnly = true;
            this.ProsjecnaOcjena.Width = 200;
            // 
            // GodinaStudija
            // 
            this.GodinaStudija.DataPropertyName = "GodinaStudija";
            this.GodinaStudija.HeaderText = "Godina studija";
            this.GodinaStudija.Name = "GodinaStudija";
            this.GodinaStudija.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // DGW_Studenti
            // 
            this.DGW_Studenti.AllowUserToAddRows = false;
            this.DGW_Studenti.AllowUserToDeleteRows = false;
            this.DGW_Studenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Studenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.Id,
            this.GodinaStudija,
            this.ProsjecnaOcjena,
            this.Konsultacije});
            this.DGW_Studenti.Location = new System.Drawing.Point(30, 72);
            this.DGW_Studenti.Name = "DGW_Studenti";
            this.DGW_Studenti.ReadOnly = true;
            this.DGW_Studenti.Size = new System.Drawing.Size(545, 123);
            this.DGW_Studenti.TabIndex = 3;
            this.DGW_Studenti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGW_Studenti_CellClick);
            // 
            // frmPretragaIB170123
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 287);
            this.Controls.Add(this.cbGodinaStudija);
            this.Controls.Add(this.DGW_Studenti);
            this.Controls.Add(this.txtPretragaStudenata);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIB170123";
            this.Text = "frmPretragaIB170123";
            this.Load += new System.EventHandler(this.frmPretragaIB170123_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Studenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretragaStudenata;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox cbGodinaStudija;
        private System.Windows.Forms.DataGridViewButtonColumn Konsultacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProsjecnaOcjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaStudija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridView DGW_Studenti;
    }
}