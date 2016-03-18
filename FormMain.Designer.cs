namespace MyToolsBox
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.metroTabControl1 = new Wisder.W3Common.WMetroControl.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupListView1 = new MyToolsBox.GroupListView();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Padding = new System.Drawing.Point(6, 8);
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(703, 374);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupListView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(695, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "插件";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupListView1
            // 
            this.groupListView1.AutoScroll = true;
            this.groupListView1.BackColor = System.Drawing.Color.White;
            this.groupListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupListView1.GroupItemList = null;
            this.groupListView1.Location = new System.Drawing.Point(3, 3);
            this.groupListView1.Name = "groupListView1";
            this.groupListView1.Size = new System.Drawing.Size(689, 326);
            this.groupListView1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 454);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "我的工具箱";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisder.W3Common.WMetroControl.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private GroupListView groupListView1;


    }
}

