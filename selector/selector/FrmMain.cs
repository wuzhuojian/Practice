using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace selector
{
    public partial class FrmMain : Form
    {
        private List<string> NumList = new List<string>();
        private Selector objSelector = new Selector();
        #region  初始化
        public FrmMain()
        {
            InitializeComponent();
            //禁止按钮
            this.btnPrint.Enabled = false;
            this.btnClear.Enabled = false;
            this.btnDel.Enabled = false;
        }
        #endregion
        //启动选号
        private void btnSingleSelectSuiji_Click(object sender, EventArgs e)
        {
            this.timerCreatNum.Start();
            this.btnSingleSelectSuiji.Enabled = false;
        }
        private void timerCreatNum_Tick(object sender, EventArgs e)
        {
            string[] numList = objSelector.CreatNums();
            //显示随机 号码
            this.txtSelector1.Text = numList[0];
            this.txtSelector2.Text = numList[1];
            this.txtSelector3.Text = numList[2];
            this.txtSelector4.Text = numList[3];
            this.txtSelector5.Text = numList[4];
            this.txtSelector6.Text = numList[5];
            this.txtSelector7.Text = numList[6];
        }
        //开始选号
        private void btnSingleSelect_Click(object sender, EventArgs e)
        {
            this.timerCreatNum.Stop();
            string[] selectedNum ={
                                  this.txtSelector1.Text.Trim(),
                                  this.txtSelector2.Text.Trim(),
                                  this.txtSelector3.Text.Trim(),
                                  this.txtSelector4.Text.Trim(),
                                  this.txtSelector5.Text.Trim(),
                                  this.txtSelector6.Text.Trim(),
                                  this.txtSelector7.Text.Trim()
                                  };
            objSelector.SelectNums.Add(selectedNum);
            //显示选中的号码
            this.lbNumList.Items.Clear();
            this.lbNumList.Items.AddRange(this.objSelector.GetPrintNums().ToArray());
            //设置按钮
            this.btnSingleSelectSuiji.Enabled = true;
            this.btnPrint.Enabled = true;
            this.btnClear.Enabled = true;
        }
        //生成指定组的号码
        private void btnGroupSelect_Click(object sender, EventArgs e)
        {

            this.objSelector.CreatGroup(Convert.ToInt32(this.txtGroup.Text.Trim()));
            //显示选中的号码
            this.lbNumList.Items.Clear();
            this.lbNumList.Items.AddRange(this.objSelector.GetPrintNums().ToArray());
            //设置按钮
            this.btnSingleSelectSuiji.Enabled = true;
            this.btnPrint.Enabled = true;
            this.btnClear.Enabled = true;
        }
        //清除选号
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lbNumList.Items.Clear();
            objSelector.SelectNums.Clear();

            this.txtSelector1.Text = "0";
            this.txtSelector6.Text = "0";
            this.txtSelector3.Text = "0";
            this.txtSelector4.Text = "0";
            this.txtSelector5.Text = "0";
            this.txtSelector6.Text = "0";
            this.txtSelector7.Text = "0";
            //设置按钮
            this.btnSingleSelectSuiji.Enabled = true;
            this.btnPrint.Enabled = false;
            this.btnClear.Enabled = false;
            this.btnDel.Enabled = false;
        }
        //行选择
        private void numListMouse_Click(object sender, EventArgs e)
        {
            if (this.lbNumList.SelectedIndex != -1)
            {
                //设置按钮
                this.btnDel.Enabled = true;
            }
        }
        //删除选定行
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.lbNumList.SelectedIndex != -1)
            {
                this.objSelector.SelectNums.RemoveAt(this.lbNumList.SelectedIndex);
                List<string[]> NumList2 = this.objSelector.SelectNums;

                //刷新 
                this.lbNumList.Items.Clear();
                this.lbNumList.Items.AddRange(this.objSelector.GetPrintNums2(NumList2).ToArray());

                //禁止按钮
                this.btnDel.Enabled = false;
            }
        }
        //保存文件
        private void button7_Click(object sender, EventArgs e)
        {
            NumList = objSelector.GetPrintNums();
            StreamWriter swList = new StreamWriter("SelectNumsList2.txt");
            foreach (string a in NumList)
            {
                swList.WriteLine(a);
            }
            swList.Close();
        }
    }
}
