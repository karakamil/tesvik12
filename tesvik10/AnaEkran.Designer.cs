
namespace tesvik10
{
    partial class AnaEkran
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
            this.btnfirmakayit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnParametre = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnfirmakayit
            // 
            this.btnfirmakayit.BackColor = System.Drawing.Color.Teal;
            this.btnfirmakayit.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnfirmakayit.ForeColor = System.Drawing.Color.Black;
            this.btnfirmakayit.Location = new System.Drawing.Point(26, 12);
            this.btnfirmakayit.Name = "btnfirmakayit";
            this.btnfirmakayit.Size = new System.Drawing.Size(186, 53);
            this.btnfirmakayit.TabIndex = 1;
            this.btnfirmakayit.Text = "FİRMA KAYIT";
            this.btnfirmakayit.UseVisualStyleBackColor = false;
            this.btnfirmakayit.Click += new System.EventHandler(this.btnfirmakayit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnParametre);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnfirmakayit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1371, 77);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(218, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "ŞUBE İŞLEMLERİ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1371, 699);
            this.panel3.TabIndex = 4;
            // 
            // btnParametre
            // 
            this.btnParametre.BackColor = System.Drawing.Color.Teal;
            this.btnParametre.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnParametre.ForeColor = System.Drawing.Color.Black;
            this.btnParametre.Location = new System.Drawing.Point(410, 12);
            this.btnParametre.Name = "btnParametre";
            this.btnParametre.Size = new System.Drawing.Size(186, 53);
            this.btnParametre.TabIndex = 3;
            this.btnParametre.Text = "PARAMETRELER";
            this.btnParametre.UseVisualStyleBackColor = false;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(5, 10);
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1371, 776);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "AnaEkran";
            this.Text = "AnaEkran";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfirmakayit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnParametre;
    }
}