
namespace tesvik10
{
    partial class Tahmin
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
            this.grpbxfirmabilgileri = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblfirmano = new System.Windows.Forms.Label();
            this.dataGritSubeOzet = new System.Windows.Forms.DataGridView();
            this.dataGritAyOzet = new System.Windows.Forms.DataGridView();
            this.dataGirtAyrıntı = new System.Windows.Forms.DataGridView();
            this.lblsubeid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblgvst = new System.Windows.Forms.Label();
            this.lbldnmgv = new System.Windows.Forms.Label();
            this.lbldetaygv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbldvst = new System.Windows.Forms.Label();
            this.lbldnmdv = new System.Windows.Forms.Label();
            this.lbldetaydv = new System.Windows.Forms.Label();
            this.cmbilk = new System.Windows.Forms.ComboBox();
            this.cmbson = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grpbxfirmabilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGritSubeOzet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGritAyOzet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGirtAyrıntı)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxfirmabilgileri
            // 
            this.grpbxfirmabilgileri.Controls.Add(this.label1);
            this.grpbxfirmabilgileri.Controls.Add(this.comboBox1);
            this.grpbxfirmabilgileri.Controls.Add(this.lblfirmano);
            this.grpbxfirmabilgileri.ForeColor = System.Drawing.Color.Lime;
            this.grpbxfirmabilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpbxfirmabilgileri.Name = "grpbxfirmabilgileri";
            this.grpbxfirmabilgileri.Size = new System.Drawing.Size(393, 43);
            this.grpbxfirmabilgileri.TabIndex = 33;
            this.grpbxfirmabilgileri.TabStop = false;
            this.grpbxfirmabilgileri.Text = "FİRMA BİLGİLERİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "FİRMA SEÇİMİ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 23);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // lblfirmano
            // 
            this.lblfirmano.AutoSize = true;
            this.lblfirmano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfirmano.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblfirmano.Location = new System.Drawing.Point(341, 20);
            this.lblfirmano.Name = "lblfirmano";
            this.lblfirmano.Size = new System.Drawing.Size(11, 15);
            this.lblfirmano.TabIndex = 30;
            this.lblfirmano.Text = "-";
            // 
            // dataGritSubeOzet
            // 
            this.dataGritSubeOzet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGritSubeOzet.Location = new System.Drawing.Point(437, 24);
            this.dataGritSubeOzet.Name = "dataGritSubeOzet";
            this.dataGritSubeOzet.RowTemplate.Height = 25;
            this.dataGritSubeOzet.Size = new System.Drawing.Size(758, 139);
            this.dataGritSubeOzet.TabIndex = 37;
            this.dataGritSubeOzet.Click += new System.EventHandler(this.dataGritSubeOzet_Click);
            // 
            // dataGritAyOzet
            // 
            this.dataGritAyOzet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGritAyOzet.Location = new System.Drawing.Point(3, 193);
            this.dataGritAyOzet.Name = "dataGritAyOzet";
            this.dataGritAyOzet.RowTemplate.Height = 25;
            this.dataGritAyOzet.Size = new System.Drawing.Size(312, 375);
            this.dataGritAyOzet.TabIndex = 38;
            this.dataGritAyOzet.Click += new System.EventHandler(this.dataGritAyOzet_Click);
            // 
            // dataGirtAyrıntı
            // 
            this.dataGirtAyrıntı.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGirtAyrıntı.Location = new System.Drawing.Point(321, 193);
            this.dataGirtAyrıntı.Name = "dataGirtAyrıntı";
            this.dataGirtAyrıntı.RowTemplate.Height = 25;
            this.dataGirtAyrıntı.Size = new System.Drawing.Size(874, 375);
            this.dataGirtAyrıntı.TabIndex = 39;
            // 
            // lblsubeid
            // 
            this.lblsubeid.AutoSize = true;
            this.lblsubeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblsubeid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblsubeid.Location = new System.Drawing.Point(411, 31);
            this.lblsubeid.Name = "lblsubeid";
            this.lblsubeid.Size = new System.Drawing.Size(11, 15);
            this.lblsubeid.TabIndex = 37;
            this.lblsubeid.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(644, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "TERKİN GV TOPLAM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 571);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "DÖNEM BAZLI TOPLAM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(388, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "DETAY BAZLI TOPLAM";
            // 
            // lblgvst
            // 
            this.lblgvst.AutoSize = true;
            this.lblgvst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblgvst.ForeColor = System.Drawing.Color.White;
            this.lblgvst.Location = new System.Drawing.Point(817, 166);
            this.lblgvst.Name = "lblgvst";
            this.lblgvst.Size = new System.Drawing.Size(11, 15);
            this.lblgvst.TabIndex = 48;
            this.lblgvst.Text = "-";
            // 
            // lbldnmgv
            // 
            this.lbldnmgv.AutoSize = true;
            this.lbldnmgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldnmgv.ForeColor = System.Drawing.Color.White;
            this.lbldnmgv.Location = new System.Drawing.Point(183, 571);
            this.lbldnmgv.Name = "lbldnmgv";
            this.lbldnmgv.Size = new System.Drawing.Size(11, 15);
            this.lbldnmgv.TabIndex = 49;
            this.lbldnmgv.Text = "-";
            // 
            // lbldetaygv
            // 
            this.lbldetaygv.AutoSize = true;
            this.lbldetaygv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldetaygv.ForeColor = System.Drawing.Color.White;
            this.lbldetaygv.Location = new System.Drawing.Point(693, 571);
            this.lbldetaygv.Name = "lbldetaygv";
            this.lbldetaygv.Size = new System.Drawing.Size(11, 15);
            this.lbldetaygv.TabIndex = 50;
            this.lbldetaygv.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(438, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 15);
            this.label6.TabIndex = 52;
            this.label6.Text = "ŞUBE BAZLI RAPOR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(3, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 15);
            this.label7.TabIndex = 53;
            this.label7.Text = "DÖNEM BAZLI RAPOR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(388, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 15);
            this.label8.TabIndex = 54;
            this.label8.Text = "AYRINTILI RAPOR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(914, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 15);
            this.label9.TabIndex = 56;
            this.label9.Text = "TERKİN DV TOPLAM";
            // 
            // lbldvst
            // 
            this.lbldvst.AutoSize = true;
            this.lbldvst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldvst.ForeColor = System.Drawing.Color.White;
            this.lbldvst.Location = new System.Drawing.Point(1089, 166);
            this.lbldvst.Name = "lbldvst";
            this.lbldvst.Size = new System.Drawing.Size(11, 15);
            this.lbldvst.TabIndex = 57;
            this.lbldvst.Text = "-";
            // 
            // lbldnmdv
            // 
            this.lbldnmdv.AutoSize = true;
            this.lbldnmdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldnmdv.ForeColor = System.Drawing.Color.White;
            this.lbldnmdv.Location = new System.Drawing.Point(273, 571);
            this.lbldnmdv.Name = "lbldnmdv";
            this.lbldnmdv.Size = new System.Drawing.Size(11, 15);
            this.lbldnmdv.TabIndex = 58;
            this.lbldnmdv.Text = "-";
            // 
            // lbldetaydv
            // 
            this.lbldetaydv.AutoSize = true;
            this.lbldetaydv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldetaydv.ForeColor = System.Drawing.Color.White;
            this.lbldetaydv.Location = new System.Drawing.Point(872, 571);
            this.lbldetaydv.Name = "lbldetaydv";
            this.lbldetaydv.Size = new System.Drawing.Size(11, 15);
            this.lbldetaydv.TabIndex = 59;
            this.lbldetaydv.Text = "-";
            // 
            // cmbilk
            // 
            this.cmbilk.FormattingEnabled = true;
            this.cmbilk.Location = new System.Drawing.Point(109, 61);
            this.cmbilk.Name = "cmbilk";
            this.cmbilk.Size = new System.Drawing.Size(97, 23);
            this.cmbilk.TabIndex = 60;
            // 
            // cmbson
            // 
            this.cmbson.FormattingEnabled = true;
            this.cmbson.Location = new System.Drawing.Point(109, 90);
            this.cmbson.Name = "cmbson";
            this.cmbson.Size = new System.Drawing.Size(97, 23);
            this.cmbson.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 62;
            this.label5.Text = "İlk Dönem";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 15);
            this.label10.TabIndex = 63;
            this.label10.Text = "Son Dönem";
            // 
            // Tahmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1207, 592);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbson);
            this.Controls.Add(this.cmbilk);
            this.Controls.Add(this.lbldetaydv);
            this.Controls.Add(this.lbldnmdv);
            this.Controls.Add(this.lbldvst);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbldetaygv);
            this.Controls.Add(this.lbldnmgv);
            this.Controls.Add(this.lblgvst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblsubeid);
            this.Controls.Add(this.dataGirtAyrıntı);
            this.Controls.Add(this.dataGritAyOzet);
            this.Controls.Add(this.dataGritSubeOzet);
            this.Controls.Add(this.grpbxfirmabilgileri);
            this.Name = "Tahmin";
            this.Text = "Tahmin";
            this.Load += new System.EventHandler(this.Tahmin_Load);
            this.grpbxfirmabilgileri.ResumeLayout(false);
            this.grpbxfirmabilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGritSubeOzet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGritAyOzet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGirtAyrıntı)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxfirmabilgileri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblfirmano;
        private System.Windows.Forms.DataGridView dataGritSubeOzet;
        private System.Windows.Forms.DataGridView dataGritAyOzet;
        private System.Windows.Forms.DataGridView dataGirtAyrıntı;
        private System.Windows.Forms.Label lblsubeid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblgvst;
        private System.Windows.Forms.Label lbldnmgv;
        private System.Windows.Forms.Label lbldetaygv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbldvst;
        private System.Windows.Forms.Label lbldnmdv;
        private System.Windows.Forms.Label lbldetaydv;
        private System.Windows.Forms.ComboBox cmbilk;
        private System.Windows.Forms.ComboBox cmbson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
    }
}