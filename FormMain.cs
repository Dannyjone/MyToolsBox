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


namespace MyToolsBox
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>test class</summary>
        private void button1_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath.AppendStr("/PulgIns");
            if (!File.Exists(path)) Directory.CreateDirectory(path);
            var result = Directory.GetFiles(path)
                        .Where(item => item.Substring(item.LastIndexOf('.')).ToLower() == ".dll");


        }

        private void AddPlugin(string FileName)
        {
            Assembly pluginAssembly = Assembly.LoadFrom(FileName);

            foreach (Type pluginType in pluginAssembly.GetTypes())
            {
                if (!pluginType.IsPublic) continue;
                Type typeInterface = pluginType.GetInterface("PluginInterface.IPlugin", true);
                var plugin = (IPlugin)Activator.CreateInstance(pluginAssembly.GetType(pluginType.ToString()));
                typeInterface = null;
            }
            pluginAssembly = null;
        }
    }
}
