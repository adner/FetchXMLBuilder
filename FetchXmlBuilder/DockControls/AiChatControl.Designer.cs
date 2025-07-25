﻿namespace Rappen.XTB.FetchXmlBuilder.DockControls
{
    partial class AiChatControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panOData = new System.Windows.Forms.Panel();
            this.splitAiChat = new System.Windows.Forms.SplitContainer();
            this.panAiConversation = new System.Windows.Forms.Panel();
            this.txtAiChat = new System.Windows.Forms.TextBox();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSupporting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDocs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnAiChatAsk = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panOData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitAiChat)).BeginInit();
            this.splitAiChat.Panel1.SuspendLayout();
            this.splitAiChat.Panel2.SuspendLayout();
            this.splitAiChat.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panOData
            // 
            this.panOData.BackColor = System.Drawing.SystemColors.Window;
            this.panOData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panOData.Controls.Add(this.splitAiChat);
            this.panOData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panOData.Location = new System.Drawing.Point(0, 0);
            this.panOData.Name = "panOData";
            this.panOData.Padding = new System.Windows.Forms.Padding(4);
            this.panOData.Size = new System.Drawing.Size(438, 373);
            this.panOData.TabIndex = 28;
            // 
            // splitAiChat
            // 
            this.splitAiChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitAiChat.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitAiChat.Location = new System.Drawing.Point(4, 4);
            this.splitAiChat.Name = "splitAiChat";
            this.splitAiChat.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitAiChat.Panel1
            // 
            this.splitAiChat.Panel1.AutoScroll = true;
            this.splitAiChat.Panel1.BackColor = System.Drawing.SystemColors.Info;
            this.splitAiChat.Panel1.Controls.Add(this.panAiConversation);
            // 
            // splitAiChat.Panel2
            // 
            this.splitAiChat.Panel2.AutoScroll = true;
            this.splitAiChat.Panel2.Controls.Add(this.txtAiChat);
            this.splitAiChat.Panel2.Controls.Add(this.txtUsage);
            this.splitAiChat.Panel2.Controls.Add(this.panel1);
            this.splitAiChat.Panel2MinSize = 40;
            this.splitAiChat.Size = new System.Drawing.Size(428, 363);
            this.splitAiChat.SplitterDistance = 258;
            this.splitAiChat.SplitterWidth = 8;
            this.splitAiChat.TabIndex = 13;
            // 
            // panAiConversation
            // 
            this.panAiConversation.AutoScroll = true;
            this.panAiConversation.AutoScrollMinSize = new System.Drawing.Size(16, 0);
            this.panAiConversation.AutoSize = true;
            this.panAiConversation.BackColor = System.Drawing.SystemColors.Window;
            this.panAiConversation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panAiConversation.Location = new System.Drawing.Point(0, 0);
            this.panAiConversation.Name = "panAiConversation";
            this.panAiConversation.Size = new System.Drawing.Size(428, 258);
            this.panAiConversation.TabIndex = 0;
            // 
            // txtAiChat
            // 
            this.txtAiChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAiChat.Location = new System.Drawing.Point(0, 0);
            this.txtAiChat.Multiline = true;
            this.txtAiChat.Name = "txtAiChat";
            this.txtAiChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAiChat.Size = new System.Drawing.Size(376, 84);
            this.txtAiChat.TabIndex = 1;
            this.txtAiChat.TextChanged += new System.EventHandler(this.txtAiChatAsk_TextChanged);
            this.txtAiChat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAiChatAsk_KeyDown);
            // 
            // txtUsage
            // 
            this.txtUsage.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUsage.Location = new System.Drawing.Point(0, 84);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.ReadOnly = true;
            this.txtUsage.Size = new System.Drawing.Size(376, 13);
            this.txtUsage.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnExecute);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnYes);
            this.panel1.Controls.Add(this.btnAiChatAsk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(376, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 97);
            this.panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.ContextMenuStrip = this.contextMenuStrip1;
            this.btnMenu.Image = global::Cinteros.Xrm.FetchXmlBuilder.Properties.Resources.icon_more_14;
            this.btnMenu.Location = new System.Drawing.Point(25, 73);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(22, 22);
            this.btnMenu.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnMenu, "Open menu to get more options\r\nfor the AI Chat, including\r\ndocumentation!");
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCopy,
            this.mnuSave,
            this.toolStripMenuItem1,
            this.mnuSettings,
            this.toolStripMenuItem2,
            this.mnuSupporting,
            this.toolStripMenuItem3,
            this.mnuDocs});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 132);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Image = global::Cinteros.Xrm.FetchXmlBuilder.Properties.Resources.icon_paste_16;
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.Size = new System.Drawing.Size(166, 22);
            this.mnuCopy.Text = "Copy dialog";
            this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Image = global::Cinteros.Xrm.FetchXmlBuilder.Properties.Resources.icon_save2_16;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(166, 22);
            this.mnuSave.Text = "Save dialog...";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 6);
            // 
            // mnuSettings
            // 
            this.mnuSettings.Image = global::Cinteros.Xrm.FetchXmlBuilder.Properties.Resources.icon_settings_16;
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(166, 22);
            this.mnuSettings.Text = "Settings...";
            this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(163, 6);
            // 
            // mnuSupporting
            // 
            this.mnuSupporting.Image = global::Cinteros.Xrm.FetchXmlBuilder.Properties.Resources.Supporting_bg_16;
            this.mnuSupporting.Name = "mnuSupporting";
            this.mnuSupporting.Size = new System.Drawing.Size(166, 22);
            this.mnuSupporting.Text = "Supporting...";
            this.mnuSupporting.Click += new System.EventHandler(this.mnuSupporting_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(163, 6);
            // 
            // mnuDocs
            // 
            this.mnuDocs.Image = global::Cinteros.Xrm.FetchXmlBuilder.Properties.Resources.icon_info_16;
            this.mnuDocs.Name = "mnuDocs";
            this.mnuDocs.Size = new System.Drawing.Size(166, 22);
            this.mnuDocs.Text = "Documentation...";
            this.mnuDocs.Click += new System.EventHandler(this.mnuDocs_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Image = global::Cinteros.Xrm.FetchXmlBuilder.Properties.Resources.icon_play_16;
            this.btnExecute.Location = new System.Drawing.Point(25, 51);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(22, 22);
            this.btnExecute.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnExecute, "Execute the query!");
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.SendChatToAI);
            // 
            // btnReset
            // 
            this.btnReset.Image = global::Cinteros.Xrm.FetchXmlBuilder.Properties.Resources.icon_reset_16;
            this.btnReset.Location = new System.Drawing.Point(3, 73);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(22, 22);
            this.btnReset.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnReset, "Reset all chat dialog");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnYes
            // 
            this.btnYes.Image = global::Cinteros.Xrm.FetchXmlBuilder.Properties.Resources.icon_yes_16;
            this.btnYes.Location = new System.Drawing.Point(3, 51);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(22, 22);
            this.btnYes.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnYes, "Yes please!\r\n<CTRL>+Y");
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.SendChatToAI);
            // 
            // btnAiChatAsk
            // 
            this.btnAiChatAsk.Enabled = false;
            this.btnAiChatAsk.Image = global::Cinteros.Xrm.FetchXmlBuilder.Properties.Resources.icon_bot_32;
            this.btnAiChatAsk.Location = new System.Drawing.Point(3, 3);
            this.btnAiChatAsk.Name = "btnAiChatAsk";
            this.btnAiChatAsk.Size = new System.Drawing.Size(44, 42);
            this.btnAiChatAsk.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAiChatAsk, "<CTRL>+Enter\r\nSend the query to the AI");
            this.btnAiChatAsk.UseVisualStyleBackColor = true;
            this.btnAiChatAsk.Click += new System.EventHandler(this.SendChatToAI);
            // 
            // AiChatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 373);
            this.Controls.Add(this.panOData);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)));
            this.Name = "AiChatControl";
            this.TabText = "AI Chat";
            this.Text = "AI Chat";
            this.DockStateChanged += new System.EventHandler(this.AiChatControl_DockStateChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AiChatControl_FormClosing);
            this.panOData.ResumeLayout(false);
            this.splitAiChat.Panel1.ResumeLayout(false);
            this.splitAiChat.Panel1.PerformLayout();
            this.splitAiChat.Panel2.ResumeLayout(false);
            this.splitAiChat.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitAiChat)).EndInit();
            this.splitAiChat.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panOData;
        private System.Windows.Forms.SplitContainer splitAiChat;
        private System.Windows.Forms.TextBox txtAiChat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAiChatAsk;
        private System.Windows.Forms.Panel panAiConversation;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuSupporting;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuDocs;
    }
}
