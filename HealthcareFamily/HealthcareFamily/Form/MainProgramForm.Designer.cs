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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmdEmergency = new System.Windows.Forms.Button();
            this.cmdAddUser = new System.Windows.Forms.Button();
            this.lvwUserList = new System.Windows.Forms.ListView();
            this.cmdProfile = new System.Windows.Forms.Button();
            this.cmdRefesh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlAvatar
            // 
            this.pnlAvatar.Location = new System.Drawing.Point(13, 13);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Size = new System.Drawing.Size(65, 75);
            this.pnlAvatar.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.Location = new System.Drawing.Point(84, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Name";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.Control;
            this.txtAge.Location = new System.Drawing.Point(84, 39);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(136, 20);
            this.txtAge.TabIndex = 2;
            this.txtAge.Text = "Age";
            // 
            // cmdEmergency
            // 
            this.cmdEmergency.Enabled = false;
            this.cmdEmergency.Location = new System.Drawing.Point(13, 98);
            this.cmdEmergency.Name = "cmdEmergency";
            this.cmdEmergency.Size = new System.Drawing.Size(92, 23);
            this.cmdEmergency.TabIndex = 3;
            this.cmdEmergency.Text = "Emergency";
            this.cmdEmergency.UseVisualStyleBackColor = true;
            // 
            // cmdAddUser
            // 
            this.cmdAddUser.Location = new System.Drawing.Point(121, 98);
            this.cmdAddUser.Name = "cmdAddUser";
            this.cmdAddUser.Size = new System.Drawing.Size(99, 23);
            this.cmdAddUser.TabIndex = 4;
            this.cmdAddUser.Text = "Add user";
            this.cmdAddUser.UseVisualStyleBackColor = true;
            this.cmdAddUser.Click += new System.EventHandler(this.cmdAddUser_Click);
            // 
            // lvwUserList
            // 
            this.lvwUserList.Location = new System.Drawing.Point(13, 133);
            this.lvwUserList.Name = "lvwUserList";
            this.lvwUserList.Size = new System.Drawing.Size(207, 233);
            this.lvwUserList.TabIndex = 5;
            this.lvwUserList.UseCompatibleStateImageBehavior = false;
            // 
            // cmdProfile
            // 
            this.cmdProfile.Location = new System.Drawing.Point(84, 65);
            this.cmdProfile.Name = "cmdProfile";
            this.cmdProfile.Size = new System.Drawing.Size(70, 23);
            this.cmdProfile.TabIndex = 6;
            this.cmdProfile.Text = "Profile";
            this.cmdProfile.UseVisualStyleBackColor = true;
            this.cmdProfile.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdRefesh
            // 
            this.cmdRefesh.Location = new System.Drawing.Point(160, 65);
            this.cmdRefesh.Name = "cmdRefesh";
            this.cmdRefesh.Size = new System.Drawing.Size(60, 23);
            this.cmdRefesh.TabIndex = 7;
            this.cmdRefesh.Text = "Refesh";
            this.cmdRefesh.UseVisualStyleBackColor = true;
            // 
            // MainProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 378);
            this.Controls.Add(this.cmdRefesh);
            this.Controls.Add(this.cmdProfile);
            this.Controls.Add(this.lvwUserList);
            this.Controls.Add(this.cmdAddUser);
            this.Controls.Add(this.cmdEmergency);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pnlAvatar);
            this.MaximizeBox = false;
            this.Name = "MainProgramForm";
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button cmdEmergency;
        private System.Windows.Forms.Button cmdAddUser;
        private System.Windows.Forms.ListView lvwUserList;
        private System.Windows.Forms.Button cmdProfile;
        private System.Windows.Forms.Button cmdRefesh;
    }
}