using Shadowsocks.Controller;
using Shadowsocks.Properties;
using Shadowsocks.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shadowsocks.View
{
    public partial class SettingsTabForm : Form
    {
        private ShadowsocksController controller;

        private ConfigForm configForm;
        private ProxyForm proxyForm;
        private HotkeySettingsForm hotkeySettingsForm;

        public SettingsTabForm(ShadowsocksController controller, Type selectedFormType = null)
        {
            this.Font = System.Drawing.SystemFonts.MessageBoxFont;
            InitializeComponent();

            this.Icon = Icon.FromHandle(Resources.ssw128.GetHicon());

            this.controller = controller;

            InitTabs();

            SelectTabByForm(selectedFormType);
        }

        private void InitTabs()
        {
            configForm = new ConfigForm(controller);
            //configForm.Dock = DockStyle.Fill;
            tabPageServers.Controls.Add(configForm);

            proxyForm = new ProxyForm(controller);
            proxyForm.Dock = DockStyle.Fill;
            tabPageProxy.Controls.Add(proxyForm);

            hotkeySettingsForm = new HotkeySettingsForm(controller);
            hotkeySettingsForm.Dock = DockStyle.Fill;
            tabPageHotkey.Controls.Add(hotkeySettingsForm);
        }

        public void SelectTabByForm(Type formType)
        {
            if (formType != null)
            {
                foreach (TabPage tabpage in tabControl1.TabPages)
                {
                    var ctrls = tabpage.GetChildControls<UserControl>();
                    if (ctrls.Any(c => c.GetType() == formType))
                    {
                        tabControl1.SelectedTab = tabpage;
                        break;
                    }
                }
            }
        }

    }
}
