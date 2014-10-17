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
            this.TabPackagePickup = new System.Windows.Forms.TabPage();
            this.TabPackageRecieved = new System.Windows.Forms.TabPage();
            this.AccountPhoto = new System.Windows.Forms.PictureBox();
            this.gbAccountInformation = new System.Windows.Forms.GroupBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.gbPackageInformation = new System.Windows.Forms.GroupBox();
            this.MainTabControl.SuspendLayout();
            this.TabPackagePickup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountPhoto)).BeginInit();
            this.gbAccountInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 434);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(513, 22);
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
            this.MainTabControl.Size = new System.Drawing.Size(513, 434);
            this.MainTabControl.TabIndex = 0;
            // 
            // TabPackagePickup
            // 
            this.TabPackagePickup.BackColor = System.Drawing.SystemColors.Control;
            this.TabPackagePickup.Controls.Add(this.gbPackageInformation);
            this.TabPackagePickup.Controls.Add(this.gbAccountInformation);
            this.TabPackagePickup.Location = new System.Drawing.Point(4, 22);
            this.TabPackagePickup.Name = "TabPackagePickup";
            this.TabPackagePickup.Padding = new System.Windows.Forms.Padding(3);
            this.TabPackagePickup.Size = new System.Drawing.Size(505, 408);
            this.TabPackagePickup.TabIndex = 0;
            this.TabPackagePickup.Text = "Package Pickup";
            // 
            // TabPackageRecieved
            // 
            this.TabPackageRecieved.BackColor = System.Drawing.SystemColors.Control;
            this.TabPackageRecieved.Location = new System.Drawing.Point(4, 22);
            this.TabPackageRecieved.Name = "TabPackageRecieved";
            this.TabPackageRecieved.Padding = new System.Windows.Forms.Padding(3);
            this.TabPackageRecieved.Size = new System.Drawing.Size(505, 408);
            this.TabPackageRecieved.TabIndex = 1;
            this.TabPackageRecieved.Text = "Package Recieved";
            // 
            // AccountPhoto
            // 
            this.AccountPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AccountPhoto.Location = new System.Drawing.Point(6, 19);
            this.AccountPhoto.Name = "AccountPhoto";
            this.AccountPhoto.Size = new System.Drawing.Size(131, 165);
            this.AccountPhoto.TabIndex = 0;
            this.AccountPhoto.TabStop = false;
            // 
            // gbAccountInformation
            // 
            this.gbAccountInformation.Controls.Add(this.lblCardNumber);
            this.gbAccountInformation.Controls.Add(this.txtCardNumber);
            this.gbAccountInformation.Controls.Add(this.lblID);
            this.gbAccountInformation.Controls.Add(this.txtID);
            this.gbAccountInformation.Controls.Add(this.textBox1);
            this.gbAccountInformation.Controls.Add(this.txtLastName);
            this.gbAccountInformation.Controls.Add(this.lblLastName);
            this.gbAccountInformation.Controls.Add(this.lblFirstName);
            this.gbAccountInformation.Controls.Add(this.AccountPhoto);
            this.gbAccountInformation.Location = new System.Drawing.Point(8, 6);
            this.gbAccountInformation.Name = "gbAccountInformation";
            this.gbAccountInformation.Size = new System.Drawing.Size(490, 192);
            this.gbAccountInformation.TabIndex = 1;
            this.gbAccountInformation.TabStop = false;
            this.gbAccountInformation.Text = "Account Information";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(157, 19);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Firstname:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(156, 45);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Lastname:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(218, 16);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(264, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 20);
            this.textBox1.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(218, 69);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(264, 20);
            this.txtID.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(191, 72);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID:";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(218, 95);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(264, 20);
            this.txtCardNumber.TabIndex = 7;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(145, 98);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(67, 13);
            this.lblCardNumber.TabIndex = 8;
            this.lblCardNumber.Text = "Cardnumber:";
            // 
            // gbPackageInformation
            // 
            this.gbPackageInformation.Location = new System.Drawing.Point(8, 204);
            this.gbPackageInformation.Name = "gbPackageInformation";
            this.gbPackageInformation.Size = new System.Drawing.Size(490, 193);
            this.gbPackageInformation.TabIndex = 2;
            this.gbPackageInformation.TabStop = false;
            this.gbPackageInformation.Text = "Packages";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 456);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Mailroom Package Service";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MainTabControl.ResumeLayout(false);
            this.TabPackagePickup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountPhoto)).EndInit();
            this.gbAccountInformation.ResumeLayout(false);
            this.gbAccountInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage TabPackagePickup;
        private System.Windows.Forms.TabPage TabPackageRecieved;
        private System.Windows.Forms.GroupBox gbPackageInformation;
        private System.Windows.Forms.GroupBox gbAccountInformation;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.PictureBox AccountPhoto;

    }
}

