using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyToolsBox
{
    public partial class GroupListViewItem : UserControl
    {
        [Browsable(true)]
        public string GroupName { get; set; }

        [Browsable(true)]
        public string ItemName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        [Browsable(true)]
        public string ItemRemark
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        [Browsable(true)]
        public Image ItemImage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        [Browsable(true)]
        public bool IsWork
        {
            get
            {
                this.metroToggle1.Text = this.metroToggle1.Checked ? "ON" : "OFF";
                return this.metroToggle1.Checked;
            }
            set
            {
                this.metroToggle1.Text = this.metroToggle1.Checked ? "ON" : "OFF";
                this.metroToggle1.Checked = value;
            }
        }

        public GroupListViewItem()
        {
            InitializeComponent();
            this.pictureBox1.Image = ItemImage;
        }

        private void GroupListViewItem_MouseHover(object sender, EventArgs e)
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void GroupListViewItem_MouseDown(object sender, MouseEventArgs e)
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }
        private void GroupListViewItem_MouseUp(object sender, MouseEventArgs e)
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        public delegate void ItemClick(object sender, EventArgs e);
        public event ItemClick ItemClickEventArges;
        private void GroupListViewItem_Click(object sender, EventArgs e)
        {
            if (ItemClickEventArges != null)
                ItemClickEventArges(this, e);
        }

        public delegate void ItemWorkStatusChangeClick(object sender, EventArgs e);
        public event ItemWorkStatusChangeClick ItemWorkStatusChangeClickEventArges;
        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (ItemWorkStatusChangeClickEventArges != null)
                ItemWorkStatusChangeClickEventArges(this, e);
        }

    }
}
