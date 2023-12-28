namespace WindowsFormsApp1
{
    partial class ogretmenkayit
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
            this.grbogrtkayıt = new System.Windows.Forms.GroupBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.lbltc = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.grbogrtkayıt.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbogrtkayıt
            // 
            this.grbogrtkayıt.Controls.Add(this.btnkaydet);
            this.grbogrtkayıt.Controls.Add(this.lbltc);
            this.grbogrtkayıt.Controls.Add(this.lblsoyad);
            this.grbogrtkayıt.Controls.Add(this.lblAd);
            this.grbogrtkayıt.Controls.Add(this.txttc);
            this.grbogrtkayıt.Controls.Add(this.txtsoyad);
            this.grbogrtkayıt.Controls.Add(this.txtad);
            this.grbogrtkayıt.Location = new System.Drawing.Point(12, 12);
            this.grbogrtkayıt.Name = "grbogrtkayıt";
            this.grbogrtkayıt.Size = new System.Drawing.Size(278, 232);
            this.grbogrtkayıt.TabIndex = 0;
            this.grbogrtkayıt.TabStop = false;
            this.grbogrtkayıt.Text = "Öğretmen Kayıt";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(91, 194);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 6;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(16, 134);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(41, 16);
            this.lbltc.TabIndex = 5;
            this.lbltc.Text = "TcNo";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(7, 89);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(47, 16);
            this.lblsoyad.TabIndex = 4;
            this.lblsoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(16, 39);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(24, 16);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Ad";
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(107, 134);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(119, 22);
            this.txttc.TabIndex = 2;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(107, 86);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(119, 22);
            this.txtsoyad.TabIndex = 1;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(107, 39);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(119, 22);
            this.txtad.TabIndex = 0;
            // 
            // ogretmenkayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbogrtkayıt);
            this.Name = "ogretmenkayit";
            this.Text = "Form1";
            this.grbogrtkayıt.ResumeLayout(false);
            this.grbogrtkayıt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbogrtkayıt;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
    }
}

