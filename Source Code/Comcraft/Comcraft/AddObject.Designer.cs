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
            this.SearchCoB = new System.Windows.Forms.ComboBox();
            this.ObjectLV = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // SearchCoB
            // 
            this.SearchCoB.FormattingEnabled = true;
            this.SearchCoB.Location = new System.Drawing.Point(12, 393);
            this.SearchCoB.Name = "SearchCoB";
            this.SearchCoB.Size = new System.Drawing.Size(686, 24);
            this.SearchCoB.TabIndex = 0;
            // 
            // ObjectLV
            // 
            this.ObjectLV.Location = new System.Drawing.Point(12, 12);
            this.ObjectLV.Name = "ObjectLV";
            this.ObjectLV.Size = new System.Drawing.Size(686, 375);
            this.ObjectLV.TabIndex = 1;
            this.ObjectLV.UseCompatibleStateImageBehavior = false;
            // 
            // AddObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 429);
            this.Controls.Add(this.ObjectLV);
            this.Controls.Add(this.SearchCoB);
            this.Name = "AddObject";
            this.Text = "AddObject";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SearchCoB;
        private System.Windows.Forms.ListView ObjectLV;
    }
}