using System;
using System.Drawing;
using System.Windows.Forms;
using Shadowsocks.Controller;
using Shadowsocks.Model;
using Shadowsocks.Properties;

namespace Shadowsocks.View
{
    public partial class ProxyForm : UserControl
    {
        private bool _isDirty;
        public bool isDirty
        {
            get { return _isDirty; }
            set
            {
                if (value != _isDirty)
                {
                    _isDirty = value;
                    DirtyStateChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        public event EventHandler DirtyStateChanged;

        private ShadowsocksController controller;

        // this is a copy of configuration that we are working on
        private ProxyConfig _modifiedProxyConfig;

        public ProxyForm(ShadowsocksController controller)
        {
            this.Font = System.Drawing.SystemFonts.MessageBoxFont;
            InitializeComponent();

            UpdateTexts();
            //this.Icon = Icon.FromHandle(Resources.ssw128.GetHicon());

            this.controller = controller;
            //controller.ConfigChanged += controller_ConfigChanged;

            UpdateEnabled();
            LoadCurrentConfiguration();

            AssignHandlersForControls(this.Controls);
        }

        private void UpdateTexts()
        {
            UseProxyCheckBox.Text = I18N.GetString("Use Proxy");
            ProxyTypeLabel.Text = I18N.GetString("Proxy Type");
            ProxyAddrLabel.Text = I18N.GetString("Proxy Addr");
            ProxyPortLabel.Text = I18N.GetString("Proxy Port");
            ProxyTimeoutLabel.Text = I18N.GetString("Timeout(Sec)");
            ProxyNotificationLabel.Text = I18N.GetString("If server has a plugin, proxy will not be used");
            //OKButton.Text = I18N.GetString("OK");
            //MyCancelButton.Text = I18N.GetString("Cancel");
            this.Text = I18N.GetString("Edit Proxy");
        }

        //private void controller_ConfigChanged(object sender, EventArgs e)
        //{
        //    LoadCurrentConfiguration();
        //}

        private void LoadCurrentConfiguration()
        {
            _modifiedProxyConfig = controller.GetConfigurationCopy().proxy;
            UseProxyCheckBox.Checked = _modifiedProxyConfig.useProxy;
            ProxyServerTextBox.Text = _modifiedProxyConfig.proxyServer;
            ProxyPortTextBox.Text = _modifiedProxyConfig.proxyPort.ToString();
            ProxyTimeoutTextBox.Text = _modifiedProxyConfig.proxyTimeout.ToString();
            ProxyTypeComboBox.SelectedIndex = _modifiedProxyConfig.proxyType;
        }

        public bool SaveChanges()
        {

            if (_modifiedProxyConfig.useProxy = UseProxyCheckBox.Checked)
            {
                if (!int.TryParse(ProxyPortTextBox.Text, out _modifiedProxyConfig.proxyPort))
                {
                    MessageBox.Show(I18N.GetString("Illegal port number format"));
                    return false;
                }

                if (!int.TryParse(ProxyTimeoutTextBox.Text, out _modifiedProxyConfig.proxyTimeout))
                {
                    MessageBox.Show(I18N.GetString("Illegal timeout format"));
                    return false;
                }

                _modifiedProxyConfig.proxyType = ProxyTypeComboBox.SelectedIndex;

                try
                {
                    Configuration.CheckServer(_modifiedProxyConfig.proxyServer = ProxyServerTextBox.Text);
                    Configuration.CheckPort(_modifiedProxyConfig.proxyPort);
                    Configuration.CheckTimeout(_modifiedProxyConfig.proxyTimeout, ProxyConfig.MaxProxyTimeoutSec);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }

            controller.SaveProxy(_modifiedProxyConfig);

            //this.Close();
            return true;
        }

        //private void CancelButton_Click(object sender, EventArgs e)
        //{
        //    //this.Close();
        //}

        //private void ProxyForm_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    controller.ConfigChanged -= controller_ConfigChanged;
        //}

        private void UseProxyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEnabled();
        }

        private void UpdateEnabled()
        {
            if (UseProxyCheckBox.Checked)
            {
                ProxyServerTextBox.Enabled =
                ProxyPortTextBox.Enabled =
                ProxyTimeoutTextBox.Enabled =
                ProxyTypeComboBox.Enabled = true;
            }
            else
            {
                ProxyServerTextBox.Enabled =
                ProxyPortTextBox.Enabled =
                ProxyTimeoutTextBox.Enabled =
                ProxyTypeComboBox.Enabled = false;
            }
        }

        #region isDirty triggers
        //todo: split this to an individual class
        private void AssignHandlersForControls(ControlCollection collection)
        {
            foreach (Control c in collection)
            {
                if (c is TextBoxBase)
                    (c as TextBoxBase).TextChanged += DirtyTracker_ValueChanged;

                if (c is CheckBox)
                    (c as CheckBox).CheckedChanged += DirtyTracker_ValueChanged;

                if (c is ComboBox)
                    (c as ComboBox).SelectedIndexChanged += DirtyTracker_ValueChanged;

                // recurively apply to inner collections
                if (c.HasChildren)
                    AssignHandlersForControls(c.Controls);
            }
        }

        private void UnassignHandlersForControls(ControlCollection collection)
        {
            foreach (Control c in collection)
            {
                if (c is TextBoxBase)
                    (c as TextBoxBase).TextChanged -= DirtyTracker_ValueChanged;

                if (c is CheckBox)
                    (c as CheckBox).CheckedChanged -= DirtyTracker_ValueChanged;

                if (c is ComboBox)
                    (c as ComboBox).SelectedIndexChanged -= DirtyTracker_ValueChanged;

                // recurively apply to inner collections
                if (c.HasChildren)
                    UnassignHandlersForControls(c.Controls);
            }
        }

        private void DirtyTracker_ValueChanged(object sender, EventArgs e)
        {
            isDirty = true;
        }

        #endregion

        protected override void OnHandleDestroyed(EventArgs e)
        {
            UnassignHandlersForControls(this.Controls);
            base.OnHandleDestroyed(e);
        }
    }
}
