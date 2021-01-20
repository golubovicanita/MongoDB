
namespace Biblioteka_MongoDB
{
    partial class DonirajKnjiguForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDoniraj = new System.Windows.Forms.Button();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtZanr = new System.Windows.Forms.TextBox();
            this.txtGod = new System.Windows.Forms.TextBox();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBroj);
            this.groupBox1.Controls.Add(this.txtGod);
            this.groupBox1.Controls.Add(this.txtZanr);
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.txtNaslov);
            this.groupBox1.Controls.Add(this.btnDoniraj);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unesite podatke o knjizi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Žanr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Godina izdavanja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Broj primeraka:";
            // 
            // btnDoniraj
            // 
            this.btnDoniraj.Location = new System.Drawing.Point(164, 363);
            this.btnDoniraj.Name = "btnDoniraj";
            this.btnDoniraj.Size = new System.Drawing.Size(167, 36);
            this.btnDoniraj.TabIndex = 5;
            this.btnDoniraj.Text = "Doniraj";
            this.btnDoniraj.UseVisualStyleBackColor = true;
            this.btnDoniraj.Click += new System.EventHandler(this.btnDoniraj_Click);
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(233, 66);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(220, 28);
            this.txtNaslov.TabIndex = 6;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(233, 123);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(220, 28);
            this.txtAutor.TabIndex = 7;
            // 
            // txtZanr
            // 
            this.txtZanr.Location = new System.Drawing.Point(233, 176);
            this.txtZanr.Name = "txtZanr";
            this.txtZanr.Size = new System.Drawing.Size(220, 28);
            this.txtZanr.TabIndex = 8;
            // 
            // txtGod
            // 
            this.txtGod.Location = new System.Drawing.Point(233, 233);
            this.txtGod.Name = "txtGod";
            this.txtGod.Size = new System.Drawing.Size(220, 28);
            this.txtGod.TabIndex = 9;
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(233, 290);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(220, 28);
            this.txtBroj.TabIndex = 10;
            // 
            // DonirajKnjiguForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(560, 495);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "DonirajKnjiguForma";
            this.Text = "DonirajKnjiguForma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.TextBox txtGod;
        private System.Windows.Forms.TextBox txtZanr;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Button btnDoniraj;
    }
}