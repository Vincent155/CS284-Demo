namespace SIENTAForms
{
    partial class SientaForm
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
            this.SientapictureBox = new System.Windows.Forms.PictureBox();
            this.LISTbutton = new System.Windows.Forms.Button();
            this.salebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SientapictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SientapictureBox
            // 
            this.SientapictureBox.Image = global::SIENTAForms.Properties.Resources.特色外型_頁面_1;
            this.SientapictureBox.Location = new System.Drawing.Point(-15, -1);
            this.SientapictureBox.Name = "SientapictureBox";
            this.SientapictureBox.Size = new System.Drawing.Size(346, 427);
            this.SientapictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SientapictureBox.TabIndex = 0;
            this.SientapictureBox.TabStop = false;
            // 
            // LISTbutton
            // 
            this.LISTbutton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LISTbutton.Location = new System.Drawing.Point(41, 26);
            this.LISTbutton.Name = "LISTbutton";
            this.LISTbutton.Size = new System.Drawing.Size(90, 32);
            this.LISTbutton.TabIndex = 1;
            this.LISTbutton.Text = "特色外型";
            this.LISTbutton.UseVisualStyleBackColor = true;
            this.LISTbutton.Click += new System.EventHandler(this.LISTbutton_Click);
            // 
            // salebutton
            // 
            this.salebutton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.salebutton.Location = new System.Drawing.Point(176, 26);
            this.salebutton.Name = "salebutton";
            this.salebutton.Size = new System.Drawing.Size(90, 32);
            this.salebutton.TabIndex = 2;
            this.salebutton.Text = "售價規配";
            this.salebutton.UseVisualStyleBackColor = true;
            this.salebutton.Click += new System.EventHandler(this.salebutton_Click);
            // 
            // SientaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 421);
            this.Controls.Add(this.salebutton);
            this.Controls.Add(this.LISTbutton);
            this.Controls.Add(this.SientapictureBox);
            this.Name = "SientaForm";
            this.Text = "SIENTA List";
            ((System.ComponentModel.ISupportInitialize)(this.SientapictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SientapictureBox;
        private System.Windows.Forms.Button LISTbutton;
        private System.Windows.Forms.Button salebutton;
    }
}

