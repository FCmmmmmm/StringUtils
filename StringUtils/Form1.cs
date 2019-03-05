using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StringUtils.Menu.Json;
using StringUtils.Menu.TextContrast;

namespace StringUtils
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private static readonly object O = new object();
        private TextContrast textContrast;
        private ToJson toJson;
        private void 文本对比ToolStripMenuItem_Click(object sender,EventArgs e)
        {
            if(textContrast == null || textContrast.IsDisposed)
            {
                lock(O)
                {
                    if(textContrast == null || textContrast.IsDisposed)
                    {
                        textContrast = new TextContrast(this);
                    }
                }
            }
            textContrast.Show();
        }

        private void 文本转JSONToolStripMenuItem_Click(object sender,EventArgs e)
        {
            if(toJson == null || toJson.IsDisposed)
            {
                lock(O)
                {
                    if(toJson == null || toJson.IsDisposed)
                    {
                        toJson = new ToJson(this);
                    }
                }
            }
            toJson.Show();
            this.Visible = false;
        }
    }
}
