
namespace DLWMS.WinForms.Forms
{
    partial class frmKonsultacijeIB170123
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
            this.txtNaslov = new System.Windows.Forms.Label();
            this.dgvKonsultacije = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDodajZahtjev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonsultacije)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaslov
            // 
            this.txtNaslov.AutoSize = true;
            this.txtNaslov.Location = new System.Drawing.Point(30, 49);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(35, 13);
            this.txtNaslov.TabIndex = 0;
            this.txtNaslov.Text = "label1";
            // 
            // dgvKonsultacije
            // 
            this.dgvKonsultacije.AllowUserToAddRows = false;
            this.dgvKonsultacije.AllowUserToDeleteRows = false;
            this.dgvKonsultacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKonsultacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Predmet,
            this.Napomena,
            this.DatumVrijeme,
            this.Obrisi});
            this.dgvKonsultacije.Location = new System.Drawing.Point(33, 107);
            this.dgvKonsultacije.Name = "dgvKonsultacije";
            this.dgvKonsultacije.ReadOnly = true;
            this.dgvKonsultacije.Size = new System.Drawing.Size(548, 216);
            this.dgvKonsultacije.TabIndex = 1;
            this.dgvKonsultacije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKonsultacije_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            // 
            // DatumVrijeme
            // 
            this.DatumVrijeme.DataPropertyName = "DatumVrijeme";
            this.DatumVrijeme.HeaderText = "Datum i vrijeme";
            this.DatumVrijeme.Name = "DatumVrijeme";
            this.DatumVrijeme.ReadOnly = true;
            this.DatumVrijeme.Width = 200;
            // 
            // Obrisi
            // 
            this.Obrisi.DataPropertyName = "Obrisi";
            this.Obrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Obrisi.HeaderText = "Obrisi";
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.ReadOnly = true;
            this.Obrisi.Text = "Obrisi";
            this.Obrisi.ToolTipText = "Obrisi";
            this.Obrisi.UseColumnTextForButtonValue = true;
            // 
            // btnDodajZahtjev
            // 
            this.btnDodajZahtjev.Location = new System.Drawing.Point(447, 44);
            this.btnDodajZahtjev.Name = "btnDodajZahtjev";
            this.btnDodajZahtjev.Size = new System.Drawing.Size(134, 23);
            this.btnDodajZahtjev.TabIndex = 2;
            this.btnDodajZahtjev.Text = "Dodaj novi zahtjev";
            this.btnDodajZahtjev.UseVisualStyleBackColor = true;
            this.btnDodajZahtjev.Click += new System.EventHandler(this.btnDodajZahtjev_Click);
            // 
            // frmKonsultacijeIB170123
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 402);
            this.Controls.Add(this.btnDodajZahtjev);
            this.Controls.Add(this.dgvKonsultacije);
            this.Controls.Add(this.txtNaslov);
            this.Name = "frmKonsultacijeIB170123";
            this.Text = "frmKonsultacijeIB170123";
            this.Load += new System.EventHandler(this.frmKonsultacijeIB170123_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonsultacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNaslov;
        private System.Windows.Forms.DataGridView dgvKonsultacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijeme;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
        private System.Windows.Forms.Button btnDodajZahtjev;
    }
}