using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalHelperClass;
using System.IO;
using System.Reflection;
using PluginInterface;
using Wisder.W3Common.WMetroControl.Forms;


namespace MyToolsBox
{
    public partial class FormMain : MetroForm
    {
        private readonly LogHelper log = new LogHelper();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary> 1.读取插件文件夹加载插件2.加载动态生成窗体</summary>
        private void FormMain_Shown(object sender, EventArgs e)
        {
            LogHelper.LogAct(() => Fun_LoadDll(), "初始化加载Dll");
        }

        /// <summary>加载Dll</summary>
        private void Fun_LoadDll()
        {
            Global.Plugins.FindPlugins(Application.StartupPath + @"\插件");
            groupListView1.GroupItemList = new List<GroupListViewItem>();
            foreach (PluginInterface.Types.AvailablePlugin pluginOn in Global.Plugins.AvailablePlugins)
            {
                GroupListViewItem glvi = new GroupListViewItem()
                {
                    GroupName = pluginOn.Instance.PlugClass,
                    ItemName = pluginOn.Instance.PlugName,
                    ItemRemark = pluginOn.Instance.Version,
                    ItemImage = pluginOn.Instance.Icon
                };
                glvi.ItemClickEventArges += glvi_ItemClickEventArges;
                glvi.ItemWorkStatusChangeClickEventArges += glvi_ItemWorkStatusChangeClickEventArges;
                groupListView1.GroupItemList.Add(glvi);
                groupListView1.Fun_IniGroupItem(groupListView1.GroupItemList);
            }
        }

        /// <summary>加载tab页或取消tab页</summary>
        void glvi_ItemWorkStatusChangeClickEventArges(object sender, EventArgs e)
        {
            LogHelper.LogAct(() =>
            {
                if (!(sender is GroupListViewItem)) return;
                GroupListViewItem glvi = sender as GroupListViewItem;
                bool result = true;
                int tmpIndex = Fun_ReturnPageIndex(glvi, ref result);
                if (!glvi.IsWork)
                    metroTabControl1.TabPages.RemoveAt(tmpIndex);
                if (result)
                {
                    TabPage tp = new TabPage(glvi.ItemName);
                    metroTabControl1.TabPages.Add(tp);
                    string path = "{0}/插件/{1}.dll".FormatEx(
                        Application.StartupPath
                        , glvi.ItemName);

                    PluginInterface.Types.AvailablePlugin selectedPlugin = Global.Plugins.AvailablePlugins.Find(glvi.ItemName);

                    if (selectedPlugin != null)
                    {
                        metroTabControl1.TabPages[metroTabControl1.TabPages.IndexOf(tp)].Controls.Clear();
                        selectedPlugin.Instance.MainInterface.Dock = DockStyle.Fill;
                        metroTabControl1.TabPages[metroTabControl1.TabPages.IndexOf(tp)].Controls.Add(selectedPlugin.Instance.MainInterface);
                    }
                }
            }, this.Name);
        }

        private int Fun_ReturnPageIndex(GroupListViewItem glvi, ref bool result)
        {
            int tmpIndex = 0;
            foreach (TabPage item in metroTabControl1.TabPages)
            {
                if (item.Text == glvi.ItemName)
                {
                    result = false;
                    tmpIndex = metroTabControl1.TabPages.IndexOf(item);
                }
            }
            return tmpIndex;
        }

        /// <summary>开启状态则选中tab页,否则不做动作</summary>
        void glvi_ItemClickEventArges(object sender, EventArgs e)
        {
            LogHelper.LogAct(() =>
            {
                if (!(sender is GroupListViewItem)) return;
                GroupListViewItem glvi = sender as GroupListViewItem;
                bool result = true;
                int tmpIndex = Fun_ReturnPageIndex(glvi, ref result);
                if (glvi.IsWork)
                    metroTabControl1.SelectedIndex = tmpIndex;

            }, this.Name);
        }
    }
}
