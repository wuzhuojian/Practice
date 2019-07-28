namespace selector
{
    partial class FrmMain
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
            this.timerCreatNum = new System.Windows.Forms.Timer(this.components);
            this.btnSingleSelectSuiji = new System.Windows.Forms.Button();
            this.btnSingleSelect = new System.Windows.Forms.Button();
            this.btnGroupSelect = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShouXie = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lbNumList = new System.Windows.Forms.ListBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtSelector6 = new System.Windows.Forms.TextBox();
            this.txtSelector5 = new System.Windows.Forms.TextBox();
            this.txtSelector4 = new System.Windows.Forms.TextBox();
            this.txtSelector3 = new System.Windows.Forms.TextBox();
            this.txtSelector2 = new System.Windows.Forms.TextBox();
            this.txtSelector1 = new System.Windows.Forms.TextBox();
            this.txtSelector7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timerCreatNum
            // 
            this.timerCreatNum.Interval = 50;
            this.timerCreatNum.Tick += new System.EventHandler(this.timerCreatNum_Tick);
            // 
            // btnSingleSelectSuiji
            // 
            this.btnSingleSelectSuiji.Location = new System.Drawing.Point(846, 349);
            this.btnSingleSelectSuiji.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSingleSelectSuiji.Name = "btnSingleSelectSuiji";
            this.btnSingleSelectSuiji.Size = new System.Drawing.Size(112, 56);
            this.btnSingleSelectSuiji.TabIndex = 1;
            this.btnSingleSelectSuiji.Text = "随机单组";
            this.btnSingleSelectSuiji.UseVisualStyleBackColor = true;
            this.btnSingleSelectSuiji.Click += new System.EventHandler(this.btnSingleSelectSuiji_Click);
            // 
            // btnSingleSelect
            // 
            this.btnSingleSelect.Location = new System.Drawing.Point(1041, 349);
            this.btnSingleSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSingleSelect.Name = "btnSingleSelect";
            this.btnSingleSelect.Size = new System.Drawing.Size(112, 56);
            this.btnSingleSelect.TabIndex = 2;
            this.btnSingleSelect.Text = "单组选号";
            this.btnSingleSelect.UseVisualStyleBackColor = true;
            this.btnSingleSelect.Click += new System.EventHandler(this.btnSingleSelect_Click);
            // 
            // btnGroupSelect
            // 
            this.btnGroupSelect.Location = new System.Drawing.Point(1041, 482);
            this.btnGroupSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGroupSelect.Name = "btnGroupSelect";
            this.btnGroupSelect.Size = new System.Drawing.Size(112, 59);
            this.btnGroupSelect.TabIndex = 3;
            this.btnGroupSelect.Text = "随机组选";
            this.btnGroupSelect.UseVisualStyleBackColor = true;
            this.btnGroupSelect.Click += new System.EventHandler(this.btnGroupSelect_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(846, 602);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(112, 54);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1041, 602);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 54);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShouXie
            // 
            this.btnShouXie.Location = new System.Drawing.Point(846, 701);
            this.btnShouXie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShouXie.Name = "btnShouXie";
            this.btnShouXie.Size = new System.Drawing.Size(112, 58);
            this.btnShouXie.TabIndex = 6;
            this.btnShouXie.Text = "手写号码";
            this.btnShouXie.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1041, 701);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(112, 58);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button7_Click);
            // 
            // lbNumList
            // 
            this.lbNumList.FormattingEnabled = true;
            this.lbNumList.ItemHeight = 24;
            this.lbNumList.Location = new System.Drawing.Point(87, 349);
            this.lbNumList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbNumList.Name = "lbNumList";
            this.lbNumList.Size = new System.Drawing.Size(654, 412);
            this.lbNumList.TabIndex = 16;
            this.lbNumList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numListMouse_Click);
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(885, 494);
            this.txtGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(72, 35);
            this.txtGroup.TabIndex = 18;
            this.txtGroup.Text = "5";
            this.txtGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSelector6
            // 
            this.txtSelector6.Location = new System.Drawing.Point(866, 163);
            this.txtSelector6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSelector6.Name = "txtSelector6";
            this.txtSelector6.Size = new System.Drawing.Size(40, 35);
            this.txtSelector6.TabIndex = 19;
            this.txtSelector6.Text = "0";
            this.txtSelector6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSelector5
            // 
            this.txtSelector5.Location = new System.Drawing.Point(621, 163);
            this.txtSelector5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSelector5.Name = "txtSelector5";
            this.txtSelector5.Size = new System.Drawing.Size(37, 35);
            this.txtSelector5.TabIndex = 20;
            this.txtSelector5.Text = "0";
            this.txtSelector5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSelector4
            // 
            this.txtSelector4.Location = new System.Drawing.Point(488, 163);
            this.txtSelector4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSelector4.Name = "txtSelector4";
            this.txtSelector4.Size = new System.Drawing.Size(38, 35);
            this.txtSelector4.TabIndex = 21;
            this.txtSelector4.Text = "0";
            this.txtSelector4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSelector3
            // 
            this.txtSelector3.Location = new System.Drawing.Point(354, 163);
            this.txtSelector3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSelector3.Name = "txtSelector3";
            this.txtSelector3.Size = new System.Drawing.Size(38, 35);
            this.txtSelector3.TabIndex = 22;
            this.txtSelector3.Text = "0";
            this.txtSelector3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSelector2
            // 
            this.txtSelector2.Location = new System.Drawing.Point(224, 163);
            this.txtSelector2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSelector2.Name = "txtSelector2";
            this.txtSelector2.Size = new System.Drawing.Size(40, 35);
            this.txtSelector2.TabIndex = 23;
            this.txtSelector2.Text = "0";
            this.txtSelector2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSelector1
            // 
            this.txtSelector1.Location = new System.Drawing.Point(87, 163);
            this.txtSelector1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSelector1.Name = "txtSelector1";
            this.txtSelector1.Size = new System.Drawing.Size(38, 35);
            this.txtSelector1.TabIndex = 24;
            this.txtSelector1.Text = "0";
            this.txtSelector1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSelector7
            // 
            this.txtSelector7.Location = new System.Drawing.Point(1020, 163);
            this.txtSelector7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSelector7.Name = "txtSelector7";
            this.txtSelector7.Size = new System.Drawing.Size(42, 35);
            this.txtSelector7.TabIndex = 25;
            this.txtSelector7.Text = "0";
            this.txtSelector7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 918);
            this.Controls.Add(this.txtSelector7);
            this.Controls.Add(this.txtSelector1);
            this.Controls.Add(this.txtSelector2);
            this.Controls.Add(this.txtSelector3);
            this.Controls.Add(this.txtSelector4);
            this.Controls.Add(this.txtSelector5);
            this.Controls.Add(this.txtSelector6);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.lbNumList);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnShouXie);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnGroupSelect);
            this.Controls.Add(this.btnSingleSelect);
            this.Controls.Add(this.btnSingleSelectSuiji);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "彩票选择器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerCreatNum;
        private System.Windows.Forms.Button btnSingleSelectSuiji;
        private System.Windows.Forms.Button btnSingleSelect;
        private System.Windows.Forms.Button btnGroupSelect;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShouXie;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ListBox lbNumList;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtSelector6;
        private System.Windows.Forms.TextBox txtSelector5;
        private System.Windows.Forms.TextBox txtSelector4;
        private System.Windows.Forms.TextBox txtSelector3;
        private System.Windows.Forms.TextBox txtSelector2;
        private System.Windows.Forms.TextBox txtSelector1;
        private System.Windows.Forms.TextBox txtSelector7;
    }
}

