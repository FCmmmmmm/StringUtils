using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringUtils.Menu.TextContrast
{
    public partial class TextContrast : Form
    {
        public TextContrast()
        {
            InitializeComponent();
        }

        private void LeftTextBox_TextChanged(object sender,EventArgs e)
        {
            bool isIgnoreSpace = IgnoreSpace.Checked;
            bool isIgnoreLineBreak = IgnoreLineBreak.Checked;
            if(isIgnoreLineBreak && isIgnoreSpace)
            {

            }
        }

        private void RightTextBox_TextChanged(object sender,EventArgs e)
        {
            bool isIgnoreSpace = IgnoreSpace.Checked;
            bool isIgnoreLineBreak = IgnoreLineBreak.Checked;
        }
    }
}
