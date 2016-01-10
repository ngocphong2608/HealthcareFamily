namespace HealthcareFamilyGUI
{
    partial class MainProgramForm
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
            this.pnlAvatar = new System.Windows.Forms.Panel();
            this.lvwUserList = new System.Windows.Forms.ListView();
            this.cmdProfile = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdMeeting = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdEmergency = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdAddUser = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdNotification = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdRequestNewUser = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.txtName = new MetroFramework.Controls.MetroLabel();
            this.txtAge = new MetroFramework.Controls.MetroLabel();
            this.txtStatus = new MetroFramework.Controls.MetroLabel();
            this.cmdLogout = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.SuspendLayout();
            // 
            // pnlAvatar
            // 
            this.pnlAvatar.Location = new System.Drawing.Point(24, 65);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Size = new System.Drawing.Size(74, 71);
            this.pnlAvatar.TabIndex = 0;
            // 
            // lvwUserList
            // 
            this.lvwUserList.Location = new System.Drawing.Point(23, 273);
            this.lvwUserList.Name = "lvwUserList";
            this.lvwUserList.Size = new System.Drawing.Size(329, 433);
            this.lvwUserList.TabIndex = 5;
            this.lvwUserList.UseCompatibleStateImageBehavior = false;
            this.lvwUserList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvwUserList_ItemCheck);
            this.lvwUserList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvwUserList_ItemChecked);
            this.lvwUserList.DoubleClick += new System.EventHandler(this.lvwUserList_DoubleClick);
            this.lvwUserList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwUserList_MouseClick);
            // 
            // cmdProfile
            // 
            this.cmdProfile.Image = null;
            this.cmdProfile.Location = new System.Drawing.Point(210, 56);
            this.cmdProfile.Name = "cmdProfile";
            this.cmdProfile.Size = new System.Drawing.Size(142, 32);
            this.cmdProfile.TabIndex = 11;
            this.cmdProfile.Text = "Profile";
            this.cmdProfile.UseSelectable = true;
            this.cmdProfile.UseVisualStyleBackColor = true;
            this.cmdProfile.Click += new System.EventHandler(this.cmdProfile_Click);
            // 
            // cmdMeeting
            // 
            this.cmdMeeting.Image = null;
            this.cmdMeeting.Location = new System.Drawing.Point(24, 197);
            this.cmdMeeting.Name = "cmdMeeting";
            this.cmdMeeting.Size = new System.Drawing.Size(156, 32);
            this.cmdMeeting.TabIndex = 12;
            this.cmdMeeting.Text = "Meeting";
            this.cmdMeeting.UseSelectable = true;
            this.cmdMeeting.UseVisualStyleBackColor = true;
            this.cmdMeeting.Click += new System.EventHandler(this.cmdMeeting_Click);
            // 
            // cmdEmergency
            // 
            this.cmdEmergency.Image = null;
            this.cmdEmergency.Location = new System.Drawing.Point(186, 197);
            this.cmdEmergency.Name = "cmdEmergency";
            this.cmdEmergency.Size = new System.Drawing.Size(166, 32);
            this.cmdEmergency.TabIndex = 13;
            this.cmdEmergency.Text = "Emergency";
            this.cmdEmergency.UseSelectable = true;
            this.cmdEmergency.UseVisualStyleBackColor = true;
            this.cmdEmergency.Click += new System.EventHandler(this.cmdEmergency_Click);
            // 
            // cmdAddUser
            // 
            this.cmdAddUser.Image = null;
            this.cmdAddUser.Location = new System.Drawing.Point(23, 235);
            this.cmdAddUser.Name = "cmdAddUser";
            this.cmdAddUser.Size = new System.Drawing.Size(157, 32);
            this.cmdAddUser.TabIndex = 14;
            this.cmdAddUser.Text = "Add New User";
            this.cmdAddUser.UseSelectable = true;
            this.cmdAddUser.UseVisualStyleBackColor = true;
            this.cmdAddUser.Click += new System.EventHandler(this.cmdAddUser_Click);
            // 
            // cmdNotification
            // 
            this.cmdNotification.Image = null;
            this.cmdNotification.Location = new System.Drawing.Point(210, 94);
            this.cmdNotification.Name = "cmdNotification";
            this.cmdNotification.Size = new System.Drawing.Size(142, 32);
            this.cmdNotification.TabIndex = 15;
            this.cmdNotification.Text = "Notification";
            this.cmdNotification.UseSelectable = true;
            this.cmdNotification.UseVisualStyleBackColor = true;
            this.cmdNotification.Click += new System.EventHandler(this.cmdNotification_Click);
            // 
            // cmdRequestNewUser
            // 
            this.cmdRequestNewUser.Image = null;
            this.cmdRequestNewUser.Location = new System.Drawing.Point(186, 235);
            this.cmdRequestNewUser.Name = "cmdRequestNewUser";
            this.cmdRequestNewUser.Size = new System.Drawing.Size(166, 32);
            this.cmdRequestNewUser.TabIndex = 16;
            this.cmdRequestNewUser.Text = "Request New User";
            this.cmdRequestNewUser.UseSelectable = true;
            this.cmdRequestNewUser.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(105, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(81, 19);
            this.txtName.TabIndex = 17;
            this.txtName.Text = "metroLabel1";
            // 
            // txtAge
            // 
            this.txtAge.AutoSize = true;
            this.txtAge.Location = new System.Drawing.Point(105, 93);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(83, 19);
            this.txtAge.TabIndex = 18;
            this.txtAge.Text = "metroLabel2";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(105, 121);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(83, 19);
            this.txtStatus.TabIndex = 19;
            this.txtStatus.Text = "metroLabel3";
            // 
            // cmdLogout
            // 
            this.cmdLogout.Image = null;
            this.cmdLogout.Location = new System.Drawing.Point(210, 132);
            this.cmdLogout.Name = "cmdLogout";
            this.cmdLogout.Size = new System.Drawing.Size(142, 32);
            this.cmdLogout.TabIndex = 21;
            this.cmdLogout.Text = "Logout";
            this.cmdLogout.UseSelectable = true;
            this.cmdLogout.UseVisualStyleBackColor = true;
            this.cmdLogout.Click += new System.EventHandler(this.cmdLogout_Click);
            // 
            // MainProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 729);
            this.Controls.Add(this.cmdLogout);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmdRequestNewUser);
            this.Controls.Add(this.cmdNotification);
            this.Controls.Add(this.cmdAddUser);
            this.Controls.Add(this.cmdEmergency);
            this.Controls.Add(this.cmdMeeting);
            this.Controls.Add(this.cmdProfile);
            this.Controls.Add(this.lvwUserList);
            this.Controls.Add(this.pnlAvatar);
            this.MaximizeBox = false;
            this.Name = "MainProgramForm";
            this.Resizable = false;
            this.Text = "MainPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainProgramForm_FormClosing);
            this.Load += new System.EventHandler(this.MainProgramForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.ListView lvwUserList;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdProfile;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdMeeting;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdEmergency;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdAddUser;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdNotification;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdRequestNewUser;
        private MetroFramework.Controls.MetroLabel txtName;
        private MetroFramework.Controls.MetroLabel txtAge;
        private MetroFramework.Controls.MetroLabel txtStatus;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdLogout;
    }
}