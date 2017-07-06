namespace CarListForms
{
    partial class carListForm
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
            this.ViospictureBox = new System.Windows.Forms.PictureBox();
            this.AltispictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ViospictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AltispictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ViospictureBox
            // 
            this.ViospictureBox.BackColor = System.Drawing.Color.Black;
            this.ViospictureBox.Image = global::CarListForms.Properties.Resources.vios_car3;
            this.ViospictureBox.Location = new System.Drawing.Point(38, 31);
            this.ViospictureBox.Name = "ViospictureBox";
            this.ViospictureBox.Size = new System.Drawing.Size(227, 151);
            this.ViospictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ViospictureBox.TabIndex = 2;
            this.ViospictureBox.TabStop = false;
            this.ViospictureBox.Click += new System.EventHandler(this.ViospictureBox_Click);
            // 
            // AltispictureBox
            // 
            this.AltispictureBox.BackColor = System.Drawing.Color.Black;
            this.AltispictureBox.Image = global::CarListForms.Properties.Resources.altis;
            this.AltispictureBox.Location = new System.Drawing.Point(305, 31);
            this.AltispictureBox.Name = "AltispictureBox";
            this.AltispictureBox.Size = new System.Drawing.Size(227, 151);
            this.AltispictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AltispictureBox.TabIndex = 1;
            this.AltispictureBox.TabStop = false;
            this.AltispictureBox.Click += new System.EventHandler(this.AltispictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarListForms.Properties.Resources.CAR_2017070514513122031102;
            this.pictureBox1.Location = new System.Drawing.Point(-15, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // carListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 216);
            this.Controls.Add(this.ViospictureBox);
            this.Controls.Add(this.AltispictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "carListForm";
            this.Text = "轎車展示";
            ((System.ComponentModel.ISupportInitialize)(this.ViospictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AltispictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox AltispictureBox;
        private System.Windows.Forms.PictureBox ViospictureBox;
    }
}

