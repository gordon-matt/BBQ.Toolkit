using BBQ.Toolkit.Controls;
using Krypton.Toolkit;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostForm));
            this.pluginMenuStrip = new BBQ.Toolkit.Controls.PluginMenuStrip();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsChoosePlugins = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolPluginSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginTreeView = new BBQ.Toolkit.Controls.PluginTreeView();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.kryptonManager = new Krypton.Toolkit.KryptonManager(this.components);
            this.pluginMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pluginMenuStrip
            // 
            this.pluginMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.pluginMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTools});
            this.pluginMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.pluginMenuStrip.Name = "pluginMenuStrip";
            this.pluginMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.pluginMenuStrip.Size = new System.Drawing.Size(1475, 24);
            this.pluginMenuStrip.TabIndex = 0;
            this.pluginMenuStrip.Text = "pluginMenuStrip1";
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsChoosePlugins,
            this.mnuToolPluginSettings});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(46, 20);
            this.mnuTools.Text = "Tools";
            // 
            // mnuToolsChoosePlugins
            // 
            this.mnuToolsChoosePlugins.Name = "mnuToolsChoosePlugins";
            this.mnuToolsChoosePlugins.Size = new System.Drawing.Size(156, 22);
            this.mnuToolsChoosePlugins.Text = "Choose Plugins";
            this.mnuToolsChoosePlugins.Click += new System.EventHandler(this.mnuToolsChoosePlugins_Click);
            // 
            // mnuToolPluginSettings
            // 
            this.mnuToolPluginSettings.Name = "mnuToolPluginSettings";
            this.mnuToolPluginSettings.Size = new System.Drawing.Size(156, 22);
            this.mnuToolPluginSettings.Text = "Plugin Settings";
            this.mnuToolPluginSettings.Click += new System.EventHandler(this.mnuToolsPluginSettings_Click);
            // 
            // pluginTreeView
            // 
            this.pluginTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pluginTreeView.ImageIndex = 0;
            this.pluginTreeView.ImageListImageSize = new System.Drawing.Size(32, 32);
            this.pluginTreeView.ItemHeight = 32;
            this.pluginTreeView.Location = new System.Drawing.Point(0, 0);
            this.pluginTreeView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pluginTreeView.Name = "pluginTreeView";
            this.pluginTreeView.SelectedImageIndex = 0;
            this.pluginTreeView.Size = new System.Drawing.Size(397, 762);
            this.pluginTreeView.TabIndex = 1;
            this.pluginTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.pluginTreeView_AfterSelect);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pluginTreeView);
            this.splitContainer.Size = new System.Drawing.Size(1475, 762);
            this.splitContainer.SplitterDistance = 397;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 2;
            // 
            // kryptonManager
            // 
            this.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.ProfessionalSystem;
            // 
            // HostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 786);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.pluginMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.pluginMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BBQ Toolkit";
            this.pluginMenuStrip.ResumeLayout(false);
            this.pluginMenuStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PluginMenuStrip pluginMenuStrip;
        private PluginTreeView pluginTreeView;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuToolsChoosePlugins;
        private System.Windows.Forms.ToolStripMenuItem mnuToolPluginSettings;
        private KryptonManager kryptonManager;
    }
}

