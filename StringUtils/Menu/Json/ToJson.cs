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
        public ToJson()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender,EventArgs e)
        {
            string str = textBox1.Text.Trim().ToString();
            str=str.Replace("\n","").Replace(" ","").Replace("\t","").Replace("\r","");
            if(str != null && str.Length > 0)
            {
                JsonUtils utils = new JsonUtils();
                string re=utils.formatJson(str);
                textBox2.Text = re;
            }
        }
    }
}
