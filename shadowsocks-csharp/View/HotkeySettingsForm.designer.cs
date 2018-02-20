namespace Shadowsocks.View
{
    partial class HotkeySettingsForm
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
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            this.btnRegisterAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SwitchSystemProxyLabel = new System.Windows.Forms.Label();
            this.SwitchProxyModeLabel = new System.Windows.Forms.Label();
            this.SwitchAllowLanLabel = new System.Windows.Forms.Label();
            this.ShowLogsLabel = new System.Windows.Forms.Label();
            this.ServerMoveUpLabel = new System.Windows.Forms.Label();
            this.ServerMoveDownLabel = new System.Windows.Forms.Label();
            this.SwitchSystemProxyTextBox = new System.Windows.Forms.TextBox();
            this.SwitchProxyModeTextBox = new System.Windows.Forms.TextBox();
            this.SwitchAllowLanTextBox = new System.Windows.Forms.TextBox();
            this.ShowLogsTextBox = new System.Windows.Forms.TextBox();
            this.ServerMoveUpTextBox = new System.Windows.Forms.TextBox();
            this.ServerMoveDownTextBox = new System.Windows.Forms.TextBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Controls.Add(this.btnRegisterAll);
            flowLayoutPanel1.Controls.Add(this.btnCancel);
            flowLayoutPanel1.Controls.Add(this.btnOK);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new System.Drawing.Point(50, 165);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(387, 56);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btnRegisterAll
            // 
            this.btnRegisterAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegisterAll.Location = new System.Drawing.Point(261, 3);
            this.btnRegisterAll.Name = "btnRegisterAll";
            this.btnRegisterAll.Size = new System.Drawing.Size(123, 31);
            this.btnRegisterAll.TabIndex = 2;
            this.btnRegisterAll.Text = "Reg All";
            this.btnRegisterAll.UseVisualStyleBackColor = true;
            this.btnRegisterAll.Click += new System.EventHandler(this.RegisterAllButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(132, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(3, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(123, 31);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SwitchSystemProxyLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SwitchProxyModeLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SwitchAllowLanLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ShowLogsLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ServerMoveUpLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ServerMoveDownLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.SwitchSystemProxyTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SwitchProxyModeTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SwitchAllowLanTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ShowLogsTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ServerMoveUpTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ServerMoveDownTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(440, 224);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SwitchSystemProxyLabel
            // 
            this.SwitchSystemProxyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SwitchSystemProxyLabel.AutoSize = true;
            this.SwitchSystemProxyLabel.Location = new System.Drawing.Point(33, 0);
            this.SwitchSystemProxyLabel.Name = "SwitchSystemProxyLabel";
            this.SwitchSystemProxyLabel.Size = new System.Drawing.Size(119, 27);
            this.SwitchSystemProxyLabel.TabIndex = 0;
            this.SwitchSystemProxyLabel.Text = "Enable System Proxy";
            this.SwitchSystemProxyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SwitchProxyModeLabel
            // 
            this.SwitchProxyModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SwitchProxyModeLabel.AutoSize = true;
            this.SwitchProxyModeLabel.Location = new System.Drawing.Point(3, 27);
            this.SwitchProxyModeLabel.Name = "SwitchProxyModeLabel";
            this.SwitchProxyModeLabel.Size = new System.Drawing.Size(149, 27);
            this.SwitchProxyModeLabel.TabIndex = 1;
            this.SwitchProxyModeLabel.Text = "Switch System Proxy Mode";
            this.SwitchProxyModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SwitchAllowLanLabel
            // 
            this.SwitchAllowLanLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SwitchAllowLanLabel.AutoSize = true;
            this.SwitchAllowLanLabel.Location = new System.Drawing.Point(15, 54);
            this.SwitchAllowLanLabel.Name = "SwitchAllowLanLabel";
            this.SwitchAllowLanLabel.Size = new System.Drawing.Size(137, 27);
            this.SwitchAllowLanLabel.TabIndex = 3;
            this.SwitchAllowLanLabel.Text = "Allow Clients from LAN";
            this.SwitchAllowLanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowLogsLabel
            // 
            this.ShowLogsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowLogsLabel.AutoSize = true;
            this.ShowLogsLabel.Location = new System.Drawing.Point(75, 81);
            this.ShowLogsLabel.Name = "ShowLogsLabel";
            this.ShowLogsLabel.Size = new System.Drawing.Size(77, 27);
            this.ShowLogsLabel.TabIndex = 4;
            this.ShowLogsLabel.Text = "Show Logs...";
            this.ShowLogsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerMoveUpLabel
            // 
            this.ServerMoveUpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerMoveUpLabel.AutoSize = true;
            this.ServerMoveUpLabel.Location = new System.Drawing.Point(105, 108);
            this.ServerMoveUpLabel.Name = "ServerMoveUpLabel";
            this.ServerMoveUpLabel.Size = new System.Drawing.Size(47, 27);
            this.ServerMoveUpLabel.TabIndex = 4;
            this.ServerMoveUpLabel.Text = "Move up";
            this.ServerMoveUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerMoveDownLabel
            // 
            this.ServerMoveDownLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerMoveDownLabel.AutoSize = true;
            this.ServerMoveDownLabel.Location = new System.Drawing.Point(93, 135);
            this.ServerMoveDownLabel.Name = "ServerMoveDownLabel";
            this.ServerMoveDownLabel.Size = new System.Drawing.Size(59, 27);
            this.ServerMoveDownLabel.TabIndex = 4;
            this.ServerMoveDownLabel.Text = "Move Down";
            this.ServerMoveDownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SwitchSystemProxyTextBox
            // 
            this.SwitchSystemProxyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SwitchSystemProxyTextBox.Location = new System.Drawing.Point(158, 3);
            this.SwitchSystemProxyTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 16, 3);
            this.SwitchSystemProxyTextBox.Name = "SwitchSystemProxyTextBox";
            this.SwitchSystemProxyTextBox.ReadOnly = true;
            this.SwitchSystemProxyTextBox.Size = new System.Drawing.Size(266, 21);
            this.SwitchSystemProxyTextBox.TabIndex = 7;
            this.SwitchSystemProxyTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.SwitchSystemProxyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyDown);
            this.SwitchSystemProxyTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HotkeyUp);
            // 
            // SwitchProxyModeTextBox
            // 
            this.SwitchProxyModeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SwitchProxyModeTextBox.Location = new System.Drawing.Point(158, 30);
            this.SwitchProxyModeTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 16, 3);
            this.SwitchProxyModeTextBox.Name = "SwitchProxyModeTextBox";
            this.SwitchProxyModeTextBox.ReadOnly = true;
            this.SwitchProxyModeTextBox.Size = new System.Drawing.Size(266, 21);
            this.SwitchProxyModeTextBox.TabIndex = 8;
            this.SwitchProxyModeTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.SwitchProxyModeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyDown);
            this.SwitchProxyModeTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HotkeyUp);
            // 
            // SwitchAllowLanTextBox
            // 
            this.SwitchAllowLanTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SwitchAllowLanTextBox.Location = new System.Drawing.Point(158, 57);
            this.SwitchAllowLanTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 16, 3);
            this.SwitchAllowLanTextBox.Name = "SwitchAllowLanTextBox";
            this.SwitchAllowLanTextBox.ReadOnly = true;
            this.SwitchAllowLanTextBox.Size = new System.Drawing.Size(266, 21);
            this.SwitchAllowLanTextBox.TabIndex = 10;
            this.SwitchAllowLanTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.SwitchAllowLanTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyDown);
            this.SwitchAllowLanTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HotkeyUp);
            // 
            // ShowLogsTextBox
            // 
            this.ShowLogsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowLogsTextBox.Location = new System.Drawing.Point(158, 84);
            this.ShowLogsTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 16, 3);
            this.ShowLogsTextBox.Name = "ShowLogsTextBox";
            this.ShowLogsTextBox.ReadOnly = true;
            this.ShowLogsTextBox.Size = new System.Drawing.Size(266, 21);
            this.ShowLogsTextBox.TabIndex = 11;
            this.ShowLogsTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.ShowLogsTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyDown);
            this.ShowLogsTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HotkeyUp);
            // 
            // ServerMoveUpTextBox
            // 
            this.ServerMoveUpTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerMoveUpTextBox.Location = new System.Drawing.Point(158, 111);
            this.ServerMoveUpTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 16, 3);
            this.ServerMoveUpTextBox.Name = "ServerMoveUpTextBox";
            this.ServerMoveUpTextBox.ReadOnly = true;
            this.ServerMoveUpTextBox.Size = new System.Drawing.Size(266, 21);
            this.ServerMoveUpTextBox.TabIndex = 12;
            this.ServerMoveUpTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.ServerMoveUpTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyDown);
            this.ServerMoveUpTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HotkeyUp);
            // 
            // ServerMoveDownTextBox
            // 
            this.ServerMoveDownTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerMoveDownTextBox.Location = new System.Drawing.Point(158, 138);
            this.ServerMoveDownTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 16, 3);
            this.ServerMoveDownTextBox.Name = "ServerMoveDownTextBox";
            this.ServerMoveDownTextBox.ReadOnly = true;
            this.ServerMoveDownTextBox.Size = new System.Drawing.Size(266, 21);
            this.ServerMoveDownTextBox.TabIndex = 13;
            this.ServerMoveDownTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.ServerMoveDownTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyDown);
            this.ServerMoveDownTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HotkeyUp);
            // 
            // HotkeySettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HotkeySettingsForm";
            this.Size = new System.Drawing.Size(440, 224);
            flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label SwitchSystemProxyLabel;
        private System.Windows.Forms.Label SwitchProxyModeLabel;
        private System.Windows.Forms.Label SwitchAllowLanLabel;
        private System.Windows.Forms.Label ShowLogsLabel;
        private System.Windows.Forms.Label ServerMoveUpLabel;
        private System.Windows.Forms.Label ServerMoveDownLabel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox ShowLogsTextBox;
        private System.Windows.Forms.TextBox SwitchAllowLanTextBox;
        private System.Windows.Forms.TextBox SwitchProxyModeTextBox;
        private System.Windows.Forms.TextBox SwitchSystemProxyTextBox;
        private System.Windows.Forms.TextBox ServerMoveUpTextBox;
        private System.Windows.Forms.TextBox ServerMoveDownTextBox;
        private System.Windows.Forms.Button btnRegisterAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}