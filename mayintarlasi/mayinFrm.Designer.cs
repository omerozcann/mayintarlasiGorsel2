namespace mayintarlasi
{
    partial class mayinFrm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.baslabtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(62, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 274);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // baslabtn
            // 
            this.baslabtn.Location = new System.Drawing.Point(165, 26);
            this.baslabtn.Name = "baslabtn";
            this.baslabtn.Size = new System.Drawing.Size(80, 32);
            this.baslabtn.TabIndex = 2;
            this.baslabtn.Text = "Başla";
            this.baslabtn.UseVisualStyleBackColor = true;
            this.baslabtn.Click += new System.EventHandler(this.baslabtn_Click);
            // 
            // mayinFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 414);
            this.Controls.Add(this.baslabtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "mayinFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mayın Tarlası V1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button baslabtn;
    }
}

