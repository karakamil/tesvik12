
namespace tesvik10
{
    partial class KanuniParametre
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtyilfiltre = new System.Windows.Forms.TextBox();
            this.lblyıl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdonemfiltre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 543);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(831, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-36, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(701, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtyilfiltre
            // 
            this.txtyilfiltre.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtyilfiltre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtyilfiltre.Location = new System.Drawing.Point(229, 75);
            this.txtyilfiltre.Name = "txtyilfiltre";
            this.txtyilfiltre.Size = new System.Drawing.Size(119, 23);
            this.txtyilfiltre.TabIndex = 4;
            // 
            // lblyıl
            // 
            this.lblyıl.AutoSize = true;
            this.lblyıl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblyıl.ForeColor = System.Drawing.Color.White;
            this.lblyıl.Location = new System.Drawing.Point(116, 77);
            this.lblyıl.Name = "lblyıl";
            this.lblyıl.Size = new System.Drawing.Size(24, 15);
            this.lblyıl.TabIndex = 34;
            this.lblyıl.Text = "YIL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "DONEM";
            // 
            // txtdonemfiltre
            // 
            this.txtdonemfiltre.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtdonemfiltre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdonemfiltre.Location = new System.Drawing.Point(229, 104);
            this.txtdonemfiltre.Name = "txtdonemfiltre";
            this.txtdonemfiltre.Size = new System.Drawing.Size(119, 23);
            this.txtdonemfiltre.TabIndex = 35;
            // 
            // KanuniParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1347, 708);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdonemfiltre);
            this.Controls.Add(this.lblyıl);
            this.Controls.Add(this.txtyilfiltre);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KanuniParametre";
            this.Text = "KanuniParametre";
            this.Load += new System.EventHandler(this.KanuniParametre_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtyilfiltre;
        private System.Windows.Forms.Label lblyıl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdonemfiltre;
    }
}