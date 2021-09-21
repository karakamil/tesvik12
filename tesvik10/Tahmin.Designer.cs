
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
            this.btnaphlistele = new System.Windows.Forms.Button();
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
            this.dataGritSubeOzet.Location = new System.Drawing.Point(437, 12);
            this.dataGritSubeOzet.Name = "dataGritSubeOzet";
            this.dataGritSubeOzet.RowTemplate.Height = 25;
            this.dataGritSubeOzet.Size = new System.Drawing.Size(495, 139);
            this.dataGritSubeOzet.TabIndex = 37;
            // 
            // dataGritAyOzet
            // 
            this.dataGritAyOzet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGritAyOzet.Location = new System.Drawing.Point(12, 157);
            this.dataGritAyOzet.Name = "dataGritAyOzet";
            this.dataGritAyOzet.RowTemplate.Height = 25;
            this.dataGritAyOzet.Size = new System.Drawing.Size(419, 355);
            this.dataGritAyOzet.TabIndex = 38;
            // 
            // dataGirtAyrıntı
            // 
            this.dataGirtAyrıntı.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGirtAyrıntı.Location = new System.Drawing.Point(437, 157);
            this.dataGirtAyrıntı.Name = "dataGirtAyrıntı";
            this.dataGirtAyrıntı.RowTemplate.Height = 25;
            this.dataGirtAyrıntı.Size = new System.Drawing.Size(495, 355);
            this.dataGirtAyrıntı.TabIndex = 39;
            // 
            // btnaphlistele
            // 
            this.btnaphlistele.BackColor = System.Drawing.Color.Salmon;
            this.btnaphlistele.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnaphlistele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnaphlistele.Location = new System.Drawing.Point(12, 61);
            this.btnaphlistele.Name = "btnaphlistele";
            this.btnaphlistele.Size = new System.Drawing.Size(393, 26);
            this.btnaphlistele.TabIndex = 45;
            this.btnaphlistele.Text = "GV TERKİN HESAPLA";
            this.btnaphlistele.UseVisualStyleBackColor = false;
            this.btnaphlistele.Click += new System.EventHandler(this.btnaphlistele_Click);
            // 
            // Tahmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(944, 524);
            this.Controls.Add(this.btnaphlistele);
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

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxfirmabilgileri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblfirmano;
        private System.Windows.Forms.DataGridView dataGritSubeOzet;
        private System.Windows.Forms.DataGridView dataGritAyOzet;
        private System.Windows.Forms.DataGridView dataGirtAyrıntı;
        private System.Windows.Forms.Button btnaphlistele;
    }
}