namespace RetiredCarListForms
{
    partial class RetiredCarListForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.sientapictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RAV4pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sientapictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAV4pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sientapictureBox
            // 
            this.sientapictureBox.BackColor = System.Drawing.Color.Transparent;
            this.sientapictureBox.Image = global::RetiredCarListForms.Properties.Resources.sienta02;
            this.sientapictureBox.Location = new System.Drawing.Point(12, 12);
            this.sientapictureBox.Name = "sientapictureBox";
            this.sientapictureBox.Size = new System.Drawing.Size(123, 76);
            this.sientapictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sientapictureBox.TabIndex = 1;
            this.sientapictureBox.TabStop = false;
            this.sientapictureBox.Click += new System.EventHandler(this.sientapictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RetiredCarListForms.Properties.Resources.特色外型_頁面_02;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RAV4pictureBox
            // 
            this.RAV4pictureBox.Image = global::RetiredCarListForms.Properties.Resources._55ae7a91d14bf;
            this.RAV4pictureBox.Location = new System.Drawing.Point(427, 224);
            this.RAV4pictureBox.Name = "RAV4pictureBox";
            this.RAV4pictureBox.Size = new System.Drawing.Size(123, 76);
            this.RAV4pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RAV4pictureBox.TabIndex = 2;
            this.RAV4pictureBox.TabStop = false;
            this.RAV4pictureBox.Click += new System.EventHandler(this.RAV4pictureBox_Click);
            // 
            // RetiredCarListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 364);
            this.Controls.Add(this.RAV4pictureBox);
            this.Controls.Add(this.sientapictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RetiredCarListForm";
            this.Text = "休旅車選單";
            ((System.ComponentModel.ISupportInitialize)(this.sientapictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAV4pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox sientapictureBox;
        private System.Windows.Forms.PictureBox RAV4pictureBox;
    }
}

