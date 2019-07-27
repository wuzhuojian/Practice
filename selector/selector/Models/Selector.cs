using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace selector
{
    /// <summary>
    /// 选号器类
    /// </summary>
    class Selector
    {
        private Random objRandom;// 生成随机数
        //属性
        /// <summary>
        /// 选择的号码
        /// </summary>
        public List<string[]> SelectNums { get; set; }

        /// <summary>
        /// 构造方法
        /// </summary>
        public Selector ()
        {
            this.SelectNums = new List<string[]>();
            this.objRandom = new Random();
        }

        //方法

        /// <summary>
        /// 随机生成7个号码
        /// </summary>
        /// <returns></returns>
        public string[] CreatNums()
        {
            string[] numList = new string[7];
            for (int i = 0; i < 7; i++)
            {
                numList[i] = objRandom.Next(10).ToString();
            }
            return numList;
        }

        /// <summary>
        /// 生成指定组的随机号码
        /// </summary>
        /// <param name="count"></param>
        public void CreatGroup(int count)
        {
            SelectNums.Clear();
            for (int i = 0; i < count; i++)
            {
                SelectNums.Add(CreatNums());
            }
        }


        //获取打印号码的列表
        public List<string> GetPrintNums()
        {
            List<string> numList = new List<string>();
            for (int i = 0; i < this.SelectNums.Count; i++)
            {
                string printedNum = string.Empty;
                if (i < 9)
                {
                    printedNum = "第0" + (i + 1) + "组：";
                }
                else
                {
                    printedNum = "第" + (i + 1) + "组：";
                }
                foreach (string num in this.SelectNums[i])
                {
                    printedNum += num + " ";
                }
                numList.Add(printedNum);
            }
            return numList;
        }
       //删除选定行
        public List<string> GetPrintNums2(List<string[]> SelectNums2)
        {
            List<string> numList2 = new List<string>();
            for (int i = 0; i < this.SelectNums.Count; i++)
            {
                string printedNum = string.Empty;
                if (i < 9)
                {
                    printedNum = "第0" + (i + 1) + "组：";
                }
                else
                {
                    printedNum = "第" + (i + 1) + "组：";
                }
                foreach (string num in SelectNums2[i])
                {
                    printedNum += num + " ";
                }
                numList2.Add(printedNum);
            }
            return numList2;
        }

    }
}
