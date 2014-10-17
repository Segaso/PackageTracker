namespace PackageTracker
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.TabPackageRecieved = new System.Windows.Forms.TabPage();
            this.TabPackagePickup = new System.Windows.Forms.TabPage();
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 456);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(846, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.TabPackagePickup);
            this.MainTabControl.Controls.Add(this.TabPackageRecieved);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(8);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(846, 456);
            this.MainTabControl.TabIndex = 0;
            // 
            // TabPackageRecieved
            // 
            this.TabPackageRecieved.BackColor = System.Drawing.SystemColors.Control;
            this.TabPackageRecieved.Location = new System.Drawing.Point(4, 22);
            this.TabPackageRecieved.Name = "TabPackageRecieved";
            this.TabPackageRecieved.Padding = new System.Windows.Forms.Padding(3);
            this.TabPackageRecieved.Size = new System.Drawing.Size(833, 430);
            this.TabPackageRecieved.TabIndex = 1;
            this.TabPackageRecieved.Text = "Package Recieved";
            // 
            // TabPackagePickup
            // 
            this.TabPackagePickup.BackColor = System.Drawing.SystemColors.Control;
            this.TabPackagePickup.Location = new System.Drawing.Point(4, 22);
            this.TabPackagePickup.Name = "TabPackagePickup";
            this.TabPackagePickup.Padding = new System.Windows.Forms.Padding(3);
            this.TabPackagePickup.Size = new System.Drawing.Size(838, 430);
            this.TabPackagePickup.TabIndex = 0;
            this.TabPackagePickup.Text = "Package Pickup";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 478);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Mailroom Package Service";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage TabPackagePickup;
        private System.Windows.Forms.TabPage TabPackageRecieved;

    }
}

