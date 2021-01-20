
namespace Biblioteka_MongoDB
{
    partial class PrikaziSveKnjigeForma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaKnjiga = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnListaZelja = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnZelje = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.btnKorisnik = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaKnjiga);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1026, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Narodna biblioteka \"Stevan Sremac\"";
            // 
            // listaKnjiga
            // 
            this.listaKnjiga.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listaKnjiga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaKnjiga.FullRowSelect = true;
            this.listaKnjiga.GridLines = true;
            this.listaKnjiga.HideSelection = false;
            this.listaKnjiga.Location = new System.Drawing.Point(3, 20);
            this.listaKnjiga.Name = "listaKnjiga";
            this.listaKnjiga.Size = new System.Drawing.Size(1020, 325);
            this.listaKnjiga.TabIndex = 0;
            this.listaKnjiga.UseCompatibleStateImageBehavior = false;
            this.listaKnjiga.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naslov";
            this.columnHeader1.Width = 202;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Autor";
            this.columnHeader2.Width = 136;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Žanr";
            this.columnHeader3.Width = 124;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Godina prvog objavjivanja";
            this.columnHeader4.Width = 185;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Broj primeraka u biblioteci";
            this.columnHeader5.Width = 194;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id knjige";
            this.columnHeader6.Width = 172;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberite knjige\r\n za svoju listu želja:";
            // 
            // btnListaZelja
            // 
            this.btnListaZelja.Location = new System.Drawing.Point(213, 33);
            this.btnListaZelja.Name = "btnListaZelja";
            this.btnListaZelja.Size = new System.Drawing.Size(149, 24);
            this.btnListaZelja.TabIndex = 2;
            this.btnListaZelja.Text = "Dodaj u listu želja";
            this.btnListaZelja.UseVisualStyleBackColor = true;
            this.btnListaZelja.Click += new System.EventHandler(this.btnListaZelja_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnZelje);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnListaZelja);
            this.groupBox2.Location = new System.Drawing.Point(636, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 138);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista želja";
            // 
            // btnZelje
            // 
            this.btnZelje.Location = new System.Drawing.Point(213, 89);
            this.btnZelje.Name = "btnZelje";
            this.btnZelje.Size = new System.Drawing.Size(149, 23);
            this.btnZelje.TabIndex = 3;
            this.btnZelje.Text = "Vidi listu zelja";
            this.btnZelje.UseVisualStyleBackColor = true;
            this.btnZelje.Click += new System.EventHandler(this.btnZelje_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtJMBG);
            this.groupBox4.Controls.Add(this.btnKorisnik);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(15, 366);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(467, 142);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Da li se korisnik nalazi u bazi? Obavezno unesti JMBG";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(226, 48);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(235, 24);
            this.txtJMBG.TabIndex = 2;
            // 
            // btnKorisnik
            // 
            this.btnKorisnik.Location = new System.Drawing.Point(136, 93);
            this.btnKorisnik.Name = "btnKorisnik";
            this.btnKorisnik.Size = new System.Drawing.Size(178, 23);
            this.btnKorisnik.TabIndex = 1;
            this.btnKorisnik.Text = "Proveri/dodaj korisnika";
            this.btnKorisnik.UseVisualStyleBackColor = true;
            this.btnKorisnik.Click += new System.EventHandler(this.btnKorisnik_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vaš JMBG:";
            // 
            // PrikaziSveKnjigeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1089, 531);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrikaziSveKnjigeForma";
            this.Text = "PrikaziSveKnjigeForma";
            this.Load += new System.EventHandler(this.PrikaziSveKnjigeForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listaKnjiga;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListaZelja;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Button btnKorisnik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnZelje;
    }
}