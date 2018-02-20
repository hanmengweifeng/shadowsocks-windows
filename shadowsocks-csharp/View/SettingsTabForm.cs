﻿using Shadowsocks.Controller;
using Shadowsocks.Properties;
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
        private ProxyForm proxyForm;
        private HotkeySettingsForm hotkeySettingsForm;


        public SettingsTabForm(ShadowsocksController controller)
        {
            this.Font = System.Drawing.SystemFonts.MessageBoxFont;
            InitializeComponent();

            this.Icon = Icon.FromHandle(Resources.ssw128.GetHicon());

            this.controller = controller;

            InitTabs();
        }

        private void InitTabs()
        {
            proxyForm = new ProxyForm(controller);
            proxyForm.Dock = DockStyle.Fill;
            tabPageProxy.Controls.Add(proxyForm);

            hotkeySettingsForm = new HotkeySettingsForm(controller);
            hotkeySettingsForm.Dock = DockStyle.Fill;
            tabPageHotkey.Controls.Add(hotkeySettingsForm);
        }

    }
}
