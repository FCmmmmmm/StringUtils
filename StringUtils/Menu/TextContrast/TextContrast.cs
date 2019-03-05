using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringUtils.Menu.TextContrast
{
    public partial class TextContrast : Form
    {
        private MainForm mainForm;
        public TextContrast()
        {
            InitializeComponent();
        }

        public TextContrast(MainForm form)
        {
            this.mainForm = form;
            InitializeComponent();
        }

        private void LeftTextBox_TextChanged(object sender,EventArgs e)
        {
            bool isIgnoreSpace = IgnoreSpace.Checked;
            bool isIgnoreLineBreak = IgnoreLineBreak.Checked;
            
        }

        private void RightTextBox_TextChanged(object sender,EventArgs e)
        {
            bool isIgnoreSpace = IgnoreSpace.Checked;
            bool isIgnoreLineBreak = IgnoreLineBreak.Checked;
            GetDiff(LeftTextBox.Text,RightTextBox.Text,isIgnoreLineBreak,isIgnoreSpace);
        }

        private string[] GetDiff(string str1,string str2,bool isIgnoreSpace,bool isIgnoreLineBreak)
        {
            if (isIgnoreLineBreak&&isIgnoreSpace)
            {
                string leftTxt = ReplaceRNS(LeftTextBox.Text.Trim().ToString());
                string rightftTxt = ReplaceRNS(RightTextBox.Text.Trim().ToString());
                int start = 0, end1 = leftTxt.Length -1,end2=rightftTxt.Length-1;
                int endL = end1, endR = end2;
                for(; start <= endL && start <= endR ;)
                {
                    if(leftTxt[start] == rightftTxt[start])
                    {
                        start++;
                    }
                    else
                    {
                        break;
                    }
                }
                for (;end1>=0&&end2>=0&&end1>=start&&end2>=start;)
                {
                    if(leftTxt[end1] == rightftTxt[end2])
                    {
                        end1--;
                        end2--;
                    }
                    else
                    {
                        break;
                    }
                }
                richTextBox1.Text = leftTxt;
                richTextBox2.Text = rightftTxt;
                richTextBox1.Select(start,end1 +1- start);
                richTextBox2.Select(start,end2 +1- start);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox2.SelectionColor = Color.Red;

            } 
            else
            {

            }
            return null;
        }

        private string ReplaceRNS(string str)
        {
            return Regex.Replace(str,"\r|\n|\\s","");
        }
    }
}
