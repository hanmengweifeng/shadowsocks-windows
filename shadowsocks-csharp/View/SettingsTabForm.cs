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

            UpdateTexts();

            InitTabs();

            SelectTabByForm(selectedFormType);
        }

        private void UpdateTexts()
        {
            //todo
        }

        private void InitTabs()
        {
            configForm = new ConfigForm(controller);
            //configForm.Dock = DockStyle.Fill;
            configForm.DirtyStateChanged += ConfigForm_DirtyStateChanged;
            tabPageServers.Controls.Add(configForm);

            proxyForm = new ProxyForm(controller);
            proxyForm.Dock = DockStyle.Fill;
            proxyForm.DirtyStateChanged += ProxyForm_DirtyStateChanged;
            tabPageProxy.Controls.Add(proxyForm);

            hotkeySettingsForm = new HotkeySettingsForm(controller);
            hotkeySettingsForm.Dock = DockStyle.Fill;
            hotkeySettingsForm.DirtyStateChanged += HotkeySettingsForm_DirtyStateChanged;
            tabPageHotkey.Controls.Add(hotkeySettingsForm);
        }

        private void ConfigForm_DirtyStateChanged(object sender, EventArgs e)
        {
            tabPageServers.Text = configForm.isDirty ?
                                  tabPageServers.Text + " *" : tabPageServers.Text.Replace(" *", "");
        }

        private void ProxyForm_DirtyStateChanged(object sender, EventArgs e)
        {
            tabPageProxy.Text = proxyForm.isDirty ?
                                tabPageProxy.Text + " *" : tabPageProxy.Text.Replace(" *", "");
        }

        private void HotkeySettingsForm_DirtyStateChanged(object sender, EventArgs e)
        {
            tabPageHotkey.Text = hotkeySettingsForm.isDirty ?
                                 tabPageHotkey.Text + " *" : tabPageHotkey.Text.Replace(" *", "");
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

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (SaveAllChanges())
                buttonCancel_Click(sender, e);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            configForm.Dispose();
            proxyForm.Dispose();
            hotkeySettingsForm.Dispose();
            this.Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            SaveAllChanges();
        }

        private bool SaveAllChanges()
        {
            bool success = true;
            if (configForm.isDirty)
            {
                if (configForm.SaveChangesThenSelect())
                    configForm.isDirty = false;
                else
                    success = false;
            }
            if (proxyForm.isDirty)
            {
                if (proxyForm.SaveChanges())
                    proxyForm.isDirty = false;
                else
                    success = false;
            }
            if (hotkeySettingsForm.isDirty)
            {
                if (hotkeySettingsForm.RegisterThenSave())
                    hotkeySettingsForm.isDirty = false;
                else
                    success = false;
            }
            return success;
        }

        private void SettingsTabForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            configForm.DirtyStateChanged -= ConfigForm_DirtyStateChanged;
            proxyForm.DirtyStateChanged -= ProxyForm_DirtyStateChanged;
            hotkeySettingsForm.DirtyStateChanged -= HotkeySettingsForm_DirtyStateChanged;
        }
    }
}
