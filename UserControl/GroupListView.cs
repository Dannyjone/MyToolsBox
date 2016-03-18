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
    public partial class GroupListView : UserControl
    {
        public List<GroupListViewItem> GroupItemList { get; set; }

        public GroupListView()
        {
            InitializeComponent();
        }

        /// <summary>初始化子项</summary>
        public void Fun_IniGroupItem(List<GroupListViewItem> IGroupItemList)
        {
            this.Controls.Clear();

            var group_ = from groupname in IGroupItemList
                         group groupname by groupname.GroupName into groupname
                         select groupname;
            int iItemHeight = 0;
            group_.ToList().ForEach(item =>
            {
                GroupBox gb = new GroupBox()
                {
                    Text = item.Key,
                    Size = new Size(this.Width, 110),
                    Location = new Point(0, iItemHeight),
                    Font = new Font("微软雅黑", 10f, FontStyle.Bold)
                };
                this.Controls.Add(gb);
                iItemHeight += 110;
                int X = 3, Y = 20;
                //Add Item & change GroupBox Size 
                GroupItemList.ForEach(item2 =>
                {
                    if (item2.GroupName == item.Key)
                    {
                        if (X + 200 > this.Width)
                        {
                            X = 3; Y += 85; iItemHeight += 90;
                            gb.Size = new Size(this.Width, gb.Height += 90);
                        }
                        item2.Location = new Point(X, Y);
                        gb.Controls.Add(item2);
                        X += 203;
                    }
                });
            });
        }

        private void GroupListView_SizeChanged(object sender, EventArgs e)
        {
            if (GroupItemList == null) return;
            Fun_IniGroupItem(GroupItemList);
        }
    }
}
