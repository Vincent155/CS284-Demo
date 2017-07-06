namespace maintaindatabaseForms
{
    partial class maintaindatabaseForm
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
            this.nextlabel = new System.Windows.Forms.Label();
            this.nextBox = new System.Windows.Forms.TextBox();
            this.maintenanceBox = new System.Windows.Forms.TextBox();
            this.maintenancelabel = new System.Windows.Forms.Label();
            this.carnumberBox = new System.Windows.Forms.TextBox();
            this.writebutton = new System.Windows.Forms.Button();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.phonelabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.CarNumberlabel = new System.Windows.Forms.Label();
            this.lookForlabel = new System.Windows.Forms.Label();
            this.checkbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nextlabel
            // 
            this.nextlabel.AutoSize = true;
            this.nextlabel.Location = new System.Drawing.Point(154, 73);
            this.nextlabel.Name = "nextlabel";
            this.nextlabel.Size = new System.Drawing.Size(77, 12);
            this.nextlabel.TabIndex = 21;
            this.nextlabel.Text = "下次回廠日期";
            // 
            // nextBox
            // 
            this.nextBox.Location = new System.Drawing.Point(156, 92);
            this.nextBox.Name = "nextBox";
            this.nextBox.Size = new System.Drawing.Size(100, 22);
            this.nextBox.TabIndex = 20;
            // 
            // maintenanceBox
            // 
            this.maintenanceBox.Location = new System.Drawing.Point(154, 34);
            this.maintenanceBox.Name = "maintenanceBox";
            this.maintenanceBox.Size = new System.Drawing.Size(100, 22);
            this.maintenanceBox.TabIndex = 19;
            // 
            // maintenancelabel
            // 
            this.maintenancelabel.AutoSize = true;
            this.maintenancelabel.Location = new System.Drawing.Point(154, 18);
            this.maintenancelabel.Name = "maintenancelabel";
            this.maintenancelabel.Size = new System.Drawing.Size(53, 12);
            this.maintenancelabel.TabIndex = 18;
            this.maintenancelabel.Text = "回廠日期";
            // 
            // carnumberBox
            // 
            this.carnumberBox.Location = new System.Drawing.Point(30, 141);
            this.carnumberBox.Name = "carnumberBox";
            this.carnumberBox.Size = new System.Drawing.Size(100, 22);
            this.carnumberBox.TabIndex = 17;
            // 
            // writebutton
            // 
            this.writebutton.Location = new System.Drawing.Point(154, 139);
            this.writebutton.Name = "writebutton";
            this.writebutton.Size = new System.Drawing.Size(75, 23);
            this.writebutton.TabIndex = 16;
            this.writebutton.Text = "新增";
            this.writebutton.UseVisualStyleBackColor = true;
            this.writebutton.Click += new System.EventHandler(this.writebutton_Click);
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(30, 92);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(100, 22);
            this.phoneBox.TabIndex = 15;
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Location = new System.Drawing.Point(28, 76);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(53, 12);
            this.phonelabel.TabIndex = 14;
            this.phonelabel.Text = "連絡電話";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(30, 35);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 22);
            this.nameBox.TabIndex = 13;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(28, 19);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(53, 12);
            this.namelabel.TabIndex = 12;
            this.namelabel.Text = "客戶姓名";
            // 
            // CarNumberlabel
            // 
            this.CarNumberlabel.AutoSize = true;
            this.CarNumberlabel.Location = new System.Drawing.Point(30, 121);
            this.CarNumberlabel.Name = "CarNumberlabel";
            this.CarNumberlabel.Size = new System.Drawing.Size(29, 12);
            this.CarNumberlabel.TabIndex = 22;
            this.CarNumberlabel.Text = "車牌";
            // 
            // lookForlabel
            // 
            this.lookForlabel.AutoSize = true;
            this.lookForlabel.Location = new System.Drawing.Point(32, 198);
            this.lookForlabel.Name = "lookForlabel";
            this.lookForlabel.Size = new System.Drawing.Size(53, 12);
            this.lookForlabel.TabIndex = 23;
            this.lookForlabel.Text = "尋找車牌";
            // 
            // checkbutton
            // 
            this.checkbutton.Location = new System.Drawing.Point(156, 215);
            this.checkbutton.Name = "checkbutton";
            this.checkbutton.Size = new System.Drawing.Size(75, 23);
            this.checkbutton.TabIndex = 24;
            this.checkbutton.Text = "查詢";
            this.checkbutton.UseVisualStyleBackColor = true;
            this.checkbutton.Click += new System.EventHandler(this.checkbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 25;
            // 
            // maintaindatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkbutton);
            this.Controls.Add(this.lookForlabel);
            this.Controls.Add(this.CarNumberlabel);
            this.Controls.Add(this.nextlabel);
            this.Controls.Add(this.nextBox);
            this.Controls.Add(this.maintenanceBox);
            this.Controls.Add(this.maintenancelabel);
            this.Controls.Add(this.carnumberBox);
            this.Controls.Add(this.writebutton);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.phonelabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.namelabel);
            this.Name = "maintaindatabaseForm";
            this.Text = "資料登入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nextlabel;
        private System.Windows.Forms.TextBox nextBox;
        private System.Windows.Forms.TextBox maintenanceBox;
        private System.Windows.Forms.Label maintenancelabel;
        private System.Windows.Forms.TextBox carnumberBox;
        private System.Windows.Forms.Button writebutton;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label CarNumberlabel;
        private System.Windows.Forms.Label lookForlabel;
        private System.Windows.Forms.Button checkbutton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

