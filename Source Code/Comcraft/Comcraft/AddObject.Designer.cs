namespace Comcraft
{
    partial class AddObject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddObject));
            this.ObjectLV = new System.Windows.Forms.ListView();
            this.SearchCoB = new Comcraft.AutoCompleteComboBox();
            this.SuspendLayout();
            // 
            // ObjectLV
            // 
            this.ObjectLV.AllowDrop = true;
            this.ObjectLV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectLV.Location = new System.Drawing.Point(12, 12);
            this.ObjectLV.Name = "ObjectLV";
            this.ObjectLV.Size = new System.Drawing.Size(658, 375);
            this.ObjectLV.TabIndex = 1;
            this.ObjectLV.UseCompatibleStateImageBehavior = false;
            this.ObjectLV.SelectedIndexChanged += new System.EventHandler(this.ObjectLV_SelectedIndexChanged);
            // 
            // SearchCoB
            // 
            this.SearchCoB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchCoB.FormattingEnabled = true;
            this.SearchCoB.Location = new System.Drawing.Point(12, 393);
            this.SearchCoB.Name = "SearchCoB";
            this.SearchCoB.Size = new System.Drawing.Size(658, 24);
            this.SearchCoB.Sorted = true;
            this.SearchCoB.TabIndex = 0;
            // 
            // AddObject
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 429);
            this.Controls.Add(this.ObjectLV);
            this.Controls.Add(this.SearchCoB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddObject";
            this.ShowInTaskbar = false;
            this.Text = "AddObject";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddObject_FormClosing);
            this.Load += new System.EventHandler(this.AddObject_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ObjectLV;
        private AutoCompleteComboBox SearchCoB;
    }
}