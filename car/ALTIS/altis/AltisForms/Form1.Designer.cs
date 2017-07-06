namespace AltisForms
{
    partial class AltisForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listbutton = new System.Windows.Forms.Button();
            this.salebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AltisForms.Properties.Resources.特色外型_頁面_1;
            this.pictureBox1.Location = new System.Drawing.Point(-39, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listbutton
            // 
            this.listbutton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listbutton.Location = new System.Drawing.Point(12, 156);
            this.listbutton.Name = "listbutton";
            this.listbutton.Size = new System.Drawing.Size(88, 35);
            this.listbutton.TabIndex = 1;
            this.listbutton.Text = "特色外型";
            this.listbutton.UseVisualStyleBackColor = true;
            this.listbutton.Click += new System.EventHandler(this.listbutton_Click);
            // 
            // salebutton
            // 
            this.salebutton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.salebutton.Location = new System.Drawing.Point(12, 197);
            this.salebutton.Name = "salebutton";
            this.salebutton.Size = new System.Drawing.Size(88, 35);
            this.salebutton.TabIndex = 2;
            this.salebutton.Text = "售價規配";
            this.salebutton.UseVisualStyleBackColor = true;
            this.salebutton.Click += new System.EventHandler(this.salebutton_Click);
            // 
            // AltisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 285);
            this.Controls.Add(this.salebutton);
            this.Controls.Add(this.listbutton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AltisForm";
            this.Text = "Altis List";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button listbutton;
        private System.Windows.Forms.Button salebutton;
    }
}

