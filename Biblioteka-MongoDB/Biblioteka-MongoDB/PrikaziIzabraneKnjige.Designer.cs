
namespace Biblioteka_MongoDB
{
    partial class PrikaziIzabraneKnjige
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
            this.btnListaZelja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKorisnik = new System.Windows.Forms.Button();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPrikaziListu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaKnjiga);
            this.groupBox1.Location = new System.Drawing.Point(51, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spisak knjiga:";
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
            this.listaKnjiga.Size = new System.Drawing.Size(933, 314);
            this.listaKnjiga.TabIndex = 0;
            this.listaKnjiga.UseCompatibleStateImageBehavior = false;
            this.listaKnjiga.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Knjiga id";
            this.columnHeader1.Width = 202;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naslov";
            this.columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Autor";
            this.columnHeader3.Width = 138;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Žanr";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Godina izdavanja";
            this.columnHeader5.Width = 162;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Broj primeraka";
            this.columnHeader6.Width = 150;
            // 
            // btnListaZelja
            // 
            this.btnListaZelja.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaZelja.Location = new System.Drawing.Point(47, 63);
            this.btnListaZelja.Name = "btnListaZelja";
            this.btnListaZelja.Size = new System.Drawing.Size(225, 23);
            this.btnListaZelja.TabIndex = 1;
            this.btnListaZelja.Text = "Dodaj u listu zelja";
            this.btnListaZelja.UseVisualStyleBackColor = true;
            this.btnListaZelja.Click += new System.EventHandler(this.btnListaZelja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Neophodno je da prvo\r\n unesete svoj JMBG:";
            // 
            // btnKorisnik
            // 
            this.btnKorisnik.Location = new System.Drawing.Point(52, 90);
            this.btnKorisnik.Name = "btnKorisnik";
            this.btnKorisnik.Size = new System.Drawing.Size(235, 23);
            this.btnKorisnik.TabIndex = 3;
            this.btnKorisnik.Text = "Proveri/dodaj korisnika";
            this.btnKorisnik.UseVisualStyleBackColor = true;
            this.btnKorisnik.Click += new System.EventHandler(this.btnKorisnik_Click);
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(52, 56);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(235, 25);
            this.txtJMBG.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mozete da izmenite svoje podatke:";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(77, 90);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(111, 23);
            this.btnIzmeni.TabIndex = 6;
            this.btnIzmeni.Text = "Izmeni podatke korisnika";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dodajte u listu zelja da biste mogli\r\n da iznajmite: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKorisnik);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtJMBG);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 119);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Obavezan deo za sve radnje!";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPrikaziListu);
            this.groupBox3.Controls.Add(this.btnListaZelja);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(759, 365);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 119);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dodaj u listu";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnIzmeni);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(452, 365);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 119);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Izmeni nalog";
            // 
            // btnPrikaziListu
            // 
            this.btnPrikaziListu.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziListu.Location = new System.Drawing.Point(47, 92);
            this.btnPrikaziListu.Name = "btnPrikaziListu";
            this.btnPrikaziListu.Size = new System.Drawing.Size(225, 23);
            this.btnPrikaziListu.TabIndex = 8;
            this.btnPrikaziListu.Text = "Prikazi listu zelja";
            this.btnPrikaziListu.UseVisualStyleBackColor = true;
            this.btnPrikaziListu.Click += new System.EventHandler(this.btnPrikaziListu_Click);
            // 
            // PrikaziIzabraneKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1060, 496);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PrikaziIzabraneKnjige";
            this.Text = "Knjige koje zadovoljavaju izabrane kriterijume";
            this.Load += new System.EventHandler(this.PrikaziIzabraneKnjige_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnListaZelja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKorisnik;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPrikaziListu;
    }
}