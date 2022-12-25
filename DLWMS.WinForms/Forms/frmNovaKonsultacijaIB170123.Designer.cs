
namespace DLWMS.WinForms.Forms
{
    partial class frmNovaKonsultacijaIB170123
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
            this.comboPredmeti = new System.Windows.Forms.ComboBox();
            this.dtPickerKonsultacije = new System.Windows.Forms.DateTimePicker();
            this.txtNapomena = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboPredmeti
            // 
            this.comboPredmeti.FormattingEnabled = true;
            this.comboPredmeti.Location = new System.Drawing.Point(40, 30);
            this.comboPredmeti.Name = "comboPredmeti";
            this.comboPredmeti.Size = new System.Drawing.Size(182, 21);
            this.comboPredmeti.TabIndex = 0;
            // 
            // dtPickerKonsultacije
            // 
            this.dtPickerKonsultacije.Location = new System.Drawing.Point(296, 27);
            this.dtPickerKonsultacije.Name = "dtPickerKonsultacije";
            this.dtPickerKonsultacije.Size = new System.Drawing.Size(200, 20);
            this.dtPickerKonsultacije.TabIndex = 1;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(40, 94);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(456, 97);
            this.txtNapomena.TabIndex = 2;
            this.txtNapomena.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Napomena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Predmet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum i vrijeme";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Odustani";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Spremi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmNovaKonsultacijaIB170123
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 274);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.dtPickerKonsultacije);
            this.Controls.Add(this.comboPredmeti);
            this.Name = "frmNovaKonsultacijaIB170123";
            this.Text = "frmNovaKonsultacijaIB170123";
            this.Load += new System.EventHandler(this.frmNovaKonsultacijaIB170123_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboPredmeti;
        private System.Windows.Forms.DateTimePicker dtPickerKonsultacije;
        private System.Windows.Forms.RichTextBox txtNapomena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}