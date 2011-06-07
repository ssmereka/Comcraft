namespace Comcraft
{
    partial class BuildCommand
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
            this.commandCoB = new System.Windows.Forms.ComboBox();
            this.commandPB = new System.Windows.Forms.PictureBox();
            this.option1CoB = new System.Windows.Forms.ComboBox();
            this.option1PB = new System.Windows.Forms.PictureBox();
            this.option2CoB = new System.Windows.Forms.ComboBox();
            this.option2PB = new System.Windows.Forms.PictureBox();
            this.option3CoB = new System.Windows.Forms.ComboBox();
            this.option3PB = new System.Windows.Forms.PictureBox();
            this.commandLV = new System.Windows.Forms.ListView();
            this.keybindingTxt = new System.Windows.Forms.TextBox();
            this.keybindingLbl = new System.Windows.Forms.Label();
            this.keybindingLV = new System.Windows.Forms.ListView();
            this.saveBtn = new System.Windows.Forms.Button();
            this.itemsBtn = new System.Windows.Forms.Button();
            this.usersBtn = new System.Windows.Forms.Button();
            this.commandBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.commandPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option1PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option2PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option3PB)).BeginInit();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // commandCoB
            // 
            this.commandCoB.FormattingEnabled = true;
            this.commandCoB.Location = new System.Drawing.Point(168, 69);
            this.commandCoB.Name = "commandCoB";
            this.commandCoB.Size = new System.Drawing.Size(150, 24);
            this.commandCoB.TabIndex = 0;
            // 
            // commandPB
            // 
            this.commandPB.Location = new System.Drawing.Point(218, 13);
            this.commandPB.Name = "commandPB";
            this.commandPB.Size = new System.Drawing.Size(50, 50);
            this.commandPB.TabIndex = 1;
            this.commandPB.TabStop = false;
            // 
            // option1CoB
            // 
            this.option1CoB.FormattingEnabled = true;
            this.option1CoB.Location = new System.Drawing.Point(324, 69);
            this.option1CoB.Name = "option1CoB";
            this.option1CoB.Size = new System.Drawing.Size(150, 24);
            this.option1CoB.TabIndex = 2;
            // 
            // option1PB
            // 
            this.option1PB.Location = new System.Drawing.Point(374, 13);
            this.option1PB.Name = "option1PB";
            this.option1PB.Size = new System.Drawing.Size(50, 50);
            this.option1PB.TabIndex = 3;
            this.option1PB.TabStop = false;
            // 
            // option2CoB
            // 
            this.option2CoB.FormattingEnabled = true;
            this.option2CoB.Location = new System.Drawing.Point(480, 69);
            this.option2CoB.Name = "option2CoB";
            this.option2CoB.Size = new System.Drawing.Size(150, 24);
            this.option2CoB.TabIndex = 4;
            // 
            // option2PB
            // 
            this.option2PB.Location = new System.Drawing.Point(530, 13);
            this.option2PB.Name = "option2PB";
            this.option2PB.Size = new System.Drawing.Size(50, 50);
            this.option2PB.TabIndex = 5;
            this.option2PB.TabStop = false;
            // 
            // option3CoB
            // 
            this.option3CoB.FormattingEnabled = true;
            this.option3CoB.Location = new System.Drawing.Point(636, 69);
            this.option3CoB.Name = "option3CoB";
            this.option3CoB.Size = new System.Drawing.Size(150, 24);
            this.option3CoB.TabIndex = 6;
            // 
            // option3PB
            // 
            this.option3PB.Location = new System.Drawing.Point(686, 13);
            this.option3PB.Name = "option3PB";
            this.option3PB.Size = new System.Drawing.Size(50, 50);
            this.option3PB.TabIndex = 7;
            this.option3PB.TabStop = false;
            // 
            // commandLV
            // 
            this.commandLV.Location = new System.Drawing.Point(168, 106);
            this.commandLV.Name = "commandLV";
            this.commandLV.Size = new System.Drawing.Size(616, 146);
            this.commandLV.TabIndex = 8;
            this.commandLV.UseCompatibleStateImageBehavior = false;
            // 
            // keybindingTxt
            // 
            this.keybindingTxt.Location = new System.Drawing.Point(12, 69);
            this.keybindingTxt.Name = "keybindingTxt";
            this.keybindingTxt.Size = new System.Drawing.Size(150, 22);
            this.keybindingTxt.TabIndex = 9;
            this.keybindingTxt.TextChanged += new System.EventHandler(this.keybindingTxt_TextChanged);
            this.keybindingTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keybindingTxt_KeyDown);
            this.keybindingTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keybindingTxt_KeyPress);
            this.keybindingTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keybindingTxt_KeyUp);
            // 
            // keybindingLbl
            // 
            this.keybindingLbl.AutoSize = true;
            this.keybindingLbl.Location = new System.Drawing.Point(39, 46);
            this.keybindingLbl.Name = "keybindingLbl";
            this.keybindingLbl.Size = new System.Drawing.Size(83, 17);
            this.keybindingLbl.TabIndex = 10;
            this.keybindingLbl.Text = "Key Binding";
            // 
            // keybindingLV
            // 
            this.keybindingLV.Location = new System.Drawing.Point(12, 106);
            this.keybindingLV.MultiSelect = false;
            this.keybindingLV.Name = "keybindingLV";
            this.keybindingLV.Size = new System.Drawing.Size(150, 146);
            this.keybindingLV.TabIndex = 17;
            this.keybindingLV.UseCompatibleStateImageBehavior = false;
            this.keybindingLV.View = System.Windows.Forms.View.List;
            this.keybindingLV.SelectedIndexChanged += new System.EventHandler(this.keybindingLV_SelectedIndexChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(636, 258);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(148, 32);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // itemsBtn
            // 
            this.itemsBtn.Location = new System.Drawing.Point(480, 258);
            this.itemsBtn.Name = "itemsBtn";
            this.itemsBtn.Size = new System.Drawing.Size(150, 32);
            this.itemsBtn.TabIndex = 21;
            this.itemsBtn.Text = "Items";
            this.itemsBtn.UseVisualStyleBackColor = true;
            this.itemsBtn.Click += new System.EventHandler(this.itemsBtn_Click);
            // 
            // usersBtn
            // 
            this.usersBtn.Location = new System.Drawing.Point(324, 258);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(150, 32);
            this.usersBtn.TabIndex = 23;
            this.usersBtn.Text = "Users";
            this.usersBtn.UseVisualStyleBackColor = true;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // commandBtn
            // 
            this.commandBtn.Location = new System.Drawing.Point(168, 258);
            this.commandBtn.Name = "commandBtn";
            this.commandBtn.Size = new System.Drawing.Size(150, 32);
            this.commandBtn.TabIndex = 22;
            this.commandBtn.Text = "Commands";
            this.commandBtn.UseVisualStyleBackColor = true;
            this.commandBtn.Click += new System.EventHandler(this.commandBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 258);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(150, 32);
            this.AddBtn.TabIndex = 24;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl});
            this.Status.Location = new System.Drawing.Point(0, 298);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(796, 25);
            this.Status.SizingGrip = false;
            this.Status.TabIndex = 25;
            this.Status.Text = "statusStrip1";
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(89, 20);
            this.statusLbl.Text = "Command:  ";
            // 
            // BuildCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 323);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.usersBtn);
            this.Controls.Add(this.commandBtn);
            this.Controls.Add(this.itemsBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.keybindingLV);
            this.Controls.Add(this.keybindingLbl);
            this.Controls.Add(this.keybindingTxt);
            this.Controls.Add(this.commandLV);
            this.Controls.Add(this.option3PB);
            this.Controls.Add(this.option3CoB);
            this.Controls.Add(this.option2PB);
            this.Controls.Add(this.option2CoB);
            this.Controls.Add(this.option1PB);
            this.Controls.Add(this.option1CoB);
            this.Controls.Add(this.commandPB);
            this.Controls.Add(this.commandCoB);
            this.Name = "BuildCommand";
            this.Text = "BuildCommand";
            ((System.ComponentModel.ISupportInitialize)(this.commandPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option1PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option2PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option3PB)).EndInit();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox commandCoB;
        private System.Windows.Forms.PictureBox commandPB;
        private System.Windows.Forms.ComboBox option1CoB;
        private System.Windows.Forms.PictureBox option1PB;
        private System.Windows.Forms.ComboBox option2CoB;
        private System.Windows.Forms.PictureBox option2PB;
        private System.Windows.Forms.ComboBox option3CoB;
        private System.Windows.Forms.PictureBox option3PB;
        private System.Windows.Forms.ListView commandLV;
        private System.Windows.Forms.TextBox keybindingTxt;
        private System.Windows.Forms.Label keybindingLbl;
        private System.Windows.Forms.ListView keybindingLV;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button itemsBtn;
        private System.Windows.Forms.Button usersBtn;
        private System.Windows.Forms.Button commandBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
    }
}