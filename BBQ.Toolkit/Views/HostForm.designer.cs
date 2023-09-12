using BBQ.Toolkit.Controls;

namespace BBQ.Toolkit.Views
{
    partial class HostForm
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
            if (disposing)
            {
                if (userControls is not null)
                {
                    foreach (var control in userControls)
                    {
                        control.Value?.Dispose();
                    }
                    userControls = null;
                }

                components?.Dispose();
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(HostForm));
            pluginMenuStrip = new PluginMenuStrip();
            mnuTools = new ToolStripMenuItem();
            mnuToolsChoosePlugins = new ToolStripMenuItem();
            mnuToolPluginSettings = new ToolStripMenuItem();
            pluginTreeView = new PluginTreeView();
            splitContainer = new SplitContainer();
            kryptonManager = new KryptonManager(components);
            pluginMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pluginMenuStrip
            // 
            pluginMenuStrip.Enabled = false;
            pluginMenuStrip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.World);
            pluginMenuStrip.Items.AddRange(new ToolStripItem[] { mnuTools });
            pluginMenuStrip.Location = new Point(0, 0);
            pluginMenuStrip.Name = "pluginMenuStrip";
            pluginMenuStrip.Padding = new Padding(7, 2, 0, 2);
            pluginMenuStrip.Size = new Size(1184, 24);
            pluginMenuStrip.TabIndex = 0;
            pluginMenuStrip.Text = "Menu";
            pluginMenuStrip.Visible = false;
            // 
            // mnuTools
            // 
            mnuTools.DropDownItems.AddRange(new ToolStripItem[] { mnuToolsChoosePlugins, mnuToolPluginSettings });
            mnuTools.Name = "mnuTools";
            mnuTools.Size = new Size(46, 20);
            mnuTools.Text = "Tools";
            // 
            // mnuToolsChoosePlugins
            // 
            mnuToolsChoosePlugins.Name = "mnuToolsChoosePlugins";
            mnuToolsChoosePlugins.Size = new Size(156, 22);
            mnuToolsChoosePlugins.Text = "Choose Plugins";
            mnuToolsChoosePlugins.Click += mnuToolsChoosePlugins_Click;
            // 
            // mnuToolPluginSettings
            // 
            mnuToolPluginSettings.Name = "mnuToolPluginSettings";
            mnuToolPluginSettings.Size = new Size(156, 22);
            mnuToolPluginSettings.Text = "Plugin Settings";
            mnuToolPluginSettings.Click += mnuToolsPluginSettings_Click;
            // 
            // pluginTreeView
            // 
            pluginTreeView.Dock = DockStyle.Fill;
            pluginTreeView.ImageIndex = 0;
            pluginTreeView.ImageListImageSize = new Size(32, 32);
            pluginTreeView.ItemHeight = 32;
            pluginTreeView.Location = new Point(0, 0);
            pluginTreeView.Margin = new Padding(4, 3, 4, 3);
            pluginTreeView.Name = "pluginTreeView";
            pluginTreeView.SelectedImageIndex = 0;
            pluginTreeView.Size = new Size(280, 681);
            pluginTreeView.TabIndex = 1;
            pluginTreeView.AfterSelect += pluginTreeView_AfterSelect;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Margin = new Padding(4, 3, 4, 3);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(pluginTreeView);
            splitContainer.Size = new Size(1184, 681);
            splitContainer.SplitterDistance = 280;
            splitContainer.SplitterWidth = 5;
            splitContainer.TabIndex = 2;
            // 
            // kryptonManager
            // 
            kryptonManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
            // 
            // HostForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 681);
            Controls.Add(splitContainer);
            Controls.Add(pluginMenuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = pluginMenuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "HostForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BBQ Toolkit";
            pluginMenuStrip.ResumeLayout(false);
            pluginMenuStrip.PerformLayout();
            splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PluginMenuStrip pluginMenuStrip;
        private PluginTreeView pluginTreeView;
        private SplitContainer splitContainer;
        private ToolStripMenuItem mnuTools;
        private ToolStripMenuItem mnuToolsChoosePlugins;
        private ToolStripMenuItem mnuToolPluginSettings;
        private KryptonManager kryptonManager;
    }
}

