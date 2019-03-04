namespace StringUtils.Menu.TextContrast
{
    partial class TextContrast
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.LeftTextBox = new System.Windows.Forms.TextBox();
            this.RightTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.leftReLable = new System.Windows.Forms.Label();
            this.rightReLable = new System.Windows.Forms.Label();
            this.IgnoreSpace = new System.Windows.Forms.CheckBox();
            this.IgnoreLineBreak = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 58);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1002, 58);
            this.splitContainer1.SplitterDistance = 334;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "左侧文本：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "右侧文本：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer2);
            this.panel2.Location = new System.Drawing.Point(3, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 194);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.LeftTextBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.RightTextBox);
            this.splitContainer2.Size = new System.Drawing.Size(1002, 194);
            this.splitContainer2.SplitterDistance = 334;
            this.splitContainer2.TabIndex = 0;
            // 
            // LeftTextBox
            // 
            this.LeftTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeftTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftTextBox.Location = new System.Drawing.Point(0, 0);
            this.LeftTextBox.Multiline = true;
            this.LeftTextBox.Name = "LeftTextBox";
            this.LeftTextBox.Size = new System.Drawing.Size(334, 194);
            this.LeftTextBox.TabIndex = 0;
            this.LeftTextBox.TextChanged += new System.EventHandler(this.LeftTextBox_TextChanged);
            // 
            // RightTextBox
            // 
            this.RightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RightTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightTextBox.Location = new System.Drawing.Point(0, 0);
            this.RightTextBox.Multiline = true;
            this.RightTextBox.Name = "RightTextBox";
            this.RightTextBox.Size = new System.Drawing.Size(664, 194);
            this.RightTextBox.TabIndex = 0;
            this.RightTextBox.TextChanged += new System.EventHandler(this.RightTextBox_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.splitContainer3);
            this.panel3.Location = new System.Drawing.Point(3, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1002, 169);
            this.panel3.TabIndex = 2;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.leftReLable);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.rightReLable);
            this.splitContainer3.Size = new System.Drawing.Size(1000, 167);
            this.splitContainer3.SplitterDistance = 333;
            this.splitContainer3.TabIndex = 0;
            // 
            // leftReLable
            // 
            this.leftReLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftReLable.Location = new System.Drawing.Point(0, 0);
            this.leftReLable.Name = "leftReLable";
            this.leftReLable.Size = new System.Drawing.Size(333, 167);
            this.leftReLable.TabIndex = 0;
            // 
            // rightReLable
            // 
            this.rightReLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightReLable.Location = new System.Drawing.Point(0, 0);
            this.rightReLable.Name = "rightReLable";
            this.rightReLable.Size = new System.Drawing.Size(663, 167);
            this.rightReLable.TabIndex = 0;
            // 
            // IgnoreSpace
            // 
            this.IgnoreSpace.AutoSize = true;
            this.IgnoreSpace.Location = new System.Drawing.Point(749, 464);
            this.IgnoreSpace.Name = "IgnoreSpace";
            this.IgnoreSpace.Size = new System.Drawing.Size(89, 19);
            this.IgnoreSpace.TabIndex = 1;
            this.IgnoreSpace.Text = "忽略空格";
            this.IgnoreSpace.UseVisualStyleBackColor = true;
            // 
            // IgnoreLineBreak
            // 
            this.IgnoreLineBreak.AutoSize = true;
            this.IgnoreLineBreak.Location = new System.Drawing.Point(888, 464);
            this.IgnoreLineBreak.Name = "IgnoreLineBreak";
            this.IgnoreLineBreak.Size = new System.Drawing.Size(89, 19);
            this.IgnoreLineBreak.TabIndex = 3;
            this.IgnoreLineBreak.Text = "忽略换行";
            this.IgnoreLineBreak.UseVisualStyleBackColor = true;
            // 
            // TextContrast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 495);
            this.Controls.Add(this.IgnoreLineBreak);
            this.Controls.Add(this.IgnoreSpace);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TextContrast";
            this.Text = "TextContrast";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public void ResizeForm()
        {
            //自定义初始化
            int width = Width, height = Height;
            panel1.Location = new System.Drawing.Point(0,0);
            panel1.Size = new System.Drawing.Size(width,(int)0.1 * height);
            panel2.Location = new System.Drawing.Point(0,panel1.Height);
            panel2.Size = new System.Drawing.Size(width,(int)0.4 * height);
            panel3.Location = new System.Drawing.Point(0,panel2.Height + panel1.Height);
            panel3.Size = new System.Drawing.Size(width,(int)0.4 * height);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LeftTextBox;
        private System.Windows.Forms.TextBox RightTextBox;
        private System.Windows.Forms.Label leftReLable;
        private System.Windows.Forms.Label rightReLable;
        private System.Windows.Forms.CheckBox IgnoreSpace;
        private System.Windows.Forms.CheckBox IgnoreLineBreak;
    }
}