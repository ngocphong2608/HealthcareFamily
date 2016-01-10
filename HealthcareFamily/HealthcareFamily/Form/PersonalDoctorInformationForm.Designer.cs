using HealthcareFamilyGUI.FormArguments;
namespace HealthcareFamilyGUI
{
    partial class PersonalDoctorInformationForm
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
            this.lvwMeeting = new System.Windows.Forms.ListView();
            this.cmdOk = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new MetroFramework.Controls.MetroLabel();
            this.txtGender = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroLabel();
            this.txtUsername = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cmdDeleteMeeting = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdCreateMeeting = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.txtCurrentName = new MetroFramework.Controls.MetroLabel();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwMeeting
            // 
            this.lvwMeeting.Location = new System.Drawing.Point(23, 248);
            this.lvwMeeting.Name = "lvwMeeting";
            this.lvwMeeting.Size = new System.Drawing.Size(327, 159);
            this.lvwMeeting.TabIndex = 33;
            this.lvwMeeting.UseCompatibleStateImageBehavior = false;
            // 
            // cmdOk
            // 
            this.cmdOk.Image = null;
            this.cmdOk.Location = new System.Drawing.Point(108, 426);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(160, 35);
            this.cmdOk.TabIndex = 32;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseSelectable = true;
            this.cmdOk.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.txtGender);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.txtUsername);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(24, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 141);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(181, 109);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(83, 19);
            this.txtEmail.TabIndex = 22;
            this.txtEmail.Text = "metroLabel9";
            // 
            // txtGender
            // 
            this.txtGender.AutoSize = true;
            this.txtGender.Location = new System.Drawing.Point(181, 82);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(83, 19);
            this.txtGender.TabIndex = 21;
            this.txtGender.Text = "metroLabel8";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(181, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(83, 19);
            this.txtName.TabIndex = 20;
            this.txtName.Text = "metroLabel7";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Location = new System.Drawing.Point(181, 28);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(83, 19);
            this.txtUsername.TabIndex = 19;
            this.txtUsername.Text = "metroLabel6";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(38, 109);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 19);
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Email";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(38, 82);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 19);
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "Gender";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(38, 55);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Fullname";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(38, 28);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(68, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Username";
            // 
            // cmdDeleteMeeting
            // 
            this.cmdDeleteMeeting.Image = null;
            this.cmdDeleteMeeting.Location = new System.Drawing.Point(190, 207);
            this.cmdDeleteMeeting.Name = "cmdDeleteMeeting";
            this.cmdDeleteMeeting.Size = new System.Drawing.Size(160, 35);
            this.cmdDeleteMeeting.TabIndex = 30;
            this.cmdDeleteMeeting.Text = "Delete Meeting";
            this.cmdDeleteMeeting.UseSelectable = true;
            this.cmdDeleteMeeting.UseVisualStyleBackColor = true;
            // 
            // cmdCreateMeeting
            // 
            this.cmdCreateMeeting.Image = null;
            this.cmdCreateMeeting.Location = new System.Drawing.Point(23, 207);
            this.cmdCreateMeeting.Name = "cmdCreateMeeting";
            this.cmdCreateMeeting.Size = new System.Drawing.Size(160, 35);
            this.cmdCreateMeeting.TabIndex = 29;
            this.cmdCreateMeeting.Text = "Create Meeting";
            this.cmdCreateMeeting.UseSelectable = true;
            this.cmdCreateMeeting.UseVisualStyleBackColor = true;
            // 
            // txtCurrentName
            // 
            this.txtCurrentName.AutoSize = true;
            this.txtCurrentName.Location = new System.Drawing.Point(241, 29);
            this.txtCurrentName.Name = "txtCurrentName";
            this.txtCurrentName.Size = new System.Drawing.Size(81, 19);
            this.txtCurrentName.TabIndex = 27;
            this.txtCurrentName.Text = "metroLabel1";
            // 
            // PersonalDoctorInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 480);
            this.Controls.Add(this.lvwMeeting);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmdDeleteMeeting);
            this.Controls.Add(this.cmdCreateMeeting);
            this.Controls.Add(this.txtCurrentName);
            this.MaximizeBox = false;
            this.Name = "PersonalDoctorInformationForm";
            this.Resizable = false;
            this.Text = "Personal Information";
            this.Load += new System.EventHandler(this.PersonalDoctorInformationForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwMeeting;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdOk;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel txtEmail;
        private MetroFramework.Controls.MetroLabel txtGender;
        private MetroFramework.Controls.MetroLabel txtName;
        private MetroFramework.Controls.MetroLabel txtUsername;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdDeleteMeeting;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdCreateMeeting;
        private MetroFramework.Controls.MetroLabel txtCurrentName;
        private UserInformationFormArguments Arguments;
    }
}