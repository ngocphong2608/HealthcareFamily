using HealthcareFamilyGUI.FormArguments;
using System;
namespace HealthcareFamilyGUI
{
    partial class PersonalFamilyInformationForm
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
            this.cmdOk = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.Gruopbox4 = new System.Windows.Forms.GroupBox();
            this.txtEmotion = new MetroFramework.Controls.MetroLabel();
            this.txtHeartBeat = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new MetroFramework.Controls.MetroLabel();
            this.txtFullname = new MetroFramework.Controls.MetroLabel();
            this.txtUsername = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCheckHeathCare = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.txtCurrentName = new MetroFramework.Controls.MetroLabel();
            this.lvwHeathcareInfo = new System.Windows.Forms.ListView();
            this.Gruopbox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdOk
            // 
            this.cmdOk.Image = null;
            this.cmdOk.Location = new System.Drawing.Point(111, 556);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(160, 35);
            this.cmdOk.TabIndex = 31;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseSelectable = true;
            this.cmdOk.UseVisualStyleBackColor = true;
            // 
            // Gruopbox4
            // 
            this.Gruopbox4.Controls.Add(this.txtEmotion);
            this.Gruopbox4.Controls.Add(this.txtHeartBeat);
            this.Gruopbox4.Controls.Add(this.metroLabel11);
            this.Gruopbox4.Controls.Add(this.metroLabel12);
            this.Gruopbox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Gruopbox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Gruopbox4.Location = new System.Drawing.Point(25, 187);
            this.Gruopbox4.Name = "Gruopbox4";
            this.Gruopbox4.Size = new System.Drawing.Size(326, 87);
            this.Gruopbox4.TabIndex = 30;
            this.Gruopbox4.TabStop = false;
            this.Gruopbox4.Text = "Recent Checking Healthcare";
            // 
            // txtEmotion
            // 
            this.txtEmotion.AutoSize = true;
            this.txtEmotion.Location = new System.Drawing.Point(181, 55);
            this.txtEmotion.Name = "txtEmotion";
            this.txtEmotion.Size = new System.Drawing.Size(83, 19);
            this.txtEmotion.TabIndex = 20;
            this.txtEmotion.Text = "metroLabel7";
            // 
            // txtHeartBeat
            // 
            this.txtHeartBeat.AutoSize = true;
            this.txtHeartBeat.Location = new System.Drawing.Point(181, 28);
            this.txtHeartBeat.Name = "txtHeartBeat";
            this.txtHeartBeat.Size = new System.Drawing.Size(83, 19);
            this.txtHeartBeat.TabIndex = 19;
            this.txtHeartBeat.Text = "metroLabel6";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(38, 55);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(58, 19);
            this.metroLabel11.TabIndex = 16;
            this.metroLabel11.Text = "Emotion";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(38, 28);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(72, 19);
            this.metroLabel12.TabIndex = 15;
            this.metroLabel12.Text = "Heart Beat";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.txtFullname);
            this.groupBox3.Controls.Add(this.txtUsername);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Controls.Add(this.metroLabel2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(25, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 108);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(181, 78);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(83, 19);
            this.txtEmail.TabIndex = 22;
            this.txtEmail.Text = "metroLabel9";
            // 
            // txtFullname
            // 
            this.txtFullname.AutoSize = true;
            this.txtFullname.Location = new System.Drawing.Point(181, 55);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(83, 19);
            this.txtFullname.TabIndex = 20;
            this.txtFullname.Text = "metroLabel7";
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
            this.metroLabel5.Location = new System.Drawing.Point(38, 78);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 19);
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Email";
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(38, 28);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Username";
            // 
            // txtCheckHeathCare
            // 
            this.txtCheckHeathCare.Image = null;
            this.txtCheckHeathCare.Location = new System.Drawing.Point(25, 280);
            this.txtCheckHeathCare.Name = "txtCheckHeathCare";
            this.txtCheckHeathCare.Size = new System.Drawing.Size(326, 35);
            this.txtCheckHeathCare.TabIndex = 28;
            this.txtCheckHeathCare.Text = "Check Healthcare";
            this.txtCheckHeathCare.UseSelectable = true;
            this.txtCheckHeathCare.UseVisualStyleBackColor = true;
            this.txtCheckHeathCare.Click += new System.EventHandler(this.txtCheckHeathCare_Click);
            // 
            // txtCurrentName
            // 
            this.txtCurrentName.AutoSize = true;
            this.txtCurrentName.Location = new System.Drawing.Point(238, 29);
            this.txtCurrentName.Name = "txtCurrentName";
            this.txtCurrentName.Size = new System.Drawing.Size(81, 19);
            this.txtCurrentName.TabIndex = 26;
            this.txtCurrentName.Text = "metroLabel1";
            // 
            // lvwHeathcareInfo
            // 
            this.lvwHeathcareInfo.Location = new System.Drawing.Point(25, 321);
            this.lvwHeathcareInfo.Name = "lvwHeathcareInfo";
            this.lvwHeathcareInfo.Size = new System.Drawing.Size(326, 224);
            this.lvwHeathcareInfo.TabIndex = 25;
            this.lvwHeathcareInfo.UseCompatibleStateImageBehavior = false;
            // 
            // PersonalFamilyInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 608);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.Gruopbox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtCheckHeathCare);
            this.Controls.Add(this.txtCurrentName);
            this.Controls.Add(this.lvwHeathcareInfo);
            this.Name = "PersonalFamilyInformationForm";
            this.Text = "Personal Information";
            this.Load += new System.EventHandler(this.PersonalFamilyInformationForm_Load);
            this.Gruopbox4.ResumeLayout(false);
            this.Gruopbox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdOk;
        private System.Windows.Forms.GroupBox Gruopbox4;
        private MetroFramework.Controls.MetroLabel txtEmotion;
        private MetroFramework.Controls.MetroLabel txtHeartBeat;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel txtEmail;
        private MetroFramework.Controls.MetroLabel txtFullname;
        private MetroFramework.Controls.MetroLabel txtUsername;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton txtCheckHeathCare;
        private MetroFramework.Controls.MetroLabel txtCurrentName;
        private System.Windows.Forms.ListView lvwHeathcareInfo;
        private PersonalFamilyInformationFormArguments Arguments;
    }
}