using StringUtils.Common.Imp;
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

namespace StringUtils.Menu.Json
{
    public partial class ToJson : Form
    {
        private MainForm mainForm;
        public ToJson()
        {
            InitializeComponent();
        }
        public ToJson(MainForm form)
        {
            this.mainForm = form;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender,EventArgs e)
        {
            string str = textBox1.Text.Trim().ToString();
            str=str.Replace("\n","").Replace(" ","").Replace("\t","").Replace("\r","");
            if(str != null && str.Length > 0)
            {
                string re = ToJsonUtil.ToJson(str);
                textBox2.Text = re;
            }
        }

        private void ToJson_Load(object sender,EventArgs e)
        {
            
        }

        private void ToJson_FormClosing(object sender,FormClosingEventArgs e)
        {
            mainForm.Visible = true;
        }
    }
}
