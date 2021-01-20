
namespace Biblioteka_MongoDB
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNaslov = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnInformacije = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOR = new System.Windows.Forms.Button();
            this.txtNaslovOR = new System.Windows.Forms.TextBox();
            this.txtAutorOR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Narodna biblioteka \"Stevan Sremac\"";
            // 
            // btnNaslov
            // 
            this.btnNaslov.Location = new System.Drawing.Point(82, 90);
            this.btnNaslov.Name = "btnNaslov";
            this.btnNaslov.Size = new System.Drawing.Size(263, 24);
            this.btnNaslov.TabIndex = 1;
            this.btnNaslov.Text = "Prikazi knjigu koju zelite";
            this.btnNaslov.UseVisualStyleBackColor = true;
            this.btnNaslov.Click += new System.EventHandler(this.btnNaslov_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNaslov);
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNaslov);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izaberite knjigu koju zelite(unesite ime autora i naziv knjige)";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(249, 27);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(178, 24);
            this.txtAutor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Autor:";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(249, 62);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(178, 24);
            this.txtNaslov.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naslov: ";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(403, 88);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(228, 31);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Doniraj knjigu";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnInformacije
            // 
            this.btnInformacije.Location = new System.Drawing.Point(403, 44);
            this.btnInformacije.Name = "btnInformacije";
            this.btnInformacije.Size = new System.Drawing.Size(228, 29);
            this.btnInformacije.TabIndex = 4;
            this.btnInformacije.Text = "Prikazi informacije";
            this.btnInformacije.UseVisualStyleBackColor = true;
            this.btnInformacije.Click += new System.EventHandler(this.btnInformacije_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOR);
            this.groupBox2.Controls.Add(this.txtNaslovOR);
            this.groupBox2.Controls.Add(this.txtAutorOR);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(632, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 123);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prikazi knjige autora ili unesi samo naslov knjige";
            // 
            // btnOR
            // 
            this.btnOR.Location = new System.Drawing.Point(35, 90);
            this.btnOR.Name = "btnOR";
            this.btnOR.Size = new System.Drawing.Size(295, 24);
            this.btnOR.TabIndex = 4;
            this.btnOR.Text = "Prikazi knjigu po jednom od kriterijuma";
            this.btnOR.UseVisualStyleBackColor = true;
            this.btnOR.Click += new System.EventHandler(this.btnOR_Click);
            // 
            // txtNaslovOR
            // 
            this.txtNaslovOR.Location = new System.Drawing.Point(121, 59);
            this.txtNaslovOR.Name = "txtNaslovOR";
            this.txtNaslovOR.Size = new System.Drawing.Size(180, 24);
            this.txtNaslovOR.TabIndex = 3;
            // 
            // txtAutorOR
            // 
            this.txtAutorOR.Location = new System.Drawing.Point(121, 24);
            this.txtAutorOR.Name = "txtAutorOR";
            this.txtAutorOR.Size = new System.Drawing.Size(180, 24);
            this.txtAutorOR.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Naslov:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Autor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "*Prikazuju se samo\r\ndostupne knjige";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(378, 39);
            this.label7.TabIndex = 7;
            this.label7.Text = "*Mozete da iznajmite knjigu klikom na \'Prikazi informacije\' \r\nili izborom po neko" +
    "m kriterijumu i klikom\r\nna \'Prikazi knjigu koju zelite\' ili \'Prikazi knjigu po j" +
    "ednom od kriterijuma\'";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1014, 529);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnInformacije);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Narodna biblioteka \"Stevan Sremac\"";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNaslov;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnInformacije;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOR;
        private System.Windows.Forms.TextBox txtNaslovOR;
        private System.Windows.Forms.TextBox txtAutorOR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

