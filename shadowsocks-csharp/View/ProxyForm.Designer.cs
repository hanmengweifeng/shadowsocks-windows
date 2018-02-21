namespace Shadowsocks.View
{
    partial class ProxyForm
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
            if (disposing && (components != null))
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
            this.UseProxyCheckBox = new System.Windows.Forms.CheckBox();
            this.ProxyAddrLabel = new System.Windows.Forms.Label();
            this.ProxyServerTextBox = new System.Windows.Forms.TextBox();
            this.ProxyPortLabel = new System.Windows.Forms.Label();
            this.ProxyPortTextBox = new System.Windows.Forms.TextBox();
            this.ProxyTypeLabel = new System.Windows.Forms.Label();
            this.ProxyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ProxyTimeoutTextBox = new System.Windows.Forms.TextBox();
            this.ProxyTimeoutLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ProxyNotificationLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UseProxyCheckBox
            // 
            this.UseProxyCheckBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.UseProxyCheckBox, 2);
            this.UseProxyCheckBox.Location = new System.Drawing.Point(3, 3);
            this.UseProxyCheckBox.Name = "UseProxyCheckBox";
            this.UseProxyCheckBox.Size = new System.Drawing.Size(78, 16);
            this.UseProxyCheckBox.TabIndex = 0;
            this.UseProxyCheckBox.Text = "Use Proxy";
            this.UseProxyCheckBox.UseVisualStyleBackColor = true;
            this.UseProxyCheckBox.CheckedChanged += new System.EventHandler(this.UseProxyCheckBox_CheckedChanged);
            // 
            // ProxyAddrLabel
            // 
            this.ProxyAddrLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyAddrLabel.AutoSize = true;
            this.ProxyAddrLabel.Location = new System.Drawing.Point(3, 76);
            this.ProxyAddrLabel.Name = "ProxyAddrLabel";
            this.ProxyAddrLabel.Size = new System.Drawing.Size(65, 12);
            this.ProxyAddrLabel.TabIndex = 0;
            this.ProxyAddrLabel.Text = "Proxy Addr";
            // 
            // ProxyServerTextBox
            // 
            this.ProxyServerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyServerTextBox.Location = new System.Drawing.Point(74, 72);
            this.ProxyServerTextBox.MaxLength = 512;
            this.ProxyServerTextBox.Name = "ProxyServerTextBox";
            this.ProxyServerTextBox.Size = new System.Drawing.Size(142, 21);
            this.ProxyServerTextBox.TabIndex = 1;
            this.ProxyServerTextBox.WordWrap = false;
            // 
            // ProxyPortLabel
            // 
            this.ProxyPortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyPortLabel.AutoSize = true;
            this.ProxyPortLabel.Location = new System.Drawing.Point(222, 76);
            this.ProxyPortLabel.Name = "ProxyPortLabel";
            this.ProxyPortLabel.Size = new System.Drawing.Size(77, 12);
            this.ProxyPortLabel.TabIndex = 2;
            this.ProxyPortLabel.Text = "Proxy Port";
            // 
            // ProxyPortTextBox
            // 
            this.ProxyPortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyPortTextBox.Location = new System.Drawing.Point(305, 72);
            this.ProxyPortTextBox.MaxLength = 10;
            this.ProxyPortTextBox.Name = "ProxyPortTextBox";
            this.ProxyPortTextBox.Size = new System.Drawing.Size(58, 21);
            this.ProxyPortTextBox.TabIndex = 3;
            this.ProxyPortTextBox.WordWrap = false;
            // 
            // ProxyTypeLabel
            // 
            this.ProxyTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyTypeLabel.AutoSize = true;
            this.ProxyTypeLabel.Location = new System.Drawing.Point(3, 43);
            this.ProxyTypeLabel.Name = "ProxyTypeLabel";
            this.ProxyTypeLabel.Size = new System.Drawing.Size(65, 12);
            this.ProxyTypeLabel.TabIndex = 1;
            this.ProxyTypeLabel.Text = "Proxy Type";
            // 
            // ProxyTypeComboBox
            // 
            this.ProxyTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProxyTypeComboBox.FormattingEnabled = true;
            this.ProxyTypeComboBox.Items.AddRange(new object[] {
            "SOCKS5",
            "HTTP"});
            this.ProxyTypeComboBox.Location = new System.Drawing.Point(74, 39);
            this.ProxyTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ProxyTypeComboBox.Name = "ProxyTypeComboBox";
            this.ProxyTypeComboBox.Size = new System.Drawing.Size(142, 20);
            this.ProxyTypeComboBox.TabIndex = 2;
            // 
            // ProxyTimeoutTextBox
            // 
            this.ProxyTimeoutTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyTimeoutTextBox.Location = new System.Drawing.Point(305, 39);
            this.ProxyTimeoutTextBox.Name = "ProxyTimeoutTextBox";
            this.ProxyTimeoutTextBox.Size = new System.Drawing.Size(58, 21);
            this.ProxyTimeoutTextBox.TabIndex = 3;
            // 
            // ProxyTimeoutLabel
            // 
            this.ProxyTimeoutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyTimeoutLabel.AutoSize = true;
            this.ProxyTimeoutLabel.Location = new System.Drawing.Point(222, 43);
            this.ProxyTimeoutLabel.Name = "ProxyTimeoutLabel";
            this.ProxyTimeoutLabel.Size = new System.Drawing.Size(77, 12);
            this.ProxyTimeoutLabel.TabIndex = 4;
            this.ProxyTimeoutLabel.Text = "Timeout(Sec)";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.UseProxyCheckBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ProxyTypeLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProxyPortTextBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.ProxyTypeComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProxyTimeoutLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProxyPortLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ProxyTimeoutTextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProxyServerTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ProxyAddrLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ProxyNotificationLabel, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.95122F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.95122F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.95122F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.14634F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 152);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // ProxyNotificationLabel
            // 
            this.ProxyNotificationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxyNotificationLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ProxyNotificationLabel, 4);
            this.ProxyNotificationLabel.ForeColor = System.Drawing.Color.Red;
            this.ProxyNotificationLabel.Location = new System.Drawing.Point(3, 119);
            this.ProxyNotificationLabel.Name = "ProxyNotificationLabel";
            this.ProxyNotificationLabel.Size = new System.Drawing.Size(360, 12);
            this.ProxyNotificationLabel.TabIndex = 5;
            this.ProxyNotificationLabel.Text = "If server has a plugin, proxy will not be used";
            // 
            // ProxyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProxyForm";
            this.Padding = new System.Windows.Forms.Padding(12, 12, 12, 9);
            this.Size = new System.Drawing.Size(396, 179);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox UseProxyCheckBox;
        private System.Windows.Forms.Label ProxyAddrLabel;
        private System.Windows.Forms.TextBox ProxyServerTextBox;
        private System.Windows.Forms.Label ProxyPortLabel;
        private System.Windows.Forms.TextBox ProxyPortTextBox;
        private System.Windows.Forms.Label ProxyTypeLabel;
        private System.Windows.Forms.ComboBox ProxyTypeComboBox;
        private System.Windows.Forms.TextBox ProxyTimeoutTextBox;
        private System.Windows.Forms.Label ProxyTimeoutLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ProxyNotificationLabel;
    }
}