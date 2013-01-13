namespace MDIApplication
{
    partial class FrmAnyEulerPole
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnyEulerPole));
            this.ComEulerPole = new System.Windows.Forms.Button();
            this.TimeEnd = new System.Windows.Forms.TextBox();
            this.TimeT = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FAngle = new System.Windows.Forms.TextBox();
            this.FPoleLong = new System.Windows.Forms.TextBox();
            this.FPoleLat = new System.Windows.Forms.TextBox();
            this.CombTerrID = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.CombTName = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeinteval = new System.Windows.Forms.NumericUpDown();
            this.Time2G = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Time1G = new System.Windows.Forms.TextBox();
            this.TimeG = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeinteval)).BeginInit();
            this.SuspendLayout();
            // 
            // ComEulerPole
            // 
            this.ComEulerPole.Location = new System.Drawing.Point(447, 296);
            this.ComEulerPole.Name = "ComEulerPole";
            this.ComEulerPole.Size = new System.Drawing.Size(66, 24);
            this.ComEulerPole.TabIndex = 37;
            this.ComEulerPole.Text = "OK";
            this.ComEulerPole.UseVisualStyleBackColor = true;
            this.ComEulerPole.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimeEnd
            // 
            this.TimeEnd.Location = new System.Drawing.Point(271, 43);
            this.TimeEnd.Name = "TimeEnd";
            this.TimeEnd.Size = new System.Drawing.Size(72, 21);
            this.TimeEnd.TabIndex = 36;
            this.TimeEnd.TextChanged += new System.EventHandler(this.TimeEnd_TextChanged);
            // 
            // TimeT
            // 
            this.TimeT.Location = new System.Drawing.Point(70, 46);
            this.TimeT.Name = "TimeT";
            this.TimeT.Size = new System.Drawing.Size(79, 21);
            this.TimeT.TabIndex = 35;
            this.TimeT.TextChanged += new System.EventHandler(this.TimeT_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FAngle);
            this.groupBox3.Controls.Add(this.FPoleLong);
            this.groupBox3.Controls.Add(this.FPoleLat);
            this.groupBox3.Controls.Add(this.CombTerrID);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.CombTName);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TimeEnd);
            this.groupBox3.Controls.Add(this.TimeT);
            this.groupBox3.Location = new System.Drawing.Point(12, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 119);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Euler pole";
            // 
            // FAngle
            // 
            this.FAngle.Location = new System.Drawing.Point(308, 84);
            this.FAngle.Name = "FAngle";
            this.FAngle.Size = new System.Drawing.Size(79, 21);
            this.FAngle.TabIndex = 20;
            this.FAngle.TextChanged += new System.EventHandler(this.FAngle_TextChanged);
            // 
            // FPoleLong
            // 
            this.FPoleLong.Location = new System.Drawing.Point(164, 84);
            this.FPoleLong.Name = "FPoleLong";
            this.FPoleLong.Size = new System.Drawing.Size(79, 21);
            this.FPoleLong.TabIndex = 19;
            this.FPoleLong.TextChanged += new System.EventHandler(this.FPoleLong_TextChanged);
            // 
            // FPoleLat
            // 
            this.FPoleLat.Location = new System.Drawing.Point(42, 84);
            this.FPoleLat.Name = "FPoleLat";
            this.FPoleLat.Size = new System.Drawing.Size(79, 21);
            this.FPoleLat.TabIndex = 18;
            this.FPoleLat.TextChanged += new System.EventHandler(this.FPoleLat_TextChanged);
            // 
            // CombTerrID
            // 
            this.CombTerrID.FormattingEnabled = true;
            this.CombTerrID.Location = new System.Drawing.Point(70, 17);
            this.CombTerrID.Name = "CombTerrID";
            this.CombTerrID.Size = new System.Drawing.Size(79, 20);
            this.CombTerrID.TabIndex = 52;
            this.CombTerrID.TextChanged += new System.EventHandler(this.CombTerrID_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(265, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 12);
            this.label18.TabIndex = 17;
            this.label18.Text = "Angle";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(134, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 16;
            this.label17.Text = "Lon.";
            // 
            // CombTName
            // 
            this.CombTName.FormattingEnabled = true;
            this.CombTName.Location = new System.Drawing.Point(271, 14);
            this.CombTName.Name = "CombTName";
            this.CombTName.Size = new System.Drawing.Size(72, 20);
            this.CombTName.TabIndex = 53;
            this.CombTName.TextChanged += new System.EventHandler(this.CombTName_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 15;
            this.label16.Text = "Lat.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "Start Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "Plate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 29;
            this.label4.Text = "End Age";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 24);
            this.button2.TabIndex = 39;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 23);
            this.button3.TabIndex = 40;
            this.button3.Text = "Del.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(224, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 23);
            this.button4.TabIndex = 41;
            this.button4.Text = "Modify";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(131, 296);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 24);
            this.button5.TabIndex = 42;
            this.button5.Text = "Import";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(540, 296);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(66, 24);
            this.button7.TabIndex = 44;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // ListView
            // 
            this.ListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListView.AllowColumnReorder = true;
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ListView.ContextMenuStrip = this.contextMenuStrip1;
            this.ListView.FullRowSelect = true;
            this.ListView.GridLines = true;
            this.ListView.HoverSelection = true;
            this.ListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ListView.LabelEdit = true;
            this.ListView.LabelWrap = false;
            this.ListView.Location = new System.Drawing.Point(11, 143);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(398, 145);
            this.ListView.TabIndex = 46;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Plate";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Age(Ma)";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Lat.";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lon.";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Angle";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 80;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.插入ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.ShowItemToolTips = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 92);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 插入ToolStripMenuItem
            // 
            this.插入ToolStripMenuItem.Name = "插入ToolStripMenuItem";
            this.插入ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.插入ToolStripMenuItem.Text = "插入";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(428, 144);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(393, 144);
            this.listView1.TabIndex = 47;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Plate";
            this.columnHeader6.Width = 56;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Age(Ma)";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Lat.";
            this.columnHeader8.Width = 61;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Lon.";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 67;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Angle";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "velocity";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(739, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 24);
            this.button1.TabIndex = 48;
            this.button1.Text = "Cancle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(643, 296);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(66, 24);
            this.button8.TabIndex = 49;
            this.button8.Text = "Del.";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeinteval);
            this.groupBox1.Controls.Add(this.Time2G);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Time1G);
            this.groupBox1.Controls.Add(this.TimeG);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(424, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 119);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculation Mode";
            // 
            // timeinteval
            // 
            this.timeinteval.Location = new System.Drawing.Point(163, 20);
            this.timeinteval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeinteval.Name = "timeinteval";
            this.timeinteval.Size = new System.Drawing.Size(41, 21);
            this.timeinteval.TabIndex = 9;
            this.timeinteval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Time2G
            // 
            this.Time2G.Location = new System.Drawing.Point(240, 83);
            this.Time2G.Name = "Time2G";
            this.Time2G.Size = new System.Drawing.Size(77, 21);
            this.Time2G.TabIndex = 6;
            this.Time2G.TextChanged += new System.EventHandler(this.Time2G_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "to";
            // 
            // Time1G
            // 
            this.Time1G.Location = new System.Drawing.Point(134, 83);
            this.Time1G.Name = "Time1G";
            this.Time1G.Size = new System.Drawing.Size(77, 21);
            this.Time1G.TabIndex = 4;
            this.Time1G.TextChanged += new System.EventHandler(this.Time1G_TextChanged);
            // 
            // TimeG
            // 
            this.TimeG.Location = new System.Drawing.Point(134, 52);
            this.TimeG.Name = "TimeG";
            this.TimeG.Size = new System.Drawing.Size(77, 21);
            this.TimeG.TabIndex = 3;
            this.TimeG.TextChanged += new System.EventHandler(this.TimeG_TextChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(18, 87);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(119, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Given time range";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 53);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Given time";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(137, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Given time interval";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(8, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 12);
            this.label7.TabIndex = 54;
            this.label7.Text = "Known Euler pole";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(424, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 12);
            this.label8.TabIndex = 55;
            this.label8.Text = "Interpolation results";
            // 
            // FrmAnyEulerPole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 329);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.ComEulerPole);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAnyEulerPole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interpolation";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeinteval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ComEulerPole;
        private System.Windows.Forms.TextBox TimeEnd;
        private System.Windows.Forms.TextBox TimeT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox FAngle;
        private System.Windows.Forms.TextBox FPoleLong;
        private System.Windows.Forms.TextBox FPoleLat;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TimeG;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox Time2G;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Time1G;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox CombTerrID;
        private System.Windows.Forms.ComboBox CombTName;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.NumericUpDown timeinteval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
    }
}
