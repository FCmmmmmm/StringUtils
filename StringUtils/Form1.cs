using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StringUtils.Menu.TextContrast;

namespace StringUtils
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private static TextContrast textContrast=new TextContrast();
        private void 文本对比ToolStripMenuItem_Click(object sender,EventArgs e)
        {
            textContrast.Show();
        }
  
    }
}
