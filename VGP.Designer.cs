namespace MDIApplication
{
    partial class VGP
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VGP));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VGPLat = new System.Windows.Forms.TextBox();
            this.VGPLong = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.NorthP = new System.Windows.Forms.RadioButton();
            this.SouthP = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cancle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "VGP lon.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "VGP Lat.";
            // 
            // VGPLat
            // 
            this.VGPLat.Location = new System.Drawing.Point(11, 110);
            this.VGPLat.Name = "VGPLat";
            this.VGPLat.Size = new System.Drawing.Size(159, 21);
            this.VGPLat.TabIndex = 8;
            this.VGPLat.TextChanged += new System.EventHandler(this.VGPLat_TextChanged);
            // 
            // VGPLong
            // 
            this.VGPLong.Location = new System.Drawing.Point(11, 61);
            this.VGPLong.Name = "VGPLong";
            this.VGPLong.Size = new System.Drawing.Size(159, 21);
            this.VGPLong.TabIndex = 9;
            this.VGPLong.TextChanged += new System.EventHandler(this.VGPLong_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // NorthP
            // 
            this.NorthP.AutoSize = true;
            this.NorthP.Location = new System.Drawing.Point(93, 12);
            this.NorthP.Name = "NorthP";
            this.NorthP.Size = new System.Drawing.Size(53, 16);
            this.NorthP.TabIndex = 12;
            this.NorthP.Text = "South";
            this.NorthP.UseVisualStyleBackColor = true;
            // 
            // SouthP
            // 
            this.SouthP.AutoSize = true;
            this.SouthP.Checked = true;
            this.SouthP.Location = new System.Drawing.Point(12, 12);
            this.SouthP.Name = "SouthP";
            this.SouthP.Size = new System.Drawing.Size(53, 16);
            this.SouthP.TabIndex = 11;
            this.SouthP.TabStop = true;
            this.SouthP.Text = "North";
            this.SouthP.UseVisualStyleBackColor = true;
            // 
            // VGP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 217);
            this.Controls.Add(this.NorthP);
            this.Controls.Add(this.SouthP);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.VGPLong);
            this.Controls.Add(this.VGPLat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VGP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paleomagnetic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VGPLat;
        private System.Windows.Forms.TextBox VGPLong;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton NorthP;
        private System.Windows.Forms.RadioButton SouthP;
    }
}
