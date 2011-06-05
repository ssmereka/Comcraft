namespace Comcraft
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMMI = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMMI = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildCommandsMMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CommandsMMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemsMMI = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersMMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OptionsMMI = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMMI = new System.Windows.Forms.ToolStripMenuItem();
            this.HowToMMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutMMI = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMMI,
            this.EditMMI,
            this.ViewMMI,
            this.HelpMMI});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(213, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // FileMMI
            // 
            this.FileMMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.ExitMMI});
            this.FileMMI.Name = "FileMMI";
            this.FileMMI.Size = new System.Drawing.Size(44, 24);
            this.FileMMI.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // ExitMMI
            // 
            this.ExitMMI.Name = "ExitMMI";
            this.ExitMMI.Size = new System.Drawing.Size(152, 24);
            this.ExitMMI.Text = "Exit";
            this.ExitMMI.Click += new System.EventHandler(this.ExitMMI_Click);
            // 
            // EditMMI
            // 
            this.EditMMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuildCommandsMMI});
            this.EditMMI.Name = "EditMMI";
            this.EditMMI.Size = new System.Drawing.Size(47, 24);
            this.EditMMI.Text = "Edit";
            // 
            // BuildCommandsMMI
            // 
            this.BuildCommandsMMI.Name = "BuildCommandsMMI";
            this.BuildCommandsMMI.Size = new System.Drawing.Size(191, 24);
            this.BuildCommandsMMI.Text = "Build Commands";
            this.BuildCommandsMMI.Click += new System.EventHandler(this.BuildCommandsMMI_Click);
            // 
            // ViewMMI
            // 
            this.ViewMMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CommandsMMI,
            this.ItemsMMI,
            this.UsersMMI,
            this.toolStripSeparator2,
            this.OptionsMMI});
            this.ViewMMI.Name = "ViewMMI";
            this.ViewMMI.Size = new System.Drawing.Size(53, 24);
            this.ViewMMI.Text = "View";
            // 
            // CommandsMMI
            // 
            this.CommandsMMI.Name = "CommandsMMI";
            this.CommandsMMI.Size = new System.Drawing.Size(153, 24);
            this.CommandsMMI.Text = "Commands";
            this.CommandsMMI.Click += new System.EventHandler(this.CommandsMMI_Click);
            // 
            // ItemsMMI
            // 
            this.ItemsMMI.Name = "ItemsMMI";
            this.ItemsMMI.Size = new System.Drawing.Size(153, 24);
            this.ItemsMMI.Text = "Items";
            this.ItemsMMI.Click += new System.EventHandler(this.ItemsMMI_Click);
            // 
            // UsersMMI
            // 
            this.UsersMMI.Name = "UsersMMI";
            this.UsersMMI.Size = new System.Drawing.Size(153, 24);
            this.UsersMMI.Text = "Users";
            this.UsersMMI.Click += new System.EventHandler(this.UsersMMI_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
            // 
            // OptionsMMI
            // 
            this.OptionsMMI.Name = "OptionsMMI";
            this.OptionsMMI.Size = new System.Drawing.Size(153, 24);
            this.OptionsMMI.Text = "Options";
            // 
            // HelpMMI
            // 
            this.HelpMMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HowToMMI,
            this.toolStripSeparator3,
            this.AboutMMI});
            this.HelpMMI.Name = "HelpMMI";
            this.HelpMMI.Size = new System.Drawing.Size(53, 24);
            this.HelpMMI.Text = "Help";
            // 
            // HowToMMI
            // 
            this.HowToMMI.Name = "HowToMMI";
            this.HowToMMI.Size = new System.Drawing.Size(152, 24);
            this.HowToMMI.Text = "How to";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // AboutMMI
            // 
            this.AboutMMI.Name = "AboutMMI";
            this.AboutMMI.Size = new System.Drawing.Size(152, 24);
            this.AboutMMI.Text = "About";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLbl});
            this.StatusStrip.Location = new System.Drawing.Point(0, 26);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(213, 25);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusLbl
            // 
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(60, 20);
            this.StatusLbl.Text = "Status:  ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 51);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.8D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Comcraft";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitMMI;
        private System.Windows.Forms.ToolStripMenuItem EditMMI;
        private System.Windows.Forms.ToolStripMenuItem BuildCommandsMMI;
        private System.Windows.Forms.ToolStripMenuItem ViewMMI;
        private System.Windows.Forms.ToolStripMenuItem CommandsMMI;
        private System.Windows.Forms.ToolStripMenuItem ItemsMMI;
        private System.Windows.Forms.ToolStripMenuItem UsersMMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem OptionsMMI;
        private System.Windows.Forms.ToolStripMenuItem HelpMMI;
        private System.Windows.Forms.ToolStripMenuItem HowToMMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem AboutMMI;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLbl;
    }
}

