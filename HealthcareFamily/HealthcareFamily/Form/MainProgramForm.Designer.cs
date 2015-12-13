namespace HealthcareFamily
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
            this.cmdEmergency = new System.Windows.Forms.Button();
            this.cmdAddUser = new System.Windows.Forms.Button();
            this.lvwUserList = new System.Windows.Forms.ListView();
            this.cmdProfile = new System.Windows.Forms.Button();
            this.cmdRefesh = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.Label();
            this.cmdMeeting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlAvatar
            // 
            this.pnlAvatar.Location = new System.Drawing.Point(13, 13);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Size = new System.Drawing.Size(65, 75);
            this.pnlAvatar.TabIndex = 0;
            // 
            // cmdEmergency
            // 
            this.cmdEmergency.Enabled = false;
            this.cmdEmergency.Location = new System.Drawing.Point(116, 98);
            this.cmdEmergency.Name = "cmdEmergency";
            this.cmdEmergency.Size = new System.Drawing.Size(92, 23);
            this.cmdEmergency.TabIndex = 3;
            this.cmdEmergency.Text = "Emergency";
            this.cmdEmergency.UseVisualStyleBackColor = true;
            // 
            // cmdAddUser
            // 
            this.cmdAddUser.Location = new System.Drawing.Point(214, 98);
            this.cmdAddUser.Name = "cmdAddUser";
            this.cmdAddUser.Size = new System.Drawing.Size(99, 23);
            this.cmdAddUser.TabIndex = 4;
            this.cmdAddUser.Text = "Add user";
            this.cmdAddUser.UseVisualStyleBackColor = true;
            this.cmdAddUser.Click += new System.EventHandler(this.cmdAddUser_Click);
            // 
            // lvwUserList
            // 
            this.lvwUserList.Location = new System.Drawing.Point(14, 130);
            this.lvwUserList.Name = "lvwUserList";
            this.lvwUserList.Size = new System.Drawing.Size(300, 450);
            this.lvwUserList.TabIndex = 5;
            this.lvwUserList.UseCompatibleStateImageBehavior = false;
            this.lvwUserList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvwUserList_ItemCheck);
            this.lvwUserList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvwUserList_ItemChecked);
            this.lvwUserList.DoubleClick += new System.EventHandler(this.lvwUserList_DoubleClick);
            this.lvwUserList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwUserList_MouseDoubleClick);
            // 
            // cmdProfile
            // 
            this.cmdProfile.Location = new System.Drawing.Point(226, 13);
            this.cmdProfile.Name = "cmdProfile";
            this.cmdProfile.Size = new System.Drawing.Size(85, 23);
            this.cmdProfile.TabIndex = 6;
            this.cmdProfile.Text = "Profile";
            this.cmdProfile.UseVisualStyleBackColor = true;
            this.cmdProfile.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdRefesh
            // 
            this.cmdRefesh.Location = new System.Drawing.Point(226, 53);
            this.cmdRefesh.Name = "cmdRefesh";
            this.cmdRefesh.Size = new System.Drawing.Size(85, 23);
            this.cmdRefesh.TabIndex = 7;
            this.cmdRefesh.Text = "Refesh";
            this.cmdRefesh.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(101, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(35, 13);
            this.txtName.TabIndex = 8;
            this.txtName.Text = "Name";
            // 
            // txtAge
            // 
            this.txtAge.AutoSize = true;
            this.txtAge.Location = new System.Drawing.Point(101, 53);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(26, 13);
            this.txtAge.TabIndex = 9;
            this.txtAge.Text = "Age";
            // 
            // cmdMeeting
            // 
            this.cmdMeeting.Location = new System.Drawing.Point(13, 98);
            this.cmdMeeting.Name = "cmdMeeting";
            this.cmdMeeting.Size = new System.Drawing.Size(97, 23);
            this.cmdMeeting.TabIndex = 10;
            this.cmdMeeting.Text = "Meeting";
            this.cmdMeeting.UseVisualStyleBackColor = true;
            // 
            // MainProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 594);
            this.Controls.Add(this.cmdMeeting);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmdRefesh);
            this.Controls.Add(this.cmdProfile);
            this.Controls.Add(this.lvwUserList);
            this.Controls.Add(this.cmdAddUser);
            this.Controls.Add(this.cmdEmergency);
            this.Controls.Add(this.pnlAvatar);
            this.MaximizeBox = false;
            this.Name = "MainProgramForm";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainProgramForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.Button cmdEmergency;
        private System.Windows.Forms.Button cmdAddUser;
        private System.Windows.Forms.ListView lvwUserList;
        private System.Windows.Forms.Button cmdProfile;
        private System.Windows.Forms.Button cmdRefesh;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtAge;
        private System.Windows.Forms.Button cmdMeeting;
    }
}